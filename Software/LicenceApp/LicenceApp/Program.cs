using DBLayer;
using System;
using System.Windows.Forms;

namespace LicenceApp
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            DB.SetConfiguration("RWA2526_mslavic23", "RWA2526_mslavic23", "+>D01Lav(g6T51Iu");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmLogin());
        }
    }
}