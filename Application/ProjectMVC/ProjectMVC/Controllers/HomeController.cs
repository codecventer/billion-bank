using Microsoft.Build.Framework;
using Microsoft.Extensions.Logging;
using ProjectMVC.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using Microsoft.AspNet.Identity;

// Web services:
using ProjectMVC.ServiceReferenceIncreases;
using ProjectMVC.ServiceReferenceAccount;
using ProjectMVC.ServiceReferenceDeduct;
using ProjectMVC.ServiceReferenceTransaction2;

namespace ProjectMVC.Controllers
{
    public class HomeController : Controller
    {
        // Database connection:
        SqlConnection connectionString = new SqlConnection("Server=localhost\\MSSQLSERVER01; Database=BillionBank; Integrated Security=True; Trusted_Connection=True; MultipleActiveResultSets=true;");
        SqlDataReader dataReader;

        // Creating new TransactionHistory model object:
        TransactionHistoryModels transactionHistory = new TransactionHistoryModels();

        [Authorize]
        public ActionResult Accounts()
        {
            ViewBag.Message = "View account information";

            // Get user's name:
            string name = User.Identity.GetUserName();

            connectionString.Open();

            // Check if any accounts exists:
            SqlCommand query = new SqlCommand();
            query.Connection = connectionString;
            query.CommandText = "SELECT [AccountNumber] FROM [dbo].[Accounts] WHERE [CreatedBy] = @User";

            // Adding parameter to SQL command:
            query.Parameters.Add("@User", SqlDbType.VarChar).Value = name;

            // Executing SQL command:
            dataReader = query.ExecuteReader();

            if (!dataReader.HasRows)
            {
                ViewBag.Response = "No accounts found";
            }

            connectionString.Close();

            // Dummy data: -------------------------------------------------------------------------
            var account = GetAccounts(321, "string", "string", 123);
            var transactions = GetTransactions(123, 321, 122, "string", "Chris Venter");

            transactionHistory.AccountListModels = account;
            transactionHistory.TransactionListModels = transactions;
            // ---------------------------------------------------------------------------------------

            ListAccounts();
            ListTransactions();

            return View(transactionHistory);
        }

        [Authorize]
        public ActionResult Transfer()
        {
            ViewBag.Message = "Transfer funds between accounts";

            // Get user's name:
            string name = User.Identity.GetUserName();

            connectionString.Open();

            // Check if any accounts exists:
            SqlCommand query = new SqlCommand();
            query.Connection = connectionString;
            query.CommandText = "SELECT [AccountNumber] FROM [dbo].[Accounts] WHERE [CreatedBy] = @User";

            // Adding parameter to SQL command:
            query.Parameters.Add("@User", SqlDbType.VarChar).Value = name;

            // Executing SQL command:
            dataReader = query.ExecuteReader();

            // User needs at least one account to transfer funds:
            if (!dataReader.HasRows)
            {
                ViewBag.Response = "No accounts found";
            }

            connectionString.Close();

            return View();
        }

