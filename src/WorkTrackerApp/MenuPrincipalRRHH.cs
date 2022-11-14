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
    public partial class MenuPrincipalRRHH : Form
    {
        public MenuPrincipalRRHH()
        {
            InitializeComponent();
            Helper.mensajeBienvenida(lblBienvenida);
        }
        private void TmrHora_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("HH:mm:ss tt");
            lblFecha.Text = DateTime.Now.ToString("D");
        }
        private void MenuPrincipalRRHH_Load(object sender, EventArgs e)
        {

        }
    }
}
