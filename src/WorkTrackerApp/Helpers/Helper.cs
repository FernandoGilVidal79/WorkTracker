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
        public static void MensajeBienvenida(Label lblBienvenida)
        {
            var hora = DateTime.UtcNow.ToString("HH");
            var mensaje = "";
            if (int.Parse(hora) >= 5 && int.Parse(hora) < 12)
            {
                mensaje = "¡Buenos días " + UserSession.User.Name + "!";
            }
            if (int.Parse(hora) >= 12 && int.Parse(hora) < 21)
            {
                mensaje = "¡Buenas tardes " + UserSession.User.Name + "!";
            }
            if (int.Parse(hora) >= 21 || int.Parse(hora) < 5)
            {
                mensaje = "¡Buenas noches " + UserSession.User.Name + "!";
            }
            lblBienvenida.Text = mensaje;
        }
        public static void MostrarHora(Label hora, Label fecha)
        {
            hora.Text = DateTime.UtcNow.AddHours(1).ToString("HH:mm:ss tt");
            fecha.Text = DateTime.UtcNow.ToString("D");
        }
    }
}
