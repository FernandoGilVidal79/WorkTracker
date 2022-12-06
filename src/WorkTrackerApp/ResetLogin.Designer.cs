
namespace WorkTrackerAPP
{
    partial class ResetLogin
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
            this.txtContraseniaActual = new System.Windows.Forms.TextBox();
            this.txtContraseniaNueva = new System.Windows.Forms.TextBox();
            this.lblContrasenia = new System.Windows.Forms.Label();
            this.lblContraseniaNueva = new System.Windows.Forms.Label();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.pcBoxLogo = new System.Windows.Forms.PictureBox();
            this.txtContraseniaNueva2 = new System.Windows.Forms.TextBox();
            this.lblContraseniaNueva2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pcBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // txtContraseniaActual
            // 
            this.txtContraseniaActual.Location = new System.Drawing.Point(219, 114);
            this.txtContraseniaActual.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtContraseniaActual.Name = "txtContraseniaActual";
            this.txtContraseniaActual.PasswordChar = '*';
            this.txtContraseniaActual.Size = new System.Drawing.Size(175, 20);
            this.txtContraseniaActual.TabIndex = 0;
            // 
            // txtContraseniaNueva
            // 
            this.txtContraseniaNueva.Location = new System.Drawing.Point(219, 146);
            this.txtContraseniaNueva.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtContraseniaNueva.Name = "txtContraseniaNueva";
            this.txtContraseniaNueva.PasswordChar = '*';
            this.txtContraseniaNueva.Size = new System.Drawing.Size(175, 20);
            this.txtContraseniaNueva.TabIndex = 1;
            // 
            // lblContrasenia
            // 
            this.lblContrasenia.AutoSize = true;
            this.lblContrasenia.Location = new System.Drawing.Point(118, 114);
            this.lblContrasenia.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblContrasenia.Name = "lblContrasenia";
            this.lblContrasenia.Size = new System.Drawing.Size(88, 13);
            this.lblContrasenia.TabIndex = 3;
            this.lblContrasenia.Text = "Contrseña Actual";
            // 
            // lblContraseniaNueva
            // 
            this.lblContraseniaNueva.AutoSize = true;
            this.lblContraseniaNueva.Location = new System.Drawing.Point(118, 146);
            this.lblContraseniaNueva.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblContraseniaNueva.Name = "lblContraseniaNueva";
            this.lblContraseniaNueva.Size = new System.Drawing.Size(90, 13);
            this.lblContraseniaNueva.TabIndex = 5;
            this.lblContraseniaNueva.Text = "Contrseña Nueva";
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(256, 227);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(90, 29);
            this.btnActualizar.TabIndex = 6;
            this.btnActualizar.Text = "ACTUALIZAR";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // pcBoxLogo
            // 
            this.pcBoxLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pcBoxLogo.Image = global::WorkTrackerAPP.Properties.Resources.Logo;
            this.pcBoxLogo.Location = new System.Drawing.Point(426, 9);
            this.pcBoxLogo.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.pcBoxLogo.MaximumSize = new System.Drawing.Size(215, 205);
            this.pcBoxLogo.Name = "pcBoxLogo";
            this.pcBoxLogo.Size = new System.Drawing.Size(155, 135);
            this.pcBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcBoxLogo.TabIndex = 7;
            this.pcBoxLogo.TabStop = false;
            // 
            // txtContraseniaNueva2
            // 
            this.txtContraseniaNueva2.Location = new System.Drawing.Point(219, 179);
            this.txtContraseniaNueva2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtContraseniaNueva2.Name = "txtContraseniaNueva2";
            this.txtContraseniaNueva2.PasswordChar = '*';
            this.txtContraseniaNueva2.Size = new System.Drawing.Size(175, 20);
            this.txtContraseniaNueva2.TabIndex = 2;
            this.txtContraseniaNueva2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidateEnterPress);
            // 
            // lblContraseniaNueva2
            // 
            this.lblContraseniaNueva2.AutoSize = true;
            this.lblContraseniaNueva2.Location = new System.Drawing.Point(118, 179);
            this.lblContraseniaNueva2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblContraseniaNueva2.Name = "lblContraseniaNueva2";
            this.lblContraseniaNueva2.Size = new System.Drawing.Size(95, 13);
            this.lblContraseniaNueva2.TabIndex = 9;
            this.lblContraseniaNueva2.Text = "Repita Contraseña";
            // 
            // ResetLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(600, 365);
            this.Controls.Add(this.lblContraseniaNueva2);
            this.Controls.Add(this.txtContraseniaNueva2);
            this.Controls.Add(this.pcBoxLogo);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.lblContraseniaNueva);
            this.Controls.Add(this.lblContrasenia);
            this.Controls.Add(this.txtContraseniaNueva);
            this.Controls.Add(this.txtContraseniaActual);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "ResetLogin";
            this.Text = "ResetLogin";
            this.Load += new System.EventHandler(this.ResetLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtContraseniaActual;
        private System.Windows.Forms.TextBox txtContraseniaNueva;
        private System.Windows.Forms.Label lblContrasenia;
        private System.Windows.Forms.Label lblContraseniaNueva;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.PictureBox pcBoxLogo;
        private System.Windows.Forms.TextBox txtContraseniaNueva2;
        private System.Windows.Forms.Label lblContraseniaNueva2;
    }
}