using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace assignment2
{
    public partial class Admin : Form
    {
        private readonly string currentAdmin;

        public Admin(string user)
        {
            InitializeComponent();
            currentAdmin = user;
            LoadUsers();
        }

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

        private void createUserButton_Click(object sender, EventArgs e)
        {
            string username = textBoxNewUser.Text.Trim();
            string password = textBoxNewPass.Text.Trim();
            string role = comboBoxRole.SelectedItem?.ToString() ?? "user";

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please fill all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (File.Exists("database.txt"))
            {
                var lines = File.ReadAllLines("database.txt");
                if (lines.Any(l => !string.IsNullOrWhiteSpace(l) && !l.StartsWith("#") && l.Split('|')[0] == username))
                {
                    MessageBox.Show("Username already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            File.AppendAllText("database.txt", $"{username}|{password}|{role}{Environment.NewLine}");
            MessageBox.Show("User created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadUsers();
        }

        private void manageTasksButton_Click(object sender, EventArgs e)
        {
            new TaskList(currentAdmin).ShowDialog();
        }

        private void signOutButton_Click(object sender, EventArgs e)
        {
            new LogInScreen().Show();
            Close();
        }
    }
}
