namespace assignment2
{
    partial class TaskList
    {
        private System.ComponentModel.IContainer components = null;
        private ListBox listBoxTasks;
        private Label labelTasks;
        private Button addTaskButton;
        private Button editTaskButton;
        private Button deleteTaskButton;
        private Button viewHistoryButton;
        private Button markAsDoneButton;
        private Button signOutButton;

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
            editTaskButton = new Button();
            deleteTaskButton = new Button();
            viewHistoryButton = new Button();
            markAsDoneButton = new Button();
            signOutButton = new Button();
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
            // BUTTON: EDIT TASK
            // ================================
            editTaskButton.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            editTaskButton.Text = "Edit Task";
            editTaskButton.Location = new Point(230, 440);
            editTaskButton.Size = new Size(150, 45);
            editTaskButton.BackColor = Color.FromArgb(255, 204, 0);
            editTaskButton.ForeColor = Color.White;
            editTaskButton.FlatStyle = FlatStyle.Flat;
            editTaskButton.Click += editTaskButton_Click;
            // ================================
            // BUTTON: DELETE TASK
            // ================================
            deleteTaskButton.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            deleteTaskButton.Text = "Delete Task";
            deleteTaskButton.Location = new Point(410, 440);
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
            viewHistoryButton.Location = new Point(590, 440);
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
            // ADD CONTROLS
            // ================================
            Controls.Add(labelTasks);
            Controls.Add(listBoxTasks);
            Controls.Add(addTaskButton);
            Controls.Add(editTaskButton);
            Controls.Add(deleteTaskButton);
            Controls.Add(viewHistoryButton);
            Controls.Add(markAsDoneButton);
            Controls.Add(signOutButton);
            ResumeLayout(false);
            PerformLayout();
        }
    }
}