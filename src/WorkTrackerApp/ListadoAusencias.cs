using IO.Swagger.Api;
using IO.Swagger.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkTrackerAPP
{
    public partial class ListadoAusencias : Form
    {
        private List<Ausencia> ausencias;
        private List<AbsenceType> tiposAusencias;
       
        public ListadoAusencias()
        {
            InitializeComponent();
        }

        private void ListadoAusencias_Load(object sender, EventArgs e)

        {
            ausencias = new List<Ausencia>();
            LeerTiposAusencias();
            LeerAusencias();
            

        }

        private void LeerTiposAusencias()
        {
            var apiAbsences = new AbsencesApi(UserSession.APIUrl);
            tiposAusencias = apiAbsences.ApiAbsencesGetAbsencesTypesGet();
        }

        private void LeerAusencias()
        {

            string year = DateTime.Today.Year.ToString();
            string fechaInicioTexto = "01/01/" + year;
            String fechaFinTexto = "31/12/" + year;
            string format = "dd/MM/yyyy";
            DateTime fechaInicio = DateTime.ParseExact(fechaInicioTexto, format, CultureInfo.InvariantCulture);
            DateTime fechaFin = DateTime.ParseExact(fechaFinTexto, format, CultureInfo.InvariantCulture);

            var apiAbsences = new AbsencesApi(UserSession.APIUrl);
            var Absences = apiAbsences.ApiAbsencesGetAbsencesByUserIdIdGet(UserSession.User.IdUser);

            int y;
            y = 25;
                       
            try
            {
                var ausenciasAgrupadasByType = Absences.Where(x => x.StartDate >= fechaInicio && x.StartDate <= fechaFin);

                foreach (var ausencia in ausenciasAgrupadasByType)
                {
                    TextBox txbTipo = new TextBox();
                    TextBox txbDesde = new TextBox();
                    TextBox txbHasta = new TextBox();

                    txbTipo.ReadOnly = true;
                    txbDesde.ReadOnly = true;
                    txbHasta.ReadOnly = true;

                    txbTipo.BackColor = Color.White;
                    txbDesde.BackColor = Color.White;
                    txbHasta.BackColor = Color.White;

                    txbTipo.Size = new System.Drawing.Size(125, 15);
                   // txbDesde.Size = new System.Drawing.Size(80, 15);
                   // txbHasta.Size = new System.Drawing.Size(80, 15);

                    //txbTipo.Font = new System.Drawing.Font(Tempus Sans ITC; 10,2pt)
                    
                    txbTipo.Location = new System.Drawing.Point(0, y);
                    txbDesde.Location = new System.Drawing.Point(135, y);
                    txbHasta.Location = new System.Drawing.Point(240, y);

                    txbTipo.AutoSize = true;
                    txbDesde.AutoSize = true;
                    txbHasta.AutoSize = true;


                    //txtTipo.TextChanged += new System.EventHandler(this.MostrarAusencias);
                    txbTipo.Text = tiposAusencias.First(x => x.IdAbsenceType == ausencia.AbsencesTypeId).Description;
                    txbDesde.Text = ((DateTime)ausencia.StartDate).ToShortDateString();
                    txbHasta.Text = ((DateTime)ausencia.FinishDate).ToShortDateString();

                    Controls.Add(txbTipo);
                    Controls.Add(txbDesde);
                    Controls.Add(txbHasta);
                    y += 35;
                    
                }
            }

            catch (Exception e)
            {
                MessageBox.Show($"Generic Exception Handler: {e}", e.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                // MessageBox.Show("indice " + indiceIncidencias);          
            }


        }


        private void diseñotxt(TextBox name, int size)
        {
            name.ReadOnly = true;
            name.BackColor = Color.White;
            name.Size = new System.Drawing.Size(size, 10);
        }

    }
}