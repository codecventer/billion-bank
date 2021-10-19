using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data.SqlClient;

namespace WebServiceAccount
{
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]

    public class WebServiceAccount : System.Web.Services.WebService
    {
        // Add account to table:
        [WebMethod]
        public void Account(int accountNumber, string name, string date, int balance)
        {
            // Database connection:
            SqlConnection connectionString = new SqlConnection("Server=localhost\\MSSQLSERVER01; Database=BillionBank; Integrated Security=True; Trusted_Connection=True; MultipleActiveResultSets=true;");
            SqlDataReader dataReader;
            connectionString.Open();

            // SQL command text:
            SqlCommand addAccount = new SqlCommand();
            addAccount.Connection = connectionString;
            addAccount.CommandText = "INSERT INTO [dbo].[Accounts] ([AccountNumber], [CreatedOn], [CreatedBy], [Balance]) VALUES (@AccNum, @Date, @Name, @Balance)";

            // Adding parameters to SQL command:
            SqlParameter accountParam = new SqlParameter();
            accountParam.ParameterName = "@AccNum";
            accountParam.Value = accountNumber;
            addAccount.Parameters.Add(accountParam);

            SqlParameter nameParam = new SqlParameter();
            nameParam.ParameterName = "@Name";
            nameParam.Value = name;
            addAccount.Parameters.Add(nameParam);

            SqlParameter dateParam = new SqlParameter();
            dateParam.ParameterName = "@Date";
            dateParam.Value = date;
            addAccount.Parameters.Add(dateParam);

            SqlParameter balanceParam = new SqlParameter();
            balanceParam.ParameterName = "@Balance";
            balanceParam.Value = balance;
            addAccount.Parameters.Add(balanceParam);

            // Execute SQL command:
            dataReader = addAccount.ExecuteReader();
            connectionString.Close();
        }
    }
}