        [Authorize]
        public ActionResult SubmitTransfer(FormCollection form)
        {
            // Amount of transferring funds:
            int amount;
            int toAccount;
            int fromAccount;

            // Variables checked and passed to web services:
            string user = User.Identity.GetUserName();
            string date = DateTime.Now.ToString("yyyy-mm-dd hh:mm:ss");

            if (form["amount"] == "")
            {
                TempData["Message"] = "Amount cannot be empty...";
                return RedirectToAction("Transfer", "Home");
            }
            else
            {
                amount = Convert.ToInt32(form["amount"]);
            }

            if (form["toAccount"] == "")
            {
                TempData["Message"] = "To Account number cannot be empty...";
                return RedirectToAction("Transfer", "Home");
            }
            else
            {
                toAccount = Convert.ToInt32(form["toAccount"]);
            }

            if (form["fromAccount"] == "")
            {
                TempData["Message"] = "From Account number cannot be empty...";
                return RedirectToAction("Transfer", "Home");
            }
            else
            {
                fromAccount = Convert.ToInt32(form["fromAccount"]);
            }

            // Cannot use one account number for both 'To'- and 'From' accounts:
            if (toAccount == fromAccount)
            {
                TempData["Message"] = "Account numbers cannot be the same...";
                return RedirectToAction("Transfer", "Home");
            }

            connectionString.Open();

            // Query account balance:
            SqlCommand query = new SqlCommand();
            query.Connection = connectionString;
            query.CommandText = "SELECT [Balance] FROM [dbo].[Accounts] WHERE [AccountNumber] = @Account";
            query.Parameters.Add("@Account", SqlDbType.Int).Value = fromAccount;
            query.ExecuteNonQuery();

            // Store query result to variable:
            int balance;
            try
            {
                balance = (int)query.ExecuteScalar();
            }
            catch
            {
                TempData["Message"] = "From account not found...";
                return RedirectToAction("Transfer", "Home");
            }

            // Web service - Deduct 'From Account' if amount available in balance:
            if (balance < amount)
            {
                TempData["Message"] = "Insufficient funds...";
                return RedirectToAction("Transfer", "Home");
            }

            try
            {
                Deduct(fromAccount, amount);
            }
            catch
            {
                TempData["Message"] = "From Account not found...";
                return RedirectToAction("Transfer", "Home");
            }

            // Web service - Increase 'To Account' balance:
            try
            {
                Increase(toAccount, amount);
            }
            catch
            {
                TempData["Message"] = "To Account not found...";
                return RedirectToAction("Transfer", "Home");
            }

            // Web service - Add transaction to table:
            try
            {
                Transaction(toAccount, fromAccount, amount, date, user);
            }
            catch
            {
                TempData["Message"] = "Unable to add transfer to database...";
                return RedirectToAction("Transfer", "Home");
            }

            connectionString.Close();

            TempData["Message"] = "Transfer was successful";
            return RedirectToAction("Accounts");
        }

        [Authorize]
        public ActionResult Apply()
        {
            ViewBag.Message = "Apply for a new account";
            return View();
        }

        [Authorize]
        public ActionResult AddAccount()
        {
            CreateAccount();
            return RedirectToAction("Accounts");
        }

