using System;
using System.Windows.Forms;

namespace assignment2
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new LogInScreen());
        }
    }
}
