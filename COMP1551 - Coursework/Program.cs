namespace COMP1551___Coursework
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            Form1 loginForm = new Form1();

            if (loginForm.ShowDialog() == DialogResult.OK)
            {
                //Pass the logged in role to MainMenu
                Application.Run(new MainMenu(loginForm.LoggedInRole));
            }
        }
    }
}