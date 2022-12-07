using IO.Swagger.Api;
using IO.Swagger.Model;
using System;
using System.Windows.Forms;

namespace WorkTrackerAPP
{
    public partial class SolicitudAusencia : Form
    {
        ToolTip mouseBotones = new ToolTip();
        public SolicitudAusencia()
        {
            InitializeComponent();
           
        }

        private void SolicitudAusencia_Load(object sender, EventArgs e)
        {
            CargarTipoAusencias();
            cmbTipoAusencia.SelectedItem = null;
            mouseBotones.SetToolTip(btnGrabar2, "Grabar");
            mouseBotones.SetToolTip(btnGrabar3, "Cancelar");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cbxTipoAusencia_SelectedIndexChanged(object sender, EventArgs e)
        {
         
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
          
              

            

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

       

        private void btnGrabar2_Click(object sender, EventArgs e)
        {
            
            
            try
            {
                DateTime desde = DateTime.Parse(mtbxDesde.Text);
                DateTime hasta = DateTime.Parse(mtbxHasta.Text);
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
                        var absences = apiAbsences.ApiAbsencesGetAbsencesByUserIdIdGet(UserSession.User.IdUser);
                        int rango = 0;

                        foreach ( var absence in absences)
                        {
                            if((desde > absence.StartDate) && (desde < absence.FinishDate))
                            {
                                rango++;
                            }
                            if((hasta > absence.StartDate) && (hasta < absence.FinishDate))
                            {
                                rango++;
                            }

                        }

                        if (rango != 0)
                        {
                            MessageBox.Show("¡CUIDADO! Has solicitado vacaciones que coinciden con otra solicitud");
                        }
                        apiAbsences.ApiAbsencesCreateAbsencePut(Absences);
                        MessageBox.Show("Ausencia grabada");
                        toolStripStatusLabel1.Text = "Ausencia grabada";

                        cmbTipoAusencia.SelectedItem = null;
                        mtbxDesde.Text = "";
                        mtbxHasta.Text = "";

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
                    mtbxDesde.Clear();
                    mtbxHasta.Clear();

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
            mtbxDesde.Clear();
            mtbxHasta.Clear();
        }

        private void mCalendar_DateSelected(object sender, DateRangeEventArgs e)
        {
            
           // if (mtbxDesde.Text.Length == 6)
           if (mtbxDesde.MaskCompleted == false)
            {
                mtbxDesde.Text = mCalendar.SelectionStart.ToShortDateString();
            }
           // else if (mtbxHasta.Text.Length != 6)
           else if (mtbxHasta.MaskCompleted)
            {
                mtbxDesde.Text = mCalendar.SelectionStart.ToShortDateString();
                mtbxHasta.Clear();
            }
            else
            {
                mtbxHasta.Text = mCalendar.SelectionEnd.ToShortDateString();
            }
        }
    }
}
