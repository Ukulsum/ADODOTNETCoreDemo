using Microsoft.Data.SqlClient;

namespace Deleting_Record_ADODOTNETCore
{
    public class program
    {
        static void Main(string[] args)
        {
            try
            {
                //I am using Windows Authentication and hence no need to pass the User Id and Password
                string connecString = "Server=DESKTOP-M6B26UP\\SQLEXPRESS;Database=StudentDB;Trusted_Connection=True;TrustServerCertificate=True;";

                // SQL query to delete a record
                string sqlQuery = "Delete From Students Where Id = @Id";

                //While Creating the SqlConnection passing the Connection String
                using (SqlConnection con = new SqlConnection(connecString))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(sqlQuery, con))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Console.WriteLine($"Id: {reader["Id"]}, First Name: {reader["FirstName"]}, Last Name: {reader["LastName"]}, Email: {reader["Email"]}");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.Write($"Something Went Wrong: {ex.Message}");
            }
        }
    }
}
