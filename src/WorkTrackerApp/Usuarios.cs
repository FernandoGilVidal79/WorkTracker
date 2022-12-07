using IO.Swagger.Api;
using IO.Swagger.Model;
using System;
using System.Linq;
using System.Windows.Forms;

namespace WorkTrackerAPP
{
    public partial class Usuarios : Form
    {

        private bool edicion = false;
        private readonly IForm _form;

        public Usuarios (IForm form)
        {
            _form = form;
            InitializeComponent();
        }

        private void CreacionUsuarios_Load(object sender, EventArgs e)
        {
            ActivarCampos(false);
            CargarTipoUsuarios();
            ActivarBotones(true);
        }

        private void ActivarCampos(bool status)
        {
            txtNumEmpleado.Enabled      = !status;
            txtNombre.Enabled           = status;
            txtApellido1.Enabled        = status;
            txtApellido2.Enabled        = status;           
            txtDepartamento.Enabled     = status;
            txtEmail.Enabled            = status;
            txtTelefono.Enabled         = status;
            txtNumVacaciones.Enabled    = status;
            cmbStatus.Enabled           = status;
            cmbTipoUsuario.Enabled      = status;
        }

        private void ActivarBotones(bool status)
        {
            btnCancelar.Enabled = !status;
            btnGuardar.Enabled = !status;
            btnBuscar.Enabled = status;      
            btnNuevo.Enabled = status;
        }
        
        private void LimpiarCampos()
        {
            txtApellido1.Text       = "";
            txtApellido2.Text       = "";      
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
            var apiclient = new UserApi(UserSession.APIUrl);
            var userTypes = apiclient.ApiUserGetUserTypesGet();       
            cmbTipoUsuario.DisplayMember = "Description";
            cmbTipoUsuario.ValueMember = "IdUserType";
            cmbTipoUsuario.DataSource = userTypes;
        }
   
        private void SetStatusCombo(bool value)
        {
            if (value == true)
            {
                cmbStatus.SelectedItem = "Y";
            }
            else
            {
                cmbStatus.SelectedItem = "N";
            }
        }

        private bool ComboStatusValor()
        {
            if ((string)cmbStatus.SelectedItem == "Y")
            {
                return true;
            }

            else if((string)cmbStatus.SelectedItem == "N")
            {
                return false;
            }

            return false;
            //throw new Exception("No se ha seleccionado un valor");
        }
      
       
   

        private void ValidationNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            else if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                Buscar();
            }
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            ActivarCampos(false);
            ActivarBotones(true);
            edicion = false;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            ActivarCampos(true);
            ActivarBotones(false);
            LimpiarCampos();
            edicion = false;
        }

        private void Buscar()
        {
            var apiclient = new UserApi(UserSession.APIUrl);

            if (txtNumEmpleado.Text != string.Empty)
            {
                var users = apiclient.ApiUserGetUserByIdIdGet(txtNumEmpleado.Text);
                var user = users.FirstOrDefault();
                if (user != null)
                {
                    this.txtNumEmpleado.Text = user.IdUser.ToString();
                    cmbTipoUsuario.SelectedValue = (int)user.UserTypeId;
                    this.txtNombre.Text = user.Name;
                    this.txtEmail.Text = user.Email;
                    this.txtApellido1.Text = user.SurName1;
                    this.txtApellido2.Text = user.SurName2;
                    this.txtTelefono.Text = user.Phone.ToString();
                    this.txtNumVacaciones.Text = user.NHollidays.ToString();
                    this.txtDepartamento.Text = user.Phone.ToString();
                    SetStatusCombo((bool)user.Status);
                    _form.EnviarEstado("Mostrando Usuario  id: " + user.IdUser.ToString());
                    edicion = true;
                    ActivarCampos(true);
                    ActivarBotones(false);
                }
                else
                {
                    _form.EnviarEstado("Usuario no encontrado");
                }
            }
            else
            {
                _form.EnviarEstado("Falta el Id Usuario");
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Buscar();
        }

        private void ValidateEnterPress(object sender, KeyPressEventArgs e)
        {

           
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            ComboStatusValor();
            try
            {
                var user = new Users
                {
                    Department = txtDepartamento.Text,
                    UserTypeId = (int?)cmbTipoUsuario.SelectedValue,
                    Name = txtNombre.Text,
                    SurName1 = txtApellido1.Text,
                    SurName2 = txtApellido2.Text,
                    Status = ComboStatusValor(),
                    Phone = Int32.Parse(txtTelefono.Text),
                    NHollidays = Int32.Parse(txtNumVacaciones.Text),
                    Email = txtEmail.Text,
                    Password = txtNombre.Text
                };

                var apiclient = new UserApi(UserSession.APIUrl);
                if (edicion)
                {
                    user.IdUser = Int32.Parse(txtNumEmpleado.Text);
                    apiclient.ApiUserUpdateUserPost(user);
                    Helper.MensajeOk("Usuario modificado correctamente", "Modificacion de Usuario");
                }
                else
                {
                    apiclient.ApiUserCreateUserPut(user);
                    LimpiarCampos();
                    Helper.MensajeOk("Usuario Creado correctamente", "Creación de Usuario");


                }

                _form.EnviarEstado("Guardado correctamente");
                ActivarCampos(false);
                ActivarBotones(true);
            }
            catch (Exception ex)
            {
                _form.EnviarEstado("Error al guardar el usuario");
            }
        
    }
    }
}