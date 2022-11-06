
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnFichar = new System.Windows.Forms.Button();
            this.btnCalendario = new System.Windows.Forms.Button();
            this.btnSolicitudes = new System.Windows.Forms.Button();
            this.btnSituacion = new System.Windows.Forms.Button();
            this.btnInformes = new System.Windows.Forms.Button();
            this.btnAprobaciones = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WorkTrackerAPP.Properties.Resources.Logo;
            this.pictureBox1.Location = new System.Drawing.Point(332, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnFichar
            // 
            this.btnFichar.Location = new System.Drawing.Point(304, 331);
            this.btnFichar.Name = "btnFichar";
            this.btnFichar.Size = new System.Drawing.Size(96, 53);
            this.btnFichar.TabIndex = 2;
            this.btnFichar.Text = "Fichar";
            this.btnFichar.UseVisualStyleBackColor = true;
            // 
            // btnCalendario
            // 
            this.btnCalendario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnCalendario.Location = new System.Drawing.Point(458, 331);
            this.btnCalendario.Name = "btnCalendario";
            this.btnCalendario.Size = new System.Drawing.Size(104, 53);
            this.btnCalendario.TabIndex = 3;
            this.btnCalendario.Text = "Calendario";
            this.btnCalendario.UseVisualStyleBackColor = true;
            // 
            // btnSolicitudes
            // 
            this.btnSolicitudes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnSolicitudes.Location = new System.Drawing.Point(304, 421);
            this.btnSolicitudes.Name = "btnSolicitudes";
            this.btnSolicitudes.Size = new System.Drawing.Size(96, 53);
            this.btnSolicitudes.TabIndex = 4;
            this.btnSolicitudes.Text = "Solicitudes";
            this.btnSolicitudes.UseVisualStyleBackColor = true;
            // 
            // btnSituacion
            // 
            this.btnSituacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSituacion.Location = new System.Drawing.Point(458, 421);
            this.btnSituacion.Name = "btnSituacion";
            this.btnSituacion.Size = new System.Drawing.Size(104, 53);
            this.btnSituacion.TabIndex = 5;
            this.btnSituacion.Text = "Situación";
            this.btnSituacion.UseVisualStyleBackColor = true;
            // 
            // btnInformes
            // 
            this.btnInformes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnInformes.Location = new System.Drawing.Point(304, 518);
            this.btnInformes.Name = "btnInformes";
            this.btnInformes.Size = new System.Drawing.Size(96, 53);
            this.btnInformes.TabIndex = 6;
            this.btnInformes.Text = "Informes";
            this.btnInformes.UseVisualStyleBackColor = true;
            // 
            // btnAprobaciones
            // 
            this.btnAprobaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnAprobaciones.Location = new System.Drawing.Point(458, 518);
            this.btnAprobaciones.Name = "btnAprobaciones";
            this.btnAprobaciones.Size = new System.Drawing.Size(104, 53);
            this.btnAprobaciones.TabIndex = 7;
            this.btnAprobaciones.Text = "Aprobaciones";
            this.btnAprobaciones.UseVisualStyleBackColor = true;
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 685);
            this.Controls.Add(this.btnAprobaciones);
            this.Controls.Add(this.btnInformes);
            this.Controls.Add(this.btnSituacion);
            this.Controls.Add(this.btnSolicitudes);
            this.Controls.Add(this.btnCalendario);
            this.Controls.Add(this.btnFichar);
            this.Controls.Add(this.pictureBox1);
            this.Name = "MenuPrincipal";
            this.Text = "Menú Principal";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnFichar;
        private System.Windows.Forms.Button btnCalendario;
        private System.Windows.Forms.Button btnSolicitudes;
        private System.Windows.Forms.Button btnSituacion;
        private System.Windows.Forms.Button btnInformes;
        private System.Windows.Forms.Button btnAprobaciones;
    }
}