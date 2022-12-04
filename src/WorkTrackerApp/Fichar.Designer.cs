
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnDescanso = new System.Windows.Forms.Button();
            this.btnComida = new System.Windows.Forms.Button();
            this.btnJornada = new System.Windows.Forms.Button();
            this.lblHistorico = new System.Windows.Forms.Label();
            this.lblResumen = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.Window;
            this.splitContainer1.Panel1.Controls.Add(this.btnDescanso);
            this.splitContainer1.Panel1.Controls.Add(this.btnComida);
            this.splitContainer1.Panel1.Controls.Add(this.btnJornada);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AutoScroll = true;
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.Window;
            this.splitContainer1.Panel2.Controls.Add(this.lblHistorico);
            this.splitContainer1.Panel2.Controls.Add(this.lblResumen);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(1070, 529);
            this.splitContainer1.SplitterDistance = 343;
            this.splitContainer1.TabIndex = 38;
            // 
            // btnDescanso
            // 
            this.btnDescanso.Location = new System.Drawing.Point(46, 272);
            this.btnDescanso.Name = "btnDescanso";
            this.btnDescanso.Size = new System.Drawing.Size(242, 71);
            this.btnDescanso.TabIndex = 40;
            this.btnDescanso.Text = "Descanso";
            this.btnDescanso.UseVisualStyleBackColor = true;
            this.btnDescanso.Click += new System.EventHandler(this.btnDescanso_Click);
            // 
            // btnComida
            // 
            this.btnComida.Location = new System.Drawing.Point(46, 172);
            this.btnComida.Name = "btnComida";
            this.btnComida.Size = new System.Drawing.Size(242, 75);
            this.btnComida.TabIndex = 39;
            this.btnComida.Text = "Comida";
            this.btnComida.UseVisualStyleBackColor = true;
            this.btnComida.Click += new System.EventHandler(this.btnComida_Click);
            // 
            // btnJornada
            // 
            this.btnJornada.Location = new System.Drawing.Point(46, 83);
            this.btnJornada.Name = "btnJornada";
            this.btnJornada.Size = new System.Drawing.Size(242, 72);
            this.btnJornada.TabIndex = 38;
            this.btnJornada.Text = "Entrada";
            this.btnJornada.UseVisualStyleBackColor = true;
            this.btnJornada.Click += new System.EventHandler(this.btnJornada_Click);
            // 
            // lblHistorico
            // 
            this.lblHistorico.AutoSize = true;
            this.lblHistorico.Location = new System.Drawing.Point(86, 97);
            this.lblHistorico.Name = "lblHistorico";
            this.lblHistorico.Size = new System.Drawing.Size(113, 20);
            this.lblHistorico.TabIndex = 1;
            this.lblHistorico.Text = "No hay Fichaje";
            // 
            // lblResumen
            // 
            this.lblResumen.AccessibleRole = System.Windows.Forms.AccessibleRole.RowHeader;
            this.lblResumen.AutoSize = true;
            this.lblResumen.Location = new System.Drawing.Point(86, 43);
            this.lblResumen.Name = "lblResumen";
            this.lblResumen.Size = new System.Drawing.Size(177, 20);
            this.lblResumen.TabIndex = 0;
            this.lblResumen.Text = "Resumen de la semana";
            // 
            // Fichar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1070, 529);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Fichar";
            this.Text = "Fichar";
            this.Load += new System.EventHandler(this.Fichar_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnDescanso;
        private System.Windows.Forms.Button btnComida;
        private System.Windows.Forms.Button btnJornada;
        private System.Windows.Forms.Label lblResumen;
        private System.Windows.Forms.Label lblHistorico;
    }
}