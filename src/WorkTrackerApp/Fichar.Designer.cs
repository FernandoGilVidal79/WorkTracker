
namespace WorkTrackerAPP
{
    partial class Fichar
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
            this.btnJornada = new System.Windows.Forms.Button();
            this.btnComida = new System.Windows.Forms.Button();
            this.btnDescanso1 = new System.Windows.Forms.Button();
            this.btnDescanso2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblHora = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pcBoxReloj = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcBoxReloj)).BeginInit();
            this.SuspendLayout();
            // 
            // btnJornada
            // 
            this.btnJornada.Location = new System.Drawing.Point(52, 102);
            this.btnJornada.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnJornada.Name = "btnJornada";
            this.btnJornada.Size = new System.Drawing.Size(104, 26);
            this.btnJornada.TabIndex = 35;
            this.btnJornada.Text = "Jornada";
            this.btnJornada.UseVisualStyleBackColor = true;
            // 
            // btnComida
            // 
            this.btnComida.Location = new System.Drawing.Point(52, 142);
            this.btnComida.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnComida.Name = "btnComida";
            this.btnComida.Size = new System.Drawing.Size(104, 26);
            this.btnComida.TabIndex = 36;
            this.btnComida.Text = "Comida";
            this.btnComida.UseVisualStyleBackColor = true;
            // 
            // btnDescanso1
            // 
            this.btnDescanso1.Location = new System.Drawing.Point(52, 190);
            this.btnDescanso1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDescanso1.Name = "btnDescanso1";
            this.btnDescanso1.Size = new System.Drawing.Size(104, 26);
            this.btnDescanso1.TabIndex = 37;
            this.btnDescanso1.Text = "Descanso 1";
            this.btnDescanso1.UseVisualStyleBackColor = true;
            // 
            // btnDescanso2
            // 
            this.btnDescanso2.Location = new System.Drawing.Point(52, 234);
            this.btnDescanso2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDescanso2.Name = "btnDescanso2";
            this.btnDescanso2.Size = new System.Drawing.Size(104, 26);
            this.btnDescanso2.TabIndex = 38;
            this.btnDescanso2.Text = "Descanso 2";
            this.btnDescanso2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(635, 171);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(73, 34);
            this.button1.TabIndex = 39;
            this.button1.Text = "FICHAR";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.lblHora.Location = new System.Drawing.Point(343, 76);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(0, 46);
            this.lblHora.TabIndex = 40;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblFecha.Location = new System.Drawing.Point(605, 86);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(0, 25);
            this.lblFecha.TabIndex = 41;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(635, 240);
            this.btnOk.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(77, 27);
            this.btnOk.TabIndex = 42;
            this.btnOk.Text = "OK";
            this.btnOk.UseMnemonic = false;
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(635, 209);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(77, 27);
            this.btnCancel.TabIndex = 43;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseMnemonic = false;
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // pcBoxReloj
            // 
            this.pcBoxReloj.Image = global::WorkTrackerAPP.Properties.Resources.reloj;
            this.pcBoxReloj.Location = new System.Drawing.Point(286, 127);
            this.pcBoxReloj.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pcBoxReloj.Name = "pcBoxReloj";
            this.pcBoxReloj.Size = new System.Drawing.Size(269, 247);
            this.pcBoxReloj.TabIndex = 44;
            this.pcBoxReloj.TabStop = false;
            // 
            // Fichar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 424);
            this.Controls.Add(this.pcBoxReloj);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnDescanso2);
            this.Controls.Add(this.btnDescanso1);
            this.Controls.Add(this.btnComida);
            this.Controls.Add(this.btnJornada);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Fichar";
            this.Text = "Fichar";
            this.Load += new System.EventHandler(this.Fichar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcBoxReloj)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnJornada;
        private System.Windows.Forms.Button btnComida;
        private System.Windows.Forms.Button btnDescanso1;
        private System.Windows.Forms.Button btnDescanso2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.PictureBox pcBoxReloj;
    }
}