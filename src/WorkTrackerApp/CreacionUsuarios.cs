using IO.Swagger.Api;
using IO.Swagger.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkTrackerAPP
{
    public partial class CreacionUsuarios : Form
    {

        private bool edicion = false;
        public CreacionUsuarios()
        {
            InitializeComponent();
        }

        private void CreacionUsuarios_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            
            var apiclient = new UserApi("http://worktracker-001-site1.atempurl.com/");
          
            if (txtNumEmpleado.Text != string.Empty)
            {
                var users = apiclient.ApiUserGetUserByIdIdGet(txtNumEmpleado.Text);
                var user = users.FirstOrDefault();
                if (user != null)
                {
                    this.txtNombre.Text        = user.UserName;
                    this.txtEmail.Text         = user.Email;
                    this.txtApellido1.Text     = user.SurName1;
                    this.txtApellido2.Text     = user.SurName2;
                    this.txtNumVacaciones.Text = user.NHollidays.ToString();
                    this.txtContrasena.Text    = user.Password; /// TODO Encrptada¿?¿?¿?
                    this.txtDepartamento.Text  = user.Phone.ToString();
                    edicion = true;
                }
                else
                {
                    this.toolStripStatusLabel1.Text = "Usuario no encontrado";
                }
            }
            else
            {
                this.toolStripStatusLabel1.Text = "Introduzca un número de empleado";
            }
        }



    

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                var user = new Users();
                user.Department = txtDepartamento.Text;
                user.UserTypeId = 1;
                user.UserName = txtNombre.Text;
                user.SurName1 = txtApellido1.Text;
                user.SurName2 = txtApellido2.Text;
                user.Status = true;
                user.NHollidays = Int32.Parse(txtNumVacaciones.Text);
                user.Email = txtEmail.Text;
                var apiclient = new UserApi("http://worktracker-001-site1.atempurl.com/");
                if (edicion)
                {
                    apiclient.ApiUserPost(user);
                }
                else
                {
                    apiclient.ApiUserCreateUserIdPut("", user);
                }
            }
            catch (Exception ex)
            {
                toolStripStatusLabel1.Text = "Error creando el usuario";
            }
         }
    }
}
