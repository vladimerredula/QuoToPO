namespace QuoToPO
{
    public class User
    {
        // Private constructor to prevent instantiation from outside
        private User() { }

        // Singleton instance
        private static User _instance;

        // Public property to access the singleton instance
        public static User Data => _instance ??= new User();

        // Properties for user
        public int User_ID { get; set; }
        public string First_name { get; set; }
        public string Last_name { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }
        public int Company_ID { get; set; }

        // Optionally, method to reset user data (e.g., on logout)
        public void Reset()
        {
            User_ID = 0;
            First_name = string.Empty;
            Last_name = string.Empty;
            Username = string.Empty;
            Password = string.Empty;
            Email = string.Empty;
            Role = string.Empty;
            Company_ID = 0;
        }

        public string Fullname()
        {
            return First_name + " " + Last_name;
        }
    }
}
