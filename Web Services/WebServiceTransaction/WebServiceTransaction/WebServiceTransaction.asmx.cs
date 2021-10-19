using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data.SqlClient;
using System.IO;
using System.Threading.Tasks;

namespace WebServiceTransaction
{
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]

    public class WebServiceTransaction : System.Web.Services.WebService
    {
        // Add transaction to table:
        [WebMethod]
        public void AddTransaction(int toAccount, int fromAccount, int amount, string date, string user)
        {
            // Database connection:
            SqlConnection connectionString = new SqlConnection("Server=localhost\\MSSQLSERVER01; Database=BillionBank; Integrated Security=True; Trusted_Connection=True; MultipleActiveResultSets=true;");
            SqlDataReader dataReader;
            connectionString.Open();

            // Get current date:
            date = DateTime.Now.ToString("yyyy-mm-dd hh:mm:ss");

            // SQL command text:
            SqlCommand addTransaction = new SqlCommand();
            addTransaction.Connection = connectionString;
            addTransaction.CommandText = "INSERT INTO [dbo].[Transactions] ([ToAccount], [FromAccount], [Amount], [Date], [FromUser]) VALUES (@ToAccount, @FromAccount, @Amount, @Date, @FromUser)";

            // Adding parameters to SQL command:
            SqlParameter fromAccountParam = new SqlParameter();
            fromAccountParam.ParameterName = "@FromAccount";
            fromAccountParam.Value = fromAccount;
            addTransaction.Parameters.Add(fromAccountParam);

            SqlParameter toAccountParam = new SqlParameter();
            toAccountParam.ParameterName = "@ToAccount";
            toAccountParam.Value = toAccount;
            addTransaction.Parameters.Add(toAccountParam);

            SqlParameter dateParam = new SqlParameter();
            dateParam.ParameterName = "@Date";
            dateParam.Value = date;
            addTransaction.Parameters.Add(dateParam);

            SqlParameter amountParam = new SqlParameter();
            amountParam.ParameterName = "@Amount";
            amountParam.Value = amount;
            addTransaction.Parameters.Add(amountParam);

            SqlParameter fromUserParam = new SqlParameter();
            fromUserParam.ParameterName = "@FromUser";
            fromUserParam.Value = user;
            addTransaction.Parameters.Add(fromUserParam);

            // Execute SQL command:
            dataReader = addTransaction.ExecuteReader();
            connectionString.Close();

            // Set variable for document path:
            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            // Create and add new string to new line inside file:
            string toAccountLine = toAccount + Environment.NewLine;
            string fromAccountLine = fromAccount + Environment.NewLine;
            string transactionAmount = amount + Environment.NewLine;
            string transactionDate = date + Environment.NewLine;
            string transactionUser = user + Environment.NewLine;

            // Create string array with additional lines of text:
            string[] lines = { "To Account: " + toAccountLine + "From Account: " + fromAccountLine + "Amount: " + transactionAmount + "Date: " + transactionDate + "Made By: " + transactionUser };

            // Append new lines of text to file:
            File.AppendAllLines(Path.Combine(docPath, "TransactionLog.csv"), lines);
        }
    }
}
