using Microsoft.Data.SqlClient;

namespace ADODOTNETCoreDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create the Connection String
            // string connectionString = "Server=your_server_name;Database=your_database_name;User Id=your_username;Password=your_password;";

            //I am using Windows Authentication and hence no need to pass the User Id and Password
            string connectionString = "Server=DESKTOP-M6B26UP\\SQLEXPRESS;Database=StudentDB;Trusted_Connection=True;TrustServerCertificate=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                //Open the Connection
                connection.Open();
                Console.WriteLine("Successfully connected to the database.");

                connection.Close();
            }
        }
    }
}


//using Microsoft.Data.SqlClient;

//namespace ADODOTNETCoreDemo
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            try
//            {
//                // Create the Connection String
//                // string connectionString = "Server=your_server_name;Database=your_database_name;User Id=your_username;Password=your_password;";

//                //I am using Windows Authentication and hence no need to pass the User Id and Password
//                string connectionString = "Server=DESKTOP-M6B26UP\\SQLEXPRESS;Database=StudentDB;Trusted_Connection=True;TrustServerCertificate=True;";

//                //Example student data to insert
//                string studentFirstName = "Umme";
//                string studentLastName = "Kulsum";
//                string studentEmail = "uku125@gmail.com";
              
//                //SQL Insert statement
//                string insertSql = "Insert INTO Students(FirstName,LastName,Email) Values (@FirstName,@LastName, @Email)";

//                //While Creating the SqlConnection passing the Connection String
//                using (SqlConnection connection = new SqlConnection(connectionString))
//                {
//                    //Open the Connection
//                    connection.Open();

//                    ////Create the Command Text
//                    //string createTableCommandText = @"
//                    //CREATE TABLE Students (
//                    //    Id INT PRIMARY KEY IDENTITY(1,1),
//                    //    FirstName NVARCHAR(50),
//                    //    LastName NVARCHAR(50),
//                    //    Email NVARCHAR(50)
//                    //);";

//                    //Create an instance of the SqlCommand object by using the Command text and Connection object
//                    ////using (SqlCommand command = new SqlCommand(createTableCommandText, connection))
//                    using (SqlCommand command = new SqlCommand(insertSql, connection))
//                    {

//                        //Add parameters to prevent SQL injection
//                        command.Parameters.AddWithValue("@FirstName", studentFirstName);
//                        command.Parameters.AddWithValue("@LastName", studentLastName);
//                        command.Parameters.AddWithValue("@Email", studentEmail);
//                        //Call ExecuteNonQuery Method to Execute the command in the Provided Connection
//                        //Execute the Command
//                        int result = command.ExecuteNonQuery();
//                        //Check the result
//                        if(result < 0)
//                        {
//                            Console.WriteLine("Error Inserting Data Into Database!");
//                        }
//                        else
//                        {
//                            Console.WriteLine("Data Inserted Successfully.");
//                        }
                        
//                    }

//                    //Close the Connection
//                    connection.Close();
//                }
//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine($"Something Went Wrong: {ex.Message}");
//            }
//        }
//    }
//}
