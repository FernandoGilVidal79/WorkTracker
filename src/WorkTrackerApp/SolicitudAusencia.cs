using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IO.Swagger.Api;
using IO.Swagger.Model;

namespace WorkTrackerAPP
{
    public partial class SolicitudAusencia : Form
    {
        public SolicitudAusencia()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cbxTipoAusencia_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        //no se como crearla conexion a tipoAusencias
       /* private void CargarTipoAusencias()
        {
            var apiclient = new UserApi("http://worktracker-001-site1.atempurl.com/");
            var absenseTypes = apiclient.A

        }*/
    }
}
