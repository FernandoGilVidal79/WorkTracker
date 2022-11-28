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
        private List<AbsenseType> tiposAusencias;
        private int nVacaciones = 0;
        private int diasRestantes = 0;
        
        public Situacion()
        {
            InitializeComponent();
        }      

        private void Situacion_Load(object sender, EventArgs e)
        {
            ausencias = new List<Ausencia>();
            LeerTiposAusencias();
            CargarAnio();
          
           
        }

        private void LeerTiposAusencias()
        {
            var apiAbsenses = new AbsensesApi("http://worktracker-001-site1.atempurl.com/");
            tiposAusencias = apiAbsenses.ApiAbsensesGetAbsensesTypesGet();
        }

        private void LeerAusencias()
        {
            try
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

                var apiAbsenses = new AbsensesApi("http://worktracker-001-site1.atempurl.com/");
                var absenses = apiAbsenses.ApiAbsensesGetAbsensesByUserIdIdGet(UserSession.User.IdUser);
                // var absensesAgrupadasYear = absenses.Where(x => x.StartDate > fechaInicio && x.StartDate < fechaFin);

                
              //  var absensesAgrupadas = absenses.Where(x => x.StartDate > fechaInicio && x.StartDate < fechaFin).GroupBy(x => x.AbsensesTypeId);

                try
                    {
                        
                        //int diasAprobados = 0;
                        //int diasPendientes = 0;
                       // int diasTotales = 0;
                       // int diasRechazados = 0;
                        var ausenciasAgrupadasByType = absenses.Where(x => x.StartDate >= fechaInicio && x.StartDate <= fechaFin).GroupBy(x => x.AbsensesTypeId);

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
                                        diasRechazados += (((int)(ausencia.FinishDate.Value - ausencia.StartDate.Value).TotalDays) + 1);

                                    }
                                    else
                                    {
                                        diasAprobados += (((int)(ausencia.FinishDate.Value - ausencia.StartDate.Value).TotalDays) + 1);

                                        if (ausencia.AbsensesTypeId == 1)
                                        {
                                            nVacaciones += (((int)(ausencia.FinishDate.Value - ausencia.StartDate.Value).TotalDays) + 1);
                                        }

                                    }
                                }
                                else
                                {
                                    diasPendientes += (((int)(ausencia.FinishDate.Value - ausencia.StartDate.Value).TotalDays) + 1);
                                }
                            }
                            diasTotales = diasAprobados + diasPendientes + diasRechazados;
                            Ausencia ausenciaTipoPintar = new Ausencia
                            {
                                Id = ausenciaAgrupada.First().AbsensesTypeId.Value,
                                DiasPendientes = diasPendientes,
                                DiasRechazados = diasRechazados,
                                DiasTotales = diasTotales,
                                DiasAprobados = diasAprobados
                            };
                            ausencias.Add(ausenciaTipoPintar);
                        }


                        int ax, bx, cx, dx, ex, y;
                        ax = 51; y = 200;
                        bx = 289;
                        cx = 407;
                        dx = 522;
                        ex = 641;
                        int posArray = 0;

                    foreach (var ausencia in ausencias)
                        {
                            {
                                TextBox txtTipo = new TextBox();
                                TextBox txtSolicitados = new TextBox();
                                TextBox txtPendientes = new TextBox();
                                TextBox txtAprobados = new TextBox();
                                TextBox txtRechazados = new TextBox();

                                txtTipo.ReadOnly = true;
                                txtSolicitados.ReadOnly = true;
                                txtPendientes.ReadOnly = true;
                                txtAprobados.ReadOnly = true;
                                txtRechazados.ReadOnly = true;

                                txtTipo.BackColor = Color.White;
                                txtSolicitados.BackColor = Color.White;
                                txtPendientes.BackColor = Color.White;
                                txtAprobados.BackColor = Color.White;
                                txtRechazados.BackColor = Color.White;


                                txtTipo.Size = new System.Drawing.Size(226, 22);
                                txtSolicitados.Size = new System.Drawing.Size(111, 22);
                                txtPendientes.Size = new System.Drawing.Size(111, 22);
                                txtAprobados.Size = new System.Drawing.Size(111, 22);
                                txtRechazados.Size = new System.Drawing.Size(111, 22);

                                txtTipo.Location = new System.Drawing.Point(ax, y);
                                txtSolicitados.Location = new System.Drawing.Point(bx, y);
                                txtPendientes.Location = new System.Drawing.Point(cx, y);
                                txtAprobados.Location = new System.Drawing.Point(dx, y);
                                txtRechazados.Location = new System.Drawing.Point(ex, y);

                                //txtTipo.TextChanged += new System.EventHandler(this.MostrarAusencias);
                                txtTipo.Text = tiposAusencias.First(x => x.IdAbsenseType == ausencia.Id).Description;
                                txtAprobados.Text = ausencia.DiasAprobados.ToString();
                                txtRechazados.Text = ausencia.DiasRechazados.ToString();
                                txtPendientes.Text = ausencia.DiasPendientes.ToString();
                                txtSolicitados.Text = ausencia.DiasTotales.ToString();
                                Controls.Add(txtTipo);
                                Controls.Add(txtSolicitados);
                                Controls.Add(txtPendientes);
                                Controls.Add(txtAprobados);
                                Controls.Add(txtRechazados);
                                y += 30;
                                posArray += 1;



                            }
                        }
                    }

                    catch (Exception e)
                    {
                        MessageBox.Show($"Generic Exception Handler: {e}", e.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        // MessageBox.Show("indice " + indiceIncidencias);          
                    }
                
            }
            catch (Exception exc)
            { 
                MessageBox.Show("Selecciona un año");
            }
        }
        
        /*Metodo para eliminar los textBox
         
        private void eliminarTxt()
        {
            foreach (TextBox t in txtTipo)
            {
                this.Controls.Remove(t);
                t.Dispose();
            }
        }
        */

        private void cargarDiasPendientes()
        {
            var apiclient = new UserApi("http://worktracker-001-site1.atempurl.com/");
            var users = apiclient.ApiUserGetUserByIdIdGet(UserSession.User.IdUser.ToString());
            var user = users.FirstOrDefault();
            diasRestantes = ((int)user.NHollidays - nVacaciones);
            txbVacaciones.Text = diasRestantes.ToString();
            nVacaciones = 0;

        }

        private void lblVacaciones_Click(object sender, EventArgs e)
        {

        }

        private void btnAplicar_Click(object sender, EventArgs e)
        {
            LeerAusencias();
            txbVacaciones.Clear();
            cargarDiasPendientes();
        }

        private void CargarAnio()
        {
            var apiAbsenses = new AbsensesApi("http://worktracker-001-site1.atempurl.com/");
            var absenses = apiAbsenses.ApiAbsensesGetAbsensesByUserIdIdGet(UserSession.User.IdUser);
            var absensesAgrupadasAnio = absenses.GroupBy(x => x.StartDate);
            try
            {
                DateTime anio;
                String year;
                List<String> years = new List<string>();
                var absensesAgrupadasAnioPorFecha = absenses.GroupBy(x => x.StartDate);
                foreach (var ausenciaAnio in absensesAgrupadasAnioPorFecha)
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

    }
}
