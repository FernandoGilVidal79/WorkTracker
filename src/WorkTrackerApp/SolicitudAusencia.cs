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

            var apiAbsences = new AbsencesApi(UserSession.APIUrl);
            var AbsencesTypes = apiAbsences.ApiAbsencesGetAbsencesTypesGet();
            cmbTipoAusencia.DisplayMember = "Description";
            cmbTipoAusencia.ValueMember = "IdAbsenceType";
            cmbTipoAusencia.DataSource = AbsencesTypes;

            
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime desde= DateTime.Parse(tbxDesde.Text);
                DateTime hasta= DateTime.Parse(tbxHasta.Text);
                var Absences = new Absences();

                Absences.StartDate = desde;
                Absences.FinishDate = hasta;
                Absences.Aproved = false;
                Absences.Denied = false;
                Absences.UserId = UserSession.User.IdUser;
                if (cmbTipoAusencia.SelectedValue != null)
                {
                    Absences.AbsencesTypeId = (int)cmbTipoAusencia.SelectedValue;
                    if (desde > hasta)
                    {
                        MessageBox.Show("Fecha Inicio anterior a Fecha Fin, vuelva a intentarlo");
                    }
                    else
                    {
                        var apiAbsences = new AbsencesApi(UserSession.APIUrl);
                        apiAbsences.ApiAbsencesCreateAbsencePut(Absences);
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

        
            private void btnCancelar1_Click(object sender, EventArgs e)
        {
           
        }

        private void btnGrabar2_Click(object sender, EventArgs e)
        {
            
            
            try
            {
                DateTime desde = DateTime.Parse(tbxDesde.Text);
                DateTime hasta = DateTime.Parse(tbxHasta.Text);
                var Absences = new Absences();

                Absences.StartDate = desde;
                Absences.FinishDate = hasta;
                Absences.Aproved = false;
                Absences.Denied = false;
                Absences.UserId = UserSession.User.IdUser;
                if (cmbTipoAusencia.SelectedValue != null)
                {
                    
                    Absences.AbsencesTypeId = (int)cmbTipoAusencia.SelectedValue;
                    if (desde > hasta)
                    {
                        MessageBox.Show("Fecha Inicio anterior a Fecha Fin, vuelva a intentarlo");
                    }
                    else
                    {
                        var apiAbsences = new AbsencesApi(UserSession.APIUrl);
                        apiAbsences.ApiAbsencesCreateAbsencePut(Absences);
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

        private void btnGrabar3_Click(object sender, EventArgs e)
        {
            cmbTipoAusencia.SelectedIndex = -1;
            tbxDesde.Clear();
            tbxHasta.Clear();
        }
    }
}
