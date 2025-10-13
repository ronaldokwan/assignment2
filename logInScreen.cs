using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace assignment2
{
    public partial class LogInScreen : Form
    {
        public LogInScreen()
        {
            InitializeComponent();
        }

        private void logIn_Click(object sender, EventArgs e)
        {
            string username = usernameField.Text.Trim();
            string password = passwordField.Text.Trim();

            if (!File.Exists("database.txt"))
            {
                MessageBox.Show("No user database found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            foreach (var line in File.ReadAllLines("database.txt"))
            {
                if (line.StartsWith("#") || string.IsNullOrWhiteSpace(line)) continue;

                var parts = line.Split('|');
                if (parts.Length < 3) continue;

                if (parts[0] == username && parts[1] == password)
                {
                    string role = parts[2];
                    if (role == "admin")
                        new Admin(username).Show();
                    else
                        new TaskList(username).Show();
                    Hide();
                    return;
                }
            }

            MessageBox.Show("Invalid credentials.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
