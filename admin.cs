using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace assignment2
{
    /// <summary>
    /// Represents the Admin Panel form.
    /// Allows admin users to view existing users, create new users, and manage tasks.
    /// </summary>
    public partial class Admin : Form
    {
        private readonly string currentAdmin; // Logged-in admin username

        /// <summary>
        /// Initializes the Admin form and loads the user list.
        /// </summary>
        public Admin(string user)
        {
            InitializeComponent();
            currentAdmin = user;
            LoadUsers();
        }

        /// <summary>
        /// Loads users from the database file into the ListBox.
        /// Ignores empty lines and commented lines (starting with #).
        /// </summary>
        private void LoadUsers()
        {
            listBoxUsers.Items.Clear();
            if (!File.Exists("database.txt")) return;

            foreach (var line in File.ReadAllLines("database.txt"))
            {
                if (line.StartsWith("#") || string.IsNullOrWhiteSpace(line)) continue;
                listBoxUsers.Items.Add(line);
            }
        }

        /// <summary>
        /// Handles the Create User button click.
        /// Validates input, ensures username is unique, and appends the new user to the database file.
        /// </summary>
        private void createUserButton_Click(object sender, EventArgs e)
        {
            string username = textBoxNewUser.Text.Trim();
            string password = textBoxNewPass.Text.Trim();
            string role = comboBoxRole.SelectedItem?.ToString() ?? "user";

            // Validate fields
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please fill all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check for duplicate username
            if (File.Exists("database.txt"))
            {
                var lines = File.ReadAllLines("database.txt");
                foreach (var line in lines)
                {
                    var parts = line.Split('|');
                    if (parts.Length >= 1 && parts[0] == username)
                    {
                        MessageBox.Show("Username already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }

            // Append new user to database
            File.AppendAllText("database.txt", $"{username}|{password}|{role}{Environment.NewLine}");
            MessageBox.Show("User created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadUsers();
        }

        /// <summary>
        /// Opens the TaskList form for managing tasks.
        /// </summary>
        private void manageTasksButton_Click(object sender, EventArgs e)
        {
            new TaskList(currentAdmin).Show();
        }
    }
}
