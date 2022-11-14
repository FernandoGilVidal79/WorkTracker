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
        /*
         * Mensaje de bienvenida
         */
        public static void mensajeBienvenida(Label lblBienvenida)
        {
            var hora = DateTime.Now.ToString("HH");
            var mensaje = "";
            if (int.Parse(hora) >= 5 && int.Parse(hora) < 12)
            {
                mensaje = "¡Buenos días " + UserSession.User.UserName + "!";
            }
            if (int.Parse(hora) >= 12 && int.Parse(hora) < 21)
            {
                mensaje = "¡Buenas tardes " + UserSession.User.UserName + "!";
            }
            if (int.Parse(hora) >= 21 && int.Parse(hora) < 5)
            {
                mensaje = "¡Buenas noches " + UserSession.User.UserName + "!";
            }
            lblBienvenida.Text = mensaje;
        }
    }
}
