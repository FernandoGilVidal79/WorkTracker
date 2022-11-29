using IO.Swagger.Api;
using IO.Swagger.Model;
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
    public partial class ResetLogin : Form
    {
        
        public ResetLogin()
        {
            InitializeComponent();
        }

        private void ResetLogin_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Cree Contraseña nueva. Incluya mayuscula(s), número(s) y caracter(es) especiales.");

        }

        private bool ConfirmarContraseniaActual(String contrasenia)
        {
            var apiclient = new UserApi("http://worktracker-001-site1.atempurl.com/");
            var users = apiclient.ApiUserGetUserByIdIdGet(UserSession.User.IdUser.ToString());
            var user = users.FirstOrDefault();

            String contraseniaApp = user.Password;
            if (contraseniaApp.Equals(txtContraseniaActual.Text))
            {
                return true;
            }

            else
            {
                return false;
            }
                        
        }

        private bool AlgoritmoContraseñaSegura(string password)
        {
           bool mayuscula = false, minuscula = false, numero = false, carespecial = false;
            for (int i = 0; i < password.Length; i++)
            {
                if (Char.IsUpper(password, i))
                {
                    mayuscula = true;
                }
                else if (Char.IsLower(password, i))
                {
                    minuscula = true;
                }
                else if (Char.IsDigit(password, i))
                {
                    numero = true;
                }
                else
                {
                    carespecial = true;
                }
            }
            if (mayuscula && minuscula && numero && carespecial && password.Length >= 8)
            {
                return true;
            }
            return false;
        }

        private bool ConfirmarContrasenia(string password2)
        {
            if (password2.Equals(txtContraseniaNueva))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (ConfirmarContraseniaActual(txtContraseniaActual.Text))
            {
                if (AlgoritmoContraseñaSegura(txtContraseniaNueva.Text))
                {
                        var apiclient = new UserApi("http://worktracker-001-site1.atempurl.com/");
                        var users = apiclient.ApiUserGetUserByIdIdGet(UserSession.User.IdUser.ToString());
                        var user = users.FirstOrDefault();
                        try
                        {
                            var usuario = new Users
                            {
                                IdUser = user.IdUser,
                                Department = user.Department,
                                UserTypeId = user.UserTypeId,
                                UserName = user.UserName,
                                SurName1 = user.SurName1,
                                SurName2 = user.SurName2,
                                Status = user.Status,
                                Phone = user.Phone,
                                NHollidays = user.NHollidays,
                                Email = user.Email,
                                Password = txtContraseniaNueva.Text
                            };
                        UserSession.User.Password = txtContraseniaNueva.Text;
                            apiclient.ApiUserUpdateUserPost(usuario);
                            MessageBox.Show("Contraseña modificada correctamente.");
                            this.Close();

                        }
                        catch
                        {
                            MessageBox.Show("Error al guardar, contacte con RRHH");
                        }

                    
                
                }
                else { MessageBox.Show("La Contraseña no cumple con los requisitos"); }

            }
            else { MessageBox.Show("La contraseña actual no coincide con la del sistema"); }

            
        }
    }
}
