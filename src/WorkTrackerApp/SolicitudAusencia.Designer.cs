
namespace WorkTrackerAPP
{
    partial class SolicitudAusencia
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
            this.cmbTipoAusencia = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mCalendar = new System.Windows.Forms.MonthCalendar();
            this.tbxDesde = new System.Windows.Forms.TextBox();
            this.tbxHasta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.pnlListadoAusencias = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnGrabar2 = new WorkTrackerAPP.Helpers.BtnGrabar();
            this.btnGrabar3 = new WorkTrackerAPP.Helpers.BtnGrabar();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbTipoAusencia
            // 
            this.cmbTipoAusencia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoAusencia.Font = new System.Drawing.Font("Verdana", 10F);
            this.cmbTipoAusencia.FormattingEnabled = true;
            this.cmbTipoAusencia.Location = new System.Drawing.Point(48, 250);
            this.cmbTipoAusencia.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.cmbTipoAusencia.Name = "cmbTipoAusencia";
            this.cmbTipoAusencia.Size = new System.Drawing.Size(123, 28);
            this.cmbTipoAusencia.TabIndex = 81;
            this.cmbTipoAusencia.SelectedIndexChanged += new System.EventHandler(this.cbxTipoAusencia_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 10F);
            this.label1.Location = new System.Drawing.Point(43, 222);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 20);
            this.label1.TabIndex = 82;
            this.label1.Text = "Tipo Ausencia";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // mCalendar
            // 
            this.mCalendar.Font = new System.Drawing.Font("Verdana", 10F);
            this.mCalendar.Location = new System.Drawing.Point(185, 306);
            this.mCalendar.Margin = new System.Windows.Forms.Padding(15, 14, 15, 14);
            this.mCalendar.Name = "mCalendar";
            this.mCalendar.TabIndex = 83;
            this.mCalendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // tbxDesde
            // 
            this.tbxDesde.Font = new System.Drawing.Font("Verdana", 10F);
            this.tbxDesde.Location = new System.Drawing.Point(185, 250);
            this.tbxDesde.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.tbxDesde.Name = "tbxDesde";
            this.tbxDesde.Size = new System.Drawing.Size(113, 28);
            this.tbxDesde.TabIndex = 84;
            // 
            // tbxHasta
            // 
            this.tbxHasta.Font = new System.Drawing.Font("Verdana", 10F);
            this.tbxHasta.Location = new System.Drawing.Point(308, 250);
            this.tbxHasta.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.tbxHasta.Name = "tbxHasta";
            this.tbxHasta.Size = new System.Drawing.Size(109, 28);
            this.tbxHasta.TabIndex = 85;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 10F);
            this.label2.Location = new System.Drawing.Point(181, 222);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 20);
            this.label2.TabIndex = 86;
            this.label2.Text = "Fecha Desde";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 10F);
            this.label3.Location = new System.Drawing.Point(309, 222);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 20);
            this.label3.TabIndex = 87;
            this.label3.Text = "Fecha Hasta";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 548);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(2, 0, 23, 0);
            this.statusStrip1.Size = new System.Drawing.Size(988, 22);
            this.statusStrip1.TabIndex = 90;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 16);
            // 
            // pnlListadoAusencias
            // 
            this.pnlListadoAusencias.Location = new System.Drawing.Point(454, 12);
            this.pnlListadoAusencias.Margin = new System.Windows.Forms.Padding(5);
            this.pnlListadoAusencias.Name = "pnlListadoAusencias";
            this.pnlListadoAusencias.Size = new System.Drawing.Size(363, 500);
            this.pnlListadoAusencias.TabIndex = 91;
            this.pnlListadoAusencias.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnGrabar2);
            this.groupBox1.Controls.Add(this.btnGrabar3);
            this.groupBox1.Location = new System.Drawing.Point(846, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(130, 71);
            this.groupBox1.TabIndex = 94;
            this.groupBox1.TabStop = false;
            // 
            // btnGrabar2
            // 
            this.btnGrabar2.BackColor = System.Drawing.Color.Transparent;
            this.btnGrabar2.FlatAppearance.BorderSize = 0;
            this.btnGrabar2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGrabar2.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.btnGrabar2.Image = global::WorkTrackerAPP.Properties.Resources.comment_check;
            this.btnGrabar2.Location = new System.Drawing.Point(8, 17);
            this.btnGrabar2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnGrabar2.Name = "btnGrabar2";
            this.btnGrabar2.Size = new System.Drawing.Size(58, 48);
            this.btnGrabar2.TabIndex = 47;
            this.btnGrabar2.UseVisualStyleBackColor = false;
            this.btnGrabar2.Click += new System.EventHandler(this.btnGrabar2_Click);
            // 
            // btnGrabar3
            // 
            this.btnGrabar3.BackColor = System.Drawing.Color.Transparent;
            this.btnGrabar3.FlatAppearance.BorderSize = 0;
            this.btnGrabar3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGrabar3.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.btnGrabar3.Image = global::WorkTrackerAPP.Properties.Resources.cross_circle;
            this.btnGrabar3.Location = new System.Drawing.Point(76, 17);
            this.btnGrabar3.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnGrabar3.Name = "btnGrabar3";
            this.btnGrabar3.Size = new System.Drawing.Size(47, 47);
            this.btnGrabar3.TabIndex = 46;
            this.btnGrabar3.UseVisualStyleBackColor = false;
            this.btnGrabar3.Click += new System.EventHandler(this.btnGrabar3_Click);
            // 
            // SolicitudAusencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(988, 570);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pnlListadoAusencias);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxHasta);
            this.Controls.Add(this.tbxDesde);
            this.Controls.Add(this.mCalendar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbTipoAusencia);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.Name = "SolicitudAusencia";
            this.Text = "SolicitudAusencia";
            this.Load += new System.EventHandler(this.SolicitudAusencia_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbTipoAusencia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MonthCalendar mCalendar;
        private System.Windows.Forms.TextBox tbxDesde;
        private System.Windows.Forms.TextBox tbxHasta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Panel pnlListadoAusencias;
        private System.Windows.Forms.GroupBox groupBox1;
        private Helpers.BtnGrabar btnGrabar2;
        private Helpers.BtnGrabar btnGrabar3;
    }
}