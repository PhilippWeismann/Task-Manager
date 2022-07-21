namespace Task_Manager
{
    /// Projektbeschreibung:
    /// Ablussprojekt PRO2UE: Task-Manager
    /// Studenten: NITSCHE Simon - S2110438010
    ///            WEISMANN Philipp - S2110438015
    /// LVA-Leiter: Dipl.- Ing. Ralph Slabihoud
    /// Abgabetermin: 31.07.2022

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

            MainView mainView = new MainView();

            ProcessManager manager = new ProcessManager(mainView, processes);

            Application.Run(mainView);            
        }
    }
}