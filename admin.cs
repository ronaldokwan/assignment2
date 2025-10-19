using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace assignment2
{
    public partial class Admin : Form
    {
        private readonly string currentAdmin;
        private readonly IUserRepository userRepository;
        private readonly ITaskRepository taskRepository;

        // Constructor with dependency injection
        public Admin(string user, IUserRepository userRepo, ITaskRepository taskRepo)
        {
            InitializeComponent();
            currentAdmin = user;
            userRepository = userRepo;
            taskRepository = taskRepo;
            LoadUsers();
        }

        // Overloaded constructor for polymorphism
        public Admin(string user) : this(user, new FileRepository(), new FileRepository())
        {
        }

        // Load users from repository
        private void LoadUsers()
        {
            listBoxUsers.Items.Clear();
            foreach (var line in userRepository.LoadUsers())
            {
                listBoxUsers.Items.Add(line);
            }
        }

        // Event handler for creating user
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

            // Validation: Username format (alphanumeric only)
            if (!System.Text.RegularExpressions.Regex.IsMatch(username, @"^[a-zA-Z0-9]+$"))
            {
                MessageBox.Show("Username must be alphanumeric.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                userRepository.CreateUser(username, password, role);
                MessageBox.Show("User created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadUsers();
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Open task management form
        private void manageTasksButton_Click(object sender, EventArgs e)
        {
            new TaskList(currentAdmin, taskRepository, userRepository).ShowDialog();
        }

        // Sign out
        private void signOutButton_Click(object sender, EventArgs e)
        {
            new LogInScreen().Show();
            Close();
        }
    }
}