using IO.Swagger.Api;
using IO.Swagger.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace WorkTrackerAPP
{
    public partial class AprobacionSolicitudes : Form
    {
        public AprobacionSolicitudes()
        {
            InitializeComponent();
        }


        private readonly IForm _form;
        public AprobacionSolicitudes(IForm formPadre)
        {
            InitializeComponent();
            _form = formPadre;
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
            CargarComboUsuarios();
        }

        private void cmbUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            var Combo = (ComboBox)sender;
            if (Combo.SelectedIndex > -1)
            {
                var apiAbsenses = new AbsensesApi("http://worktracker-001-site1.atempurl.com/");
                var absenses = apiAbsenses.ApiAbsensesGetAbsensesByUserIdIdGet((int)Combo.SelectedValue);              
                CargarDatosGrid(absenses);

                var apiUser = new UserApi("http://worktracker-001-site1.atempurl.com/");
                var user = apiUser.ApiUserGetUserByIdIdGet(Combo.SelectedValue.ToString());

                if (user != null)
                {
                    lblUsuario.Text = user.First().UserName + " " + user.First().SurName1;
                }
            }
         
        }

        private void CargarDatosGrid(List<Absenses> absenses)
        {

            dataGridView1.Columns.Clear();
          
            var dt = new DataTable();
            dt.Columns.Add(new DataColumn("Id", typeof(string)));

            dt.Columns.Add(new DataColumn("Fecha Inicio", typeof(string)));
            dt.Columns.Add(new DataColumn("Fecha Fin", typeof(string)));
            dt.Columns.Add(new DataColumn("Aprobar", typeof(bool)));
            dt.Columns.Add(new DataColumn("Denegar", typeof(bool)));
            //dt.Columns.Add(new DataColumn("Uninstall", typeof(System.Windows.Forms.Button)));

            foreach (var absense in absenses)
            {
                DataRow dr = dt.NewRow();
                dr[0] = absense.IdAbsenses;
                dr[1] = absense.StartDate;
                dr[2] = absense.FinishDate;
                dr[3] = absense.Aproved;
                dr[4] = absense.Denied;
                dt.Rows.Add(dr);
            }
            
            dataGridView1.DataSource = dt;
 
       
            
            //int columnIndex = dt.Columns.Count ;
            //if (dataGridView1.Columns["uninstall_column"] == null)
            //{
            //    var i = dataGridView1.Columns["uninstall_column"];
         
            //}

            dataGridView1.Columns[0].Visible = false;

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
   
            foreach ( DataGridViewRow data in dataGridView1.Rows)
            {   
                var cell = data.Cells[3];
                if (cell.Value != null && (bool)cell.Value == true)
                {
                    int id = int.Parse((string)data.Cells[0].Value);
                    var apiAbsenses = new AbsensesApi("http://worktracker-001-site1.atempurl.com/");
                    var absenses = apiAbsenses.ApiAbsensesValidateAbsensesByIdidGet(id);
                }
            }
        }
    }
}
