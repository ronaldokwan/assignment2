namespace assignment2
{
    partial class signUp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            signUpLabel = new Label();
            passwordLabel = new Label();
            usernameLabel = new Label();
            passwordField = new TextBox();
            usernameField = new TextBox();
            label1 = new Label();
            textBox1 = new TextBox();
            signUpButton = new Button();
            SuspendLayout();
            // 
            // signUpLabel
            // 
            signUpLabel.AutoSize = true;
            signUpLabel.Font = new Font("Segoe UI", 22F);
            signUpLabel.Location = new Point(322, 25);
            signUpLabel.Name = "signUpLabel";
            signUpLabel.Size = new Size(151, 50);
            signUpLabel.TabIndex = 1;
            signUpLabel.Text = "Sign Up";
            signUpLabel.Click += signUpLabel_Click;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new Point(258, 240);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(73, 20);
            passwordLabel.TabIndex = 10;
            passwordLabel.Text = "Password:";
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Location = new Point(258, 193);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(78, 20);
            usernameLabel.TabIndex = 9;
            usernameLabel.Text = "Username:";
            // 
            // passwordField
            // 
            passwordField.Location = new Point(342, 237);
            passwordField.Name = "passwordField";
            passwordField.PasswordChar = '*';
            passwordField.Size = new Size(201, 27);
            passwordField.TabIndex = 8;
            // 
            // usernameField
            // 
            usernameField.Location = new Point(342, 186);
            usernameField.Name = "usernameField";
            usernameField.Size = new Size(201, 27);
            usernameField.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(258, 148);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 12;
            label1.Text = "Email:";
            label1.Click += this.label1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(342, 141);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(201, 27);
            textBox1.TabIndex = 11;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // signUpButton
            // 
            signUpButton.Location = new Point(342, 309);
            signUpButton.Name = "signUpButton";
            signUpButton.Size = new Size(94, 29);
            signUpButton.TabIndex = 13;
            signUpButton.Text = "Sign Up";
            signUpButton.UseVisualStyleBackColor = true;
            // 
            // signUp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(signUpButton);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(passwordLabel);
            Controls.Add(usernameLabel);
            Controls.Add(passwordField);
            Controls.Add(usernameField);
            Controls.Add(signUpLabel);
            Name = "signUp";
            Text = "Sign Up";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label signUpLabel;
        private Label passwordLabel;
        private Label usernameLabel;
        private TextBox passwordField;
        private TextBox usernameField;
        private Label label1;
        private TextBox textBox1;
        private Button signUpButton;
    }
}