using System;
using System.Windows.Forms;

namespace WorkTrackerAPP
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
            tmrHora.Enabled = true;
            pnlFichar.Controls.Clear();
            Fichar Frm = new Fichar();
            Frm.TopLevel = false;
            Frm.FormBorderStyle = FormBorderStyle.None;
            Frm.Dock = DockStyle.Fill;
            pnlFichar.Controls.Add(Frm);
            pnlFichar.Tag = Frm;
            Frm.Show();
            Console.WriteLine(UserSession.user);
            mostrarMensajeBienvenida();
        }
        public void mostrarMensajeBienvenida()
        {
            var hora = DateTime.Now.ToString("HH");
            var mensaje = "";
            if(int.Parse(hora) >= 5 && int.Parse(hora) < 12)
            {
                mensaje = "¡Buenos días " + UserSession.user.UserName + "!";
            }
            if (int.Parse(hora) >= 12 && int.Parse(hora) < 21)
            {
                mensaje = "¡Buenas tardes " + UserSession.user.UserName + "!";
            }
            if (int.Parse(hora) >= 21 && int.Parse(hora) < 5)
            {
                mensaje = "¡Buenas noches " + UserSession.user.UserName + "!";
            }
            lblBienvenida.Text = mensaje;
        }
        private void ficharToolStripMenuItem_Click(object sender, EventArgs e)
        {

            pnlFichar.Controls.Clear();
            Fichar Frm = new Fichar();
            Frm.TopLevel = false;
            Frm.FormBorderStyle = FormBorderStyle.None;
            Frm.Dock = DockStyle.Fill;
            pnlFichar.Controls.Add(Frm);
            pnlFichar.Tag = Frm;
            Frm.Show();

        }

        private void tmrHora_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("HH:mm:ss tt");
            lblFecha.Text = DateTime.Now.ToString("D");
        }

        private void solicitudesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlFichar.Controls.Clear();
            SolicitudAusencia FrmAusencia = new SolicitudAusencia();
            FrmAusencia.TopLevel = false;
            FrmAusencia.FormBorderStyle = FormBorderStyle.None;
            FrmAusencia.Dock = DockStyle.Fill;
            pnlFichar.Controls.Add(FrmAusencia);
            pnlFichar.Tag = FrmAusencia;
            FrmAusencia.Show();
        }

        private void lblFecha_Click(object sender, EventArgs e)
        {

        }
    }
}
