using System.Drawing;
using System.Windows.Forms;

namespace assignment2
{
    partial class TrashScreen
    {
        private System.ComponentModel.IContainer components = null;
        private ListBox listBoxTrash;
        private Label labelTrash;
        private Button closeButton;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            listBoxTrash = new ListBox();
            labelTrash = new Label();
            closeButton = new Button();
            SuspendLayout();
            // ================================
            // FORM SETTINGS
            // ================================
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 600);
            StartPosition = FormStartPosition.CenterParent;
            Text = "Trash Bin";
            BackColor = Color.WhiteSmoke;
            // ================================
            // LABEL: TRASH TITLE
            // ================================
            labelTrash.AutoSize = true;
            labelTrash.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            labelTrash.Location = new Point(50, 30);
            labelTrash.Text = "Deleted Tasks:";
            // ================================
            // LISTBOX: TRASH
            // ================================
            listBoxTrash.Font = new Font("Segoe UI", 11F);
            listBoxTrash.Location = new Point(50, 80);
            listBoxTrash.Size = new Size(800, 400);
            listBoxTrash.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            listBoxTrash.BorderStyle = BorderStyle.FixedSingle;
            // ================================
            // BUTTON: CLOSE
            // ================================
            closeButton.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            closeButton.Text = "Close";
            closeButton.Location = new Point(700, 500);
            closeButton.Size = new Size(150, 45);
            closeButton.BackColor = Color.Gray;
            closeButton.ForeColor = Color.White;
            closeButton.FlatStyle = FlatStyle.Flat;
            closeButton.Click += (sender, e) => Close();
            // ================================
            // BUTTON: CLEAR ALL TRASH
            // ================================
            clearTrashButton = new Button();
            clearTrashButton.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            clearTrashButton.Text = "Clear All Trash";
            clearTrashButton.Location = new Point(500, 500);
            clearTrashButton.Size = new Size(180, 45);
            clearTrashButton.BackColor = Color.Red;
            clearTrashButton.ForeColor = Color.White;
            clearTrashButton.FlatStyle = FlatStyle.Flat;
            clearTrashButton.Click += clearTrashButton_Click;
            // ================================
            // ADD CONTROLS
            // ================================
            Controls.Add(clearTrashButton);
            Controls.Add(labelTrash);
            Controls.Add(listBoxTrash);
            Controls.Add(closeButton);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}
