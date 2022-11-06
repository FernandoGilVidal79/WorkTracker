
namespace WorkTrackerAPP
{
    partial class MenuPrincipalAdmin
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
            this.btnInformesAdmin = new System.Windows.Forms.Button();
            this.btnErroresAdmin = new System.Windows.Forms.Button();
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
            // btnInformesAdmin
            // 
            this.btnInformesAdmin.Location = new System.Drawing.Point(304, 331);
            this.btnInformesAdmin.Name = "btnInformesAdmin";
            this.btnInformesAdmin.Size = new System.Drawing.Size(96, 53);
            this.btnInformesAdmin.TabIndex = 2;
            this.btnInformesAdmin.Text = "Informes";
            this.btnInformesAdmin.UseVisualStyleBackColor = true;
            // 
            // btnErroresAdmin
            // 
            this.btnErroresAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnErroresAdmin.Location = new System.Drawing.Point(458, 331);
            this.btnErroresAdmin.Name = "btnErroresAdmin";
            this.btnErroresAdmin.Size = new System.Drawing.Size(104, 53);
            this.btnErroresAdmin.TabIndex = 3;
            this.btnErroresAdmin.Text = "Errores";
            this.btnErroresAdmin.UseVisualStyleBackColor = true;
            // 
            // MenuPrincipalAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 685);
            this.Controls.Add(this.btnErroresAdmin);
            this.Controls.Add(this.btnInformesAdmin);
            this.Controls.Add(this.pictureBox1);
            this.Name = "MenuPrincipalAdmin";
            this.Text = "Menú Principal Admin";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnInformesAdmin;
        private System.Windows.Forms.Button btnErroresAdmin;
    }
}