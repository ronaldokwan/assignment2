namespace assignment2
{
    partial class addTask
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
            addTaskLabel = new Label();
            SuspendLayout();
            // 
            // addTaskLabel
            // 
            addTaskLabel.AutoSize = true;
            addTaskLabel.Font = new Font("Segoe UI", 22F);
            addTaskLabel.Location = new Point(292, 27);
            addTaskLabel.Name = "addTaskLabel";
            addTaskLabel.Size = new Size(197, 50);
            addTaskLabel.TabIndex = 0;
            addTaskLabel.Text = "Add a Task";
            // 
            // addTask
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(addTaskLabel);
            Name = "addTask";
            Text = "Add Task";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label addTaskLabel;
    }
}