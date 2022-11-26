using IO.Swagger.Api;
using System;
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
    public partial class ListadoAusencias : Form
    {
        public ListadoAusencias()
        {
            InitializeComponent();
        }

        private void ListadoAusencias_Load(object sender, EventArgs e)
        {

            LeerAusencias();
        }

        private void LeerAusencias()
        {

            var apiAbsenses = new AbsensesApi("http://worktracker-001-site1.atempurl.com/");
            var absenses = apiAbsenses.ApiAbsensesGetAbsensesByUserIdIdGet(UserSession.User.IdUser);

            try
            {

                int ax, bx, cx, dx, ex, y;
                ax = 51; y = 200;
                bx = 289;
                cx = 407;
                dx = 522;
                ex = 641;
                int posArray = 0;

                foreach (var absense in absenses)
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

                    txbTipo.Size = new System.Drawing.Size(226, 22);
                    txbDesde.Size = new System.Drawing.Size(111, 22);
                    txbHasta.Size = new System.Drawing.Size(111, 22);


                    txbTipo.Location = new System.Drawing.Point(ax, y);
                    txbDesde.Location = new System.Drawing.Point(bx, y);
                    txbHasta.Location = new System.Drawing.Point(cx, y);

                    //aquí el tipo esta mal,tiene que salir la descripcion.
                    txbTipo.Text = absense.IdAbsenses.ToString();
                    txbDesde.Text = absense.StartDate.ToString();
                    txbHasta.Text = absense.FinishDate.ToString();

                    Controls.Add(txbTipo);
                    Controls.Add(txbDesde);
                    Controls.Add(txbHasta);

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
    }
}
