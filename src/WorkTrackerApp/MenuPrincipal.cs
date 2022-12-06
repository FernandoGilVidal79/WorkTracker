﻿using System;
using System.Windows.Forms;

namespace WorkTrackerAPP
{
    public partial class MenuPrincipal : Form, IForm
    {
        public MenuPrincipal()
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
            Helper.MensajeBienvenida(lblBienvenida);
        }
        private void FicharToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void TmrHora_Tick(object sender, EventArgs e)
        {
            Helper.MostrarHora(lblHora, lblFecha);
        }

        private void SolicitudesToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void pnlFichar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("¿Está seguro que desea salir?","", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                this.Close();
                this.Dispose();

            }
            
            
        }

        private void calendarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlFichar.Controls.Clear();
            Calendario FrmCalendario = new Calendario(this);
            FrmCalendario.TopLevel = false;
            FrmCalendario.FormBorderStyle = FormBorderStyle.None;
            FrmCalendario.Dock = DockStyle.Fill;
            pnlFichar.Controls.Add(FrmCalendario);
            pnlFichar.Tag = FrmCalendario;
            FrmCalendario.Show();
        }

        void IForm.EnviarEstado(string estado)
        {
            this.toolStripMenuPrincipalStatus.Text = estado;
        }

        void IForm.EnviarMaxValueProgressBar(int value)
        {
            this.toolStripProgressBar1.Maximum = value;
        }

        int IForm.EnviarValueProgressBar(int value)
        {
            this.toolStripProgressBar1.Value = value;
            System.Threading.Thread.Sleep(1000);
            return this.toolStripProgressBar1.Value;
        }
    }
}
