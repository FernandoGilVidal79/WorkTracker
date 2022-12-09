
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.pnlListadoAusencias = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnGrabar2 = new WorkTrackerAPP.Helpers.BtnGrabar();
            this.btnGrabar3 = new WorkTrackerAPP.Helpers.BtnGrabar();
            this.cmbTipoAusencia = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mCalendar = new System.Windows.Forms.MonthCalendar();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mtbxDesde = new System.Windows.Forms.MaskedTextBox();
            this.mtbxHasta = new System.Windows.Forms.MaskedTextBox();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
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
            this.pnlListadoAusencias.Location = new System.Drawing.Point(19, 12);
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
            this.groupBox1.Location = new System.Drawing.Point(882, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(105, 65);
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
            this.btnGrabar2.Size = new System.Drawing.Size(45, 40);
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
            this.btnGrabar3.Location = new System.Drawing.Point(63, 17);
            this.btnGrabar3.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnGrabar3.Name = "btnGrabar3";
            this.btnGrabar3.Size = new System.Drawing.Size(39, 40);
            this.btnGrabar3.TabIndex = 46;
            this.btnGrabar3.UseVisualStyleBackColor = false;
            this.btnGrabar3.Click += new System.EventHandler(this.btnGrabar3_Click);
            // 
            // cmbTipoAusencia
            // 
            this.cmbTipoAusencia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoAusencia.Font = new System.Drawing.Font("Verdana", 10F);
            this.cmbTipoAusencia.FormattingEnabled = true;
            this.cmbTipoAusencia.Location = new System.Drawing.Point(464, 43);
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
            this.label1.Location = new System.Drawing.Point(459, 15);
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
            this.mCalendar.Location = new System.Drawing.Point(601, 99);
            this.mCalendar.Margin = new System.Windows.Forms.Padding(15, 14, 15, 14);
            this.mCalendar.Name = "mCalendar";
            this.mCalendar.TabIndex = 83;
            this.mCalendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            this.mCalendar.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.mCalendar_DateSelected);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 10F);
            this.label2.Location = new System.Drawing.Point(597, 15);
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
            this.label3.Location = new System.Drawing.Point(725, 15);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 20);
            this.label3.TabIndex = 87;
            this.label3.Text = "Fecha Hasta";
            // 
            // mtbxDesde
            // 
            this.mtbxDesde.Font = new System.Drawing.Font("Verdana", 10F);
            this.mtbxDesde.Location = new System.Drawing.Point(601, 43);
            this.mtbxDesde.Mask = "00/00/0000";
            this.mtbxDesde.Name = "mtbxDesde";
            this.mtbxDesde.Size = new System.Drawing.Size(113, 28);
            this.mtbxDesde.TabIndex = 95;
            this.mtbxDesde.ValidatingType = typeof(System.DateTime);
            // 
            // mtbxHasta
            // 
            this.mtbxHasta.Font = new System.Drawing.Font("Verdana", 10F);
            this.mtbxHasta.Location = new System.Drawing.Point(730, 43);
            this.mtbxHasta.Mask = "00/00/0000";
            this.mtbxHasta.Name = "mtbxHasta";
            this.mtbxHasta.Size = new System.Drawing.Size(113, 28);
            this.mtbxHasta.TabIndex = 96;
            this.mtbxHasta.ValidatingType = typeof(System.DateTime);
            // 
            // SolicitudAusencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(988, 570);
            this.Controls.Add(this.mtbxHasta);
            this.Controls.Add(this.mtbxDesde);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pnlListadoAusencias);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
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
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Panel pnlListadoAusencias;
        private System.Windows.Forms.GroupBox groupBox1;
        private Helpers.BtnGrabar btnGrabar2;
        private Helpers.BtnGrabar btnGrabar3;
        private System.Windows.Forms.ComboBox cmbTipoAusencia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MonthCalendar mCalendar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mtbxDesde;
        private System.Windows.Forms.MaskedTextBox mtbxHasta;
    }
}