namespace assignment2
{
    partial class Archive
    {
        private System.ComponentModel.IContainer components = null;
        private ListBox listBoxArchive;
        private Label labelArchive;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            listBoxArchive = new ListBox();
            labelArchive = new Label();
            SuspendLayout();

            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 600);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Archive";

            labelArchive.AutoSize = true;
            labelArchive.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelArchive.Location = new Point(50, 40);
            labelArchive.Text = "Archived Tasks:";

            listBoxArchive.Font = new Font("Segoe UI", 11F);
            listBoxArchive.Location = new Point(50, 80);
            listBoxArchive.Size = new Size(700, 450);

            Controls.Add(labelArchive);
            Controls.Add(listBoxArchive);
            ResumeLayout(false);
            PerformLayout();
        }

    }
}
