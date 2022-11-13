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
                Helper.MensajeError("El Nombre de usuario está vacío", "Error");
                return false;

            }
            if (contrasena.Text == "")
            {
                contrasena.Focus();
                Helper.MensajeError("La Contraseña no es correcta", "Error");
                return false;
            }
                return true;

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
                var users = apiclient.ApiUserLoginGet(txtUsuario.Text, txtContrasena.Text);

                //Comprobamos que el usuario existe, en caso de existir entra en al APP, en caso contrario muestra un mensaje
                var user = users;
                if(user != null)
                {
                    UserSession.user = user;
                    Helper.MensajeOk("Bienvenido " + user.Email, "Correcto");
                    this.Hide();
                    MenuPrincipal frmMenuPrincipal  = new MenuPrincipal();
                    frmMenuPrincipal.ShowDialog();
                    this.Close();

                } 
                else
                {
                    Helper.MensajeError("El usuario NO existe", "Error");
                }

            } 
            else
            {
                Helper.MensajeError("Ocurrió un error en la validación", "Error");
            }

        }

    }
}
