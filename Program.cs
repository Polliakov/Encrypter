using System;
using System.Windows.Forms;
using Encrypter.UI;

namespace Encrypter
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (args.Length == 0)
                Application.Run(new MainForm());
            else
                Application.Run(new DecryptForm(args[0]));
        }
    }
}
