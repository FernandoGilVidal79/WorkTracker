﻿using System;
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
            ///Frm.Dock = DockStyle.Fill;
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

        private void SituaciónToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void AprobacionestoolStripMenuItem1_Click(object sender, EventArgs e)
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

        private void ToolStripCreacionUsuario_Click(object sender, EventArgs e)
        {

            pnlFichar.Controls.Clear(); 
            CreacionUsuarios FrmCreacion = new CreacionUsuarios(this);
            FrmCreacion.TopLevel = false;
            FrmCreacion.FormBorderStyle = FormBorderStyle.None;
            FrmCreacion.Dock = DockStyle.Fill;
            pnlFichar.Controls.Add(FrmCreacion);
            pnlFichar.Tag = FrmCreacion;
            FrmCreacion.Show();
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

        private void SalirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("¿Está seguro que desea salir?", "", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                this.Close();
                this.Dispose();
            }
        }     

        void IForm.MensajeBox(string texto)
        {
            
        }

        void IForm.EnviarEstado(string estado)
        {
            this.toolStripMenuPrincipalStatus.Text = estado;
        }

        private void pnlFichar_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
