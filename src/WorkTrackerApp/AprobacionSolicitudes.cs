using IO.Swagger.Api;
using System;
using System.Windows.Forms;

namespace WorkTrackerAPP
{
    public partial class AprobacionSolicitudes : Form
    {
        public AprobacionSolicitudes()
        {
            InitializeComponent();
        }

        private void AprobacionSolicitudes_Combo_Load(object sender, EventArgs e)
        {

        }

        private void CargarComboUsuarios()
        {
            var apiUsers = new UserApi("http://worktracker-001-site1.atempurl.com/");
            var absensesTypes = apiUsers.ApiUserGetUsersGet();
            cmbUsuarios.DisplayMember = "UserName";
            cmbUsuarios.ValueMember = "IdUser";
            cmbUsuarios.DataSource = absensesTypes;
        }

        private void AprobacionSolicitudes_Load(object sender, EventArgs e)
        {
            //CargarComboUsuarios();
        }

        private void cmbUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            var Combo = (ComboBox)sender;
            if (Combo.SelectedIndex > -1)
            {
                var apiAbsenses = new AbsensesApi("http://worktracker-001-site1.atempurl.com/");
                var absensesTypes = apiAbsenses.ApiAbsensesIdGet(6);
            }
         
        }
    }
}
