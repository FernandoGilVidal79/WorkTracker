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
      //private List<Ausencia> ausencia = new List<Ausencia>();
        private int nVacaciones = 0;
        private int diasRestantes = 0;

        
        public Situacion()
        {
            InitializeComponent();
        }

        
        

        private void Situacion_Load(object sender, EventArgs e)
        {
            ausencias = new ArrayList();
            LeerAusencias();
            cargarDiasPendientes();
           
        }

        private void LeerAusencias()
        {
            
            var apiAbsenses = new AbsensesApi("http://worktracker-001-site1.atempurl.com/");
            var absenses = apiAbsenses.ApiAbsensesGetAbsensesByUserIdIdGet(UserSession.User.IdUser);

            //rellenamos array con api ausencias con tipo ausencia, dias totales, dias en status 0, dias en status 1, dias en status 2
            //List<int> idAusencias = new List<int>();
            var absensesAgrupadas = absenses.GroupBy(x=> x.AbsensesTypeId);
            try
            {

            
                foreach (var absenseAgrupada in absensesAgrupadas)
                {
                    Ausencia ausenciaActual = new Ausencia();
                    
                   

                    foreach (var x in absenseAgrupada)
                    {
                        //string prueba = x.FinishDate.ToString();
                        DateTime diaInicio = (DateTime)x.StartDate;
                        DateTime diaFinal = (DateTime)x.FinishDate;
                        int dias = ((diaFinal - diaInicio).Days + 1);

                        
                     //   ausenciaActual.Id = (int)x.AbsensesTypeId;
                       ausenciaActual.DiasTotales += dias;

                        if ((int)x.AbsensesTypeId == 1)
                    {
                        nVacaciones += dias;
                    }

                       
                    }

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
                    Ausencia ausenciaMostrada = (Ausencia)ausencias[posArray];

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

                    //aquí el tipo esta mal,tiene que salir la descripcion.
                    txbTipo.Text = ausenciaMostrada.Id.ToString();
                    txbSolicitados.Text = ausenciaMostrada.DiasTotales.ToString();
                    txbPendientes.Text = ausenciaMostrada.DiasTotales.ToString();
                    txbAprobados.Text = ausenciaMostrada.DiasTotales.ToString();
                    txbRechazados.Text = ausenciaMostrada.DiasTotales.ToString();

                    Controls.Add(txbTipo);
                    Controls.Add(txbSolicitados);
                    Controls.Add(txbPendientes);
                    Controls.Add(txbAprobados);
                    Controls.Add(txbRechazados);

                    y += 30;
                    posArray += 1;


                }
                
            }
            catch (Exception e)
            {
               MessageBox.Show($"Generic Exception Handler: {e}", e.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
               // MessageBox.Show("indice " + indiceIncidencias);          
            }
        }


        
        private void cargarDiasPendientes()
        {
            /*var apiclient = new UserApi("http://worktracker-001-site1.atempurl.com/");
            var users = apiclient.ApiUserGetUserByIdIdGet(UserSession.User.IdUser.ToString);
            var user = users.FirstOrDefault();
            diasRestantes = ((int)user.NHollidays - nVacaciones);
            */
            diasRestantes = ( nVacaciones);
            txbVacaciones.Text = diasRestantes.ToString();
        }
        


        private void lblVacaciones_Click(object sender, EventArgs e)
        {

        }
    }
}
