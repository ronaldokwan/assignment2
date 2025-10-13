using System;
using System.Windows.Forms;

namespace assignment2
{
    /// <summary>
    /// The main entry point for the Task Management System.
    /// This class launches the application and loads the initial login screen.
    /// </summary>
    internal static class Program
    {
        /// <summary>
        /// The main method where program execution begins.
        /// It initializes Windows Forms configurations and runs the LogInScreen form.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Initializes the application configuration (scaling, styles, etc.)
            ApplicationConfiguration.Initialize();

            // Launches the login window as the starting form of the application
            Application.Run(new LogInScreen());
        }
    }
}
