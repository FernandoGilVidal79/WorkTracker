
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
            this.pnlBanner = new System.Windows.Forms.Panel();
            this.lblBienvenida = new System.Windows.Forms.Label();
            this.pcBoxLogo = new System.Windows.Forms.PictureBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.lgnStripResult = new System.Windows.Forms.StatusStrip();
            this.toolStripMenuAdminStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.mstrpPrincipal.SuspendLayout();
            this.pnlBanner.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcBoxLogo)).BeginInit();
            this.lgnStripResult.SuspendLayout();
            this.SuspendLayout();
            // 
            // mstrpPrincipal
            // 
            this.mstrpPrincipal.BackColor = System.Drawing.Color.Gainsboro;
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
            this.mstrpPrincipal.Size = new System.Drawing.Size(1591, 39);
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
            this.calendarioToolStripMenuItem.Click += new System.EventHandler(this.calendarioToolStripMenuItem_Click);
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
            this.situaciónToolStripMenuItem.Click += new System.EventHandler(this.situaciónToolStripMenuItem_Click);
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
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // pnlFichar
            // 
            this.pnlFichar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlFichar.BackColor = System.Drawing.SystemColors.Window;
            this.pnlFichar.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlFichar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnlFichar.Location = new System.Drawing.Point(0, 102);
            this.pnlFichar.Name = "pnlFichar";
            this.pnlFichar.Size = new System.Drawing.Size(1591, 627);
            this.pnlFichar.TabIndex = 9;
            this.pnlFichar.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlFichar_Paint);
            // 
            // TmrHora
            // 
            this.TmrHora.Tick += new System.EventHandler(this.TmrHora_Tick);
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
            this.pnlBanner.Size = new System.Drawing.Size(1591, 70);
            this.pnlBanner.TabIndex = 41;
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
            // lblFecha
            // 
            this.lblFecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblFecha.ForeColor = System.Drawing.Color.DimGray;
            this.lblFecha.Location = new System.Drawing.Point(1334, 40);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(0, 29);
            this.lblFecha.TabIndex = 45;
            // 
            // lblHora
            // 
            this.lblHora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblHora.ForeColor = System.Drawing.Color.DimGray;
            this.lblHora.Location = new System.Drawing.Point(1334, 10);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(0, 29);
            this.lblHora.TabIndex = 44;
            // 
            // lgnStripResult
            // 
            this.lgnStripResult.BackColor = System.Drawing.Color.Silver;
            this.lgnStripResult.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.lgnStripResult.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lgnStripResult.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.lgnStripResult.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuAdminStatus,
            this.toolStripProgressBar1,
            this.toolStripStatusLabel1});
            this.lgnStripResult.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.lgnStripResult.Location = new System.Drawing.Point(0, 715);
            this.lgnStripResult.Name = "lgnStripResult";
            this.lgnStripResult.Size = new System.Drawing.Size(1591, 38);
            this.lgnStripResult.TabIndex = 48;
            // 
            // toolStripMenuAdminStatus
            // 
            this.toolStripMenuAdminStatus.Name = "toolStripMenuAdminStatus";
            this.toolStripMenuAdminStatus.Size = new System.Drawing.Size(0, 31);
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 30);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(218, 31);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1591, 753);
            this.Controls.Add(this.lgnStripResult);
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
            this.lgnStripResult.ResumeLayout(false);
            this.lgnStripResult.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip mstrpPrincipal;
        private System.Windows.Forms.ToolStripMenuItem FicharToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calendarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SolicitudesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem situaciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.Panel pnlFichar;
        private System.Windows.Forms.Timer TmrHora;
        private System.Windows.Forms.Panel pnlBanner;
        private System.Windows.Forms.Label lblBienvenida;
        private System.Windows.Forms.PictureBox pcBoxLogo;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.StatusStrip lgnStripResult;
        private System.Windows.Forms.ToolStripStatusLabel toolStripMenuAdminStatus;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}