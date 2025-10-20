namespace assignment2
{
    partial class TrashScreen
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
            listBoxTrash = new ListBox();
            SuspendLayout();
            // 
            // listBoxTrash
            // 
            listBoxTrash.FormattingEnabled = true;
            listBoxTrash.Location = new Point(176, 27);
            listBoxTrash.Name = "listBoxTrash";
            listBoxTrash.Size = new Size(443, 244);
            listBoxTrash.TabIndex = 0;
            // 
            // TrashScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listBoxTrash);
            Name = "TrashScreen";
            Text = "Trash";
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBoxTrash;
    }
}