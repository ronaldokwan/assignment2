namespace assignment2
{
    partial class LogInScreen
    {
        /// <summary>
        /// Required designer variable — manages UI components.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        // Form controls
        private Label labelTitle;
        private Label labelUsername;
        private Label labelPassword;
        private TextBox usernameField;
        private TextBox passwordField;
        private Button logIn;
        private Button signUpButton;

        /// <summary>
        /// Disposes resources used by this form.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();

            base.Dispose(disposing);
        }

        /// <summary>
        /// Initializes and configures all visual components for the Login screen.
        /// </summary>
        private void InitializeComponent()
        {
            // Create controls
            labelTitle = new Label();
            labelUsername = new Label();
            labelPassword = new Label();
            usernameField = new TextBox();
            passwordField = new TextBox();
            logIn = new Button();
            signUpButton = new Button();
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
            usernameField.PlaceholderText = "Enter your username";

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
            passwordField.PlaceholderText = "Enter your password";

            // ================================
            // BUTTON: LOG IN
            // ================================
            logIn.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            logIn.Text = "Log In";
            logIn.Location = new Point(350, 320);
            logIn.Size = new Size(150, 45);
            logIn.BackColor = System.Drawing.Color.FromArgb(51, 153, 255);
            logIn.ForeColor = Color.White;
            logIn.FlatStyle = FlatStyle.Flat;
            logIn.Click += logIn_Click;

            // ================================
            // BUTTON: SIGN UP
            // ================================
            signUpButton.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            signUpButton.Text = "Sign Up";
            signUpButton.Location = new Point(520, 320);
            signUpButton.Size = new Size(150, 45);
            signUpButton.BackColor = System.Drawing.Color.FromArgb(0, 204, 102);
            signUpButton.ForeColor = Color.White;
            signUpButton.FlatStyle = FlatStyle.Flat;
            signUpButton.Click += signUpButton_Click;

            // ================================
            // ADD CONTROLS TO FORM
            // ================================
            Controls.Add(labelTitle);
            Controls.Add(labelUsername);
            Controls.Add(usernameField);
            Controls.Add(labelPassword);
            Controls.Add(passwordField);
            Controls.Add(logIn);
            Controls.Add(signUpButton);

            // ================================
            // FINALIZE LAYOUT
            // ================================
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
