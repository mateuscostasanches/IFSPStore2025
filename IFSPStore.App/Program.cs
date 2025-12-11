using IFSPStore.App.Infra;

namespace IFSPStore.App
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Dependence Injection Config
            ConfigureDI.ConfigureServices();
            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());
        }
    }
}