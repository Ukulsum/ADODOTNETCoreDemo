﻿using Microsoft.Data.SqlClient;

namespace Retrieve_Specific_Record_ADODOTNETCore
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //I am using Windows Authentication and hence no need to pass the User Id and Password
                string connecString = "Server=DESKTOP-M6B26UP\\SQLEXPRESS;Database=StudentDB;Trusted_Connection=True;TrustServerCertificate=True;";

                // SQL query to retrieve all records
                string sqlQuery = "Select * FROM Students where Id = '1'";

                //While Creating the SqlConnection passing the Connection String
                 using (SqlConnection connection = new SqlConnection(connecString))
                {
                    //Open the Connection
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
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
                Console.WriteLine($"Something Went Wrong: {ex.Message}");
            }
        }
    }
}