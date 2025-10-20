using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment2
{
    public partial class TrashScreen : Form
    {
        private readonly ITaskRepository taskRepository;
        private Button clearTrashButton;

        public TrashScreen(ITaskRepository repo)
        {
            taskRepository = repo;
            InitializeComponent();
            LoadTrash();
        }

        private void LoadTrash()
        {
            listBoxTrash.Items.Clear();
            var deleted = taskRepository.LoadDeletedTasks();
            if (deleted == null || deleted.Length == 0)
            {
                listBoxTrash.Items.Add("No deleted tasks.");
                return;
            }

            foreach (var line in deleted)
            {
                listBoxTrash.Items.Add(line);
            }
        }
        private void clearTrashButton_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(
                "Are you sure you want to permanently delete all tasks in trash?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.Yes)
            {
                try
                {
                    // Clear the trash file
                    File.WriteAllText("trash.txt", string.Empty);
                    LoadTrash();
                    MessageBox.Show("Trash cleared successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error clearing trash: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }
}
