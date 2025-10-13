using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace assignment2
{
    /// <summary>
    /// Represents the login form.
    /// Allows users to log in with their username and password.
    /// Navigates to the Admin panel or TaskList depending on role.
    /// </summary>
    public partial class LogInScreen : Form
    {
        /// <summary>
        /// Initializes the login form.
        /// </summary>
        public LogInScreen()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles the Log In button click.
        /// Validates credentials and opens the appropriate form.
        /// </summary>
        private void logIn_Click(object sender, EventArgs e)
        {
            string username = usernameField.Text.Trim();
            string password = passwordField.Text.Trim();

            // ================================
            // CHECK IF DATABASE EXISTS
            // ================================
            if (!File.Exists("database.txt"))
            {
                MessageBox.Show("No user database found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // ================================
            // VALIDATE USER CREDENTIALS
            // ================================
            foreach (var line in File.ReadAllLines("database.txt"))
            {
                // Skip comments or empty lines
                if (line.StartsWith("#") || string.IsNullOrWhiteSpace(line)) continue;

                var parts = line.Split('|');
                if (parts.Length < 3) continue;

                // Check username and password match
                if (parts[0] == username && parts[1] == password)
                {
                    string role = parts[2];

                    // Open Admin or TaskList form based on role
                    if (role == "admin")
                        new Admin(username).Show();
                    else
                        new TaskList(username).Show();

                    Hide(); // Hide login form
                    return;
                }
            }

            // ================================
            // INVALID CREDENTIALS
            // ================================
            MessageBox.Show("Invalid credentials.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        /// <summary>
        /// Handles the Sign Up button click.
        /// Opens the SignUp form to allow creating a new account.
        /// </summary>
        private void signUpButton_Click(object sender, EventArgs e)
        {
            new SignUp().Show();
            Hide(); // Hide login form while signing up
        }
    }
}
