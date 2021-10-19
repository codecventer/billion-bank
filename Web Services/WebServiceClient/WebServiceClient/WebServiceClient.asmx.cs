using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data.SqlClient;

namespace WebServiceClient
{
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]

    public class WebServiceClient : System.Web.Services.WebService
    {
        // Add client to table:
        [WebMethod]
        public void Client(string name, string id, string email, string telephone, string address, string password, string question, string answer)
        {
            // Database connection:
            SqlConnection connectionString = new SqlConnection("Server=localhost\\MSSQLSERVER01; Database=BillionBank; Integrated Security=True; Trusted_Connection=True; MultipleActiveResultSets=true;");
            SqlDataReader dataReader;
            connectionString.Open();

            // SQL command text:
            SqlCommand addClient = new SqlCommand();
            addClient.Connection = connectionString;
            addClient.CommandText = "INSERT INTO [dbo].[Client] ([Name], [Id], [Email], [Telephone], [Address], [Password], [SecurityQuestion], [SecurityAnswer]) VALUES (@Name, @ID, @Email, @Telephone, @Address, @Password, @Question, @Answer)";

            // Adding parameters to SQL commadn:
            SqlParameter nameParam = new SqlParameter();
            nameParam.ParameterName = "@Name";
            nameParam.Value = name;
            addClient.Parameters.Add(nameParam);

            SqlParameter idParam = new SqlParameter();
            idParam.ParameterName = "@ID";
            idParam.Value = id;
            addClient.Parameters.Add(idParam);

            SqlParameter emailParam = new SqlParameter();
            emailParam.ParameterName = "@Email";
            emailParam.Value = email;
            addClient.Parameters.Add(emailParam);

            SqlParameter telephoneParam = new SqlParameter();
            telephoneParam.ParameterName = "@Telephone";
            telephoneParam.Value = telephone;
            addClient.Parameters.Add(telephoneParam);

            SqlParameter addressParam = new SqlParameter();
            addressParam.ParameterName = "@Address";
            addressParam.Value = address;
            addClient.Parameters.Add(addressParam);

            SqlParameter passwordParam = new SqlParameter();
            passwordParam.ParameterName = "@Password";
            passwordParam.Value = password;
            addClient.Parameters.Add(passwordParam);

            SqlParameter questionParam = new SqlParameter();
            questionParam.ParameterName = "@Question";
            questionParam.Value = question;
            addClient.Parameters.Add(questionParam);

            SqlParameter answerParam = new SqlParameter();
            answerParam.ParameterName = "@Answer";
            answerParam.Value = answer;
            addClient.Parameters.Add(answerParam);

            // Executing SQL command:
            dataReader = addClient.ExecuteReader();
            connectionString.Close();
        }
    }
}
