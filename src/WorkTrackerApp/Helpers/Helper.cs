using System;
using System.Windows.Forms;

namespace WorkTrackerAPP
{
    public static class Helper
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="mensaje"></param>
        /// <param name="cabecera"></param>
        public static void MensajeError(String mensaje, String cabecera)
        {
            MessageBox.Show(mensaje, cabecera, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="mensaje"></param>
        /// <param name="cabecera"></param>
        public static void MensajeOk(String mensaje, String cabecera)
        {
            MessageBox.Show(mensaje, cabecera, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
