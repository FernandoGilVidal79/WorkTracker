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
            TmrHora.Enabled = true;
            Helper.MensajeBienvenida(lblBienvenida);
        }
        private void TmrHora_Tick(object sender, EventArgs e)
        {
            Helper.MostrarHora(lblHora, lblFecha);
        }
        private void MenuPrincipalRRHH_Load(object sender, EventArgs e)
        {

        }

        private void pnlFichar_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
