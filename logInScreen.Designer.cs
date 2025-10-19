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
            // ================================
            // LABEL: TITLE
            // ================================
            labelTitle = new Label();
            // ================================
            // LABEL: USERNAME
            // ================================
            labelUsername = new Label();
            // ================================
            // LABEL: PASSWORD
            // ================================
            labelPassword = new Label();
            // ================================
            // TEXTBOX: USERNAME
            // ================================
            usernameField = new TextBox();
            // ================================
            // TEXTBOX: PASSWORD
            // ================================
            passwordField = new TextBox();
            // ================================
            // BUTTON: LOG IN
            // ================================
            logIn = new Button();
            SuspendLayout();
            // ================================
            // FORM SETTINGS
            // ================================
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 600);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            BackColor = System.Drawing.Color.WhiteSmoke;
            // ================================
            // LABEL: TITLE
            // ================================
            labelTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            labelTitle.AutoSize = true;
            labelTitle.Location = new Point(260, 60);
            labelTitle.Text = "Task Management System";
            // ================================
            // LABEL: USERNAME
            // ================================
            labelUsername.AutoSize = true;
            labelUsername.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelUsername.Location = new Point(220, 180);
            labelUsername.Text = "Username:";
            // ================================
            // TEXTBOX: USERNAME
            // ================================
            usernameField.Font = new Font("Segoe UI", 11F);
            usernameField.Location = new Point(350, 175);
            usernameField.Size = new Size(300, 35);
            // ================================
            // LABEL: PASSWORD
            // ================================
            labelPassword.AutoSize = true;
            labelPassword.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelPassword.Location = new Point(220, 240);
            labelPassword.Text = "Password:";
            // ================================
            // TEXTBOX: PASSWORD
            // ================================
            passwordField.Font = new Font("Segoe UI", 11F);
            passwordField.Location = new Point(350, 235);
            passwordField.Size = new Size(300, 35);
            passwordField.PasswordChar = '*';
            // ================================
            // BUTTON: LOG IN
            // ================================
            logIn.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            logIn.Text = "Log In";
            logIn.Location = new Point(350, 320);
            logIn.Size = new Size(150, 45);
            logIn.BackColor = Color.FromArgb(51, 153, 255);
            logIn.ForeColor = Color.White;
            logIn.FlatStyle = FlatStyle.Flat;
            logIn.Click += logIn_Click;
            // ================================
            // ADD CONTROLS
            // ================================
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