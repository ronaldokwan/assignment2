using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace assignment2
{
    /// <summary>
    /// Represents the SignUp form.
    /// Allows a new user to create an account with a unique username.
    /// </summary>
    public partial class SignUp : Form
    {
        /// <summary>
        /// Initializes the SignUp form.
        /// </summary>
        public SignUp()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles the Sign Up button click.
        /// Validates input and creates a new user if the username is unique.
        /// </summary>
        private void signUpButton_Click(object sender, EventArgs e)
        {
            string username = usernameField.Text.Trim();
            string password = passwordField.Text.Trim();

            // ================================
            // VALIDATE INPUT
            // ================================
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please fill all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // ================================
            // ENSURE DATABASE FILE EXISTS
            // ================================
            if (!File.Exists("database.txt"))
                File.WriteAllText("database.txt", "# User database\n");

            // ================================
            // CHECK FOR UNIQUE USERNAME
            // ================================
            var existingUsers = File.ReadAllLines("database.txt")
                                    .Where(line => !string.IsNullOrWhiteSpace(line) && !line.StartsWith("#"))
                                    .Select(line => line.Split('|')[0])
                                    .ToList();

            if (existingUsers.Contains(username))
            {
                MessageBox.Show("Username already exists. Please choose another.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // ================================
            // SAVE NEW USER
            // ================================
            File.AppendAllText("database.txt", $"{username}|{password}|user{Environment.NewLine}");
            MessageBox.Show("Account created! You can now log in.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // ================================
            // NAVIGATE TO LOGIN
            // ================================
            new LogInScreen().Show();
            Hide();
        }
    }
}
