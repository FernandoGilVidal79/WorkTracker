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

        private static List<AbsenceType> AbsencesType;
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
            var AbsencesTypes = apiUsers.ApiUserGetUsersGet();
            cmbUsuarios.DisplayMember = "Name";
            cmbUsuarios.ValueMember = "IdUser";
            cmbUsuarios.DataSource = AbsencesTypes;
        }

        private void CargarTiposAusencias()
        {
            var apiAbsences = new AbsencesApi(UserSession.APIUrl);
            AbsencesType = apiAbsences.ApiAbsencesGetAbsencesTypesGet();
        }

        private void AprobacionSolicitudes_Load(object sender, EventArgs e)
        {
            CargarComboUsuarios();
            CargarTiposAusencias();
        }

        private void cmbUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            var Combo = (ComboBox)sender;
            if (Combo.SelectedIndex > -1)
            {
                var apiAbsences = new AbsencesApi(UserSession.APIUrl);
                var Absences = apiAbsences.ApiAbsencesGetAbsencesByUserIdIdGet((int)Combo.SelectedValue);              
                CargarDatosGrid(Absences);

                var apiUser = new UserApi(UserSession.APIUrl);
                var user = apiUser.ApiUserGetUserByIdIdGet(Combo.SelectedValue.ToString());

                if (user != null)
                {
                    lblUsuario.Text = user.First().Name + " " + user.First().SurName1;
                }
            }
        }

        private void CargarDatosGrid(List<Absences> Absences)
        {
            dataGridView1.Columns.Clear();
          
            var dt = new DataTable();
            dt.Columns.Add(new DataColumn("Id", typeof(string)));
            dt.Columns.Add(new DataColumn("Tipo", typeof(string)));
            dt.Columns.Add(new DataColumn("Fecha Inicio", typeof(string)));
            dt.Columns.Add(new DataColumn("Fecha Fin", typeof(string)));
            dt.Columns.Add(new DataColumn("Aprobar", typeof(bool)));
            dt.Columns.Add(new DataColumn("Denegar", typeof(bool)));
            
            foreach (var absense in Absences)
            {
                DataRow dr = dt.NewRow();

                dr[0] = absense.IdAbsences;
                dr[1] = AbsencesType.First(x => x.IdAbsenceType == absense.AbsencesTypeId).Description;
                dr[2] = absense.StartDate;
                dr[3] = absense.FinishDate;
                dr[4] = absense.Aproved;
                dr[5] = absense.Denied;
                dt.Rows.Add(dr);
            }
            
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].Visible = false;

        }


        private void btnAprobar_Click(object sender, EventArgs e)
        {
            int index = 0;
            int increment = 100 / dataGridView1.Rows.Count;

            foreach (DataGridViewRow data in dataGridView1.Rows)
            {
                _form.EnviarValue(index);
                var cellAprobacion = data.Cells[4];
                var cellDenegacion = data.Cells[5];
                if (cellAprobacion.Value == null)
                    break;

                if ((bool)cellAprobacion?.Value == true && (bool)cellDenegacion?.Value == true)
                {
                    _form.EnviarEstado("No se puede dar de alta la validación");
                    Helper.MensajeError("No se puede seleccionar Validación y Denegación", "Error");
                    break;
                }
                else
                {
                    if (cellAprobacion.Value != null && (bool)cellAprobacion.Value == true)
                    {
                        int id = int.Parse((string)data.Cells[0].Value);
                        var apiAbsences = new AbsencesApi(UserSession.APIUrl);
                        var Absences = apiAbsences.ApiAbsencesValidateAbsencesByIdIdGet(id);
                    }

                    if (cellDenegacion.Value != null && (bool)cellDenegacion.Value == true)
                    {
                        int id = int.Parse((string)data.Cells[0].Value);
                        var apiAbsences = new AbsencesApi(UserSession.APIUrl);
                        var Absences = apiAbsences.ApiAbsencesDenegateAbsencesByIdIdGet(id);
                    }
                }
                index = index + increment;

            }
            _form.EnviarValue(0);
        }

        private void btnGrabar3_Click(object sender, EventArgs e)
        {
            
        }
    }
}