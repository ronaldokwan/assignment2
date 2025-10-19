namespace assignment2
{
    partial class LogInScreen
    {
        private System.ComponentModel.IContainer components = null;
        private Label labelTitle;
        private Label labelUsername;
        private Label labelPassword;
        private TextBox usernameField;
        private TextBox passwordField;
        private Button logIn;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            labelTitle = new Label();
            labelUsername = new Label();
            labelPassword = new Label();
            usernameField = new TextBox();
            passwordField = new TextBox();
            logIn = new Button();
            SuspendLayout();
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 600);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            BackColor = System.Drawing.Color.WhiteSmoke;
            labelTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            labelTitle.AutoSize = true;
            labelTitle.Location = new Point(260, 60);
            labelTitle.Text = "Task Management System";
            labelUsername.AutoSize = true;
            labelUsername.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelUsername.Location = new Point(220, 180);
            labelUsername.Text = "Username:";
            usernameField.Font = new Font("Segoe UI", 11F);
            usernameField.Location = new Point(350, 175);
            usernameField.Size = new Size(300, 35);
            labelPassword.AutoSize = true;
            labelPassword.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelPassword.Location = new Point(220, 240);
            labelPassword.Text = "Password:";
            passwordField.Font = new Font("Segoe UI", 11F);
            passwordField.Location = new Point(350, 235);
            passwordField.Size = new Size(300, 35);
            passwordField.PasswordChar = '*';
            logIn.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            logIn.Text = "Log In";
            logIn.Location = new Point(350, 320);
            logIn.Size = new Size(150, 45);
            logIn.BackColor = Color.FromArgb(51, 153, 255);
            logIn.ForeColor = Color.White;
            logIn.FlatStyle = FlatStyle.Flat;
            logIn.Click += logIn_Click;
            Controls.Add(labelTitle);
            Controls.Add(labelUsername);
            Controls.Add(usernameField);
            Controls.Add(labelPassword);
            Controls.Add(passwordField);
            Controls.Add(logIn);
            ResumeLayout(false);
            PerformLayout();
        }
    }
}