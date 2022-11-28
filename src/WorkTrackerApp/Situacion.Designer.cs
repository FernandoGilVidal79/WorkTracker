
namespace WorkTrackerAPP
{
    partial class Situacion
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
            this.cmbAño = new System.Windows.Forms.ComboBox();
            this.labAño = new System.Windows.Forms.Label();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.txbVacaciones = new System.Windows.Forms.TextBox();
            this.btnAplicar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAprobados = new System.Windows.Forms.Label();
            this.lblPendientesAprobar = new System.Windows.Forms.Label();
            this.lblSolicitados = new System.Windows.Forms.Label();
            this.lblTipoAusencia = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbAño
            // 
            this.cmbAño.Font = new System.Drawing.Font("Tempus Sans ITC", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAño.FormattingEnabled = true;
            this.cmbAño.Location = new System.Drawing.Point(551, 55);
            this.cmbAño.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbAño.Name = "cmbAño";
            this.cmbAño.Size = new System.Drawing.Size(71, 25);
            this.cmbAño.TabIndex = 82;
            // 
            // labAño
            // 
            this.labAño.AutoSize = true;
            this.labAño.Font = new System.Drawing.Font("Tempus Sans ITC", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labAño.Location = new System.Drawing.Point(484, 55);
            this.labAño.Name = "labAño";
            this.labAño.Size = new System.Drawing.Size(43, 22);
            this.labAño.TabIndex = 83;
            this.labAño.Text = "Año";
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Font = new System.Drawing.Font("Tempus Sans ITC", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldo.Location = new System.Drawing.Point(274, 92);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(253, 22);
            this.lblSaldo.TabIndex = 87;
            this.lblSaldo.Text = "Vacaciones pendientes de disfrutar";
            // 
            // txbVacaciones
            // 
            this.txbVacaciones.Location = new System.Drawing.Point(551, 92);
            this.txbVacaciones.Name = "txbVacaciones";
            this.txbVacaciones.Size = new System.Drawing.Size(71, 22);
            this.txbVacaciones.TabIndex = 88;
            // 
            // btnAplicar
            // 
            this.btnAplicar.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAplicar.ForeColor = System.Drawing.Color.DarkRed;
            this.btnAplicar.Location = new System.Drawing.Point(655, 44);
            this.btnAplicar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAplicar.Name = "btnAplicar";
            this.btnAplicar.Size = new System.Drawing.Size(112, 43);
            this.btnAplicar.TabIndex = 98;
            this.btnAplicar.Text = "APLICAR";
            this.btnAplicar.UseVisualStyleBackColor = true;
            this.btnAplicar.Click += new System.EventHandler(this.btnAplicar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tempus Sans ITC", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(594, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 22);
            this.label1.TabIndex = 97;
            this.label1.Text = "Días rechazados";
            // 
            // lblAprobados
            // 
            this.lblAprobados.AutoSize = true;
            this.lblAprobados.Font = new System.Drawing.Font("Tempus Sans ITC", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAprobados.Location = new System.Drawing.Point(484, 146);
            this.lblAprobados.Name = "lblAprobados";
            this.lblAprobados.Size = new System.Drawing.Size(115, 22);
            this.lblAprobados.TabIndex = 91;
            this.lblAprobados.Text = "Días aprobados";
            // 
            // lblPendientesAprobar
            // 
            this.lblPendientesAprobar.AutoSize = true;
            this.lblPendientesAprobar.Font = new System.Drawing.Font("Tempus Sans ITC", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPendientesAprobar.Location = new System.Drawing.Point(357, 146);
            this.lblPendientesAprobar.Name = "lblPendientesAprobar";
            this.lblPendientesAprobar.Size = new System.Drawing.Size(129, 22);
            this.lblPendientesAprobar.TabIndex = 90;
            this.lblPendientesAprobar.Text = "Días para aprobar";
            // 
            // lblSolicitados
            // 
            this.lblSolicitados.AutoSize = true;
            this.lblSolicitados.Font = new System.Drawing.Font("Tempus Sans ITC", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSolicitados.Location = new System.Drawing.Point(245, 146);
            this.lblSolicitados.Name = "lblSolicitados";
            this.lblSolicitados.Size = new System.Drawing.Size(115, 22);
            this.lblSolicitados.TabIndex = 89;
            this.lblSolicitados.Text = "Días solicitados";
            // 
            // lblTipoAusencia
            // 
            this.lblTipoAusencia.AutoSize = true;
            this.lblTipoAusencia.Font = new System.Drawing.Font("Tempus Sans ITC", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoAusencia.Location = new System.Drawing.Point(47, 146);
            this.lblTipoAusencia.Name = "lblTipoAusencia";
            this.lblTipoAusencia.Size = new System.Drawing.Size(111, 22);
            this.lblTipoAusencia.TabIndex = 95;
            this.lblTipoAusencia.Text = "Tipo Ausencia";
            this.lblTipoAusencia.Click += new System.EventHandler(this.lblVacaciones_Click);
            // 
            // Situacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAplicar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTipoAusencia);
            this.Controls.Add(this.lblAprobados);
            this.Controls.Add(this.lblPendientesAprobar);
            this.Controls.Add(this.lblSolicitados);
            this.Controls.Add(this.txbVacaciones);
            this.Controls.Add(this.lblSaldo);
            this.Controls.Add(this.labAño);
            this.Controls.Add(this.cmbAño);
            this.Name = "Situacion";
            this.Text = "Situacion";
            this.Load += new System.EventHandler(this.Situacion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbAño;
        private System.Windows.Forms.Label labAño;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.TextBox txbVacaciones;
        private System.Windows.Forms.Button btnAplicar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAprobados;
        private System.Windows.Forms.Label lblPendientesAprobar;
        private System.Windows.Forms.Label lblSolicitados;
        private System.Windows.Forms.Label lblTipoAusencia;
    }
}