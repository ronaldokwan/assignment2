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
    }
}
