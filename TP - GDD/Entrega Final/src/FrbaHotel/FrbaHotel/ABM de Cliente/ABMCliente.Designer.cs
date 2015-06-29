namespace FrbaHotel.ABM_de_Cliente
{
    partial class ABMCliente
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblCiudad = new System.Windows.Forms.Label();
            this.txtCiudad = new System.Windows.Forms.MaskedTextBox();
            this.txtNacionalidad = new System.Windows.Forms.MaskedTextBox();
            this.btnCalendario = new System.Windows.Forms.Button();
            this.calendNacimiento = new System.Windows.Forms.MonthCalendar();
            this.txtNacimiento = new System.Windows.Forms.MaskedTextBox();
            this.lblNacionalidad = new System.Windows.Forms.Label();
            this.lblPaisOr = new System.Windows.Forms.Label();
            this.txtPais = new System.Windows.Forms.MaskedTextBox();
            this.txtNumCalle = new System.Windows.Forms.MaskedTextBox();
            this.txtLocalidad = new System.Windows.Forms.MaskedTextBox();
            this.txtCalle = new System.Windows.Forms.MaskedTextBox();
            this.lblLocal = new System.Windows.Forms.Label();
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnHabDeshab = new System.Windows.Forms.Button();
            this.gpoBoxAlta.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(393, 387);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(98, 25);
            this.btnGuardar.TabIndex = 9;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(12, 386);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(79, 25);
            this.btnLimpiar.TabIndex = 8;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // gpoBoxAlta
            // 
            this.gpoBoxAlta.Controls.Add(this.label1);
            this.gpoBoxAlta.Controls.Add(this.lblCiudad);
            this.gpoBoxAlta.Controls.Add(this.txtCiudad);
            this.gpoBoxAlta.Controls.Add(this.txtNacionalidad);
            this.gpoBoxAlta.Controls.Add(this.btnCalendario);
            this.gpoBoxAlta.Controls.Add(this.calendNacimiento);
            this.gpoBoxAlta.Controls.Add(this.txtNacimiento);
            this.gpoBoxAlta.Controls.Add(this.lblNacionalidad);
            this.gpoBoxAlta.Controls.Add(this.lblPaisOr);
            this.gpoBoxAlta.Controls.Add(this.txtPais);
            this.gpoBoxAlta.Controls.Add(this.txtNumCalle);
            this.gpoBoxAlta.Controls.Add(this.txtLocalidad);
            this.gpoBoxAlta.Controls.Add(this.txtCalle);
            this.gpoBoxAlta.Controls.Add(this.lblLocal);
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
            this.gpoBoxAlta.Controls.Add(this.lblNombre);
            this.gpoBoxAlta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpoBoxAlta.Location = new System.Drawing.Point(12, 12);
            this.gpoBoxAlta.Name = "gpoBoxAlta";
            this.gpoBoxAlta.Size = new System.Drawing.Size(622, 368);
            this.gpoBoxAlta.TabIndex = 7;
            this.gpoBoxAlta.TabStop = false;
            this.gpoBoxAlta.Text = "Cliente nuevo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 20);
            this.label1.TabIndex = 35;
            this.label1.Text = "* Campos Obligatorios";
            // 
            // lblCiudad
            // 
            this.lblCiudad.AutoSize = true;
            this.lblCiudad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCiudad.Location = new System.Drawing.Point(9, 340);
            this.lblCiudad.Name = "lblCiudad";
            this.lblCiudad.Size = new System.Drawing.Size(73, 20);
            this.lblCiudad.TabIndex = 34;
            this.lblCiudad.Text = "* Ciudad:";
            // 
            // txtCiudad
            // 
            this.txtCiudad.Location = new System.Drawing.Point(96, 340);
            this.txtCiudad.Name = "txtCiudad";
            this.txtCiudad.Size = new System.Drawing.Size(273, 23);
            this.txtCiudad.TabIndex = 33;
            // 
            // txtNacionalidad
            // 
            this.txtNacionalidad.Location = new System.Drawing.Point(119, 311);
            this.txtNacionalidad.Name = "txtNacionalidad";
            this.txtNacionalidad.Size = new System.Drawing.Size(250, 23);
            this.txtNacionalidad.TabIndex = 32;
            // 
            // btnCalendario
            // 
            this.btnCalendario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalendario.Location = new System.Drawing.Point(275, 222);
            this.btnCalendario.Name = "btnCalendario";
            this.btnCalendario.Size = new System.Drawing.Size(94, 25);
            this.btnCalendario.TabIndex = 7;
            this.btnCalendario.Text = "Seleccionar";
            this.btnCalendario.UseVisualStyleBackColor = true;
            this.btnCalendario.Click += new System.EventHandler(this.btnCalendario_Click);
            // 
            // calendNacimiento
            // 
            this.calendNacimiento.Location = new System.Drawing.Point(381, 172);
            this.calendNacimiento.Name = "calendNacimiento";
            this.calendNacimiento.SelectionRange = new System.Windows.Forms.SelectionRange(new System.DateTime(1905, 1, 1, 0, 0, 0, 0), new System.DateTime(1905, 1, 7, 0, 0, 0, 0));
            this.calendNacimiento.TabIndex = 31;
            this.calendNacimiento.Visible = false;
            this.calendNacimiento.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.calendNacimiento_DateSelected);
            // 
            // txtNacimiento
            // 
            this.txtNacimiento.Enabled = false;
            this.txtNacimiento.Location = new System.Drawing.Point(176, 222);
            this.txtNacimiento.Mask = "00/00/0000";
            this.txtNacimiento.Name = "txtNacimiento";
            this.txtNacimiento.Size = new System.Drawing.Size(93, 23);
            this.txtNacimiento.TabIndex = 28;
            this.txtNacimiento.ValidatingType = typeof(System.DateTime);
            // 
            // lblNacionalidad
            // 
            this.lblNacionalidad.AutoSize = true;
            this.lblNacionalidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNacionalidad.Location = new System.Drawing.Point(9, 311);
            this.lblNacionalidad.Name = "lblNacionalidad";
            this.lblNacionalidad.Size = new System.Drawing.Size(104, 20);
            this.lblNacionalidad.TabIndex = 2;
            this.lblNacionalidad.Text = "Nacionalidad:";
            // 
            // lblPaisOr
            // 
            this.lblPaisOr.AutoSize = true;
            this.lblPaisOr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaisOr.Location = new System.Drawing.Point(9, 282);
            this.lblPaisOr.Name = "lblPaisOr";
            this.lblPaisOr.Size = new System.Drawing.Size(53, 20);
            this.lblPaisOr.TabIndex = 1;
            this.lblPaisOr.Text = "* Pais:";
            // 
            // txtPais
            // 
            this.txtPais.Location = new System.Drawing.Point(96, 282);
            this.txtPais.Name = "txtPais";
            this.txtPais.Size = new System.Drawing.Size(273, 23);
            this.txtPais.TabIndex = 12;
            // 
            // txtNumCalle
            // 
            this.txtNumCalle.Location = new System.Drawing.Point(307, 193);
            this.txtNumCalle.Mask = "000009";
            this.txtNumCalle.Name = "txtNumCalle";
            this.txtNumCalle.Size = new System.Drawing.Size(62, 23);
            this.txtNumCalle.TabIndex = 27;
            // 
            // txtLocalidad
            // 
            this.txtLocalidad.Location = new System.Drawing.Point(96, 253);
            this.txtLocalidad.Name = "txtLocalidad";
            this.txtLocalidad.Size = new System.Drawing.Size(273, 23);
            this.txtLocalidad.TabIndex = 10;
            // 
            // txtCalle
            // 
            this.txtCalle.Location = new System.Drawing.Point(134, 193);
            this.txtCalle.Name = "txtCalle";
            this.txtCalle.Size = new System.Drawing.Size(162, 23);
            this.txtCalle.TabIndex = 26;
            // 
            // lblLocal
            // 
            this.lblLocal.AutoSize = true;
            this.lblLocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocal.Location = new System.Drawing.Point(9, 253);
            this.lblLocal.Name = "lblLocal";
            this.lblLocal.Size = new System.Drawing.Size(81, 20);
            this.lblLocal.TabIndex = 0;
            this.lblLocal.Text = "Localidad:";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(90, 164);
            this.txtTelefono.Mask = "00-0000-0000";
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.ResetOnPrompt = false;
            this.txtTelefono.Size = new System.Drawing.Size(279, 23);
            this.txtTelefono.TabIndex = 25;
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(56, 135);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(313, 23);
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
            this.cboTipoDNI.Location = new System.Drawing.Point(190, 105);
            this.cboTipoDNI.Name = "cboTipoDNI";
            this.cboTipoDNI.Size = new System.Drawing.Size(79, 24);
            this.cboTipoDNI.TabIndex = 23;
            // 
            // txtNumDNI
            // 
            this.txtNumDNI.Location = new System.Drawing.Point(275, 106);
            this.txtNumDNI.Mask = "999999999";
            this.txtNumDNI.Name = "txtNumDNI";
            this.txtNumDNI.Size = new System.Drawing.Size(94, 23);
            this.txtNumDNI.TabIndex = 22;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(84, 76);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(285, 23);
            this.txtApellido.TabIndex = 21;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(84, 45);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(285, 23);
            this.txtNombre.TabIndex = 20;
            // 
            // lblNacido
            // 
            this.lblNacido.AutoSize = true;
            this.lblNacido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNacido.Location = new System.Drawing.Point(5, 222);
            this.lblNacido.Name = "lblNacido";
            this.lblNacido.Size = new System.Drawing.Size(171, 20);
            this.lblNacido.TabIndex = 18;
            this.lblNacido.Text = "* Fecha de nacimiento:";
            // 
            // lblDirecc
            // 
            this.lblDirecc.AutoSize = true;
            this.lblDirecc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDirecc.Location = new System.Drawing.Point(5, 193);
            this.lblDirecc.Name = "lblDirecc";
            this.lblDirecc.Size = new System.Drawing.Size(129, 20);
            this.lblDirecc.TabIndex = 17;
            this.lblDirecc.Text = "* Calle y Número:";
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTel.Location = new System.Drawing.Point(5, 164);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(85, 20);
            this.lblTel.TabIndex = 16;
            this.lblTel.Text = "* Teléfono:";
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMail.Location = new System.Drawing.Point(5, 135);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(51, 20);
            this.lblMail.TabIndex = 15;
            this.lblMail.Text = "* Mail:";
            // 
            // lblTipoDoc
            // 
            this.lblTipoDoc.AutoSize = true;
            this.lblTipoDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoDoc.Location = new System.Drawing.Point(5, 105);
            this.lblTipoDoc.Name = "lblTipoDoc";
            this.lblTipoDoc.Size = new System.Drawing.Size(185, 20);
            this.lblTipoDoc.TabIndex = 14;
            this.lblTipoDoc.Text = "* Tipo y Núm documento:";
            // 
            // lblApe
            // 
            this.lblApe.AutoSize = true;
            this.lblApe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApe.Location = new System.Drawing.Point(5, 76);
            this.lblApe.Name = "lblApe";
            this.lblApe.Size = new System.Drawing.Size(79, 20);
            this.lblApe.TabIndex = 13;
            this.lblApe.Text = "* Apellido:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(5, 45);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(79, 20);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "* Nombre:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(495, 387);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(137, 25);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar / Cerrar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnHabDeshab
            // 
            this.btnHabDeshab.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHabDeshab.Location = new System.Drawing.Point(287, 387);
            this.btnHabDeshab.Name = "btnHabDeshab";
            this.btnHabDeshab.Size = new System.Drawing.Size(100, 25);
            this.btnHabDeshab.TabIndex = 11;
            this.btnHabDeshab.UseVisualStyleBackColor = true;
            this.btnHabDeshab.Visible = false;
            this.btnHabDeshab.Click += new System.EventHandler(this.btnHabDeshab_Click);
            // 
            // ABMCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 424);
            this.Controls.Add(this.btnHabDeshab);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.gpoBoxAlta);
            this.Name = "ABMCliente";
            this.Text = "ABM Cliente";
            this.Load += new System.EventHandler(this.ABMCliente_Load);
            this.gpoBoxAlta.ResumeLayout(false);
            this.gpoBoxAlta.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.GroupBox gpoBoxAlta;
        private System.Windows.Forms.Button btnCalendario;
        private System.Windows.Forms.MonthCalendar calendNacimiento;
        private System.Windows.Forms.MaskedTextBox txtNacimiento;
        private System.Windows.Forms.MaskedTextBox txtNumCalle;
        private System.Windows.Forms.MaskedTextBox txtCalle;
        private System.Windows.Forms.MaskedTextBox txtTelefono;
        private System.Windows.Forms.MaskedTextBox txtMail;
        private System.Windows.Forms.ComboBox cboTipoDNI;
        private System.Windows.Forms.MaskedTextBox txtNumDNI;
        private System.Windows.Forms.MaskedTextBox txtApellido;
        private System.Windows.Forms.MaskedTextBox txtNombre;
        private System.Windows.Forms.Label lblNacido;
        private System.Windows.Forms.Label lblDirecc;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblTipoDoc;
        private System.Windows.Forms.Label lblApe;
        private System.Windows.Forms.MaskedTextBox txtPais;
        private System.Windows.Forms.MaskedTextBox txtLocalidad;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblLocal;
        private System.Windows.Forms.Label lblPaisOr;
        private System.Windows.Forms.Label lblNacionalidad;
        private System.Windows.Forms.MaskedTextBox txtNacionalidad;
        private System.Windows.Forms.Label lblCiudad;
        private System.Windows.Forms.MaskedTextBox txtCiudad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnHabDeshab;
    }
}