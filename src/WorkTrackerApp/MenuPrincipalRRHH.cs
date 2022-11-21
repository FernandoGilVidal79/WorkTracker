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
    public partial class MenuPrincipalRRHH : Form, IForm
    {
        public MenuPrincipalRRHH()
        {
            InitializeComponent();
            TmrHora.Enabled = true;
            pnlFichar.Controls.Clear();
            Fichar Frm = new Fichar();
            Frm.TopLevel = false;
            Frm.FormBorderStyle = FormBorderStyle.None;
            Frm.Dock = DockStyle.Fill;
            pnlFichar.Controls.Add(Frm);
            pnlFichar.Tag = Frm;
            Frm.Show();
            Console.WriteLine(UserSession.User);
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

        public void MetodoPrueba()
        {
            MessageBox.Show("funciona");
            this.toolMensajes.Text = "Esta funcionando";
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

        private void situaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlFichar.Controls.Clear();
            Situacion FrmSituacion = new Situacion();
            FrmSituacion.TopLevel = false;
            FrmSituacion.FormBorderStyle = FormBorderStyle.None;
            FrmSituacion.Dock = DockStyle.Fill;
            pnlFichar.Controls.Add(FrmSituacion);
            pnlFichar.Tag = FrmSituacion;
            FrmSituacion.Show();
        }

        private void aprobacionestoolStripMenuItem1_Click(object sender, EventArgs e)
        {
            pnlFichar.Controls.Clear();
            AprobacionSolicitudes FrmAprobaciones = new AprobacionSolicitudes(this);
            FrmAprobaciones.TopLevel = false;
            FrmAprobaciones.FormBorderStyle = FormBorderStyle.None;
            FrmAprobaciones.Dock = DockStyle.Fill;
            pnlFichar.Controls.Add(FrmAprobaciones);
            pnlFichar.Tag = FrmAprobaciones;
            FrmAprobaciones.Show();
        }

        private void toolStripCreacionUsuario_Click(object sender, EventArgs e)
        {

            pnlFichar.Controls.Clear(); 
            CreacionUsuarios FrmCreacion = new CreacionUsuarios();
            FrmCreacion.TopLevel = false;
            FrmCreacion.FormBorderStyle = FormBorderStyle.None;
            FrmCreacion.Dock = DockStyle.Fill;
            pnlFichar.Controls.Add(FrmCreacion);
            pnlFichar.Tag = FrmCreacion;
            FrmCreacion.Show();
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

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("¿Está seguro que desea salir?", "", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                this.Close();
                this.Dispose();

            }
        }
    }
}
