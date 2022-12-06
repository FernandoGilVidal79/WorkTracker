
namespace WorkTrackerAPP
{
    partial class MenuPrincipalRRHH
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipalRRHH));
            this.mstrpPrincipal = new System.Windows.Forms.MenuStrip();
            this.ficharToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calendarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.solicitudesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.situaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aprobacionestoolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripCreacionUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlBanner = new System.Windows.Forms.Panel();
            this.lblBienvenida = new System.Windows.Forms.Label();
            this.pcBoxLogo = new System.Windows.Forms.PictureBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.pnlFichar = new System.Windows.Forms.Panel();
            this.TmrHora = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripMenuPrincipalStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.mstrpPrincipal.SuspendLayout();
            this.pnlBanner.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcBoxLogo)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mstrpPrincipal
            // 
            this.mstrpPrincipal.BackColor = System.Drawing.Color.Gainsboro;
            this.mstrpPrincipal.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mstrpPrincipal.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.mstrpPrincipal.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.mstrpPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ficharToolStripMenuItem,
            this.calendarioToolStripMenuItem,
            this.solicitudesToolStripMenuItem,
            this.situaciónToolStripMenuItem,
            this.aprobacionestoolStripMenuItem1,
            this.salirToolStripMenuItem,
            this.toolStripCreacionUsuario});
            this.mstrpPrincipal.Location = new System.Drawing.Point(0, 0);
            this.mstrpPrincipal.Name = "mstrpPrincipal";
            this.mstrpPrincipal.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.mstrpPrincipal.Size = new System.Drawing.Size(1591, 41);
            this.mstrpPrincipal.TabIndex = 9;
            this.mstrpPrincipal.Text = "menuPrincipal";
            // 
            // ficharToolStripMenuItem
            // 
            this.ficharToolStripMenuItem.ForeColor = System.Drawing.Color.DarkRed;
            this.ficharToolStripMenuItem.Name = "ficharToolStripMenuItem";
            this.ficharToolStripMenuItem.Size = new System.Drawing.Size(90, 37);
            this.ficharToolStripMenuItem.Text = "Fichar";
            this.ficharToolStripMenuItem.Click += new System.EventHandler(this.FicharToolStripMenuItem_Click);
            // 
            // calendarioToolStripMenuItem
            // 
            this.calendarioToolStripMenuItem.ForeColor = System.Drawing.Color.DarkRed;
            this.calendarioToolStripMenuItem.Name = "calendarioToolStripMenuItem";
            this.calendarioToolStripMenuItem.Size = new System.Drawing.Size(137, 37);
            this.calendarioToolStripMenuItem.Text = "Calendario";
            this.calendarioToolStripMenuItem.Click += new System.EventHandler(this.calendarioToolStripMenuItem_Click);
            // 
            // solicitudesToolStripMenuItem
            // 
            this.solicitudesToolStripMenuItem.ForeColor = System.Drawing.Color.DarkRed;
            this.solicitudesToolStripMenuItem.Name = "solicitudesToolStripMenuItem";
            this.solicitudesToolStripMenuItem.Size = new System.Drawing.Size(135, 37);
            this.solicitudesToolStripMenuItem.Text = "Solicitudes";
            this.solicitudesToolStripMenuItem.Click += new System.EventHandler(this.SolicitudesToolStripMenuItem_Click);
            // 
            // situaciónToolStripMenuItem
            // 
            this.situaciónToolStripMenuItem.ForeColor = System.Drawing.Color.DarkRed;
            this.situaciónToolStripMenuItem.Name = "situaciónToolStripMenuItem";
            this.situaciónToolStripMenuItem.Size = new System.Drawing.Size(121, 37);
            this.situaciónToolStripMenuItem.Text = "Situación";
            this.situaciónToolStripMenuItem.Click += new System.EventHandler(this.SituaciónToolStripMenuItem_Click);
            // 
            // aprobacionestoolStripMenuItem1
            // 
            this.aprobacionestoolStripMenuItem1.ForeColor = System.Drawing.Color.DarkRed;
            this.aprobacionestoolStripMenuItem1.Name = "aprobacionestoolStripMenuItem1";
            this.aprobacionestoolStripMenuItem1.Size = new System.Drawing.Size(168, 37);
            this.aprobacionestoolStripMenuItem1.Text = "Aprobaciones";
            this.aprobacionestoolStripMenuItem1.Click += new System.EventHandler(this.AprobacionestoolStripMenuItem1_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.salirToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.salirToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.salirToolStripMenuItem.ForeColor = System.Drawing.Color.DarkRed;
            this.salirToolStripMenuItem.Image = global::WorkTrackerAPP.Properties.Resources.Salir_Rojo;
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(40, 37);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.SalirToolStripMenuItem_Click);
            // 
            // toolStripCreacionUsuario
            // 
            this.toolStripCreacionUsuario.ForeColor = System.Drawing.Color.DarkRed;
            this.toolStripCreacionUsuario.Name = "toolStripCreacionUsuario";
            this.toolStripCreacionUsuario.Size = new System.Drawing.Size(115, 37);
            this.toolStripCreacionUsuario.Text = "&Usuarios";
            this.toolStripCreacionUsuario.Click += new System.EventHandler(this.ToolStripCreacionUsuario_Click);
            // 
            // pnlBanner
            // 
            this.pnlBanner.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlBanner.BackColor = System.Drawing.SystemColors.Window;
            this.pnlBanner.Controls.Add(this.lblBienvenida);
            this.pnlBanner.Controls.Add(this.pcBoxLogo);
            this.pnlBanner.Controls.Add(this.lblFecha);
            this.pnlBanner.Controls.Add(this.lblHora);
            this.pnlBanner.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBanner.Location = new System.Drawing.Point(0, 41);
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
            // pnlFichar
            // 
            this.pnlFichar.AutoSize = true;
            this.pnlFichar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlFichar.BackColor = System.Drawing.SystemColors.Window;
            this.pnlFichar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFichar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFichar.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlFichar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnlFichar.Location = new System.Drawing.Point(0, 111);
            this.pnlFichar.Name = "pnlFichar";
            this.pnlFichar.Size = new System.Drawing.Size(1591, 642);
            this.pnlFichar.TabIndex = 42;
            this.pnlFichar.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlFichar_Paint);
            // 
            // TmrHora
            // 
            this.TmrHora.Tick += new System.EventHandler(this.TmrHora_Tick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuPrincipalStatus,
            this.toolStripProgressBar1,
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 721);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1591, 32);
            this.statusStrip1.TabIndex = 43;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripMenuPrincipalStatus
            // 
            this.toolStripMenuPrincipalStatus.Name = "toolStripMenuPrincipalStatus";
            this.toolStripMenuPrincipalStatus.Size = new System.Drawing.Size(0, 25);
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 24);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(179, 25);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // MenuPrincipalRRHH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1591, 753);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.pnlFichar);
            this.Controls.Add(this.pnlBanner);
            this.Controls.Add(this.mstrpPrincipal);
            this.Font = new System.Drawing.Font("Tempus Sans ITC", 12F);
            this.ForeColor = System.Drawing.Color.DarkRed;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MenuPrincipalRRHH";
            this.Text = "Work Tracker";
            this.Load += new System.EventHandler(this.MenuPrincipalRRHH_Load);
            this.mstrpPrincipal.ResumeLayout(false);
            this.mstrpPrincipal.PerformLayout();
            this.pnlBanner.ResumeLayout(false);
            this.pnlBanner.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcBoxLogo)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mstrpPrincipal;
        private System.Windows.Forms.ToolStripMenuItem ficharToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calendarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem solicitudesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem situaciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.Panel pnlBanner;
        private System.Windows.Forms.Label lblBienvenida;
        private System.Windows.Forms.PictureBox pcBoxLogo;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Panel pnlFichar;
        private System.Windows.Forms.Timer TmrHora;
        private System.Windows.Forms.ToolStripMenuItem aprobacionestoolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripCreacionUsuario;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripMenuPrincipalStatus;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}