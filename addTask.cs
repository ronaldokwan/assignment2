using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace assignment2
{
    public partial class AddTask : Form
    {
        private readonly string currentUser;
        private readonly string taskFile = "tasks.txt";
        private readonly string editingTaskTitle;

        public AddTask(string user, string taskTitleToEdit = null)
        {
            InitializeComponent();
            currentUser = user;
            editingTaskTitle = taskTitleToEdit;
            LoadUsers();
            if (editingTaskTitle != null) LoadTaskData();
        }

        private void LoadUsers()
        {
            comboBoxAssignUser.Items.Clear();
            if (!File.Exists("database.txt")) return;

            foreach (var line in File.ReadAllLines("database.txt"))
            {
                if (line.StartsWith("#") || string.IsNullOrWhiteSpace(line)) continue;
                var parts = line.Split('|');
                comboBoxAssignUser.Items.Add(parts[0]);
            }
        }

        private void LoadTaskData()
        {
            var lines = File.ReadAllLines(taskFile);
            var taskLine = lines.FirstOrDefault(l => l.Split('|')[0] == editingTaskTitle);
            if (taskLine == null) return;
            var parts = taskLine.Split('|');
            taskTitle.Text = parts[0];
            taskDescription.Text = parts[1];
            comboBoxAssignUser.SelectedItem = parts[3];
        }

        private void saveTaskButton_Click(object sender, EventArgs e)
        {
            string title = taskTitle.Text.Trim();
            string description = taskDescription.Text.Trim();
            string status = "ToDo";
            string assignedUser = comboBoxAssignUser.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(title) || string.IsNullOrEmpty(description) || string.IsNullOrEmpty(assignedUser))
            {
                MessageBox.Show("Fill all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!File.Exists(taskFile)) File.WriteAllText(taskFile, "");

            var lines = File.ReadAllLines(taskFile).ToList();

            if (editingTaskTitle != null)
            {
                for (int i = 0; i < lines.Count; i++)
                {
                    if (lines[i].Split('|')[0] == editingTaskTitle)
                    {
                        lines[i] = $"{title}|{description}|{status}|{assignedUser}";
                        break;
                    }
                }
            }
            else
            {
                lines.Add($"{title}|{description}|{status}|{assignedUser}");
            }

            File.WriteAllLines(taskFile, lines);
            MessageBox.Show("Task saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }
    }
}
