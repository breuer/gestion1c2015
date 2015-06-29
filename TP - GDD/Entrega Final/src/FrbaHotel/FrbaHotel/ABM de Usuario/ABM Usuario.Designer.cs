namespace FrbaHotel.ABM_de_Usuario
{
    partial class ABMUser
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
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.gpoBoxAlta = new System.Windows.Forms.GroupBox();
            this.ckListRoles = new System.Windows.Forms.CheckedListBox();
            this.ckActivo = new System.Windows.Forms.CheckBox();
            this.btnCalendario = new System.Windows.Forms.Button();
            this.calendNacimiento = new System.Windows.Forms.MonthCalendar();
            this.txtNacimiento = new System.Windows.Forms.MaskedTextBox();
            this.txtNumCalle = new System.Windows.Forms.MaskedTextBox();
            this.txtCalle = new System.Windows.Forms.MaskedTextBox();
            this.txtTelefono = new System.Windows.Forms.MaskedTextBox();
            this.txtMail = new System.Windows.Forms.MaskedTextBox();
            this.cboTipoDNI = new System.Windows.Forms.ComboBox();
            this.txtNumDNI = new System.Windows.Forms.MaskedTextBox();
            this.txtApellido = new System.Windows.Forms.MaskedTextBox();
            this.txtNombre = new System.Windows.Forms.MaskedTextBox();
            this.lblNacido = new System.Windows.Forms.Label();
            this.lblDirecc = new System.Windows.Forms.Label();
            this.lblTel = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblTipoDoc = new System.Windows.Forms.Label();
            this.lblApe = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.MaskedTextBox();
            this.txtUser = new System.Windows.Forms.MaskedTextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblPersona = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblRol = new System.Windows.Forms.Label();
            this.gpoBoxAlta.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(587, 481);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(98, 25);
            this.btnGuardar.TabIndex = 6;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(12, 481);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(79, 25);
            this.btnLimpiar.TabIndex = 5;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // gpoBoxAlta
            // 
            this.gpoBoxAlta.Controls.Add(this.ckListRoles);
            this.gpoBoxAlta.Controls.Add(this.ckActivo);
            this.gpoBoxAlta.Controls.Add(this.btnCalendario);
            this.gpoBoxAlta.Controls.Add(this.calendNacimiento);
            this.gpoBoxAlta.Controls.Add(this.txtNacimiento);
            this.gpoBoxAlta.Controls.Add(this.txtNumCalle);
            this.gpoBoxAlta.Controls.Add(this.txtCalle);
            this.gpoBoxAlta.Controls.Add(this.txtTelefono);
            this.gpoBoxAlta.Controls.Add(this.txtMail);
            this.gpoBoxAlta.Controls.Add(this.cboTipoDNI);
            this.gpoBoxAlta.Controls.Add(this.txtNumDNI);
            this.gpoBoxAlta.Controls.Add(this.txtApellido);
            this.gpoBoxAlta.Controls.Add(this.txtNombre);
            this.gpoBoxAlta.Controls.Add(this.lblNacido);
            this.gpoBoxAlta.Controls.Add(this.lblDirecc);
            this.gpoBoxAlta.Controls.Add(this.lblTel);
            this.gpoBoxAlta.Controls.Add(this.lblMail);
            this.gpoBoxAlta.Controls.Add(this.lblTipoDoc);
            this.gpoBoxAlta.Controls.Add(this.lblApe);
            this.gpoBoxAlta.Controls.Add(this.txtPassword);
            this.gpoBoxAlta.Controls.Add(this.txtUser);
            this.gpoBoxAlta.Controls.Add(this.lblNombre);
            this.gpoBoxAlta.Controls.Add(this.lblPersona);
            this.gpoBoxAlta.Controls.Add(this.lblUser);
            this.gpoBoxAlta.Controls.Add(this.lblPassword);
            this.gpoBoxAlta.Controls.Add(this.lblRol);
            this.gpoBoxAlta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpoBoxAlta.Location = new System.Drawing.Point(12, 12);
            this.gpoBoxAlta.Name = "gpoBoxAlta";
            this.gpoBoxAlta.Size = new System.Drawing.Size(673, 463);
            this.gpoBoxAlta.TabIndex = 4;
            this.gpoBoxAlta.TabStop = false;
            this.gpoBoxAlta.Text = "Usuario";
            // 
            // ckListRoles
            // 
            this.ckListRoles.FormattingEnabled = true;
            this.ckListRoles.Location = new System.Drawing.Point(104, 322);
            this.ckListRoles.Name = "ckListRoles";
            this.ckListRoles.Size = new System.Drawing.Size(228, 130);
            this.ckListRoles.TabIndex = 41;
            // 
            // ckActivo
            // 
            this.ckActivo.AutoSize = true;
            this.ckActivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckActivo.Location = new System.Drawing.Point(404, 66);
            this.ckActivo.Name = "ckActivo";
            this.ckActivo.Size = new System.Drawing.Size(71, 24);
            this.ckActivo.TabIndex = 33;
            this.ckActivo.Text = "Activo";
            this.ckActivo.UseVisualStyleBackColor = true;
            // 
            // btnCalendario
            // 
            this.btnCalendario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalendario.Location = new System.Drawing.Point(329, 279);
            this.btnCalendario.Name = "btnCalendario";
            this.btnCalendario.Size = new System.Drawing.Size(94, 25);
            this.btnCalendario.TabIndex = 7;
            this.btnCalendario.Text = "Seleccionar";
            this.btnCalendario.UseVisualStyleBackColor = true;
            this.btnCalendario.Click += new System.EventHandler(this.btnCalendario_Click);
            // 
            // calendNacimiento
            // 
            this.calendNacimiento.Location = new System.Drawing.Point(435, 203);
            this.calendNacimiento.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.calendNacimiento.Name = "calendNacimiento";
            this.calendNacimiento.TabIndex = 31;
            this.calendNacimiento.Visible = false;
            this.calendNacimiento.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.calendNacimiento_DateSelected);
            // 
            // txtNacimiento
            // 
            this.txtNacimiento.Enabled = false;
            this.txtNacimiento.Location = new System.Drawing.Point(210, 279);
            this.txtNacimiento.Mask = "00/00/0000";
            this.txtNacimiento.Name = "txtNacimiento";
            this.txtNacimiento.Size = new System.Drawing.Size(93, 23);
            this.txtNacimiento.TabIndex = 28;
            this.txtNacimiento.ValidatingType = typeof(System.DateTime);
            // 
            // txtNumCalle
            // 
            this.txtNumCalle.Location = new System.Drawing.Point(361, 235);
            this.txtNumCalle.Mask = "000009";
            this.txtNumCalle.Name = "txtNumCalle";
            this.txtNumCalle.Size = new System.Drawing.Size(62, 23);
            this.txtNumCalle.TabIndex = 27;
            // 
            // txtCalle
            // 
            this.txtCalle.Location = new System.Drawing.Point(154, 235);
            this.txtCalle.Name = "txtCalle";
            this.txtCalle.Size = new System.Drawing.Size(197, 23);
            this.txtCalle.TabIndex = 26;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(438, 163);
            this.txtTelefono.Mask = "00-0000-0000";
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(112, 23);
            this.txtTelefono.TabIndex = 25;
            // 
            // txtMail
            // 
            this.txtMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMail.Location = new System.Drawing.Point(404, 134);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(258, 21);
            this.txtMail.TabIndex = 24;
            // 
            // cboTipoDNI
            // 
            this.cboTipoDNI.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.cboTipoDNI.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTipoDNI.FormattingEnabled = true;
            this.cboTipoDNI.Items.AddRange(new object[] {
            "Exterior",
            "Interior"});
            this.cboTipoDNI.Location = new System.Drawing.Point(210, 202);
            this.cboTipoDNI.Name = "cboTipoDNI";
            this.cboTipoDNI.Size = new System.Drawing.Size(122, 24);
            this.cboTipoDNI.TabIndex = 23;
            // 
            // txtNumDNI
            // 
            this.txtNumDNI.Location = new System.Drawing.Point(338, 202);
            this.txtNumDNI.Mask = "99999999";
            this.txtNumDNI.Name = "txtNumDNI";
            this.txtNumDNI.Size = new System.Drawing.Size(85, 23);
            this.txtNumDNI.TabIndex = 22;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(104, 166);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(247, 23);
            this.txtApellido.TabIndex = 21;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(104, 134);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(247, 23);
            this.txtNombre.TabIndex = 20;
            // 
            // lblNacido
            // 
            this.lblNacido.AutoSize = true;
            this.lblNacido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNacido.Location = new System.Drawing.Point(29, 280);
            this.lblNacido.Name = "lblNacido";
            this.lblNacido.Size = new System.Drawing.Size(161, 20);
            this.lblNacido.TabIndex = 18;
            this.lblNacido.Text = "Fecha de nacimiento:";
            // 
            // lblDirecc
            // 
            this.lblDirecc.AutoSize = true;
            this.lblDirecc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDirecc.Location = new System.Drawing.Point(29, 235);
            this.lblDirecc.Name = "lblDirecc";
            this.lblDirecc.Size = new System.Drawing.Size(119, 20);
            this.lblDirecc.TabIndex = 17;
            this.lblDirecc.Text = "Calle y Número:";
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTel.Location = new System.Drawing.Point(357, 166);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(75, 20);
            this.lblTel.TabIndex = 16;
            this.lblTel.Text = "Teléfono:";
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMail.Location = new System.Drawing.Point(357, 134);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(41, 20);
            this.lblMail.TabIndex = 15;
            this.lblMail.Text = "Mail:";
            // 
            // lblTipoDoc
            // 
            this.lblTipoDoc.AutoSize = true;
            this.lblTipoDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoDoc.Location = new System.Drawing.Point(29, 203);
            this.lblTipoDoc.Name = "lblTipoDoc";
            this.lblTipoDoc.Size = new System.Drawing.Size(175, 20);
            this.lblTipoDoc.TabIndex = 14;
            this.lblTipoDoc.Text = "Tipo y Núm documento:";
            // 
            // lblApe
            // 
            this.lblApe.AutoSize = true;
            this.lblApe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApe.Location = new System.Drawing.Point(29, 169);
            this.lblApe.Name = "lblApe";
            this.lblApe.Size = new System.Drawing.Size(69, 20);
            this.lblApe.TabIndex = 13;
            this.lblApe.Text = "Apellido:";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(99, 67);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(290, 23);
            this.txtPassword.TabIndex = 12;
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(99, 30);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(290, 23);
            this.txtUser.TabIndex = 10;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(29, 134);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(69, 20);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblPersona
            // 
            this.lblPersona.AutoSize = true;
            this.lblPersona.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersona.Location = new System.Drawing.Point(6, 103);
            this.lblPersona.Name = "lblPersona";
            this.lblPersona.Size = new System.Drawing.Size(166, 20);
            this.lblPersona.TabIndex = 4;
            this.lblPersona.Text = "* Datos de la persona:";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(6, 33);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(97, 20);
            this.lblUser.TabIndex = 0;
            this.lblUser.Text = "* Username:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(6, 67);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(92, 20);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "* Password:";
            // 
            // lblRol
            // 
            this.lblRol.AutoSize = true;
            this.lblRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRol.Location = new System.Drawing.Point(34, 322);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(64, 20);
            this.lblRol.TabIndex = 2;
            this.lblRol.Text = "* Roles:";
            // 
            // ABMUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 521);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.gpoBoxAlta);
            this.Name = "ABMUser";
            this.Text = "ABM Usuario";
            this.Load += new System.EventHandler(this.ABMUser_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ABMUser_FormClosing);
            this.gpoBoxAlta.ResumeLayout(false);
            this.gpoBoxAlta.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.GroupBox gpoBoxAlta;
        private System.Windows.Forms.Label lblApe;
        private System.Windows.Forms.MaskedTextBox txtPassword;
        private System.Windows.Forms.MaskedTextBox txtUser;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblPersona;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblRol;
        private System.Windows.Forms.MaskedTextBox txtNumDNI;
        private System.Windows.Forms.MaskedTextBox txtApellido;
        private System.Windows.Forms.MaskedTextBox txtNombre;
        private System.Windows.Forms.Label lblNacido;
        private System.Windows.Forms.Label lblDirecc;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblTipoDoc;
        private System.Windows.Forms.ComboBox cboTipoDNI;
        private System.Windows.Forms.MaskedTextBox txtNacimiento;
        private System.Windows.Forms.MaskedTextBox txtNumCalle;
        private System.Windows.Forms.MaskedTextBox txtCalle;
        private System.Windows.Forms.MaskedTextBox txtTelefono;
        private System.Windows.Forms.MaskedTextBox txtMail;
        private System.Windows.Forms.Button btnCalendario;
        private System.Windows.Forms.MonthCalendar calendNacimiento;
        private System.Windows.Forms.CheckBox ckActivo;
        private System.Windows.Forms.CheckedListBox ckListRoles;

    }
}