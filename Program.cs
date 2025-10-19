using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace assignment2
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            SeedAdmin();
            Application.Run(new LogInScreen());
        }

        // Automatically create default admin if database.txt is missing or empty
        private static void SeedAdmin()
        {
            string filePath = "database.txt";
            if (!File.Exists(filePath) || File.ReadAllLines(filePath).All(l => string.IsNullOrWhiteSpace(l)))
            {
                File.WriteAllText(filePath, "admin|admin123|admin" + Environment.NewLine);
                MessageBox.Show("Default admin account created.\nUsername: admin\nPassword: admin123",
                                "Admin Created", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}