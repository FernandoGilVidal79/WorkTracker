using System;
using System.Windows.Forms;

namespace WorkTrackerAPP
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
           // Application.Run(new CreacionUsuarios());
           // Application.Run(new Situacion());
            Application.Run(new Login());
        }
    }
}
