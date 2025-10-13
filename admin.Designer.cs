namespace assignment2
{
    partial class Admin
    {
        private System.ComponentModel.IContainer components = null;
        private ListBox listBoxUsers;
        private Label labelUsers;
        private TextBox textBoxNewUser;
        private TextBox textBoxNewPass;
        private ComboBox comboBoxRole;
        private Button createUserButton;
        private Button manageTasksButton;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            listBoxUsers = new ListBox();
            labelUsers = new Label();
            textBoxNewUser = new TextBox();
            textBoxNewPass = new TextBox();
            comboBoxRole = new ComboBox();
            createUserButton = new Button();
            manageTasksButton = new Button();
            SuspendLayout();

            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 600);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin Panel";
            BackColor = Color.WhiteSmoke;

            labelUsers.AutoSize = true;
            labelUsers.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelUsers.Location = new Point(40, 40);
            labelUsers.Text = "Existing Users:";

            listBoxUsers.Font = new Font("Segoe UI", 11F);
            listBoxUsers.Location = new Point(40, 80);
            listBoxUsers.Size = new Size(350, 420);

            textBoxNewUser.Font = new Font("Segoe UI", 11F);
            textBoxNewUser.PlaceholderText = "Username";
            textBoxNewUser.Location = new Point(420, 100);
            textBoxNewUser.Size = new Size(250, 35);

            textBoxNewPass.Font = new Font("Segoe UI", 11F);
            textBoxNewPass.PlaceholderText = "Password";
            textBoxNewPass.Location = new Point(420, 150);
            textBoxNewPass.Size = new Size(250, 35);

            comboBoxRole.Font = new Font("Segoe UI", 11F);
            comboBoxRole.Items.AddRange(new object[] { "admin", "user" });
            comboBoxRole.Location = new Point(420, 200);
            comboBoxRole.Size = new Size(250, 35);
            comboBoxRole.SelectedIndex = 1;

            createUserButton.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            createUserButton.Location = new Point(420, 260);
            createUserButton.Size = new Size(150, 45);
            createUserButton.Text = "Create User";
            createUserButton.BackColor = Color.FromArgb(51, 153, 255);
            createUserButton.ForeColor = Color.White;
            createUserButton.FlatStyle = FlatStyle.Flat;
            createUserButton.Click += createUserButton_Click;

            manageTasksButton.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            manageTasksButton.Location = new Point(420, 330);
            manageTasksButton.Size = new Size(150, 45);
            manageTasksButton.Text = "Manage Tasks";
            manageTasksButton.BackColor = Color.FromArgb(0, 204, 102);
            manageTasksButton.ForeColor = Color.White;
            manageTasksButton.FlatStyle = FlatStyle.Flat;
            manageTasksButton.Click += manageTasksButton_Click;

            Controls.Add(labelUsers);
            Controls.Add(listBoxUsers);
            Controls.Add(textBoxNewUser);
            Controls.Add(textBoxNewPass);
            Controls.Add(comboBoxRole);
            Controls.Add(createUserButton);
            Controls.Add(manageTasksButton);

            ResumeLayout(false);
            PerformLayout();
        }
    }
}
