using FirebaseAdmin;
using Google.Apis.Auth.OAuth2;
using System.Diagnostics;

namespace LibraryManager
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
            Application.Run(new Form1());

            //var filepath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "pushpractise-e526b-firebase-adminsdk-4dfid-f7f7e28155.json");
            //Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", filepath);
            //Debug.WriteLine(filepath);

            

        }
    }
}