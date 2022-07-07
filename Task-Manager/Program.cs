namespace Task_Manager
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

            
            InternalProcesses processes = new InternalProcesses();
            processes.RunProcessLoop(2000);

            MainView mainView = new MainView();

            ProcessManager manager = new ProcessManager(mainView, processes);

            Application.Run(mainView);
            
        }
    }
}