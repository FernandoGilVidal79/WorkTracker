using IO.Swagger.Api;
using IO.Swagger.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Globalization;


namespace WorkTrackerAPP
{
    public partial class Situacion : Form
    {
        private List<Ausencia> ausencias;
        private List<DateTime> festivos;
        private int nVacaciones = 0;
        private int diasRestantes = 0;
        private int borrado = 0;

        public Situacion()
        {
            InitializeComponent();
        }

        private void Situacion_Load(object sender, EventArgs e)
        {
            
            CargarAnio();
            
        }

        private void LeerAusencias()
        {
            ausencias = new List<Ausencia>();
            if (borrado == 0)
            {

                if (cmbAño.SelectedIndex >= 0)

                {
                    string fechaInicioTexto = "01/01/" + cmbAño.SelectedItem.ToString();
                    String fechaFinTexto = "31/12/" + cmbAño.SelectedItem.ToString();
                    string format = "dd/MM/yyyy";
                    DateTime fechaInicio = DateTime.ParseExact(fechaInicioTexto, format, CultureInfo.InvariantCulture);
                    DateTime fechaFin = DateTime.ParseExact(fechaFinTexto, format, CultureInfo.InvariantCulture);
                    int diasAprobados = 0;
                    int diasPendientes = 0;
                    int diasTotales = 0;
                    int diasRechazados = 0;
                    nVacaciones = 0;
                    lblAnio.Text = cmbAño.SelectedItem.ToString();
                    borrado++;


                    var apiAbsences = new AbsencesApi("http://worktracker-001-site1.atempurl.com/");
                    var Absences = apiAbsences.ApiAbsencesGetAbsencesByUserIdIdGet(UserSession.User.IdUser);

                    try
                    {

                        var ausenciasAgrupadasByType = Absences.Where(x => x.StartDate >= fechaInicio && x.StartDate <= fechaFin).GroupBy(x => x.AbsencesTypeId);

                        foreach (var ausenciaAgrupada in ausenciasAgrupadasByType)
                        {
                            diasAprobados = 0;
                            diasPendientes = 0;
                            diasTotales = 0;
                            diasRechazados = 0;

                            foreach (var ausencia in ausenciaAgrupada)
                            {
                                if (ausencia.Aproved == true)

                                {
                                    if (ausencia.Denied == true)
                                    {
                                        
                                        //diasRechazados += (((int)(ausencia.FinishDate.Value - ausencia.StartDate.Value).TotalDays) + 1);
                                        diasRechazados += DiasSinFestivos((DateTime)ausencia.StartDate, (DateTime)ausencia.FinishDate, true, festivos);
                                    }
                                    else
                                    {
                                        //diasAprobados += (((int)(ausencia.FinishDate.Value - ausencia.StartDate.Value).TotalDays) + 1);
                                        diasAprobados += DiasSinFestivos((DateTime)ausencia.StartDate, (DateTime)ausencia.FinishDate, true, festivos);
                                        if (ausencia.AbsencesTypeId == 1)
                                        {
                                           // nVacaciones += (((int)(ausencia.FinishDate.Value - ausencia.StartDate.Value).TotalDays) + 1);
                                           nVacaciones += DiasSinFestivos((DateTime)ausencia.StartDate, (DateTime)ausencia.FinishDate, true, festivos);

                                        }

                                    }
                                }
                                else
                                {
                                    //diasPendientes += (((int)(ausencia.FinishDate.Value - ausencia.StartDate.Value).TotalDays) + 1);
                                    diasPendientes += DiasSinFestivos((DateTime)ausencia.StartDate, (DateTime)ausencia.FinishDate, true, festivos);
                                }
                            }
                            diasTotales = diasAprobados + diasPendientes + diasRechazados;
                            Ausencia ausenciaTipoPintar = new Ausencia
                            {
                                Id = ausenciaAgrupada.First().AbsencesTypeId.Value,
                                DiasPendientes = diasPendientes,
                                DiasRechazados = diasRechazados,
                                DiasTotales = diasTotales,
                                DiasAprobados = diasAprobados
                            };
                            ausencias.Add(ausenciaTipoPintar);
                        }

                        foreach (var ausencia in ausencias)

                        {
                            switch (ausencia.Id)
                            {
                                case 1:
                                    // txtTipo1.Text = tiposAusencias.First(x => x.IdAbsenseType == ausencia.Id).Description;
                                    txtAprobados1.Text = ausencia.DiasAprobados.ToString();
                                    txtRechazados1.Text = ausencia.DiasRechazados.ToString();
                                    txtPendientes1.Text = ausencia.DiasPendientes.ToString();
                                    txtSolicitados1.Text = ausencia.DiasTotales.ToString();
                                    break;
                                case 2:
                                    //txtTipo2.Text = tiposAusencias.First(x => x.IdAbsenseType == ausencia.Id).Description;
                                    txtAprobados2.Text = ausencia.DiasAprobados.ToString();
                                    txtRechazados2.Text = ausencia.DiasRechazados.ToString();
                                    txtPendientes2.Text = ausencia.DiasPendientes.ToString();
                                    txtSolicitados2.Text = ausencia.DiasTotales.ToString();
                                    break;
                                case 3:
                                    //txtTipo3.Text = tiposAusencias.First(x => x.IdAbsenseType == ausencia.Id).Description;
                                    txtAprobados3.Text = ausencia.DiasAprobados.ToString();
                                    txtRechazados3.Text = ausencia.DiasRechazados.ToString();
                                    txtPendientes3.Text = ausencia.DiasPendientes.ToString();
                                    txtSolicitados3.Text = ausencia.DiasTotales.ToString();
                                    break;
                                case 4:
                                    //txtTipo4.Text = tiposAusencias.First(x => x.IdAbsenseType == ausencia.Id).Description;
                                    txtAprobados4.Text = ausencia.DiasAprobados.ToString();
                                    txtRechazados4.Text = ausencia.DiasRechazados.ToString();
                                    txtPendientes4.Text = ausencia.DiasPendientes.ToString();
                                    txtSolicitados4.Text = ausencia.DiasTotales.ToString();
                                    break;
                                case 5:
                                    //txtTipo5.Text = tiposAusencias.First(x => x.IdAbsenseType == ausencia.Id).Description;
                                    txtAprobados5.Text = ausencia.DiasAprobados.ToString();
                                    txtRechazados5.Text = ausencia.DiasRechazados.ToString();
                                    txtPendientes5.Text = ausencia.DiasPendientes.ToString();
                                    txtSolicitados5.Text = ausencia.DiasTotales.ToString();
                                    break;
                                case 6:
                                    //txtTipo6.Text = tiposAusencias.First(x => x.IdAbsenseType == ausencia.Id).Description;
                                    txtAprobados6.Text = ausencia.DiasAprobados.ToString();
                                    txtRechazados6.Text = ausencia.DiasRechazados.ToString();
                                    txtPendientes6.Text = ausencia.DiasPendientes.ToString();
                                    txtSolicitados6.Text = ausencia.DiasTotales.ToString();
                                    break;
                                case 7:
                                    //txtTipo7.Text = tiposAusencias.First(x => x.IdAbsenseType == ausencia.Id).Description;
                                    txtAprobados7.Text = ausencia.DiasAprobados.ToString();
                                    txtRechazados7.Text = ausencia.DiasRechazados.ToString();
                                    txtPendientes7.Text = ausencia.DiasPendientes.ToString();
                                    txtSolicitados7.Text = ausencia.DiasTotales.ToString();
                                    break;
                            }

                        }

                    }

                    catch (Exception e)
                    {
                        MessageBox.Show($"Generic Exception Handler: {e}", e.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        // MessageBox.Show("indice " + indiceIncidencias);          
                    }
                }
                else
                {
                    MessageBox.Show("Por favor seleccione año");
                }
            }
            else
            {
                MessageBox.Show("Por favor limpie la pantalla");
            }

        }

        private void EliminarValorTxt(Control control)
        {
            foreach (var txt in control.Controls)
            {
                if (txt is TextBox)
                {
                    
                    ((TextBox)txt).Clear();
                }

            }
            lblAnio.Text = "";
            borrado = 0;
        }
        private void CargarDiasPendientes()
        {
            var apiclient = new UserApi("http://worktracker-001-site1.atempurl.com/");
            var users = apiclient.ApiUserGetUserByIdIdGet(UserSession.User.IdUser.ToString());
            var user = users.FirstOrDefault();
            diasRestantes = ((int)user.NHollidays - nVacaciones);
            txbVacaciones.Text = diasRestantes.ToString();
            nVacaciones = 0;

        }

        private void CargarFestivos()
        {
            DateTime fechaDateTime;
            festivos = new List<DateTime>();
          
            var apicalendar = new CalendarApi("http://worktracker-001-site1.atempurl.com/");
            var calendar = apicalendar.ApiCalendarGetFestiveByYearYearGet(int.Parse(cmbAño.SelectedItem.ToString()));
            foreach (var fecha in calendar)
            {
                fechaDateTime = new DateTime((int)fecha.Year, (int)fecha.Month, (int)fecha.Day);
                festivos.Add(fechaDateTime);
            }
        }

        private void lblVacaciones_Click(object sender, EventArgs e)
        {

        }

        private void btnAplicar_Click(object sender, EventArgs e)
        {
            CargarFestivos();
            LeerAusencias();
            CargarDiasPendientes();
            cmbAño.SelectedIndex = -1;

        }

        private void CargarAnio()
        {
            var apiAbsences = new AbsencesApi("http://worktracker-001-site1.atempurl.com/");
            var Absences = apiAbsences.ApiAbsencesGetAbsencesByUserIdIdGet(UserSession.User.IdUser);
            var AbsencesAgrupadasAnio = Absences.GroupBy(x => x.StartDate);
            try
            {
                DateTime anio;
                String year;
                List<String> years = new List<string>();
                var AbsencesAgrupadasAnioPorFecha = Absences.GroupBy(x => x.StartDate);
                foreach (var ausenciaAnio in AbsencesAgrupadasAnioPorFecha)
                {
                    var anios = ausenciaAnio.Min(x => x.StartDate);
                    anio = Convert.ToDateTime(anios);
                    year = anio.ToString("yyyy");

                    if (!years.Contains(year))
                    {
                        years.Add(year);

                    }

                }
                foreach (var anioMostrado in years)
                {
                    cmbAño.Items.Add(anioMostrado);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("fallo en la carga de los años");
            }

        }


        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            EliminarValorTxt(this);
            
        }

        public int DiasSinFestivos(DateTime startDate, DateTime endDate, Boolean excludeWeekends, List<DateTime> excludeDates)
        {
            int count = 0;
            for (DateTime index = startDate; index <= endDate; index = index.AddDays(1))
            {
                if (excludeWeekends && index.DayOfWeek != DayOfWeek.Sunday && index.DayOfWeek != DayOfWeek.Saturday)
                {
                    bool excluded = false; ;
                    for (int i = 0; i < excludeDates.Count; i++)
                    {
                        if (index.Date.CompareTo(excludeDates[i].Date) == 0)
                        {
                            excluded = true;
                            break;
                        }
                    }

                    if (!excluded)
                    {
                        count++;
                    }
                }
            }

            return count;
        }
    }
}
