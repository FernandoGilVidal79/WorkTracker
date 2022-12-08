
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fichar));
            this.btnDescanso = new System.Windows.Forms.Button();
            this.btnComida = new System.Windows.Forms.Button();
            this.lblResumen = new System.Windows.Forms.Label();
            this.btnJornada = new System.Windows.Forms.Button();
            this.lblHistorico = new System.Windows.Forms.Label();
            this.lblFichajeActual = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTComida = new System.Windows.Forms.Label();
            this.lblTDesc = new System.Windows.Forms.Label();
            this.lblTJornada = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDescanso
            // 
            this.btnDescanso.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDescanso.Image = ((System.Drawing.Image)(resources.GetObject("btnDescanso.Image")));
            this.btnDescanso.Location = new System.Drawing.Point(70, 279);
            this.btnDescanso.Name = "btnDescanso";
            this.btnDescanso.Size = new System.Drawing.Size(269, 64);
            this.btnDescanso.TabIndex = 44;
            this.btnDescanso.Text = "Descanso";
            this.btnDescanso.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDescanso.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDescanso.UseVisualStyleBackColor = true;
            this.btnDescanso.Click += new System.EventHandler(this.btnDescanso_Click);
            // 
            // btnComida
            // 
            this.btnComida.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComida.Image = ((System.Drawing.Image)(resources.GetObject("btnComida.Image")));
            this.btnComida.Location = new System.Drawing.Point(70, 189);
            this.btnComida.Name = "btnComida";
            this.btnComida.Size = new System.Drawing.Size(269, 67);
            this.btnComida.TabIndex = 43;
            this.btnComida.Text = "Comida";
            this.btnComida.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnComida.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnComida.UseVisualStyleBackColor = true;
            this.btnComida.Click += new System.EventHandler(this.btnComida_Click);
            // 
            // lblResumen
            // 
            this.lblResumen.AccessibleRole = System.Windows.Forms.AccessibleRole.RowHeader;
            this.lblResumen.AutoSize = true;
            this.lblResumen.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResumen.Location = new System.Drawing.Point(363, 33);
            this.lblResumen.Name = "lblResumen";
            this.lblResumen.Size = new System.Drawing.Size(170, 17);
            this.lblResumen.TabIndex = 41;
            this.lblResumen.Text = "Resumen de la semana";
            // 
            // btnJornada
            // 
            this.btnJornada.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJornada.Image = ((System.Drawing.Image)(resources.GetObject("btnJornada.Image")));
            this.btnJornada.Location = new System.Drawing.Point(70, 103);
            this.btnJornada.Name = "btnJornada";
            this.btnJornada.Size = new System.Drawing.Size(269, 65);
            this.btnJornada.TabIndex = 42;
            this.btnJornada.Text = "Entrada";
            this.btnJornada.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnJornada.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnJornada.UseVisualStyleBackColor = true;
            this.btnJornada.Click += new System.EventHandler(this.btnJornada_Click);
            // 
            // lblHistorico
            // 
            this.lblHistorico.AutoSize = true;
            this.lblHistorico.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHistorico.Location = new System.Drawing.Point(363, 103);
            this.lblHistorico.Name = "lblHistorico";
            this.lblHistorico.Size = new System.Drawing.Size(0, 17);
            this.lblHistorico.TabIndex = 45;
            // 
            // lblFichajeActual
            // 
            this.lblFichajeActual.AutoSize = true;
            this.lblFichajeActual.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFichajeActual.Location = new System.Drawing.Point(363, 77);
            this.lblFichajeActual.Name = "lblFichajeActual";
            this.lblFichajeActual.Size = new System.Drawing.Size(0, 17);
            this.lblFichajeActual.TabIndex = 46;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblTComida);
            this.groupBox1.Controls.Add(this.lblTDesc);
            this.groupBox1.Controls.Add(this.lblTJornada);
            this.groupBox1.Location = new System.Drawing.Point(696, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(269, 135);
            this.groupBox1.TabIndex = 47;
            this.groupBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Comida";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Descanso";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Jornada";
            // 
            // lblTComida
            // 
            this.lblTComida.AutoSize = true;
            this.lblTComida.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTComida.Location = new System.Drawing.Point(155, 106);
            this.lblTComida.Name = "lblTComida";
            this.lblTComida.Size = new System.Drawing.Size(64, 16);
            this.lblTComida.TabIndex = 2;
            this.lblTComida.Text = "TComida";
            // 
            // lblTDesc
            // 
            this.lblTDesc.AutoSize = true;
            this.lblTDesc.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTDesc.Location = new System.Drawing.Point(155, 63);
            this.lblTDesc.Name = "lblTDesc";
            this.lblTDesc.Size = new System.Drawing.Size(49, 16);
            this.lblTDesc.TabIndex = 1;
            this.lblTDesc.Text = "TDesc";
            // 
            // lblTJornada
            // 
            this.lblTJornada.AutoSize = true;
            this.lblTJornada.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTJornada.Location = new System.Drawing.Point(155, 23);
            this.lblTJornada.Name = "lblTJornada";
            this.lblTJornada.Size = new System.Drawing.Size(68, 16);
            this.lblTJornada.TabIndex = 0;
            this.lblTJornada.Text = "TJornada";
            // 
            // Fichar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1185, 684);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblFichajeActual);
            this.Controls.Add(this.lblHistorico);
            this.Controls.Add(this.btnDescanso);
            this.Controls.Add(this.btnComida);
            this.Controls.Add(this.lblResumen);
            this.Controls.Add(this.btnJornada);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.Name = "Fichar";
            this.Text = "Fichar";
            this.Load += new System.EventHandler(this.Fichar_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDescanso;
        private System.Windows.Forms.Button btnComida;
        private System.Windows.Forms.Label lblResumen;
        private System.Windows.Forms.Button btnJornada;
        private System.Windows.Forms.Label lblHistorico;
        private System.Windows.Forms.Label lblFichajeActual;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblTComida;
        private System.Windows.Forms.Label lblTDesc;
        private System.Windows.Forms.Label lblTJornada;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}