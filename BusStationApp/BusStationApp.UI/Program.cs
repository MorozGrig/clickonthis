using System;
using System.Windows.Forms;
using BusStationApp.UI.Forms;

namespace BusStationApp.UI
{
    internal static class Program
    {
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.ThreadException += (sender, args) =>
            {
                MessageBox.Show(args.Exception.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            };

            AppDomain.CurrentDomain.UnhandledException += (sender, args) =>
            {
                MessageBox.Show("Критическая ошибка приложения.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            };

            Application.Run(new LoginForm());
        }
    }
}
