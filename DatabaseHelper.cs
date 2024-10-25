﻿using MySql.Data.MySqlClient;
using System.Data;

namespace QuoToPO
{
    public class DatabaseHelper
    {
        private string _connectionString;

        // Constructor to initialize the connection string
        public DatabaseHelper(string server, string database, string username, string password)
        {
            _connectionString = $"Server={server};Database={database};Uid={username};Pwd={password};";
        }

        // Method to establish and open a connection to the database
        public MySqlConnection GetConnection()
        {
            MySqlConnection connection = new MySqlConnection(_connectionString);
            connection.Open();

            return connection;
        }

        // Method to authenticate user by username and password
        public bool AuthenticateUser(string username, string password)
        {
            string query = "SELECT COUNT(1) FROM users WHERE username = @username AND password = @password";

            using (MySqlConnection connection = GetConnection())
            {
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    // Add parameters to prevent SQL injection
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);  // Use hashed password here in production.

                    int result = Convert.ToInt32(cmd.ExecuteScalar());

                    return result == 1;
                }
            }
        }

        // Method to execute a non-query (e.g., INSERT, UPDATE, DELETE)
        public int ExecuteNonQuery(string query, params MySqlParameter[] parameters)
        {
            using (MySqlConnection connection = GetConnection())
            {
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddRange(parameters);

                    return cmd.ExecuteNonQuery();
                }
            }
        }

        // Method to execute a query that returns a DataTable (for SELECT queries)
        public DataTable ExecuteQuery(string query, params MySqlParameter[] parameters)
        {
            DataTable dataTable = new DataTable();
            using (MySqlConnection connection = GetConnection())
            {
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddRange(parameters);
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        adapter.Fill(dataTable);
                    }
                }
            }

            return dataTable;
        }
    }
}
