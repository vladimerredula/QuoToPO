namespace QuoToPO
{
    public partial class LoginForm : Form
    {
        private DatabaseHelper _db;

        public LoginForm()
        {
            InitializeComponent();

            // Initialize DatabaseHelper
            _db = new DatabaseHelper();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (_db.AuthenticateUser(username, password))
            {
                // Authentication successful
                MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Hide the login form and show the main application form
                this.Hide();
                MainForm mainForm = new MainForm();
                mainForm.ShowDialog();
                this.Close();
            }
            else
            {
                // Authentication failed
                MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
