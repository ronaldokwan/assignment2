using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace assignment2
{
    // Base class for forms that load tasks, demonstrating polymorphism via inheritance
    public class BaseTaskForm : Form
    {
        protected readonly string currentUser;
        protected readonly ITaskRepository taskRepository;
        protected readonly IUserRepository userRepository;

        public BaseTaskForm(string user, ITaskRepository taskRepo, IUserRepository userRepo)
        {
            currentUser = user;
            taskRepository = taskRepo;
            userRepository = userRepo;
        }

        // Virtual method for loading tasks, can be overridden
        protected virtual void LoadTasks(ListBox listBox, string sortMode = "dueDate")
        {
            listBox.Items.Clear();
            var tasks = taskRepository.LoadTasks();
            var taskDict = new Dictionary<string, string[]>();
            foreach (var line in tasks)
            {
                var parts = line.Split('|');
                if (parts.Length < 4) continue;
                taskDict[parts[0]] = parts;
            }

            List<KeyValuePair<string, string[]>> sortedTasks;
            if (sortMode == "priority")
            {
                // Sort by priority (High first), then by due date
                sortedTasks = taskDict
                    .OrderByDescending(t => t.Value[6] == "High")
                    .ThenBy(t => DateTime.Parse(t.Value[5]))
                    .ToList();
            }
            else
            {
                // Default sort by due date
                sortedTasks = taskDict.OrderBy(t => DateTime.Parse(t.Value[5])).ToList();
            }

            foreach (var task in sortedTasks)
            {
                var parts = task.Value;
                string title = parts[0];
                string description = parts[1];
                string status = parts[2];
                string assignedUser = parts[3];
                string dueDate = parts[5];
                string priority = parts[6];

                if (assignedUser == currentUser || IsAdmin())
                {
                    listBox.Items.Add($"{title} | {description} | {assignedUser} | {status} | Due: {dueDate} | Priority: {priority}");
                }
            }
        }

        protected bool IsAdmin()
        {
            return userRepository.GetUserRole(currentUser) == "admin";
        }

        protected string ExtractTitle(string taskItem)
        {
            return taskItem.Split('|')[0].Trim();
        }
    }

    public partial class TaskList : BaseTaskForm
    {
        private string sortMode = "dueDate"; // Default sort mode

        // Constructor inheriting from base
        public TaskList(string user, ITaskRepository taskRepo, IUserRepository userRepo) : base(user, taskRepo, userRepo)
        {
            InitializeComponent();
            LoadTasks(listBoxTasks, sortMode); // Calls base virtual method with sort mode
            ConfigureButtons();
        }

        // Overloaded constructor
        public TaskList(string user) : this(user, new FileRepository(), new FileRepository())
        {
        }

        // Override to add custom loading logic if needed (polymorphism)
        protected override void LoadTasks(ListBox listBox, string sortMode = "dueDate")
        {
            base.LoadTasks(listBox, sortMode);
            for (int i = 0; i < listBox.Items.Count; i++)
            {
                var item = listBox.Items[i].ToString();
                var parts = item.Split('|');
                if (parts.Length >= 5 && DateTime.Parse(parts[4].Trim().Substring(5)) < DateTime.Today)
                {
                    listBox.Items[i] = item + " (Overdue)";
                }
            }
        }

        private void ConfigureButtons()
        {
            bool isAdmin = IsAdmin();
            addTaskButton.Visible = isAdmin;
            deleteTaskButton.Visible = isAdmin;
            markAsDoneButton.Visible = !isAdmin;
            signOutButton.Visible = !isAdmin;
        }

        private void addTaskButton_Click(object sender, EventArgs e)
        {
            new AddTask(currentUser, taskRepository, userRepository).ShowDialog();
            LoadTasks(listBoxTasks, sortMode);
        }

        private void deleteTaskButton_Click(object sender, EventArgs e)
        {
            if (listBoxTasks.SelectedItem == null) return;
            string title = ExtractTitle(listBoxTasks.SelectedItem.ToString());
            taskRepository.DeleteTask(title);
            MessageBox.Show("Task deleted!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadTasks(listBoxTasks, sortMode);
        }

        private void viewHistoryButton_Click(object sender, EventArgs e)
        {
            if (listBoxTasks.SelectedItem == null) return;
            string title = ExtractTitle(listBoxTasks.SelectedItem.ToString());
            string history = taskRepository.GetTaskHistory(title);
            MessageBox.Show(history, $"History of {title}", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void markAsDoneButton_Click(object sender, EventArgs e)
        {
            if (listBoxTasks.SelectedItem == null) return;
            string title = ExtractTitle(listBoxTasks.SelectedItem.ToString());
            var taskLine = taskRepository.LoadTasks().FirstOrDefault(l => l.Split('|')[0] == title);
            if (taskLine == null) return;
            var parts = taskLine.Split('|');
            string assignedUser = parts[3];
            if (assignedUser != currentUser && !IsAdmin())
            {
                MessageBox.Show("You can only complete your own tasks.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string historyEntry = $"{DateTime.Now}: Marked as Done by {currentUser}";
            taskRepository.UpdateTaskStatus(title, "Done", currentUser, historyEntry);
            MessageBox.Show("Task marked as done.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadTasks(listBoxTasks, sortMode);
        }

        private void signOutButton_Click(object sender, EventArgs e)
        {
            new LogInScreen().Show();
            Close();
        }

        private void sortByPriorityButton_Click(object sender, EventArgs e)
        {
            sortMode = "priority";
            LoadTasks(listBoxTasks, sortMode);
        }
    }
}