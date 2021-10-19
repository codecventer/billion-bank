using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data.SqlClient;
using System.Data;

namespace WebServiceIncreases
{
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]

    public class WebServiceIncreases : System.Web.Services.WebService
    {
        // Transaction - Increase 'To Account' balance:
        [WebMethod]
        public void Increase(int toAccount, int amount)
        {
            // Database connection:
            SqlConnection connectionString = new SqlConnection("Server=localhost\\MSSQLSERVER01; Database=BillionBank; Integrated Security=True; Trusted_Connection=True; MultipleActiveResultSets=true;");
            SqlDataReader dataReader;
            connectionString.Open();

            // Query account balance:
            SqlCommand query = new SqlCommand();
            query.Connection = connectionString;
            query.CommandText = "SELECT [Balance] FROM [dbo].[Accounts] WHERE [AccountNumber] = @Account";
            query.Parameters.Add("@Account", SqlDbType.Int).Value = toAccount;
            query.ExecuteNonQuery();

            // Store query result to variable:
            int balance;
            balance = (int)query.ExecuteScalar();

            // SQL command text:
            SqlCommand increaseAccount = new SqlCommand();
            increaseAccount.Connection = connectionString;
            increaseAccount.CommandText = "UPDATE [dbo].[Accounts] SET [Balance] = @Amount WHERE [AccountNumber] = @ToAccount";
            increaseAccount.Parameters.Add("@ToAccount", SqlDbType.Int).Value = toAccount;

            // Adding parameter to SQL command:
            SqlParameter amountParam = new SqlParameter();
            amountParam.ParameterName = "@Amount";
            int increaseAmount = balance + amount;
            amountParam.Value = increaseAmount;
            increaseAccount.Parameters.Add(amountParam);

            // Executing SQL command:
            dataReader = increaseAccount.ExecuteReader();
            connectionString.Close();
        }
    }
}
