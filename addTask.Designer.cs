namespace assignment2
{
    partial class AddTask
    {
        private System.ComponentModel.IContainer components = null;
        private Label labelTitle;
        private TextBox taskTitle;
        private Label labelDesc;
        private TextBox taskDescription;
        private Label labelAssign;
        private ComboBox comboBoxAssignUser;
        private Button saveTaskButton;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            labelTitle = new Label();
            taskTitle = new TextBox();
            labelDesc = new Label();
            taskDescription = new TextBox();
            labelAssign = new Label();
            comboBoxAssignUser = new ComboBox();
            saveTaskButton = new Button();
            SuspendLayout();

            // ================================
            // FORM SETTINGS
            // ================================
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 600);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add / Edit Task";
            BackColor = System.Drawing.Color.WhiteSmoke;

            // ================================
            // LABEL: TITLE
            // ================================
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelTitle.Location = new Point(50, 40);
            labelTitle.Text = "Task Title:";

            // ================================
            // TEXTBOX: TITLE
            // ================================
            taskTitle.Font = new Font("Segoe UI", 11F);
            taskTitle.Location = new Point(180, 35);
            taskTitle.Size = new Size(650, 35);

            // ================================
            // LABEL: DESCRIPTION
            // ================================
            labelDesc.AutoSize = true;
            labelDesc.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelDesc.Location = new Point(50, 100);
            labelDesc.Text = "Description:";

            // ================================
            // TEXTBOX: DESCRIPTION
            // ================================
            taskDescription.Font = new Font("Segoe UI", 11F);
            taskDescription.Location = new Point(180, 95);
            taskDescription.Multiline = true;
            taskDescription.ScrollBars = ScrollBars.Vertical;
            taskDescription.Size = new Size(650, 350);

            // ================================
            // LABEL: ASSIGN USER
            // ================================
            labelAssign.AutoSize = true;
            labelAssign.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelAssign.Location = new Point(50, 470);
            labelAssign.Text = "Assign To:";

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
            saveTaskButton.Location = new Point(710, 465);
            saveTaskButton.Size = new Size(120, 45);
            saveTaskButton.BackColor = System.Drawing.Color.FromArgb(0, 204, 102);
            saveTaskButton.ForeColor = Color.White;
            saveTaskButton.FlatStyle = FlatStyle.Flat;
            saveTaskButton.Click += saveTaskButton_Click;

            // ================================
            // ADD CONTROLS
            // ================================
            Controls.Add(labelTitle);
            Controls.Add(taskTitle);
            Controls.Add(labelDesc);
            Controls.Add(taskDescription);
            Controls.Add(labelAssign);
            Controls.Add(comboBoxAssignUser);
            Controls.Add(saveTaskButton);

            ResumeLayout(false);
            PerformLayout();
        }
    }
}
