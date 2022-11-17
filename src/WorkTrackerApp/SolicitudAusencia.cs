using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IO.Swagger.Api;
using IO.Swagger.Model;

namespace WorkTrackerAPP
{
    public partial class SolicitudAusencia : Form
    {
        public SolicitudAusencia()
        {
            InitializeComponent();
           
        }

        private void SolicitudAusencia_Load(object sender, EventArgs e)
        {
            CargarTipoAusencias();
            cmbTipoAusencia.SelectedItem = null;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cbxTipoAusencia_SelectedIndexChanged(object sender, EventArgs e)
        {
         
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            {
                if (tbxDesde.Text.Length == 0)
                {
                    tbxDesde.Text = mCalendar.SelectionStart.ToString();
                }
                else if (tbxHasta.Text.Length != 0)
                {
                    tbxDesde.Text = mCalendar.SelectionStart.ToString();
                    tbxHasta.Clear();
                }
                else
                {
                    tbxHasta.Text = mCalendar.SelectionEnd.ToString();
                }

            }

        }

       
        private void CargarTipoAusencias()
        {
            //cmbTipoAusencia.Items.Insert(0, string.Empty);

            var apiAbsenses = new AbsensesApi("http://worktracker-001-site1.atempurl.com/");
            var absensesTypes = apiAbsenses.ApiAbsensesGetAbsensesTypesGet();
            cmbTipoAusencia.DisplayMember = "Description";
            cmbTipoAusencia.ValueMember = "IdAbsenseType";
            cmbTipoAusencia.DataSource = absensesTypes;

            
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                var absenses = new Absenses();
                
                absenses.StartDate = DateTime.Parse(tbxDesde.Text);
                absenses.FinishDate = DateTime.Parse(tbxHasta.Text);
                absenses.Status = false;
                absenses.UserId = UserSession.User.IdUser;
                absenses.AbsensesTypeId = (int)cmbTipoAusencia.SelectedValue; 

                var apiabsenses = new AbsensesApi("http://worktracker-001-site1.atempurl.com/");
                apiabsenses.ApiAbsensesCreateAbsensePut(absenses);
                toolStripStatusLabel1.Text = "Ausencia grabada";

                cmbTipoAusencia.SelectedItem = null;
                tbxDesde.Text = "";
                tbxHasta.Text = "";
                
            }
            catch (Exception ex)
            {
                toolStripStatusLabel1.Text = "Error al guardar la ausencia" + ex;
            }
        }
    }
}
