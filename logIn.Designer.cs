namespace assignment2
{
    partial class logInScreen
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            logInTitle = new Label();
            logInButton = new Button();
            usernameField = new TextBox();
            passwordField = new TextBox();
            signUpButton = new Button();
            usernameLabel = new Label();
            passwordLabel = new Label();
            SuspendLayout();
            // 
            // logInTitle
            // 
            logInTitle.AutoSize = true;
            logInTitle.Font = new Font("Segoe UI", 20F);
            logInTitle.Location = new Point(276, 55);
            logInTitle.Name = "logInTitle";
            logInTitle.Size = new Size(213, 46);
            logInTitle.TabIndex = 0;
            logInTitle.Text = "Login Screen";
            logInTitle.TextAlign = ContentAlignment.TopCenter;
            // 
            // logInButton
            // 
            logInButton.Location = new Point(276, 299);
            logInButton.Name = "logInButton";
            logInButton.Size = new Size(94, 29);
            logInButton.TabIndex = 1;
            logInButton.Text = "Log In";
            logInButton.UseVisualStyleBackColor = true;
            logInButton.Click += logIn_Click;
            // 
            // usernameField
            // 
            usernameField.Location = new Point(342, 169);
            usernameField.Name = "usernameField";
            usernameField.Size = new Size(201, 27);
            usernameField.TabIndex = 2;
            usernameField.TextChanged += textBox1_TextChanged;
            // 
            // passwordField
            // 
            passwordField.Location = new Point(342, 220);
            passwordField.Name = "passwordField";
            passwordField.PasswordChar = '*';
            passwordField.Size = new Size(201, 27);
            passwordField.TabIndex = 3;
            // 
            // signUpButton
            // 
            signUpButton.Location = new Point(383, 299);
            signUpButton.Name = "signUpButton";
            signUpButton.Size = new Size(94, 29);
            signUpButton.TabIndex = 4;
            signUpButton.Text = "Sign Up";
            signUpButton.UseVisualStyleBackColor = true;
            signUpButton.Click += signUpButton_Click;
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Location = new Point(258, 176);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(78, 20);
            usernameLabel.TabIndex = 5;
            usernameLabel.Text = "Username:";
            usernameLabel.Click += label1_Click;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new Point(258, 223);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(73, 20);
            passwordLabel.TabIndex = 6;
            passwordLabel.Text = "Password:";
            // 
            // logInScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(passwordLabel);
            Controls.Add(usernameLabel);
            Controls.Add(signUpButton);
            Controls.Add(passwordField);
            Controls.Add(usernameField);
            Controls.Add(logInButton);
            Controls.Add(logInTitle);
            Name = "logInScreen";
            Text = "Task Manager";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label logInTitle;
        private Button logInButton;
        private TextBox usernameField;
        private TextBox passwordField;
        private Button signUpButton;
        private Label usernameLabel;
        private Label passwordLabel;
    }
}
