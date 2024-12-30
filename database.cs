using MySql.Data.MySqlClient;
using System;

namespace RestaurantManagementApp
{
    public class database
    {
        // Connection string (Replace with your own credentials)
        private string connectionString = "Server=127.0.0.1;Database=restaurantdb;User ID=root;Password=H1u2Z3a4I5.;";

        // MySqlConnection object for connecting to the database
        private MySqlConnection connection;

        // Constructor that initializes the connection object
        public database()
        {
            connection = new MySqlConnection(connectionString);
        }

        // Method to open a connection to the database
        public MySqlConnection OpenConnection()
        {
            try
            {
                if (connection.State != System.Data.ConnectionState.Open)
                {
                    connection.Open();
                }
                return connection;
            }
            catch (Exception ex)
            {
                // Handle connection errors (could be logged or shown to user)
                Console.WriteLine($"Error: {ex.Message}");
                throw;
            }
        }

        // Method to close the database connection
        public void CloseConnection()
        {
            try
            {
                if (connection.State != System.Data.ConnectionState.Closed)
                {
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                // Handle closing errors (could be logged or shown to user)
                Console.WriteLine($"Error: {ex.Message}");
                throw;
            }
        }
    }
}
