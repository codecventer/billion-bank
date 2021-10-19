using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data.SqlClient;

namespace WebServiceUpdate
{
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]

    public class WebServiceUpdate : System.Web.Services.WebService
    {
        // Update profile:
        [WebMethod]
        public void Update(string name, string telephone, string email, string address)
        {
            // Database connection:
            SqlConnection connectionString = new SqlConnection("Server=localhost\\MSSQLSERVER01; Database=BillionBank; Integrated Security=True; Trusted_Connection=True; MultipleActiveResultSets=true;");
            SqlDataReader dataReader;
            connectionString.Open();

            // SQL command text:
            SqlCommand updateProfile = new SqlCommand();
            updateProfile.Connection = connectionString;
            updateProfile.CommandText = "UPDATE [dbo].[Client] SET [Telephone] = @Telephone, [Email] = @Email, [Address] = @Address WHERE [Name] = @Name";

            // Adding parameters to SQL command:
            if (string.IsNullOrEmpty(name))
            {
                updateProfile.Parameters.AddWithValue("@Name", DBNull.Value);
            }
            else
            {
                updateProfile.Parameters.AddWithValue("@Name", name);
            }

            if (string.IsNullOrEmpty(telephone))
            {
                updateProfile.Parameters.AddWithValue("@Telephone", DBNull.Value);
            }
            else
            {
                updateProfile.Parameters.AddWithValue("@Telephone", telephone);
            }

            if (string.IsNullOrEmpty(email))
            {
                updateProfile.Parameters.AddWithValue("@Email", DBNull.Value);
            }
            else
            {
                updateProfile.Parameters.AddWithValue("@Email", email);
            }

            if (string.IsNullOrEmpty(address))
            {
                updateProfile.Parameters.AddWithValue("@Address", DBNull.Value);
            }
            else
            {
                updateProfile.Parameters.AddWithValue("@Address", address);
            }

            // Execute SQL command:
            dataReader = updateProfile.ExecuteReader();
            connectionString.Close();
        }
    }
}
