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
        public static Boolean ValidarCampos(TextBox nombreUsuario, TextBox contrasena)
        {
            if (nombreUsuario.Text == "")
            {
                nombreUsuario.Focus();
                MensajeError("El Nombre de usuario está vacío", "Error");
                return false;

            }
            if (contrasena.Text == "")
            {
                contrasena.Focus();
                MensajeError("La Contraseña no es correcta", "Error");
                return false;
            }
                return true;

        }
        /*
         * Mensaje de error 
         */
        public static void MensajeError(String mensaje, String cabecera)
        {
            MessageBox.Show(mensaje, cabecera, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        /*
         * Mensaje de OK
         */
        public static void MensajeOk(String mensaje, String cabecera)
        {
            MessageBox.Show(mensaje, cabecera, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            //Validamos los campos
            var validar = ValidarCampos(txtUsuario, txtContrasena);
            //En caso de que la validación sea correcta obtenemos el usuario
            if(validar)
            {
                //Llamamos a al api para obtener el usuario
                var apiclient = new UserApi("http://worktracker-001-site1.atempurl.com/");
                var users = apiclient.ApiUserLoginGetWithHttpInfo(txtUsuario.Text, txtContrasena.Text);

                //Comprobamos que el usuario existe, en caso de existir entra en al APP, en caso contrario muestra un mensaje
                var user = users.Data;
                if(user != null)
                {
                    Console.WriteLine(user);
                    MensajeOk("Bienvenido " + user.UserName, "Correcto");
                    this.Hide();
                    MenuPrincipal frmMenuPrincipal  = new MenuPrincipal();
                    frmMenuPrincipal.ShowDialog();
                    this.Close();

                } else
                {
                    MensajeError("El usuario NO existe", "Error");
                }

            } else
            {
                MensajeError("Ocurrió un error en la validación", "Error");
            }

        }

    }
}
