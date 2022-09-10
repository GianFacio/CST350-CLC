using static System.Net.Mime.MediaTypeNames;
using System;
using System.Security.Permissions;
using RegisterAndLoginApp.Models;
using System.Data.SqlClient;

namespace RegisterAndLoginApp.Services
{
    public class SecurityDAO
    {
        string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Test;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public bool FindUserByNameAndPassword(Register user)
        {
            // Assume nothing is found
            bool success = false;

            // Uses prepared statements for security. @username @password are defined below

            string sqlStatement = "SELECT * FROM dbo.users WHERE username = @username and password = @password";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(sqlStatement, connection);

                // Define the values of the two placeholders in the sqlStatement string
                command.Parameters.Add("@USERNAME", System.Data.SqlDbType.VarChar, 50).Value = user.username;
                command.Parameters.Add("@PASSWORD", System.Data.SqlDbType.VarChar, 50).Value = user.password;

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                        success = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                };
            }
        return success;
        }

        public string RegisterUser(Register user)
        {

            string sqlStatement = "INSERT INTO dbo.users (FIRSTNAME, LASTNAME, SEX, AGE, STATE, EMAIL, USERNAME, PASSWORD) VALUES (@firstname, @lastname, @sex, @age, @state, @email, @username, @password)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(sqlStatement, connection);


                command.Parameters.Add("@FIRSTNAME", System.Data.SqlDbType.VarChar, 50).Value = user.firstName;
                command.Parameters.Add("@LASTNAME", System.Data.SqlDbType.VarChar, 50).Value = user.lastName ;
                command.Parameters.Add("@SEX", System.Data.SqlDbType.VarChar, 50).Value = user.sex;
                command.Parameters.Add("@AGE", System.Data.SqlDbType.VarChar, 50).Value = user.age;
                command.Parameters.Add("@STATE", System.Data.SqlDbType.VarChar, 50).Value = user.state;
                command.Parameters.Add("@EMAIL", System.Data.SqlDbType.VarChar, 50).Value = user.email;
                command.Parameters.Add("@USERNAME", System.Data.SqlDbType.VarChar, 50).Value = user.username;
                command.Parameters.Add("@PASSWORD", System.Data.SqlDbType.VarChar, 50).Value = user.password;


                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                };
                return "RegistrationSuccess";

            }
        }
    }
}
