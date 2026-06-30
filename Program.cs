using ClinicMangementSystem.Models;
#nullable disable
namespace ClinicMangementSystem
{
    internal static class Program
    {
        public static UserModel? CurrentUser { get; internal set; }

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new PL.LoginForm());
        }
    }
}