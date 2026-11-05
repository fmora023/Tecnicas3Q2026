using ClassExampleController;
using ClassExampleModels;

namespace ClassExample
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
            var dataHandler = new FileHandler<User>();
            var informationService = new InformationService(dataHandler);
            var loginController = new LoginController(informationService);
            var loginView = new LoginView(loginController);
            Application.Run(loginView);
        }
    }
}