﻿
namespace WorkTrackerAPP
{
    partial class Usuarios 
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtNumEmpleado = new System.Windows.Forms.TextBox();
            this.txtContrasena = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido1 = new System.Windows.Forms.TextBox();
            this.txtApellido2 = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtDepartamento = new System.Windows.Forms.TextBox();
            this.txtNumVacaciones = new System.Windows.Forms.TextBox();
            this.cmbTipoUsuario = new System.Windows.Forms.ComboBox();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.component11 = new WorkTrackerAPP.Helpers.Component1(this.components);
            this.btnGrabar2 = new WorkTrackerAPP.Helpers.BtnGrabar();
            this.btnGrabar1 = new WorkTrackerAPP.Helpers.BtnGrabar();
            this.btnNuevo = new WorkTrackerAPP.Helpers.BtnGrabar();
            this.btnBuscar = new WorkTrackerAPP.Helpers.BtnGrabar();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nº Empleado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Contraseña";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nombre";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 205);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 15);
            this.label10.TabIndex = 12;
            this.label10.Text = "Apellido 1";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 245);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 15);
            this.label9.TabIndex = 13;
            this.label9.Text = "Apellido 2";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(476, 292);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 15);
            this.label7.TabIndex = 14;
            this.label7.Text = "Telefono";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(476, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 15;
            this.label4.Text = "Tipo Usuario";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(476, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 15);
            this.label6.TabIndex = 16;
            this.label6.Text = "Departamento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(476, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 15);
            this.label5.TabIndex = 17;
            this.label5.Text = "Días Vacaciones";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(476, 253);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 15);
            this.label11.TabIndex = 18;
            this.label11.Text = "Activo (Y/N)";
            // 
            // txtNumEmpleado
            // 
            this.txtNumEmpleado.Location = new System.Drawing.Point(111, 30);
            this.txtNumEmpleado.Name = "txtNumEmpleado";
            this.txtNumEmpleado.Size = new System.Drawing.Size(141, 21);
            this.txtNumEmpleado.TabIndex = 0;
            this.txtNumEmpleado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidationNumber_KeyPress);
            // 
            // txtContrasena
            // 
            this.txtContrasena.Location = new System.Drawing.Point(91, 126);
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.PasswordChar = '*';
            this.txtContrasena.Size = new System.Drawing.Size(141, 21);
            this.txtContrasena.TabIndex = 2;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(91, 164);
            this.txtNombre.MaxLength = 50;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(305, 21);
            this.txtNombre.TabIndex = 3;
            // 
            // txtApellido1
            // 
            this.txtApellido1.Location = new System.Drawing.Point(91, 201);
            this.txtApellido1.MaxLength = 50;
            this.txtApellido1.Name = "txtApellido1";
            this.txtApellido1.Size = new System.Drawing.Size(305, 21);
            this.txtApellido1.TabIndex = 4;
            // 
            // txtApellido2
            // 
            this.txtApellido2.Location = new System.Drawing.Point(91, 241);
            this.txtApellido2.MaxLength = 50;
            this.txtApellido2.Name = "txtApellido2";
            this.txtApellido2.Size = new System.Drawing.Size(305, 21);
            this.txtApellido2.TabIndex = 5;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(573, 288);
            this.txtTelefono.MaxLength = 12;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(141, 21);
            this.txtTelefono.TabIndex = 24;
            this.txtTelefono.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidationNumber_KeyPress);
            // 
            // txtDepartamento
            // 
            this.txtDepartamento.Location = new System.Drawing.Point(573, 178);
            this.txtDepartamento.MaxLength = 50;
            this.txtDepartamento.Name = "txtDepartamento";
            this.txtDepartamento.Size = new System.Drawing.Size(141, 21);
            this.txtDepartamento.TabIndex = 26;
            // 
            // txtNumVacaciones
            // 
            this.txtNumVacaciones.Location = new System.Drawing.Point(573, 216);
            this.txtNumVacaciones.MaxLength = 2;
            this.txtNumVacaciones.Name = "txtNumVacaciones";
            this.txtNumVacaciones.Size = new System.Drawing.Size(51, 21);
            this.txtNumVacaciones.TabIndex = 27;
            this.txtNumVacaciones.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidationNumber_KeyPress);
            // 
            // cmbTipoUsuario
            // 
            this.cmbTipoUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoUsuario.FormattingEnabled = true;
            this.cmbTipoUsuario.Location = new System.Drawing.Point(573, 144);
            this.cmbTipoUsuario.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cmbTipoUsuario.Name = "cmbTipoUsuario";
            this.cmbTipoUsuario.Size = new System.Drawing.Size(113, 21);
            this.cmbTipoUsuario.TabIndex = 33;
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "Y",
            "N"});
            this.cmbStatus.Location = new System.Drawing.Point(573, 249);
            this.cmbStatus.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(41, 21);
            this.cmbStatus.TabIndex = 34;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(91, 284);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(305, 21);
            this.txtEmail.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 288);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 15);
            this.label8.TabIndex = 35;
            this.label8.Text = "Email";
            // 
            // btnGrabar2
            // 
            this.btnGrabar2.BackColor = System.Drawing.Color.Transparent;
            this.btnGrabar2.FlatAppearance.BorderSize = 0;
            this.btnGrabar2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGrabar2.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.btnGrabar2.Image = global::WorkTrackerAPP.Properties.Resources.comment_check;
            this.btnGrabar2.Location = new System.Drawing.Point(320, 26);
            this.btnGrabar2.Name = "btnGrabar2";
            this.btnGrabar2.Size = new System.Drawing.Size(35, 35);
            this.btnGrabar2.TabIndex = 43;
            this.btnGrabar2.UseVisualStyleBackColor = false;
            // 
            // btnGrabar1
            // 
            this.btnGrabar1.BackColor = System.Drawing.Color.Transparent;
            this.btnGrabar1.FlatAppearance.BorderSize = 0;
            this.btnGrabar1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGrabar1.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.btnGrabar1.Image = global::WorkTrackerAPP.Properties.Resources.cross_circle;
            this.btnGrabar1.Location = new System.Drawing.Point(390, 27);
            this.btnGrabar1.Name = "btnGrabar1";
            this.btnGrabar1.Size = new System.Drawing.Size(28, 34);
            this.btnGrabar1.TabIndex = 42;
            this.btnGrabar1.UseVisualStyleBackColor = false;
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.Transparent;
            this.btnNuevo.FlatAppearance.BorderSize = 0;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.btnNuevo.Image = global::WorkTrackerAPP.Properties.Resources.add1;
            this.btnNuevo.Location = new System.Drawing.Point(350, 26);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(46, 34);
            this.btnNuevo.TabIndex = 41;
            this.btnNuevo.UseVisualStyleBackColor = false;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.btnBuscar.Image = global::WorkTrackerAPP.Properties.Resources.search_alt;
            this.btnBuscar.Location = new System.Drawing.Point(278, 26);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(46, 34);
            this.btnBuscar.TabIndex = 40;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 450);
            this.Controls.Add(this.btnGrabar2);
            this.Controls.Add(this.btnGrabar1);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.cmbTipoUsuario);
            this.Controls.Add(this.txtNumVacaciones);
            this.Controls.Add(this.txtDepartamento);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtApellido2);
            this.Controls.Add(this.txtApellido1);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtContrasena);
            this.Controls.Add(this.txtNumEmpleado);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tempus Sans ITC", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Usuarios";
            this.Text = "U S U A R I O S";
            this.Load += new System.EventHandler(this.CreacionUsuarios_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtNumEmpleado;
        private System.Windows.Forms.TextBox txtContrasena;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido1;
        private System.Windows.Forms.TextBox txtApellido2;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtDepartamento;
        private System.Windows.Forms.TextBox txtNumVacaciones;
        private System.Windows.Forms.ComboBox cmbTipoUsuario;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label8;
        private Helpers.BtnGrabar btnBuscar;
        private Helpers.Component1 component11;
        private Helpers.BtnGrabar btnNuevo;
        private Helpers.BtnGrabar btnGrabar1;
        private Helpers.BtnGrabar btnGrabar2;
    }
}