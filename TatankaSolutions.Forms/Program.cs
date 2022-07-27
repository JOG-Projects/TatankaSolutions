namespace TatankaSolutions
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(HandleException);
            Application.Run(new MainForm());
        }

        private static void HandleException(object sender, UnhandledExceptionEventArgs e)
        {
            MessageBox.Show(e.ExceptionObject.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}