using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace assignment2
{
    public partial class TaskList : Form
    {
        private readonly string currentUser;
        private readonly string taskFile = "tasks.txt";

        public TaskList(string user)
        {
            InitializeComponent();
            currentUser = user;
            LoadTasks();
        }

        private void LoadTasks()
        {
            listBoxTasks.Items.Clear();
            if (!File.Exists(taskFile)) return;

            foreach (var line in File.ReadAllLines(taskFile))
            {
                var parts = line.Split('|');
                string assignedUser = parts[3];
                if (assignedUser == currentUser || IsAdmin())
                {
                    listBoxTasks.Items.Add(parts[0] + " (" + assignedUser + ")");
                }
            }
        }

        private bool IsAdmin()
        {
            var userLine = File.ReadAllLines("database.txt")
                .FirstOrDefault(l => l.Split('|')[0] == currentUser);
            return userLine != null && userLine.Split('|')[2] == "admin";
        }

        private void addTaskButton_Click(object sender, EventArgs e)
        {
            new AddTask(currentUser).ShowDialog();
            LoadTasks();
        }

        private void editTaskButton_Click(object sender, EventArgs e)
        {
            if (listBoxTasks.SelectedItem == null) return;
            string title = listBoxTasks.SelectedItem.ToString().Split('(')[0].Trim();
            new AddTask(currentUser, title).ShowDialog();
            LoadTasks();
        }

        private void deleteTaskButton_Click(object sender, EventArgs e)
        {
            if (listBoxTasks.SelectedItem == null) return;
            string title = listBoxTasks.SelectedItem.ToString().Split('(')[0].Trim();
            var lines = File.ReadAllLines(taskFile).Where(l => !l.StartsWith(title + "|")).ToArray();
            File.WriteAllLines(taskFile, lines);
            MessageBox.Show("Task deleted!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadTasks();
        }

        private void viewHistoryButton_Click(object sender, EventArgs e)
        {
            if (listBoxTasks.SelectedItem == null) return;
            string title = listBoxTasks.SelectedItem.ToString().Split('(')[0].Trim();
            var taskLine = File.ReadAllLines(taskFile).FirstOrDefault(l => l.Split('|')[0] == title);
            if (taskLine == null) return;
            var history = taskLine.Split('|').Length >= 5 ? taskLine.Split('|')[4].Replace(";", Environment.NewLine) : "No history";
            MessageBox.Show(history, $"History of {title}", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
