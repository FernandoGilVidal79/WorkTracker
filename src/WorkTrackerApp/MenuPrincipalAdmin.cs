using System;
using System.Windows.Forms;

namespace WorkTrackerAPP
{
    public partial class MenuPrincipalAdmin : Form
    {
        public MenuPrincipalAdmin()
        {
            InitializeComponent();
            TmrHora.Enabled = true;
            Helper.MensajeBienvenida(lblBienvenida);
        }
        private void TmrHora_Tick(object sender, EventArgs e)
        {
            Helper.MostrarHora(lblHora, lblFecha);
        }
        private void MenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void ficharToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void MenuPrincipalAdmin_Load(object sender, EventArgs e)
        {
            TmrHora.Enabled = true;
            pnlInformes.Controls.Clear();
            Logs Frm = new Logs();
            Frm.TopLevel = false;
            Frm.FormBorderStyle = FormBorderStyle.None;
            ///Frm.Dock = DockStyle.Fill;
            pnlInformes.Controls.Add(Frm);
            pnlInformes.Tag = Frm;
            Frm.Show();
            Helper.MensajeBienvenida(lblBienvenida);
        }

        private void pnlInformes_Paint(object sender, PaintEventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("¿Está seguro que desea salir?", "", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                this.Close();
                this.Dispose();

            }
        }

        private void calendarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TmrHora.Enabled = true;
            pnlInformes.Controls.Clear();
            Logs Frm = new Logs();
            Frm.TopLevel = false;
            Frm.FormBorderStyle = FormBorderStyle.None;
            ///Frm.Dock = DockStyle.Fill;
            pnlInformes.Controls.Add(Frm);
            pnlInformes.Tag = Frm;
            Frm.Show();
            Helper.MensajeBienvenida(lblBienvenida);
        }
    }
}
