using DotNetEnv;
using MySql.Data.MySqlClient;
using System.Data;

namespace QuoToPO
{
    public class DatabaseHelper
    {
        private string _connectionString;

        // Constructor to initialize the connection string
        public DatabaseHelper()
        {
            // Load the .env file
            Env.Load();

            _connectionString = Env.GetString("DB_CONNECTION_STRING");
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

        private string HashPassword(string password)
        {
            using (var sha256 = System.Security.Cryptography.SHA256.Create())
            {
                byte[] hashedBytes = sha256.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
                return BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();
            }
        }

        #region Company functions

        public List<Company> GetCompanies()
        {
            List<Company> companies = new List<Company>();
            string query = "SELECT * FROM Companies";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(_connectionString))
                {
                    connection.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                companies.Add(new Company()
                                {
                                    Company_ID = reader.IsDBNull(reader.GetOrdinal("Company_ID")) ? 0 : reader.GetInt32("Company_ID"),
                                    Company_name = reader.IsDBNull(reader.GetOrdinal("Company_name")) ? string.Empty : reader.GetString("Company_name"),
                                    Company_name_jpn = reader.IsDBNull(reader.GetOrdinal("Company_name_jpn")) ? string.Empty : reader.GetString("Company_name_jpn"),
                                    Company_address = reader.IsDBNull(reader.GetOrdinal("Company_address")) ? string.Empty : reader.GetString("Company_address"),
                                    Company_address_jpn = reader.IsDBNull(reader.GetOrdinal("Company_address_jpn")) ? string.Empty : reader.GetString("Company_address_jpn"),
                                    Postal_code = reader.IsDBNull(reader.GetOrdinal("Postal_code")) ? string.Empty : reader.GetString("Postal_code"),
                                    Telephone = reader.IsDBNull(reader.GetOrdinal("Telephone")) ? string.Empty : reader.GetString("Telephone"),
                                    Fax = reader.IsDBNull(reader.GetOrdinal("Fax")) ? string.Empty : reader.GetString("Fax"),
                                    Key_words = reader.IsDBNull(reader.GetOrdinal("Key_words")) ? string.Empty : reader.GetString("Key_words")
                                });
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error fetching companies: {ex.Message}");
            }

            return companies;
        }

        public Company GetCompany(int companyId)
        {
            Company company = new Company();

            var query = $"SELECT * FROM Companies WHERE Company_ID = {companyId}";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(_connectionString))
                {
                    connection.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                company.Company_ID = reader.IsDBNull(reader.GetOrdinal("Company_ID")) ? 0 : reader.GetInt32("Company_ID");
                                company.Company_name = reader.IsDBNull(reader.GetOrdinal("Company_name")) ? string.Empty : reader.GetString("Company_name");
                                company.Company_name_jpn = reader.IsDBNull(reader.GetOrdinal("Company_name_jpn")) ? string.Empty : reader.GetString("Company_name_jpn");
                                company.Company_address = reader.IsDBNull(reader.GetOrdinal("Company_address")) ? string.Empty : reader.GetString("Company_address");
                                company.Company_address_jpn = reader.IsDBNull(reader.GetOrdinal("Company_address_jpn")) ? string.Empty : reader.GetString("Company_address_jpn");
                                company.Postal_code = reader.IsDBNull(reader.GetOrdinal("Postal_code")) ? string.Empty : reader.GetString("Postal_code");
                                company.Telephone = reader.IsDBNull(reader.GetOrdinal("Telephone")) ? string.Empty : reader.GetString("Telephone");
                                company.Fax = reader.IsDBNull(reader.GetOrdinal("Fax")) ? string.Empty : reader.GetString("Fax");
                                company.Key_words = reader.IsDBNull(reader.GetOrdinal("Key_words")) ? string.Empty : reader.GetString("Key_words");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error fetching company: {ex.Message}");
                //Console.WriteLine($"Error fetching company: {ex.Message}");
            }

            return company;
        }

        public List<Company> GetFFJCompanyList()
        {
            var companies = GetCompanies();

            return companies.Where(c => c.Company_ID <= 5).ToList();
        }

        #endregion
    }
}
