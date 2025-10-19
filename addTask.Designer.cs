namespace assignment2
{
    partial class AddTask
    {
        private System.ComponentModel.IContainer components = null;
        private Label labelTitle;
        private TextBox taskTitle;
        private Label labelDescription;
        private TextBox taskDescription;
        private Label labelAssignUser;
        private ComboBox comboBoxAssignUser;
        private Button saveTaskButton;
        private Label labelDueDate;
        private DateTimePicker dueDatePicker;
        private CheckBox checkBoxHighPriority;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            labelTitle = new Label();
            taskTitle = new TextBox();
            labelDescription = new Label();
            taskDescription = new TextBox();
            labelAssignUser = new Label();
            comboBoxAssignUser = new ComboBox();
            saveTaskButton = new Button();
            labelDueDate = new Label();
            dueDatePicker = new DateTimePicker();
            checkBoxHighPriority = new CheckBox();
            SuspendLayout();
            // ================================
            // FORM SETTINGS
            // ================================
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 600);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add Task";
            BackColor = System.Drawing.Color.WhiteSmoke;
            // ================================
            // LABEL: TASK TITLE
            // ================================
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelTitle.Location = new Point(50, 40);
            labelTitle.Text = "Task Title:";
            // ================================
            // TEXTBOX: TASK TITLE
            // ================================
            taskTitle.Font = new Font("Segoe UI", 11F);
            taskTitle.Location = new Point(180, 35);
            taskTitle.Size = new Size(650, 35);
            taskTitle.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            // ================================
            // LABEL: DESCRIPTION
            // ================================
            labelDescription.AutoSize = true;
            labelDescription.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelDescription.Location = new Point(50, 100);
            labelDescription.Text = "Description:";
            // ================================
            // TEXTBOX: DESCRIPTION
            // ================================
            taskDescription.Font = new Font("Segoe UI", 11F);
            taskDescription.Location = new Point(180, 95);
            taskDescription.Multiline = true;
            taskDescription.ScrollBars = ScrollBars.Vertical;
            taskDescription.Size = new Size(650, 300);
            taskDescription.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
            // ================================
            // LABEL: DUE DATE
            // ================================
            labelDueDate.AutoSize = true;
            labelDueDate.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelDueDate.Location = new Point(50, 410);
            labelDueDate.Text = "Due Date:";
            // ================================
            // DATETIMEPICKER: DUE DATE
            // ================================
            dueDatePicker.Font = new Font("Segoe UI", 11F);
            dueDatePicker.Location = new Point(180, 405);
            dueDatePicker.Size = new Size(300, 35);
            dueDatePicker.Value = DateTime.Today.AddDays(7); // Default to 1 week from now
            // ================================
            // CHECKBOX: HIGH PRIORITY
            // ================================
            checkBoxHighPriority.Font = new Font("Segoe UI", 11F);
            checkBoxHighPriority.Location = new Point(500, 410);
            checkBoxHighPriority.Text = "High Priority";
            checkBoxHighPriority.AutoSize = true;
            // ================================
            // LABEL: ASSIGN USER
            // ================================
            labelAssignUser.AutoSize = true;
            labelAssignUser.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelAssignUser.Location = new Point(50, 470);
            labelAssignUser.Text = "Assign To:";
            // ================================
            // COMBOBOX: ASSIGN USER
            // ================================
            comboBoxAssignUser.Font = new Font("Segoe UI", 11F);
            comboBoxAssignUser.Location = new Point(180, 465);
            comboBoxAssignUser.Size = new Size(300, 35);
            // ================================
            // BUTTON: SAVE TASK
            // ================================
            saveTaskButton.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            saveTaskButton.Text = "Save";
            saveTaskButton.BackColor = Color.FromArgb(0, 204, 102);
            saveTaskButton.ForeColor = Color.White;
            saveTaskButton.FlatStyle = FlatStyle.Flat;
            saveTaskButton.Location = new Point(710, 465);
            saveTaskButton.Size = new Size(120, 45);
            saveTaskButton.Click += saveTaskButton_Click;
            // ================================
            // ADD CONTROLS
            // ================================
            Controls.Add(labelTitle);
            Controls.Add(taskTitle);
            Controls.Add(labelDescription);
            Controls.Add(taskDescription);
            Controls.Add(labelDueDate);
            Controls.Add(dueDatePicker);
            Controls.Add(checkBoxHighPriority);
            Controls.Add(labelAssignUser);
            Controls.Add(comboBoxAssignUser);
            Controls.Add(saveTaskButton);
            ResumeLayout(false);
            PerformLayout();
        }
    }
}