using IO.Swagger.Api;
using IO.Swagger.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkTrackerAPP
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            
        }
        public static Boolean ValidarCampos(String nombreUsuario, String contrasena)
        {
            if (nombreUsuario != "" || contrasena != "")
                return true;
            else 
                return false;
        }
        public static void MensajeError(String mensaje, String cabecera)
        {
            MessageBox.Show(mensaje, cabecera, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static void MensajeOk(String mensaje, String cabecera)
        {
            MessageBox.Show(mensaje, cabecera, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            var validar = ValidarCampos(txtUsuario.Text, txtContrasena.Text);
            if(validar)
            {
                var apiclient = new UserApi("http://worktracker-001-site1.atempurl.com/");
                var users = apiclient.ApiUserLoginGetWithHttpInfo("Mariano", "Mariano");
                var user = users.Data;
                Console.WriteLine(user.Email);
                MensajeOk("Bienvenido" + user.UserName, "Correcto");
            } else
            {
                MensajeError("El usuario NO existe", "Error");
            }

        }

    }
}
