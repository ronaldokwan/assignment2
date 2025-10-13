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
            if (!File.Exists("archive.txt")) return;
            listBoxArchive.Items.AddRange(File.ReadAllLines("archive.txt"));
        }
    }
}
