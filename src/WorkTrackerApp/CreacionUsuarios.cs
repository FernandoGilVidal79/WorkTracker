using IO.Swagger.Api;
using IO.Swagger.Model;
using System;
using System.Linq;
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
            ActivarCampos(false);
            CargarTipoUsuarios();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void ActivarCampos(bool status)
        {
            txtNumEmpleado.Enabled      = !status;
            txtNombre.Enabled           = status;
            txtApellido1.Enabled        = status;
            txtApellido2.Enabled        = status;
            txtContrasena.Enabled       = status;
            txtDepartamento.Enabled     = status;
            txtEmail.Enabled            = status;
            txtTelefono.Enabled         = status;
            txtNumVacaciones.Enabled    = status;
        }
        
        private void LimpiarCampos()
        {
            txtApellido1.Text       = "";
            txtApellido2.Text       = "";
            txtContrasena.Text      = "";
            txtDepartamento.Text    = "";
            txtDepartamento.Text    = "";
            txtEmail.Text           = "";
            txtNombre.Text          = "";
            txtNumEmpleado.Text     = "";
            txtNumVacaciones.Text   = "";
            txtTelefono.Text        = "";

        }

        private void CargarTipoUsuarios()
        {
            var apiclient = new UserApi("http://worktracker-001-site1.atempurl.com/");
            var userTypes = apiclient.ApiUserGetUserTypesGet();

            cmbTipoUsuario.DisplayMember = "Description";
            cmbTipoUsuario.ValueMember = "IdUserType";
            cmbTipoUsuario.DataSource = userTypes;
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
                    this.txtNumEmpleado.Text   = user.IdUser.ToString();
                    this.txtNombre.Text        = user.UserName;
                    this.txtEmail.Text         = user.Email;
                    this.txtApellido1.Text     = user.SurName1;
                    this.txtApellido2.Text     = user.SurName2;
                    this.txtTelefono.Text      = user.Phone.ToString();
                    this.txtNumVacaciones.Text = user.NHollidays.ToString();
                    this.txtContrasena.Text    = user.Password; /// TODO Encrptada¿?¿?¿?
                    this.txtDepartamento.Text  = user.Phone.ToString();
                    edicion = true;
                    ActivarCampos(true);
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                var user = new Users();
                
               
                user.Department = txtDepartamento.Text;
                user.UserTypeId = 1;///cmbTipoUsuario.Items[cmbTipoUsuario.SelectedIndex];
                user.UserName   = txtNombre.Text;
                user.SurName1   = txtApellido1.Text;
                user.SurName2   = txtApellido2.Text;
                user.Status     = true;
                user.Phone      = Int32.Parse(txtTelefono.Text);
                user.NHollidays = Int32.Parse(txtNumVacaciones.Text);
                user.Email      = txtEmail.Text;
                user.Password   = txtContrasena.Text;

                var apiclient = new UserApi("http://worktracker-001-site1.atempurl.com/");
                if (edicion)
                {
                    user.IdUser = Int32.Parse(txtNumEmpleado.Text);
                    apiclient.ApiUserUpdateUserPost(user);
                }
                else
                {
                    apiclient.ApiUserCreateUserPut(user);
                }
            }
            catch (Exception ex)
            {
                toolStripStatusLabel1.Text = "Error creando el usuario"+ex;
            }
         }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            ActivarCampos(true);
            LimpiarCampos();
            edicion = false;

        }
    }
}
