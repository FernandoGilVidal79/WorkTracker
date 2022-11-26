using IO.Swagger.Api;
using IO.Swagger.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace WorkTrackerAPP
{
    public partial class Situacion : Form
    {
        private List<Ausencia> ausencias;
        private List<AbsenseType> tiposAusencias;
        private int nVacaciones = 0;
        public Situacion()
        {
            InitializeComponent();
        }      

        private void Situacion_Load(object sender, EventArgs e)
        {
            ausencias = new List<Ausencia>();
            LeerTiposAusencias();
            LeerAusencias();
         
        }

        private void LeerTiposAusencias()
        {
            var apiAbsenses = new AbsensesApi("http://worktracker-001-site1.atempurl.com/");
            tiposAusencias = apiAbsenses.ApiAbsensesGetAbsensesTypesGet();
        }

        private void LeerAusencias()
        {
            var apiAbsenses = new AbsensesApi("http://worktracker-001-site1.atempurl.com/");
            var absenses = apiAbsenses.ApiAbsensesGetAbsensesByUserIdIdGet(UserSession.User.IdUser);

            try
            {
                int diasAprobados  = 0;
                int diasPendientes = 0;
                int diasTotales    = 0;
                var ausenciasAgrupadasByType =  absenses.GroupBy(x => x.AbsensesTypeId);

                foreach (var ausenciaAgrupada in ausenciasAgrupadasByType)
                {
                    diasAprobados  = 0;
                    diasPendientes = 0;
                    diasTotales    = 0;

                    foreach (var ausencia in ausenciaAgrupada)
                    {
                        if (ausencia.Status == true)
                        {
                            diasAprobados += ((int)(ausencia.FinishDate.Value - ausencia.StartDate.Value).TotalDays);
                        }
                        else
                        {
                            diasPendientes += ((int)(ausencia.FinishDate.Value - ausencia.StartDate.Value).TotalDays);
                        }                                                     
                    }
                    diasTotales = diasAprobados + diasPendientes;
                    Ausencia ausenciaTipoPintar = new Ausencia
                    {
                        Id = ausenciaAgrupada.First().AbsensesTypeId.Value,
                        DiasPendientes = diasPendientes,
                        //a.DiasRechazados = diasRechazados;
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

                foreach (var ausencia in ausencias)
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

                    txtTipo.TextChanged += new System.EventHandler(this.MostrarAusencias);
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
                    


                }

            }
            catch (Exception e)
            {
                MessageBox.Show($"Generic Exception Handler: {e}", e.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void MostrarAusencias(object sender, EventArgs e)
        {

                        //recorremos la colección para mostrar las incidencias de la clasificación elegida en el listbox
            foreach (var ausencia in ausencias)

            {
              
            }



        }
        private void lblVacaciones_Click(object sender, EventArgs e)
        {

        }
    }
}
