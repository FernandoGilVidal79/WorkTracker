
namespace WorkTrackerAPP
{
    partial class AprobacionSolicitudes
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbUsuarios = new System.Windows.Forms.ComboBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblUsuario = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 18);
            this.label1.TabIndex = 90;
            this.label1.Text = "Empleado";
            // 
            // cmbUsuarios
            // 
            this.cmbUsuarios.FormattingEnabled = true;
            this.cmbUsuarios.Location = new System.Drawing.Point(175, 15);
            this.cmbUsuarios.Name = "cmbUsuarios";
            this.cmbUsuarios.Size = new System.Drawing.Size(184, 26);
            this.cmbUsuarios.TabIndex = 101;
            this.cmbUsuarios.SelectedIndexChanged += new System.EventHandler(this.cmbUsuarios_SelectedIndexChanged);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnGuardar.Location = new System.Drawing.Point(832, 235);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(127, 47);
            this.btnGuardar.TabIndex = 102;
            this.btnGuardar.Text = "GRABAR";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id});
            this.dataGridView1.Location = new System.Drawing.Point(63, 51);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(895, 177);
            this.dataGridView1.TabIndex = 103;
            // 
            // Id
            // 
            this.Id.Frozen = true;
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 8;
            this.Id.Name = "Id";
            this.Id.Visible = false;
            this.Id.Width = 150;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(402, 19);
            this.lblUsuario.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(0, 18);
            this.lblUsuario.TabIndex = 104;
            // 
            // AprobacionSolicitudes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1000, 507);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.cmbUsuarios);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "AprobacionSolicitudes";
            this.Text = "AprobacionSolicitudes";
            this.Load += new System.EventHandler(this.AprobacionSolicitudes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbUsuarios;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.Label lblUsuario;
    }
}