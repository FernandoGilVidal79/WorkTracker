
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
            this.cbxTipoAusencia = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mCalendar = new System.Windows.Forms.MonthCalendar();
            this.tbxDesde = new System.Windows.Forms.TextBox();
            this.tbxHasta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbxTipoAusencia
            // 
            this.cbxTipoAusencia.Font = new System.Drawing.Font("Tempus Sans ITC", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTipoAusencia.FormattingEnabled = true;
            this.cbxTipoAusencia.Location = new System.Drawing.Point(74, 135);
            this.cbxTipoAusencia.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbxTipoAusencia.Name = "cbxTipoAusencia";
            this.cbxTipoAusencia.Size = new System.Drawing.Size(92, 21);
            this.cbxTipoAusencia.TabIndex = 81;
            this.cbxTipoAusencia.SelectedIndexChanged += new System.EventHandler(this.cbxTipoAusencia_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tempus Sans ITC", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, 115);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 18);
            this.label1.TabIndex = 82;
            this.label1.Text = "Tipo Ausencia";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // mCalendar
            // 
            this.mCalendar.Location = new System.Drawing.Point(409, 91);
            this.mCalendar.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.mCalendar.Name = "mCalendar";
            this.mCalendar.TabIndex = 83;
            this.mCalendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // tbxDesde
            // 
            this.tbxDesde.Font = new System.Drawing.Font("Tempus Sans ITC", 8.25F);
            this.tbxDesde.Location = new System.Drawing.Point(184, 135);
            this.tbxDesde.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbxDesde.Name = "tbxDesde";
            this.tbxDesde.Size = new System.Drawing.Size(76, 22);
            this.tbxDesde.TabIndex = 84;
            // 
            // tbxHasta
            // 
            this.tbxHasta.Font = new System.Drawing.Font("Tempus Sans ITC", 8.25F);
            this.tbxHasta.Location = new System.Drawing.Point(281, 135);
            this.tbxHasta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbxHasta.Name = "tbxHasta";
            this.tbxHasta.Size = new System.Drawing.Size(76, 22);
            this.tbxHasta.TabIndex = 85;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tempus Sans ITC", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(182, 115);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 18);
            this.label2.TabIndex = 86;
            this.label2.Text = "Fecha Desde";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tempus Sans ITC", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(278, 115);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 18);
            this.label3.TabIndex = 87;
            this.label3.Text = "Fecha Hasta";
            // 
            // btnGrabar
            // 
            this.btnGrabar.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrabar.ForeColor = System.Drawing.Color.DarkRed;
            this.btnGrabar.Location = new System.Drawing.Point(273, 245);
            this.btnGrabar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(75, 35);
            this.btnGrabar.TabIndex = 88;
            this.btnGrabar.Text = "GRABAR";
            this.btnGrabar.UseVisualStyleBackColor = true;
            // 
            // SolicitudAusencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 344);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxHasta);
            this.Controls.Add(this.tbxDesde);
            this.Controls.Add(this.mCalendar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxTipoAusencia);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "SolicitudAusencia";
            this.Text = "SolicitudAusencia";
            this.Load += new System.EventHandler(this.SolicitudAusencia_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbxTipoAusencia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MonthCalendar mCalendar;
        private System.Windows.Forms.TextBox tbxDesde;
        private System.Windows.Forms.TextBox tbxHasta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGrabar;
    }
}