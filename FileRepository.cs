using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace assignment2
{
    // Interface for task operations
    public interface ITaskRepository
    {
        void SaveTask(string title, string description, string status, string assignedUser, string history, string dueDate, bool isHighPriority, string editingTaskTitle = null);
        string[] LoadTasks();
        string GetTaskHistory(string title);
        void DeleteTask(string title);
        void UpdateTaskStatus(string title, string newStatus, string updatedBy, string newHistoryEntry);

        // Read deleted tasks for trash functionality
        string[] LoadDeletedTasks();
    }

    // Interface for user operations
    public interface IUserRepository
    {
        void CreateUser(string username, string password, string role);
        string[] LoadUsers();
        string GetUserRole(string username);
    }

    // file storage
    public class FileRepository : ITaskRepository, IUserRepository
    {
        private readonly string taskFile = "tasks.txt";
        private readonly string userFile = "database.txt";
        private readonly string trashFile = "trash.txt";

        // IUserRepository implementation
        public void CreateUser(string username, string password, string role)
        {
            if (File.Exists(userFile))
            {
                var lines = File.ReadAllLines(userFile);
                if (lines.Any(l => !string.IsNullOrWhiteSpace(l) && !l.StartsWith("#") && l.Split('|')[0] == username))
                {
                    throw new InvalidOperationException("Username already exists.");
                }
            }
            File.AppendAllText(userFile, $"{username}|{password}|{role}{Environment.NewLine}");
        }

        public string[] LoadUsers()
        {
            if (!File.Exists(userFile)) return new string[0];
            return File.ReadAllLines(userFile)
                .Where(l => !l.StartsWith("#") && !string.IsNullOrWhiteSpace(l))
                .ToArray();
        }

        public string GetUserRole(string username)
        {
            var userLine = LoadUsers().FirstOrDefault(l => l.Split('|')[0] == username);
            return userLine?.Split('|')[2] ?? null;
        }

        // ITaskRepository implementation
        public void SaveTask(string title, string description, string status, string assignedUser, string history, string dueDate, bool isHighPriority, string editingTaskTitle = null)
        {
            try
            {
                if (!File.Exists(taskFile)) File.WriteAllText(taskFile, string.Empty);
                var lines = File.ReadAllLines(taskFile).ToList();

                // Check for unique title if new task
                if (editingTaskTitle == null && lines.Any(l => l.Split('|')[0] == title))
                {
                    throw new InvalidOperationException("Task title already exists.");
                }

                bool updated = false;
                if (editingTaskTitle != null)
                {
                    for (int i = 0; i < lines.Count; i++)
                    {
                        var parts = lines[i].Split('|');
                        if (parts.Length >= 4 && parts[0] == editingTaskTitle)
                        {
                            lines[i] = $"{title}|{description}|{status}|{assignedUser}|{history}|{dueDate}|{(isHighPriority ? "High" : "Normal")}";
                            updated = true;
                            break;
                        }
                    }
                }
                if (!updated)
                {
                    lines.Add($"{title}|{description}|{status}|{assignedUser}|{history}|{dueDate}|{(isHighPriority ? "High" : "Normal")}");
                }
                File.WriteAllLines(taskFile, lines);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving task: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public string[] LoadTasks()
        {
            if (!File.Exists(taskFile)) return new string[0];
            return File.ReadAllLines(taskFile);
        }

        public string GetTaskHistory(string title)
        {
            var taskLine = LoadTasks().FirstOrDefault(l => l.Split('|')[0] == title);
            if (taskLine == null) return "No history yet.";
            var parts = taskLine.Split('|');
            return parts.Length >= 5 && !string.IsNullOrWhiteSpace(parts[4])
                ? parts[4].Replace(";", Environment.NewLine)
                : "No history yet.";
        }

        public void DeleteTask(string title)
        {
            try
            {
                var lines = LoadTasks().ToList();
                // find tasks to delete (matching title)
                var toDelete = lines.Where(l =>
                {
                    var parts = l.Split('|');
                    return parts.Length > 0 && parts[0] == title;
                }).ToList();

                // Remaining tasks = all minus the deleted ones
                var remaining = lines.Except(toDelete).ToArray();

                // Write remaining tasks back to tasks file
                File.WriteAllLines(taskFile, remaining);

                // Ensure trash file exists and append deleted lines
                if (!File.Exists(trashFile)) File.WriteAllText(trashFile, string.Empty);
                File.AppendAllLines(trashFile, toDelete);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting task: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void UpdateTaskStatus(string title, string newStatus, string updatedBy, string newHistoryEntry)
        {
            try
            {
                var lines = LoadTasks();
                for (int i = 0; i < lines.Length; i++)
                {
                    var parts = lines[i].Split('|');
                    if (parts.Length < 4) continue;
                    if (parts[0] == title)
                    {
                        string oldHistory = parts.Length >= 5 ? parts[4] : "";
                        string history = $"{oldHistory};{newHistoryEntry}";
                        lines[i] = $"{parts[0]}|{parts[1]}|{newStatus}|{parts[3]}|{history}|{(parts.Length >= 6 ? parts[5] : "")}|{(parts.Length >= 7 ? parts[6] : "Normal")}";
                        break;
                    }
                }
                File.WriteAllLines(taskFile, lines);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating task: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public string[] LoadDeletedTasks()
        {
            if (!File.Exists(trashFile)) return new string[0];
            return File.ReadAllLines(trashFile)
                       .Where(l => !string.IsNullOrWhiteSpace(l))
                       .ToArray();
        }
    }
}