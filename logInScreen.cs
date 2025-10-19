using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace assignment2
{
    public partial class LogInScreen : Form
    {
        private readonly IUserRepository userRepository;

        // Constructor with DI
        public LogInScreen(IUserRepository userRepo)
        {
            InitializeComponent();
            userRepository = userRepo;
        }

        // Overloaded default constructor
        public LogInScreen() : this(new FileRepository())
        {
        }

        // Event handler for login
        private void logIn_Click(object sender, EventArgs e)
        {
            string username = usernameField.Text.Trim();
            string password = passwordField.Text.Trim();

            try
            {
                var users = userRepository.LoadUsers();
                var userLine = users.FirstOrDefault(l => l.Split('|')[0] == username && l.Split('|')[1] == password);
                if (userLine == null)
                {
                    MessageBox.Show("Invalid credentials.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string role = userLine.Split('|')[2];
                if (role == "admin")
                    new Admin(username).Show();
                else
                    new TaskList(username).Show();
                Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error during login: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}