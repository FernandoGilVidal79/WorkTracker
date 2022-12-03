using IO.Swagger.Api;
using IO.Swagger.Model;
using System;
using System.Windows.Forms;

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
                    tbxDesde.Text = mCalendar.SelectionStart.ToShortDateString();
                }
                else if (tbxHasta.Text.Length != 0)
                {
                    tbxDesde.Text = mCalendar.SelectionStart.ToShortDateString();
                    tbxHasta.Clear();
                }
                else
                {
                    tbxHasta.Text = mCalendar.SelectionEnd.ToShortDateString();
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
                DateTime desde= DateTime.Parse(tbxDesde.Text);
                DateTime hasta= DateTime.Parse(tbxHasta.Text);
                var absenses = new Absenses();

                absenses.StartDate = desde;
                absenses.FinishDate = hasta;
                absenses.Aproved = false;
                absenses.Denied = false;
                absenses.UserId = UserSession.User.IdUser;
                if (cmbTipoAusencia.SelectedValue != null)
                {
                    absenses.AbsensesTypeId = (int)cmbTipoAusencia.SelectedValue;
                    if (desde > hasta)
                    {
                        MessageBox.Show("Fecha Inicio anterior a Fecha Fin, vuelva a intentarlo");
                    }
                    else
                    {
                        var apiabsenses = new AbsensesApi("http://worktracker-001-site1.atempurl.com/");
                        apiabsenses.ApiAbsensesCreateAbsensePut(absenses);
                        MessageBox.Show("Ausencia grabada");
                        toolStripStatusLabel1.Text = "Ausencia grabada";

                        cmbTipoAusencia.SelectedItem = null;
                        tbxDesde.Text = "";
                        tbxHasta.Text = "";

                        pnlListadoAusencias.Controls.Clear();
                        ListadoAusencias FrmListaAusencia = new ListadoAusencias();
                        FrmListaAusencia.TopLevel = false;
                        FrmListaAusencia.FormBorderStyle = FormBorderStyle.None;
                        FrmListaAusencia.Dock = DockStyle.Fill;
                        pnlListadoAusencias.Controls.Add(FrmListaAusencia);
                        pnlListadoAusencias.Tag = FrmListaAusencia;
                        FrmListaAusencia.Show();

                    }
                }
                else            
               
                {
                    MessageBox.Show("Introduzca el tipo de ausencia");
                    tbxDesde.Clear();
                    tbxHasta.Clear();
                    
                }

                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar, revise los datos");
                toolStripStatusLabel1.Text = "Error al guardar la ausencia";
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            ListadoAusencias FrmListaAusencia = new ListadoAusencias();
            FrmListaAusencia.TopLevel = false;
            FrmListaAusencia.FormBorderStyle = FormBorderStyle.None;
            FrmListaAusencia.Dock = DockStyle.Fill;
            pnlListadoAusencias.Controls.Add(FrmListaAusencia);
            pnlListadoAusencias.Tag = FrmListaAusencia;
            FrmListaAusencia.Show();
        }
    }
}
