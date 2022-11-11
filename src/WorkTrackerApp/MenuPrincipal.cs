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
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
            timer1.Enabled = true;
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void ficharToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Frm = new Form();
            Frm.TopLevel = false;
            pnlFichar.Controls.Add(Frm);
            Frm.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("hh:mm:ss tt");
            lblFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }
    }
}
