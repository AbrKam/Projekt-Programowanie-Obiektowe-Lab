using Projekt_w69758_GL01_3IIZ.DbFunctionality;

namespace Projekt_w69758_GL01_3IIZ
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            DBManager dbContext = new DBManager();
            DbInitializer.Initialize(dbContext);
            Application.Run(new MainForm());
        }
    }
}