namespace ZombieShooter
{
    internal static class Program
    {
        static Player1 player1;
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            player1 = new Player1();

            MainMenu mainMenu = new MainMenu(player1); // Pass the Player1 instance to the MainMenu
            Application.Run(mainMenu);

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
        }
    }
}