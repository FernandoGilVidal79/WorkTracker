
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
            this.btnJornada = new System.Windows.Forms.Button();
            this.btnComida = new System.Windows.Forms.Button();
            this.btnDescanso = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnJornada
            // 
            this.btnJornada.Location = new System.Drawing.Point(58, 128);
            this.btnJornada.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnJornada.Name = "btnJornada";
            this.btnJornada.Size = new System.Drawing.Size(117, 32);
            this.btnJornada.TabIndex = 35;
            this.btnJornada.Text = "Entrada";
            this.btnJornada.UseVisualStyleBackColor = true;
            this.btnJornada.Click += new System.EventHandler(this.btnJornada_Click);
            // 
            // btnComida
            // 
            this.btnComida.Location = new System.Drawing.Point(58, 177);
            this.btnComida.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnComida.Name = "btnComida";
            this.btnComida.Size = new System.Drawing.Size(117, 32);
            this.btnComida.TabIndex = 36;
            this.btnComida.Text = "Comida";
            this.btnComida.UseVisualStyleBackColor = true;
            // 
            // btnDescanso
            // 
            this.btnDescanso.Location = new System.Drawing.Point(58, 226);
            this.btnDescanso.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDescanso.Name = "btnDescanso";
            this.btnDescanso.Size = new System.Drawing.Size(117, 32);
            this.btnDescanso.TabIndex = 37;
            this.btnDescanso.Text = "Descanso";
            this.btnDescanso.UseVisualStyleBackColor = true;
            // 
            // Fichar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 530);
            this.Controls.Add(this.btnDescanso);
            this.Controls.Add(this.btnComida);
            this.Controls.Add(this.btnJornada);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Fichar";
            this.Text = "Fichar";
            this.Load += new System.EventHandler(this.Fichar_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnJornada;
        private System.Windows.Forms.Button btnComida;
        private System.Windows.Forms.Button btnDescanso;
    }
}