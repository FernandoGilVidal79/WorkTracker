
namespace WorkTrackerAPP
{
    partial class MenuPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            this.mstrpPrincipal = new System.Windows.Forms.MenuStrip();
            this.FicharToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calendarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SolicitudesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.situaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlFichar = new System.Windows.Forms.Panel();
            this.TmrHora = new System.Windows.Forms.Timer(this.components);
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.pnlBanner = new System.Windows.Forms.Panel();
            this.lblBienvenida = new System.Windows.Forms.Label();
            this.pcBoxLogo = new System.Windows.Forms.PictureBox();
            this.mstrpPrincipal.SuspendLayout();
            this.pnlBanner.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // mstrpPrincipal
            // 
            this.mstrpPrincipal.BackColor = System.Drawing.Color.Silver;
            this.mstrpPrincipal.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mstrpPrincipal.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.mstrpPrincipal.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.mstrpPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FicharToolStripMenuItem,
            this.calendarioToolStripMenuItem,
            this.SolicitudesToolStripMenuItem,
            this.situaciónToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.mstrpPrincipal.Location = new System.Drawing.Point(0, 0);
            this.mstrpPrincipal.Name = "mstrpPrincipal";
            this.mstrpPrincipal.Size = new System.Drawing.Size(968, 39);
            this.mstrpPrincipal.TabIndex = 8;
            this.mstrpPrincipal.Text = "menuPrincipal";
            // 
            // FicharToolStripMenuItem
            // 
            this.FicharToolStripMenuItem.ForeColor = System.Drawing.Color.DarkRed;
            this.FicharToolStripMenuItem.Name = "FicharToolStripMenuItem";
            this.FicharToolStripMenuItem.Size = new System.Drawing.Size(90, 35);
            this.FicharToolStripMenuItem.Text = "Fichar";
            this.FicharToolStripMenuItem.Click += new System.EventHandler(this.FicharToolStripMenuItem_Click);
            // 
            // calendarioToolStripMenuItem
            // 
            this.calendarioToolStripMenuItem.ForeColor = System.Drawing.Color.DarkRed;
            this.calendarioToolStripMenuItem.Name = "calendarioToolStripMenuItem";
            this.calendarioToolStripMenuItem.Size = new System.Drawing.Size(137, 35);
            this.calendarioToolStripMenuItem.Text = "Calendario";
            // 
            // SolicitudesToolStripMenuItem
            // 
            this.SolicitudesToolStripMenuItem.ForeColor = System.Drawing.Color.DarkRed;
            this.SolicitudesToolStripMenuItem.Name = "SolicitudesToolStripMenuItem";
            this.SolicitudesToolStripMenuItem.Size = new System.Drawing.Size(135, 35);
            this.SolicitudesToolStripMenuItem.Text = "Solicitudes";
            this.SolicitudesToolStripMenuItem.Click += new System.EventHandler(this.SolicitudesToolStripMenuItem_Click);
            // 
            // situaciónToolStripMenuItem
            // 
            this.situaciónToolStripMenuItem.ForeColor = System.Drawing.Color.DarkRed;
            this.situaciónToolStripMenuItem.Name = "situaciónToolStripMenuItem";
            this.situaciónToolStripMenuItem.Size = new System.Drawing.Size(121, 35);
            this.situaciónToolStripMenuItem.Text = "Situación";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.salirToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.salirToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.salirToolStripMenuItem.ForeColor = System.Drawing.Color.DarkRed;
            this.salirToolStripMenuItem.Image = global::WorkTrackerAPP.Properties.Resources.Salir_Rojo;
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(40, 35);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            // 
            // pnlFichar
            // 
            this.pnlFichar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlFichar.BackColor = System.Drawing.SystemColors.Control;
            this.pnlFichar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFichar.Location = new System.Drawing.Point(0, 39);
            this.pnlFichar.Name = "pnlFichar";
            this.pnlFichar.Size = new System.Drawing.Size(968, 466);
            this.pnlFichar.TabIndex = 9;
            // 
            // TmrHora
            // 
            this.TmrHora.Tick += new System.EventHandler(this.TmrHora_Tick);
            // 
            // lblFecha
            // 
            this.lblFecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblFecha.Location = new System.Drawing.Point(711, 40);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(0, 29);
            this.lblFecha.TabIndex = 45;
            // 
            // lblHora
            // 
            this.lblHora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblHora.Location = new System.Drawing.Point(711, 10);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(0, 29);
            this.lblHora.TabIndex = 44;
            // 
            // pnlBanner
            // 
            this.pnlBanner.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlBanner.BackColor = System.Drawing.Color.White;
            this.pnlBanner.Controls.Add(this.lblBienvenida);
            this.pnlBanner.Controls.Add(this.pcBoxLogo);
            this.pnlBanner.Controls.Add(this.lblFecha);
            this.pnlBanner.Controls.Add(this.lblHora);
            this.pnlBanner.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBanner.Location = new System.Drawing.Point(0, 39);
            this.pnlBanner.Name = "pnlBanner";
            this.pnlBanner.Size = new System.Drawing.Size(968, 70);
            this.pnlBanner.TabIndex = 40;
            // 
            // lblBienvenida
            // 
            this.lblBienvenida.AutoSize = true;
            this.lblBienvenida.Font = new System.Drawing.Font("Tempus Sans ITC", 14F);
            this.lblBienvenida.Location = new System.Drawing.Point(311, 26);
            this.lblBienvenida.Name = "lblBienvenida";
            this.lblBienvenida.Size = new System.Drawing.Size(173, 37);
            this.lblBienvenida.TabIndex = 46;
            this.lblBienvenida.Text = "lblBienvenida";
            // 
            // pcBoxLogo
            // 
            this.pcBoxLogo.Image = global::WorkTrackerAPP.Properties.Resources.logo_p;
            this.pcBoxLogo.Location = new System.Drawing.Point(0, 0);
            this.pcBoxLogo.Name = "pcBoxLogo";
            this.pcBoxLogo.Size = new System.Drawing.Size(132, 70);
            this.pcBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcBoxLogo.TabIndex = 1;
            this.pcBoxLogo.TabStop = false;
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 505);
            this.Controls.Add(this.pnlBanner);
            this.Controls.Add(this.pnlFichar);
            this.Controls.Add(this.mstrpPrincipal);
            this.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DarkRed;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mstrpPrincipal;
            this.Name = "MenuPrincipal";
            this.Text = "Work Tracker";
            this.mstrpPrincipal.ResumeLayout(false);
            this.mstrpPrincipal.PerformLayout();
            this.pnlBanner.ResumeLayout(false);
            this.pnlBanner.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcBoxLogo;
        private System.Windows.Forms.MenuStrip mstrpPrincipal;
        private System.Windows.Forms.ToolStripMenuItem FicharToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calendarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SolicitudesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem situaciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.Panel pnlFichar;
        private System.Windows.Forms.Timer TmrHora;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Panel pnlBanner;
        private System.Windows.Forms.Label lblBienvenida;
    }
}