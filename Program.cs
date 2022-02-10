using DataJuggler.UltimateHelper;

namespace Center
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            // Create a new instance of a 'MainForm' object.
            MainForm mainForm = new MainForm();
            mainForm.Tag = args;
            Application.Run(mainForm);
        }

        
    }
}