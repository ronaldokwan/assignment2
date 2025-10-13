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
        private readonly string editingTaskTitle; // null if creating new

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
            string desc = taskDescription.Text.Trim();
            string assignedUser = comboBoxAssignUser.SelectedItem?.ToString() ?? currentUser;
            string status = "ToDo";

            if (string.IsNullOrEmpty(title))
            {
                MessageBox.Show("Task title is required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string historyEntry = $"{DateTime.Now}: {(editingTaskTitle == null ? $"Created by {currentUser}" : $"Edited by {currentUser}")}";

            string[] lines = File.Exists(taskFile) ? File.ReadAllLines(taskFile) : Array.Empty<string>();
            if (editingTaskTitle != null)
            {
                // Edit existing task
                for (int i = 0; i < lines.Length; i++)
                {
                    var parts = lines[i].Split('|');
                    if (parts[0] == editingTaskTitle)
                    {
                        string oldHistory = parts.Length >= 5 ? parts[4] : "";
                        lines[i] = $"{title}|{desc}|{status}|{assignedUser}|{oldHistory};{historyEntry}";
                        break;
                    }
                }
                File.WriteAllLines(taskFile, lines);
            }
            else
            {
                // New task
                File.AppendAllText(taskFile, $"{title}|{desc}|{status}|{assignedUser}|{historyEntry}{Environment.NewLine}");
            }

            MessageBox.Show("Task saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }
    }
}