        // Create Account:
        public void CreateAccount()
        {
            // Variables for creating new account:
            Random random = new Random();
            int accountNumber = random.Next(100000000, 999999999);
            string name = User.Identity.GetUserName();
            string date = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
            int balance = 100;

            try
            {
                connectionString.Open();

                // If previous accounts exists, balance of new account is equal to 0:
                SqlCommand query = new SqlCommand();
                query.Connection = connectionString;
                query.CommandText = "SELECT [AccountNumber] FROM [dbo].[Accounts] WHERE [CreatedBy] = @User";

                // Adding parameter to SQL command:
                query.Parameters.Add("@User", SqlDbType.VarChar).Value = name;

                // Executing SQL command:
                dataReader = query.ExecuteReader();

                if (dataReader.HasRows)
                {
                    balance = 0;
                }

                connectionString.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            // Web service - add account:
            WebServiceAccountSoapClient wsAccount = new WebServiceAccountSoapClient();
            wsAccount.Account(accountNumber, name, date, balance);
        }

        // List Accounts:
        public void ListAccounts()
        {
            if (Request.IsAuthenticated)
            {
                // Get user's name:
                string name = User.Identity.GetUserName();

                if (transactionHistory.AccountListModels.Count > 0)
                {
                    transactionHistory.AccountListModels.Clear();
                }

                try
                {
                    connectionString.Open();

                    // SQL command text:
                    SqlCommand listAccounts = new SqlCommand();
                    listAccounts.Connection = connectionString;
                    listAccounts.CommandText = "SELECT TOP (1000) [AccountNumber] ,[CreatedOn] ,[CreatedBy] ,[Balance] FROM [BillionBank].[dbo].[Accounts] WHERE[CreatedBy] = @UserName";

                    // Adding parameter to SQL command:
                    SqlParameter nameParam = new SqlParameter();
                    nameParam.ParameterName = "@UserName";
                    nameParam.Value = name;
                    listAccounts.Parameters.Add(nameParam);

                    // Executing SQL command:
                    dataReader = listAccounts.ExecuteReader();

                    // Add each account to AccountListModels model:
                    while (dataReader.Read())
                    {
                        transactionHistory.AccountListModels.Add(new AccountListModels()
                        {
                            AccountNumber = dataReader["AccountNumber"].ToString(),
                            CreatedOn = dataReader["CreatedOn"].ToString(),
                            CreatedBy = dataReader["CreatedBy"].ToString(),
                            Balance = dataReader["Balance"].ToString()
                        });
                    }
                    connectionString.Close();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        // Add account to AccountListModels model:
        public List<AccountListModels> GetAccounts(int accountNumber, string createdBy, string createdOn, int balance)
        {
            return new List<AccountListModels>()
            {
                new AccountListModels(){ AccountNumber = accountNumber.ToString(), CreatedBy = createdBy, CreatedOn = createdOn, Balance = balance.ToString() }
            };
        }

        // List Transactions:
        public void ListTransactions()
        {
            if (Request.IsAuthenticated)
            {
                string name = User.Identity.GetUserName();

                if (transactionHistory.TransactionListModels.Count > 0)
                {
                    transactionHistory.TransactionListModels.Clear();
                }

                try
                {
                    connectionString.Open();

                    // SQL command text:
                    SqlCommand listTransactions = new SqlCommand();
                    listTransactions.Connection = connectionString;
                    listTransactions.CommandText = "SELECT TOP (1000) [FromAccount], [ToAccount], [Amount], [Date], [FromUser] FROM[BillionBank].[dbo].[Transactions] WHERE[FromUser] = @UserName";

                    // Adding parameter to SQL command:
                    SqlParameter nameParam = new SqlParameter();
                    nameParam.ParameterName = "@UserName";
                    nameParam.Value = name;
                    listTransactions.Parameters.Add(nameParam);

                    // Execute SQL command:
                    dataReader = listTransactions.ExecuteReader();

                    // Write each transaction to TransactionListModels model:
                    while (dataReader.Read())
                    {
                        transactionHistory.TransactionListModels.Add(new TransactionListModels()
                        {
                            FromAccount = dataReader["FromAccount"].ToString(),
                            ToAccount = dataReader["ToAccount"].ToString(),
                            Amount = dataReader["Amount"].ToString(),
                            TransactionDate = dataReader["Date"].ToString(),
                            FromUser = dataReader["FromUser"].ToString()
                        });
                    }
                    connectionString.Close();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        // Add transaction to TransactionListModels model:
        public List<TransactionListModels> GetTransactions(int fromAccount, int toAccount, int amount, string date, string fromUser)
        {
            return new List<TransactionListModels>()
            {
                new TransactionListModels(){ FromAccount = fromAccount.ToString(), ToAccount = toAccount.ToString(), Amount = amount.ToString(), TransactionDate = date, FromUser = fromUser }
            };
        }

        // Web service - Deduct account:
        public void Deduct(int fromAccount, int amount)
        {
            WebServiceDeductSoapClient wsDeduct = new WebServiceDeductSoapClient();
            wsDeduct.Deduct(fromAccount, amount);
        }

        // Web service - Increase account:
        public void Increase(int toAccount, int amount)
        {
            WebServiceIncreasesSoapClient wsIncrease = new WebServiceIncreasesSoapClient();
            wsIncrease.Increase(toAccount, amount);
        }

        // Web service - Add transaction:
        public void Transaction(int toAccount, int fromAccount, int amount, string date, string user)
        {
            WebServiceTransactionSoapClient wsTransaction = new WebServiceTransactionSoapClient();
            wsTransaction.AddTransaction(toAccount, fromAccount, amount, date, user);
        }
    }
}