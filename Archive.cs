using System;
using System.IO;
using System.Windows.Forms;

namespace assignment2
{
    public partial class Archive : Form
    {
        public Archive()
        {
            InitializeComponent();
            LoadArchive();
        }

        private void LoadArchive()
        {
            listBoxArchive.Items.Clear();
            if (!File.Exists("archive.txt"))
            {
                listBoxArchive.Items.Add("No archived tasks yet.");
                return;
            }

            var lines = File.ReadAllLines("archive.txt");
            if (lines.Length == 0)
                listBoxArchive.Items.Add("No archived tasks yet.");
            else
                listBoxArchive.Items.AddRange(lines);
        }
    }
}
