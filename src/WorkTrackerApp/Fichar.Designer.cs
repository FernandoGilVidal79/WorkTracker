
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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcBoxReloj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnJornada
            // 
            this.btnJornada.Location = new System.Drawing.Point(59, 127);
            this.btnJornada.Name = "btnJornada";
            this.btnJornada.Size = new System.Drawing.Size(117, 32);
            this.btnJornada.TabIndex = 35;
            this.btnJornada.Text = "Jornada";
            this.btnJornada.UseVisualStyleBackColor = true;
            // 
            // btnComida
            // 
            this.btnComida.Location = new System.Drawing.Point(59, 178);
            this.btnComida.Name = "btnComida";
            this.btnComida.Size = new System.Drawing.Size(117, 32);
            this.btnComida.TabIndex = 36;
            this.btnComida.Text = "Comida";
            this.btnComida.UseVisualStyleBackColor = true;
            // 
            // btnDescanso1
            // 
            this.btnDescanso1.Location = new System.Drawing.Point(59, 237);
            this.btnDescanso1.Name = "btnDescanso1";
            this.btnDescanso1.Size = new System.Drawing.Size(117, 32);
            this.btnDescanso1.TabIndex = 37;
            this.btnDescanso1.Text = "Descanso 1";
            this.btnDescanso1.UseVisualStyleBackColor = true;
            // 
            // btnDescanso2
            // 
            this.btnDescanso2.Location = new System.Drawing.Point(59, 293);
            this.btnDescanso2.Name = "btnDescanso2";
            this.btnDescanso2.Size = new System.Drawing.Size(117, 32);
            this.btnDescanso2.TabIndex = 38;
            this.btnDescanso2.Text = "Descanso 2";
            this.btnDescanso2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(714, 214);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 42);
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
            this.lblHora.Location = new System.Drawing.Point(386, 95);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(0, 37);
            this.lblHora.TabIndex = 40;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblFecha.Location = new System.Drawing.Point(681, 108);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(0, 20);
            this.lblFecha.TabIndex = 41;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(538, 523);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(87, 34);
            this.btnOk.TabIndex = 42;
            this.btnOk.Text = "OK";
            this.btnOk.UseMnemonic = false;
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(322, 523);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(87, 34);
            this.btnCancel.TabIndex = 43;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseMnemonic = false;
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // pcBoxReloj
            // 
            this.pcBoxReloj.Image = global::WorkTrackerAPP.Properties.Resources.reloj;
            this.pcBoxReloj.Location = new System.Drawing.Point(322, 159);
            this.pcBoxReloj.Name = "pcBoxReloj";
            this.pcBoxReloj.Size = new System.Drawing.Size(303, 309);
            this.pcBoxReloj.TabIndex = 44;
            this.pcBoxReloj.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WorkTrackerAPP.Properties.Resources.Salir_Rojo;
            this.pictureBox2.Location = new System.Drawing.Point(929, 11);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(70, 70);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 34;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WorkTrackerAPP.Properties.Resources.Nombre;
            this.pictureBox1.Location = new System.Drawing.Point(297, 30);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(439, 51);
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // Fichar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 617);
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
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Fichar";
            this.Text = "Fichar";
            this.Load += new System.EventHandler(this.Fichar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcBoxReloj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
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