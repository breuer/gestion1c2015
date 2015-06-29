namespace FrbaHotel.Generar_Modificar_Reserva
{
    partial class BusquedaReserva
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
            this.gpoBoxAlta = new System.Windows.Forms.GroupBox();
            this.txtDNI = new System.Windows.Forms.MaskedTextBox();
            this.txtMail = new System.Windows.Forms.MaskedTextBox();
            this.lblMail = new System.Windows.Forms.Label();
            this.cboTipo = new System.Windows.Forms.ComboBox();
            this.lblDNI = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.BtnConfirmar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.lblNombre = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblApell = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.MaskedTextBox();
            this.txtApellido = new System.Windows.Forms.MaskedTextBox();
            this.txtMailSel = new System.Windows.Forms.MaskedTextBox();
            this.txtDniSel = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTipoSel = new System.Windows.Forms.MaskedTextBox();
            this.gridPersonas = new System.Windows.Forms.DataGridView();
            this.Seleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblVariosUsers = new System.Windows.Forms.Label();
            this.gpoBoxAlta.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPersonas)).BeginInit();
            this.SuspendLayout();
            // 
            // gpoBoxAlta
            // 
            this.gpoBoxAlta.Controls.Add(this.lblVariosUsers);
            this.gpoBoxAlta.Controls.Add(this.txtDNI);
            this.gpoBoxAlta.Controls.Add(this.txtMail);
            this.gpoBoxAlta.Controls.Add(this.lblMail);
            this.gpoBoxAlta.Controls.Add(this.cboTipo);
            this.gpoBoxAlta.Controls.Add(this.lblDNI);
            this.gpoBoxAlta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpoBoxAlta.Location = new System.Drawing.Point(12, 12);
            this.gpoBoxAlta.Name = "gpoBoxAlta";
            this.gpoBoxAlta.Size = new System.Drawing.Size(614, 100);
            this.gpoBoxAlta.TabIndex = 16;
            this.gpoBoxAlta.TabStop = false;
            this.gpoBoxAlta.Text = "Filtros de búsqueda";
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(508, 27);
            this.txtDNI.Mask = "999999990";
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(88, 23);
            this.txtDNI.TabIndex = 27;
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(54, 27);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(160, 23);
            this.txtMail.TabIndex = 26;
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(6, 30);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(42, 17);
            this.lblMail.TabIndex = 18;
            this.lblMail.Text = "Mail:";
            // 
            // cboTipo
            // 
            this.cboTipo.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.cboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTipo.FormattingEnabled = true;
            this.cboTipo.Location = new System.Drawing.Point(426, 27);
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.Size = new System.Drawing.Size(72, 24);
            this.cboTipo.TabIndex = 14;
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Location = new System.Drawing.Point(220, 30);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(200, 17);
            this.lblDNI.TabIndex = 6;
            this.lblDNI.Text = "Tipo y núm de documento:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(519, 118);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(106, 23);
            this.btnBuscar.TabIndex = 15;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(11, 118);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(114, 23);
            this.btnLimpiar.TabIndex = 14;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // BtnConfirmar
            // 
            this.BtnConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConfirmar.Location = new System.Drawing.Point(494, 413);
            this.BtnConfirmar.Name = "BtnConfirmar";
            this.BtnConfirmar.Size = new System.Drawing.Size(131, 33);
            this.BtnConfirmar.TabIndex = 20;
            this.BtnConfirmar.Text = "Confirmar";
            this.BtnConfirmar.UseVisualStyleBackColor = true;
            this.BtnConfirmar.Click += new System.EventHandler(this.BtnConfirmar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(11, 423);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(124, 23);
            this.btnModificar.TabIndex = 19;
            this.btnModificar.Text = "Modificar Cliente";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(6, 34);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(69, 17);
            this.lblNombre.TabIndex = 4;
            this.lblNombre.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(220, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tipo y núm de documento:";
            // 
            // lblApell
            // 
            this.lblApell.AutoSize = true;
            this.lblApell.Location = new System.Drawing.Point(283, 34);
            this.lblApell.Name = "lblApell";
            this.lblApell.Size = new System.Drawing.Size(71, 17);
            this.lblApell.TabIndex = 17;
            this.lblApell.Text = "Apellido:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "Mail:";
            // 
            // txtNombre
            // 
            this.txtNombre.Enabled = false;
            this.txtNombre.Location = new System.Drawing.Point(81, 31);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(196, 23);
            this.txtNombre.TabIndex = 23;
            // 
            // txtApellido
            // 
            this.txtApellido.Enabled = false;
            this.txtApellido.Location = new System.Drawing.Point(360, 31);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(241, 23);
            this.txtApellido.TabIndex = 24;
            // 
            // txtMailSel
            // 
            this.txtMailSel.Enabled = false;
            this.txtMailSel.Location = new System.Drawing.Point(54, 60);
            this.txtMailSel.Name = "txtMailSel";
            this.txtMailSel.Size = new System.Drawing.Size(160, 23);
            this.txtMailSel.TabIndex = 26;
            // 
            // txtDniSel
            // 
            this.txtDniSel.Enabled = false;
            this.txtDniSel.Location = new System.Drawing.Point(513, 60);
            this.txtDniSel.Mask = "999999990";
            this.txtDniSel.Name = "txtDniSel";
            this.txtDniSel.Size = new System.Drawing.Size(88, 23);
            this.txtDniSel.TabIndex = 27;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTipoSel);
            this.groupBox1.Controls.Add(this.txtDniSel);
            this.groupBox1.Controls.Add(this.txtMailSel);
            this.groupBox1.Controls.Add(this.txtApellido);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblApell);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblNombre);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 308);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(614, 99);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cliente seleccionado";
            // 
            // txtTipoSel
            // 
            this.txtTipoSel.Enabled = false;
            this.txtTipoSel.Location = new System.Drawing.Point(415, 60);
            this.txtTipoSel.Name = "txtTipoSel";
            this.txtTipoSel.Size = new System.Drawing.Size(83, 23);
            this.txtTipoSel.TabIndex = 28;
            // 
            // gridPersonas
            // 
            this.gridPersonas.AllowUserToDeleteRows = false;
            this.gridPersonas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPersonas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Seleccionar});
            this.gridPersonas.Location = new System.Drawing.Point(12, 147);
            this.gridPersonas.Name = "gridPersonas";
            this.gridPersonas.ReadOnly = true;
            this.gridPersonas.Size = new System.Drawing.Size(614, 155);
            this.gridPersonas.TabIndex = 13;
            this.gridPersonas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridPersonas_CellContentClick);
            // 
            // Seleccionar
            // 
            this.Seleccionar.HeaderText = "Select";
            this.Seleccionar.Name = "Seleccionar";
            this.Seleccionar.ReadOnly = true;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(252, 118);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(106, 23);
            this.btnNuevo.TabIndex = 17;
            this.btnNuevo.Text = "Nuevo Cliente";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(357, 413);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(131, 33);
            this.btnCancelar.TabIndex = 29;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblVariosUsers
            // 
            this.lblVariosUsers.AutoSize = true;
            this.lblVariosUsers.Location = new System.Drawing.Point(6, 65);
            this.lblVariosUsers.Name = "lblVariosUsers";
            this.lblVariosUsers.Size = new System.Drawing.Size(519, 17);
            this.lblVariosUsers.TabIndex = 29;
            this.lblVariosUsers.Text = "Existen varios clientes con los datos ingresados. Por favor valide uno.";
            this.lblVariosUsers.Visible = false;
            // 
            // BusquedaReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 458);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.BtnConfirmar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.gpoBoxAlta);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.gridPersonas);
            this.Name = "BusquedaReserva";
            this.Text = "Busqueda para Reserva";
            this.Load += new System.EventHandler(this.BusquedaReserva_Load);
            this.gpoBoxAlta.ResumeLayout(false);
            this.gpoBoxAlta.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPersonas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpoBoxAlta;
        private System.Windows.Forms.MaskedTextBox txtDNI;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button BtnConfirmar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblApell;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txtNombre;
        private System.Windows.Forms.MaskedTextBox txtApellido;
        private System.Windows.Forms.MaskedTextBox txtMailSel;
        private System.Windows.Forms.MaskedTextBox txtDniSel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView gridPersonas;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.MaskedTextBox txtMail;
        private System.Windows.Forms.ComboBox cboTipo;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.MaskedTextBox txtTipoSel;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridViewButtonColumn Seleccionar;
        private System.Windows.Forms.Label lblVariosUsers;
    }
}