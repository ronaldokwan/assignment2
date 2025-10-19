using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace assignment2
{
    public partial class AddTask : Form
    {
        private readonly string currentUser;
        private readonly string editingTaskTitle;
        private readonly ITaskRepository taskRepository;
        private readonly IUserRepository userRepository;

        // Constructor with dependency injection for repositories
        public AddTask(string user, ITaskRepository taskRepo, IUserRepository userRepo, string taskTitleToEdit = null)
        {
            InitializeComponent();
            currentUser = user;
            editingTaskTitle = taskTitleToEdit;
            taskRepository = taskRepo;
            userRepository = userRepo;
            LoadUsers();
            if (editingTaskTitle != null) LoadTaskData();
        }

        // Overloaded constructor for polymorphism (default repositories)
        public AddTask(string user, string taskTitleToEdit = null) : this(user, new FileRepository(), new FileRepository(), taskTitleToEdit)
        {
        }

        // Load users from repository
        private void LoadUsers()
        {
            comboBoxAssignUser.Items.Clear();
            foreach (var line in userRepository.LoadUsers())
            {
                var parts = line.Split('|');
                if (parts.Length >= 1)
                    comboBoxAssignUser.Items.Add(parts[0]);
            }
        }

        // Load existing task data for editing
        private void LoadTaskData()
        {
            var taskLine = taskRepository.LoadTasks()
                               .FirstOrDefault(l => l.Split('|')[0] == editingTaskTitle);
            if (taskLine == null) return;
            var parts = taskLine.Split('|');
            if (parts.Length < 4) return;
            taskTitle.Text = parts[0];
            taskDescription.Text = parts[1];
            comboBoxAssignUser.SelectedItem = parts[3];
            if (parts.Length >= 6) dueDatePicker.Value = DateTime.Parse(parts[5]);
            if (parts.Length >= 7) checkBoxHighPriority.Checked = parts[6] == "High";
        }

        // Event handler for saving task
        private void saveTaskButton_Click(object sender, EventArgs e)
        {
            string title = taskTitle.Text.Trim();
            string description = taskDescription.Text.Trim();
            string status = "ToDo";
            string assignedUser = comboBoxAssignUser.SelectedItem?.ToString();
            string history = editingTaskTitle != null ? taskRepository.GetTaskHistory(editingTaskTitle) : "";
            string dueDate = dueDatePicker.Value.ToString("yyyy-MM-dd");
            bool isHighPriority = checkBoxHighPriority.Checked;

            if (string.IsNullOrEmpty(title) || string.IsNullOrEmpty(description) || string.IsNullOrEmpty(assignedUser))
            {
                MessageBox.Show("Please fill all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Additional validation: Title length
            if (title.Length > 50)
            {
                MessageBox.Show("Title must be under 50 characters.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                taskRepository.SaveTask(title, description, status, assignedUser, history, dueDate, isHighPriority, editingTaskTitle);
                MessageBox.Show("Task saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}