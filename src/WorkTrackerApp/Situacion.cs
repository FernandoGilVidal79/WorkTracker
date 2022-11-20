using IO.Swagger.Api;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkTrackerAPP
{
    public partial class Situacion : Form
    {
      private ArrayList ausencias;
      private List<Ausencia> ausencia = new List<Ausencia>();
        private int nVacaciones = 0;
        public Situacion()
        {
            InitializeComponent();
        }

        
        

        private void Situacion_Load(object sender, EventArgs e)
        {
          ausencias = new ArrayList();
            LeerAusencias();
           
        }

        private void LeerAusencias()
        {
            var apiAbsenses = new AbsensesApi("http://worktracker-001-site1.atempurl.com/");
            var absenses = apiAbsenses.ApiAbsensesGetAbsensesByUserIdIdGet(UserSession.User.IdUser);

            //rellenamos array con api ausencias con tipo ausencia, dias totales, dias en status 0, dias en status 1, dias en status 2
            List<int> idAusencias = new List<int>();
            try
            {
                //recorremos la api ausencias
                foreach (var absense in absenses)
                {

                    Ausencia a = new Ausencia();

                    DateTime diaInicio = (DateTime)absense.StartDate;
                    DateTime diaFinal = (DateTime)absense.FinishDate;
                    int dias = (diaInicio - diaFinal).Days;
                    nVacaciones += dias;

                   // if (!idAusencias.Contains((int)absense.AbsensesTypeId))
                    if (!idAusencias.Contains((int)absense.IdAbsenses))
                        {

                        //  a.Id = (int)absense.AbsensesTypeId;
                        a.Id = (int)absense.IdAbsenses;
                        //rellenamos id ausencia para el control
                        idAusencias.Add(a.Id);


                        a.DiasTotales = dias;

                        //rellenamos numero de pendientes
                        if (absense.Status == false)
                        {

                            a.DiasPendientes = dias;
                            a.DiasAprobados = 0;
                            a.DiasRechazados = 0;
                        }
                        //rellenamos numero dias aprobados
                        else if (absense.Status == true)
                        {
                            a.DiasPendientes = 0;
                            a.DiasAprobados = dias;
                            a.DiasRechazados = 0;

                        }
                        //rellenamos numeros rechazados para cuando este preparado
                        else
                        {
                            a.DiasPendientes = 0;
                            a.DiasAprobados = 0;
                            a.DiasRechazados = dias;

                        }

                        ausencias.Add(a);
                    }

                    else
                    {
                       // int indice = ausencias.IndexOf((int)absense.AbsensesTypeId);
                       int indice = ausencias.IndexOf((int)absense.IdAbsenses);
                        a = (Ausencia)ausencias[indice];
                        a.DiasTotales += dias;

                        if (absense.Status == false)
                        {
                            a.DiasPendientes += dias;
                        }
                        else if (absense.Status == true)
                        {
                            a.DiasAprobados += dias;
                        }
                        else
                        {
                            a.DiasRechazados += dias;
                        }
                        //  volvemos a añadir a al sitio donde estaba con los valores modificados
                        ausencias[indice] = a;


                    }

                }
                
                int ax, bx, cx, dx, ex, y;
                ax = 51; y = 200;
                bx = 289;
                cx = 407;
                dx = 522;
                ex = 641;

                foreach (var ausencia in ausencias)
                {
                    TextBox txbTipo = new TextBox();
                    TextBox txbSolicitados = new TextBox();
                    TextBox txbPendientes = new TextBox();
                    TextBox txbAprobados = new TextBox();
                    TextBox txbRechazados = new TextBox();

                    txbTipo.ReadOnly = true;
                    txbSolicitados.ReadOnly = true;
                    txbPendientes.ReadOnly = true;
                    txbAprobados.ReadOnly = true;
                    txbRechazados.ReadOnly = true;

                    txbTipo.BackColor = Color.White;
                    txbSolicitados.BackColor = Color.White;
                    txbPendientes.BackColor = Color.White;
                    txbAprobados.BackColor = Color.White;
                    txbRechazados.BackColor = Color.White;

                    txbTipo.Size = new System.Drawing.Size(226, 22);
                    txbSolicitados.Size = new System.Drawing.Size(111, 22);
                    txbPendientes.Size = new System.Drawing.Size(111, 22);
                    txbAprobados.Size = new System.Drawing.Size(111, 22);
                    txbRechazados.Size = new System.Drawing.Size(111, 22);

                    txbTipo.Location = new System.Drawing.Point(ax, y);
                    txbSolicitados.Location = new System.Drawing.Point(bx, y);
                    txbPendientes.Location = new System.Drawing.Point(cx, y);
                    txbAprobados.Location = new System.Drawing.Point(dx, y);
                    txbRechazados.Location = new System.Drawing.Point(ex, y);

                    txbTipo.TextChanged += new System.EventHandler(this.MostrarAusencias);

                    Controls.Add(txbTipo);
                    Controls.Add(txbSolicitados);
                    Controls.Add(txbPendientes);
                    Controls.Add(txbAprobados);
                    Controls.Add(txbRechazados);

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
