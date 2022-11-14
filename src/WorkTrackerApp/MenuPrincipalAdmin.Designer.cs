
namespace WorkTrackerAPP
{
    partial class MenuPrincipalAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipalAdmin));
            this.mstrpPrincipal = new System.Windows.Forms.MenuStrip();
            this.ficharToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calendarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlBanner = new System.Windows.Forms.Panel();
            this.lblBienvenida = new System.Windows.Forms.Label();
            this.pcBoxLogo = new System.Windows.Forms.PictureBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.pnlInformes = new System.Windows.Forms.Panel();
            this.lgnStripResult = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.TmrHora = new System.Windows.Forms.Timer(this.components);
            this.mstrpPrincipal.SuspendLayout();
            this.pnlBanner.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcBoxLogo)).BeginInit();
            this.pnlInformes.SuspendLayout();
            this.lgnStripResult.SuspendLayout();
            this.SuspendLayout();
            // 
            // mstrpPrincipal
            // 
            this.mstrpPrincipal.BackColor = System.Drawing.Color.Silver;
            this.mstrpPrincipal.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mstrpPrincipal.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.mstrpPrincipal.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.mstrpPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ficharToolStripMenuItem,
            this.calendarioToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.mstrpPrincipal.Location = new System.Drawing.Point(0, 0);
            this.mstrpPrincipal.Name = "mstrpPrincipal";
            this.mstrpPrincipal.Size = new System.Drawing.Size(1260, 39);
            this.mstrpPrincipal.TabIndex = 9;
            this.mstrpPrincipal.Text = "menuPrincipal";
            // 
            // ficharToolStripMenuItem
            // 
            this.ficharToolStripMenuItem.ForeColor = System.Drawing.Color.DarkRed;
            this.ficharToolStripMenuItem.Name = "ficharToolStripMenuItem";
            this.ficharToolStripMenuItem.Size = new System.Drawing.Size(120, 35);
            this.ficharToolStripMenuItem.Text = "Informes";
            // 
            // calendarioToolStripMenuItem
            // 
            this.calendarioToolStripMenuItem.ForeColor = System.Drawing.Color.DarkRed;
            this.calendarioToolStripMenuItem.Name = "calendarioToolStripMenuItem";
            this.calendarioToolStripMenuItem.Size = new System.Drawing.Size(76, 35);
            this.calendarioToolStripMenuItem.Text = "Logs";
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
            this.pnlBanner.Size = new System.Drawing.Size(1260, 70);
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
            this.lblFecha.Location = new System.Drawing.Point(1003, 40);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(0, 29);
            this.lblFecha.TabIndex = 45;
            // 
            // lblHora
            // 
            this.lblHora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblHora.Location = new System.Drawing.Point(1003, 10);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(0, 29);
            this.lblHora.TabIndex = 44;
            // 
            // pnlInformes
            // 
            this.pnlInformes.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlInformes.BackColor = System.Drawing.SystemColors.Control;
            this.pnlInformes.Controls.Add(this.lgnStripResult);
            this.pnlInformes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlInformes.Location = new System.Drawing.Point(0, 109);
            this.pnlInformes.Name = "pnlInformes";
            this.pnlInformes.Size = new System.Drawing.Size(1260, 769);
            this.pnlInformes.TabIndex = 42;
            // 
            // lgnStripResult
            // 
            this.lgnStripResult.BackColor = System.Drawing.Color.Silver;
            this.lgnStripResult.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.lgnStripResult.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lgnStripResult.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.lgnStripResult.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.lgnStripResult.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.lgnStripResult.Location = new System.Drawing.Point(0, 731);
            this.lgnStripResult.Name = "lgnStripResult";
            this.lgnStripResult.Size = new System.Drawing.Size(1260, 38);
            this.lgnStripResult.TabIndex = 47;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(218, 31);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // TmrHora
            // 
            this.TmrHora.Tick += new System.EventHandler(this.TmrHora_Tick);
            // 
            // MenuPrincipalAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1260, 878);
            this.Controls.Add(this.pnlInformes);
            this.Controls.Add(this.pnlBanner);
            this.Controls.Add(this.mstrpPrincipal);
            this.Font = new System.Drawing.Font("Tempus Sans ITC", 12F);
            this.ForeColor = System.Drawing.Color.DarkRed;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MenuPrincipalAdmin";
            this.Text = "Work Tracker";
            this.Load += new System.EventHandler(this.MenuPrincipalAdmin_Load);
            this.mstrpPrincipal.ResumeLayout(false);
            this.mstrpPrincipal.PerformLayout();
            this.pnlBanner.ResumeLayout(false);
            this.pnlBanner.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcBoxLogo)).EndInit();
            this.pnlInformes.ResumeLayout(false);
            this.pnlInformes.PerformLayout();
            this.lgnStripResult.ResumeLayout(false);
            this.lgnStripResult.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mstrpPrincipal;
        private System.Windows.Forms.ToolStripMenuItem ficharToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calendarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.Panel pnlBanner;
        private System.Windows.Forms.Label lblBienvenida;
        private System.Windows.Forms.PictureBox pcBoxLogo;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Panel pnlInformes;
        private System.Windows.Forms.StatusStrip lgnStripResult;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Timer TmrHora;
    }
}