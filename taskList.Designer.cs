namespace assignment2
{
    partial class TaskList
    {
        private System.ComponentModel.IContainer components = null;
        private ListBox listBoxTasks;
        private Label labelTasks;
        private Button addTaskButton;
        private Button deleteTaskButton;
        private Button viewHistoryButton;
        private Button markAsDoneButton;
        private Button signOutButton;
        private Button sortByPriorityButton;
        private Button viewTrashButton;
        private Button closeButton;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            listBoxTasks = new ListBox();
            labelTasks = new Label();
            addTaskButton = new Button();
            deleteTaskButton = new Button();
            viewHistoryButton = new Button();
            markAsDoneButton = new Button();
            signOutButton = new Button();
            sortByPriorityButton = new Button();
            viewTrashButton = new Button();
            closeButton = new Button();
            SuspendLayout();
            // ================================
            // FORM SETTINGS
            // ================================
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 600);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Task List";
            BackColor = System.Drawing.Color.WhiteSmoke;
            // ================================
            // LABEL: TASKS
            // ================================
            labelTasks.AutoSize = true;
            labelTasks.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelTasks.Location = new Point(50, 30);
            labelTasks.Text = "Your Tasks:";
            // ================================
            // LISTBOX: TASKS
            // ================================
            listBoxTasks.Font = new Font("Segoe UI", 11F);
            listBoxTasks.Location = new Point(50, 70);
            listBoxTasks.Size = new Size(800, 350);
            listBoxTasks.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            // ================================
            // BUTTON: ADD TASK
            // ================================
            addTaskButton.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            addTaskButton.Text = "Add Task";
            addTaskButton.Location = new Point(50, 440);
            addTaskButton.Size = new Size(150, 45);
            addTaskButton.BackColor = Color.FromArgb(51, 153, 255);
            addTaskButton.ForeColor = Color.White;
            addTaskButton.FlatStyle = FlatStyle.Flat;
            addTaskButton.Click += addTaskButton_Click;
            // ================================
            // BUTTON: DELETE TASK
            // ================================
            deleteTaskButton.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            deleteTaskButton.Text = "Delete Task";
            deleteTaskButton.Location = new Point(230, 440);
            deleteTaskButton.Size = new Size(150, 45);
            deleteTaskButton.BackColor = Color.FromArgb(255, 77, 77);
            deleteTaskButton.ForeColor = Color.White;
            deleteTaskButton.FlatStyle = FlatStyle.Flat;
            deleteTaskButton.Click += deleteTaskButton_Click;
            // ================================
            // BUTTON: VIEW HISTORY
            // ================================
            viewHistoryButton.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            viewHistoryButton.Text = "View History";
            viewHistoryButton.Location = new Point(410, 440);
            viewHistoryButton.Size = new Size(150, 45);
            viewHistoryButton.BackColor = Color.FromArgb(102, 102, 255);
            viewHistoryButton.ForeColor = Color.White;
            viewHistoryButton.FlatStyle = FlatStyle.Flat;
            viewHistoryButton.Click += viewHistoryButton_Click;
            // ================================
            // BUTTON: MARK AS DONE
            // ================================
            markAsDoneButton.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            markAsDoneButton.Text = "Mark as Done";
            markAsDoneButton.Location = new Point(50, 500);
            markAsDoneButton.Size = new Size(150, 45);
            markAsDoneButton.BackColor = Color.FromArgb(0, 204, 102);
            markAsDoneButton.ForeColor = Color.White;
            markAsDoneButton.FlatStyle = FlatStyle.Flat;
            markAsDoneButton.Click += markAsDoneButton_Click;
            // ================================
            // BUTTON: SORT BY PRIORITY
            // ================================
            sortByPriorityButton.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            sortByPriorityButton.Text = "Sort by Priority";
            sortByPriorityButton.Location = new Point(230, 500);
            sortByPriorityButton.Size = new Size(150, 45);
            sortByPriorityButton.BackColor = Color.FromArgb(153, 51, 255);
            sortByPriorityButton.ForeColor = Color.White;
            sortByPriorityButton.FlatStyle = FlatStyle.Flat;
            sortByPriorityButton.Click += sortByPriorityButton_Click;
            // ================================
            // BUTTON: SIGN OUT
            // ================================
            signOutButton.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            signOutButton.Text = "Sign Out";
            signOutButton.Location = new Point(700, 500);
            signOutButton.Size = new Size(150, 45);
            signOutButton.BackColor = Color.Gray;
            signOutButton.ForeColor = Color.White;
            signOutButton.FlatStyle = FlatStyle.Flat;
            signOutButton.Click += signOutButton_Click;
            // ================================
            // BUTTON: VIEW TRASH
            // ================================
            viewTrashButton.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            viewTrashButton.Text = "View Trash";
            viewTrashButton.Location = new Point(410, 500);
            viewTrashButton.Size = new Size(150, 45);
            viewTrashButton.BackColor = Color.FromArgb(255, 153, 0);
            viewTrashButton.ForeColor = Color.White;
            viewTrashButton.FlatStyle = FlatStyle.Flat;
            viewTrashButton.Click += viewTrashButton_Click;
            // ================================
            // BUTTON: CLOSE 
            // ================================
            closeButton.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            closeButton.Text = "Close";
            closeButton.Location = new Point(700, 440);
            closeButton.Size = new Size(150, 45);
            closeButton.BackColor = Color.FromArgb(128, 128, 128);
            closeButton.ForeColor = Color.White;
            closeButton.FlatStyle = FlatStyle.Flat;
            closeButton.Click += (sender, e) => Close();
            // ================================
            // ADD CONTROLS
            // ================================
            Controls.Add(labelTasks);
            Controls.Add(listBoxTasks);
            Controls.Add(addTaskButton);
            Controls.Add(deleteTaskButton);
            Controls.Add(viewHistoryButton);
            Controls.Add(markAsDoneButton);
            Controls.Add(sortByPriorityButton);
            Controls.Add(signOutButton);
            Controls.Add(viewTrashButton);
            Controls.Add(closeButton);
            ResumeLayout(false);
            PerformLayout();
        }
    }
}