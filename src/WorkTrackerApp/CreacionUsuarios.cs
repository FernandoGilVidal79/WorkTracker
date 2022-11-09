using IO.Swagger.Api;
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
            var users = apiclient.ApiUserGetUserByIdIdGet("1");
            var user = users.FirstOrDefault();
            if (txtNumEmpleado.Text != string.Empty)
            {       
                this.txtNombre.Text = user.UserName;
                this.txtEmail.Text = user.Email;
                this.txtApellido1.Text = user.SurName1;
                this.txtApellido2.Text = user.SurName2;
                this.txtNumVacaciones.Text = user.NHollidays.ToString();
                this.txtContrasena.Text = user.Password; /// TODO Encrptada¿?¿?¿?
            }
            else
            {
                
            }
        }



    

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
