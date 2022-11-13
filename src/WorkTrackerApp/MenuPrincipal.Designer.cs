
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
            this.ficharToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calendarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.solicitudesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.situaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aprobacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlFichar = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnDescanso2 = new System.Windows.Forms.Button();
            this.btnJornada = new System.Windows.Forms.Button();
            this.btnDescanso1 = new System.Windows.Forms.Button();
            this.btnComida = new System.Windows.Forms.Button();
            this.lgnStripResult = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.pcBoxLogo = new System.Windows.Forms.PictureBox();
            this.tmrHora = new System.Windows.Forms.Timer(this.components);
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.pnlBanner = new System.Windows.Forms.Panel();
            this.lblBienvenida = new System.Windows.Forms.Label();
            this.mstrpPrincipal.SuspendLayout();
            this.pnlFichar.SuspendLayout();
            this.lgnStripResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcBoxLogo)).BeginInit();
            this.pnlBanner.SuspendLayout();
            this.SuspendLayout();
            // 
            // mstrpPrincipal
            // 
            this.mstrpPrincipal.BackColor = System.Drawing.Color.Silver;
            this.mstrpPrincipal.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mstrpPrincipal.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.mstrpPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ficharToolStripMenuItem,
            this.calendarioToolStripMenuItem,
            this.solicitudesToolStripMenuItem,
            this.situaciónToolStripMenuItem,
            this.informesToolStripMenuItem,
            this.aprobacionesToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.mstrpPrincipal.Location = new System.Drawing.Point(0, 0);
            this.mstrpPrincipal.Name = "mstrpPrincipal";
            this.mstrpPrincipal.Size = new System.Drawing.Size(968, 32);
            this.mstrpPrincipal.TabIndex = 8;
            this.mstrpPrincipal.Text = "menuPrincipal";
            // 
            // ficharToolStripMenuItem
            // 
            this.ficharToolStripMenuItem.ForeColor = System.Drawing.Color.DarkRed;
            this.ficharToolStripMenuItem.Name = "ficharToolStripMenuItem";
            this.ficharToolStripMenuItem.Size = new System.Drawing.Size(61, 28);
            this.ficharToolStripMenuItem.Text = "Fichar";
            this.ficharToolStripMenuItem.Click += new System.EventHandler(this.ficharToolStripMenuItem_Click);
            // 
            // calendarioToolStripMenuItem
            // 
            this.calendarioToolStripMenuItem.ForeColor = System.Drawing.Color.DarkRed;
            this.calendarioToolStripMenuItem.Name = "calendarioToolStripMenuItem";
            this.calendarioToolStripMenuItem.Size = new System.Drawing.Size(91, 28);
            this.calendarioToolStripMenuItem.Text = "Calendario";
            // 
            // solicitudesToolStripMenuItem
            // 
            this.solicitudesToolStripMenuItem.ForeColor = System.Drawing.Color.DarkRed;
            this.solicitudesToolStripMenuItem.Name = "solicitudesToolStripMenuItem";
            this.solicitudesToolStripMenuItem.Size = new System.Drawing.Size(91, 28);
            this.solicitudesToolStripMenuItem.Text = "Solicitudes";
            this.solicitudesToolStripMenuItem.Click += new System.EventHandler(this.solicitudesToolStripMenuItem_Click);
            // 
            // situaciónToolStripMenuItem
            // 
            this.situaciónToolStripMenuItem.ForeColor = System.Drawing.Color.DarkRed;
            this.situaciónToolStripMenuItem.Name = "situaciónToolStripMenuItem";
            this.situaciónToolStripMenuItem.Size = new System.Drawing.Size(83, 28);
            this.situaciónToolStripMenuItem.Text = "Situación";
            // 
            // informesToolStripMenuItem
            // 
            this.informesToolStripMenuItem.ForeColor = System.Drawing.Color.DarkRed;
            this.informesToolStripMenuItem.Name = "informesToolStripMenuItem";
            this.informesToolStripMenuItem.Size = new System.Drawing.Size(80, 28);
            this.informesToolStripMenuItem.Text = "Informes";
            // 
            // aprobacionesToolStripMenuItem
            // 
            this.aprobacionesToolStripMenuItem.ForeColor = System.Drawing.Color.DarkRed;
            this.aprobacionesToolStripMenuItem.Name = "aprobacionesToolStripMenuItem";
            this.aprobacionesToolStripMenuItem.Size = new System.Drawing.Size(111, 28);
            this.aprobacionesToolStripMenuItem.Text = "Aprobaciones";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.salirToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.salirToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.salirToolStripMenuItem.ForeColor = System.Drawing.Color.DarkRed;
            this.salirToolStripMenuItem.Image = global::WorkTrackerAPP.Properties.Resources.Salir_Rojo;
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(36, 28);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            // 
            // pnlFichar
            // 
            this.pnlFichar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlFichar.BackColor = System.Drawing.SystemColors.Control;
            this.pnlFichar.Controls.Add(this.button1);
            this.pnlFichar.Controls.Add(this.btnDescanso2);
            this.pnlFichar.Controls.Add(this.btnJornada);
            this.pnlFichar.Controls.Add(this.btnDescanso1);
            this.pnlFichar.Controls.Add(this.btnComida);
            this.pnlFichar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFichar.Location = new System.Drawing.Point(0, 32);
            this.pnlFichar.Name = "pnlFichar";
            this.pnlFichar.Size = new System.Drawing.Size(968, 473);
            this.pnlFichar.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(306, 179);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 42);
            this.button1.TabIndex = 46;
            this.button1.Text = "FICHAR";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnDescanso2
            // 
            this.btnDescanso2.Location = new System.Drawing.Point(15, 235);
            this.btnDescanso2.Name = "btnDescanso2";
            this.btnDescanso2.Size = new System.Drawing.Size(117, 32);
            this.btnDescanso2.TabIndex = 43;
            this.btnDescanso2.Text = "Descanso 2";
            this.btnDescanso2.UseVisualStyleBackColor = true;
            // 
            // btnJornada
            // 
            this.btnJornada.Location = new System.Drawing.Point(15, 69);
            this.btnJornada.Name = "btnJornada";
            this.btnJornada.Size = new System.Drawing.Size(117, 32);
            this.btnJornada.TabIndex = 40;
            this.btnJornada.Text = "Jornada";
            this.btnJornada.UseVisualStyleBackColor = true;
            // 
            // btnDescanso1
            // 
            this.btnDescanso1.Location = new System.Drawing.Point(15, 179);
            this.btnDescanso1.Name = "btnDescanso1";
            this.btnDescanso1.Size = new System.Drawing.Size(117, 32);
            this.btnDescanso1.TabIndex = 42;
            this.btnDescanso1.Text = "Descanso 1";
            this.btnDescanso1.UseVisualStyleBackColor = true;
            // 
            // btnComida
            // 
            this.btnComida.Location = new System.Drawing.Point(15, 120);
            this.btnComida.Name = "btnComida";
            this.btnComida.Size = new System.Drawing.Size(117, 32);
            this.btnComida.TabIndex = 41;
            this.btnComida.Text = "Comida";
            this.btnComida.UseVisualStyleBackColor = true;
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
            this.lgnStripResult.Location = new System.Drawing.Point(0, 480);
            this.lgnStripResult.Name = "lgnStripResult";
            this.lgnStripResult.Size = new System.Drawing.Size(968, 25);
            this.lgnStripResult.TabIndex = 39;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(147, 20);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
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
            // tmrHora
            // 
            this.tmrHora.Tick += new System.EventHandler(this.tmrHora_Tick);
            // 
            // lblFecha
            // 
            this.lblFecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblFecha.Location = new System.Drawing.Point(711, 40);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(173, 13);
            this.lblFecha.TabIndex = 45;
            this.lblFecha.Text = "Domingo, 13 de noviembre de 2022";
            this.lblFecha.Click += new System.EventHandler(this.lblFecha_Click);
            // 
            // lblHora
            // 
            this.lblHora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblHora.Location = new System.Drawing.Point(711, 10);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(47, 13);
            this.lblHora.TabIndex = 44;
            this.lblHora.Text = "12:34:00";
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
            this.pnlBanner.Location = new System.Drawing.Point(0, 32);
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
            this.lblBienvenida.Size = new System.Drawing.Size(78, 16);
            this.lblBienvenida.TabIndex = 46;
            this.lblBienvenida.Text = "lblBienvenida";
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 505);
            this.Controls.Add(this.pnlBanner);
            this.Controls.Add(this.lgnStripResult);
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
            this.pnlFichar.ResumeLayout(false);
            this.lgnStripResult.ResumeLayout(false);
            this.lgnStripResult.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcBoxLogo)).EndInit();
            this.pnlBanner.ResumeLayout(false);
            this.pnlBanner.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcBoxLogo;
        private System.Windows.Forms.MenuStrip mstrpPrincipal;
        private System.Windows.Forms.ToolStripMenuItem ficharToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calendarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem solicitudesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem situaciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aprobacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.Panel pnlFichar;
        private System.Windows.Forms.StatusStrip lgnStripResult;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Button btnDescanso2;
        private System.Windows.Forms.Button btnJornada;
        private System.Windows.Forms.Button btnDescanso1;
        private System.Windows.Forms.Button btnComida;
        private System.Windows.Forms.Timer tmrHora;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel pnlBanner;
        private System.Windows.Forms.Label lblBienvenida;
    }
}