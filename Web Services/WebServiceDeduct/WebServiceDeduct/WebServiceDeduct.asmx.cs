using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data.SqlClient;
using System.Data;

namespace WebServiceDeduct
{
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]

    public class WebServiceDeduct : System.Web.Services.WebService
    {
        // Transaction - Deduct 'From Account' balance:
        [WebMethod]
        public void Deduct(int fromAccount, int amount)
        {
            // Database connection:
            SqlConnection connectionString = new SqlConnection("Server=localhost\\MSSQLSERVER01; Database=BillionBank; Integrated Security=True; Trusted_Connection=True; MultipleActiveResultSets=true;");
            SqlDataReader dataReader;
            connectionString.Open();

            // Query account balance:
            SqlCommand query = new SqlCommand();
            query.Connection = connectionString;
            query.CommandText = "SELECT [Balance] FROM [dbo].[Accounts] WHERE [AccountNumber] = @Account";
            query.Parameters.Add("@Account", SqlDbType.Int).Value = fromAccount;
            query.ExecuteNonQuery();

            // Store query result to variable:
            int balance;
            balance = (int)query.ExecuteScalar();

            // SQL command text:
            SqlCommand deductAccount = new SqlCommand();
            deductAccount.Connection = connectionString;
            deductAccount.CommandText = "UPDATE [dbo].[Accounts] SET [Balance] = @Amount WHERE [AccountNumber] = @FromAccount";
            deductAccount.Parameters.Add("@FromAccount", SqlDbType.Int).Value = fromAccount;

            // Adding parameter to SQL command:
            SqlParameter amountParam = new SqlParameter();
            amountParam.ParameterName = "@Amount";
            int deductAmount = balance - amount;
            amountParam.Value = deductAmount;
            deductAccount.Parameters.Add(amountParam);

            // Executing SQL command:
            dataReader = deductAccount.ExecuteReader();
            connectionString.Close();
        }
    }
}
