using IO.Swagger.Api;
using System;
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
            LoginExecute();


        }


        private void LoginExecute()
        {
            //Validamos los campos
            var validar = ValidarCampos(txtUsuario, txtContrasena);
            //En caso de que la validación sea correcta obtenemos el usuario
            if (validar)
            {
                //encriptamos la contraseña que meten en el login
                String pswMail = txtUsuario.Text;
                String pswMailUsuario = txtContrasena.Text + pswMail.Substring(0, pswMail.IndexOf("@"));

                string psw = Encriptado.GetSHA256(pswMailUsuario);

                //Llamamos a al api para obtener el usuario

                //var userAPI = new LoginApi("https://localhost:44363/");
                //var token = userAPI.ApiLoginTokenGet("usuario","123456");
                //token = token.Replace("\"", "");
                //var apiclient = new UserApi("https://localhost:44363/");

                //apiclient.Configuration = new IO.Swagger.Client.Configuration();
                //apiclient.Configuration.BasePath = "https://localhost:44363/";
                //apiclient.Configuration.AddApiKeyPrefix("Authorization", $"Bearer {token}");
                //apiclient.Configuration.AddDefaultHeader("Content-Type", "application/json");
                //apiclient.Configuration.AddDefaultHeader("Authorization", $"Bearer {token}"); 
                //var users = apiclient.ApiUserLoginGet(txtUsuario.Text, psw);

                var apiclient = new UserApi(UserSession.APIUrl);
                var users = apiclient.ApiUserLoginGet(txtUsuario.Text, psw);


                //Comprobamos que el usuario existe, en caso de existir entra en al APP, en caso contrario muestra un mensaje
                var user = users;
                if (user != null)
                {
                    if (user.Status == true)
                    {
                        UserSession.User = user;
                        Helper.MensajeOk("Bienvenido " + user.Name, "Correcto");
                        this.Hide();
                        //Obtenemos el id del usuario
                        if (user.UserTypeId == 1)
                        {
                            MenuPrincipalAdmin frmMenuPrincipal = new MenuPrincipalAdmin();
                            frmMenuPrincipal.ShowDialog();
                            this.Close();
                        }
                        else if (user.UserTypeId == 2)
                        {
                            MenuPrincipalRRHH frmMenuPrincipal = new MenuPrincipalRRHH();
                            frmMenuPrincipal.ShowDialog();
                            this.Close();
                        }
                        else
                        {
                            MenuPrincipal frmMenuPrincipal = new MenuPrincipal();
                            frmMenuPrincipal.ShowDialog();
                            this.Close();
                        }

                    }
                    else
                    {
                        MessageBox.Show("Usuario en estado de baja, pruebe otro usuario.");
                    }
                }
                else
                {
                    var usersSinEncriptar = apiclient.ApiUserLoginGet(txtUsuario.Text, txtContrasena.Text);
                    var user2 = usersSinEncriptar;
                    UserSession.User = user2;

                    if ((user2!= null) && txtContrasena.Text.Equals(user2.Name))
                    {
                        txtContrasena.Clear();
                        Helper.MensajeOk("Por favor cambie la contraseña ", "OK");
                        ResetLogin frmResetLogin = new ResetLogin();
                        frmResetLogin.ShowDialog();
                    }
                    else
                    {
                        Helper.MensajeError("El usuario NO existe", "Error");
                    }

                }
            }
            else
            {
                Helper.MensajeError("Ocurrió un error en la validación", "Error");
            }
        }



        private void ValidateEnterPress(object sender, KeyPressEventArgs e)
            {

                if (e.KeyChar == Convert.ToChar(Keys.Enter))
                {
                    LoginExecute();
                }
            }

        private void Login_Load(object sender, EventArgs e)
        {

            ///Usuario RRHH
          //  this.txtUsuario.Text = "mariano@superman.com";
           // this.txtContrasena.Text = "Worktracker@1";

            //Usuario Admin
         //   this.txtUsuario.Text = "olema@worktrackers";
           // this.txtContrasena.Text = "Worktracker@1";

        }

        private void linkPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ResetLogin frmResetLogin = new ResetLogin();
            frmResetLogin.ShowDialog();
        }
    }
    }