namespace FrbaHotel.ABM_de_Cliente
{
    partial class BusquedaCliente
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
            this.lblVariosUsers = new System.Windows.Forms.Label();
            this.txtDNI = new System.Windows.Forms.MaskedTextBox();
            this.txtMail = new System.Windows.Forms.MaskedTextBox();
            this.txtApellido = new System.Windows.Forms.MaskedTextBox();
            this.txtNombre = new System.Windows.Forms.MaskedTextBox();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblApell = new System.Windows.Forms.Label();
            this.cboTipo = new System.Windows.Forms.ComboBox();
            this.lblDNI = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.gridClientes = new System.Windows.Forms.DataGridView();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.Seleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.gpoBoxAlta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // gpoBoxAlta
            // 
            this.gpoBoxAlta.Controls.Add(this.lblVariosUsers);
            this.gpoBoxAlta.Controls.Add(this.txtDNI);
            this.gpoBoxAlta.Controls.Add(this.txtMail);
            this.gpoBoxAlta.Controls.Add(this.txtApellido);
            this.gpoBoxAlta.Controls.Add(this.txtNombre);
            this.gpoBoxAlta.Controls.Add(this.lblMail);
            this.gpoBoxAlta.Controls.Add(this.lblApell);
            this.gpoBoxAlta.Controls.Add(this.cboTipo);
            this.gpoBoxAlta.Controls.Add(this.lblDNI);
            this.gpoBoxAlta.Controls.Add(this.lblNombre);
            this.gpoBoxAlta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpoBoxAlta.Location = new System.Drawing.Point(12, 12);
            this.gpoBoxAlta.Name = "gpoBoxAlta";
            this.gpoBoxAlta.Size = new System.Drawing.Size(614, 126);
            this.gpoBoxAlta.TabIndex = 12;
            this.gpoBoxAlta.TabStop = false;
            this.gpoBoxAlta.Text = "Filtros de búsqueda";
            // 
            // lblVariosUsers
            // 
            this.lblVariosUsers.AutoSize = true;
            this.lblVariosUsers.Location = new System.Drawing.Point(23, 95);
            this.lblVariosUsers.Name = "lblVariosUsers";
            this.lblVariosUsers.Size = new System.Drawing.Size(519, 17);
            this.lblVariosUsers.TabIndex = 28;
            this.lblVariosUsers.Text = "Existen varios clientes con los datos ingresados. Por favor valide uno.";
            this.lblVariosUsers.Visible = false;
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(513, 60);
            this.txtDNI.Mask = "999999990";
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(88, 23);
            this.txtDNI.TabIndex = 27;
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(63, 60);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(160, 23);
            this.txtMail.TabIndex = 26;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(360, 31);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(241, 23);
            this.txtApellido.TabIndex = 24;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(81, 31);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(196, 23);
            this.txtNombre.TabIndex = 23;
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(6, 63);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(42, 17);
            this.lblMail.TabIndex = 18;
            this.lblMail.Text = "Mail:";
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
            // cboTipo
            // 
            this.cboTipo.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.cboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTipo.FormattingEnabled = true;
            this.cboTipo.Location = new System.Drawing.Point(435, 59);
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.Size = new System.Drawing.Size(72, 24);
            this.cboTipo.TabIndex = 14;
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Location = new System.Drawing.Point(229, 63);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(200, 17);
            this.lblDNI.TabIndex = 6;
            this.lblDNI.Text = "Tipo y núm de documento:";
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
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(520, 144);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(106, 23);
            this.btnBuscar.TabIndex = 11;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(12, 144);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(114, 23);
            this.btnLimpiar.TabIndex = 10;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // gridClientes
            // 
            this.gridClientes.AllowUserToDeleteRows = false;
            this.gridClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Seleccionar});
            this.gridClientes.Location = new System.Drawing.Point(12, 173);
            this.gridClientes.Name = "gridClientes";
            this.gridClientes.ReadOnly = true;
            this.gridClientes.Size = new System.Drawing.Size(614, 344);
            this.gridClientes.TabIndex = 9;
            this.gridClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridClientes_CellContentClick);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(244, 144);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(106, 23);
            this.btnNuevo.TabIndex = 18;
            this.btnNuevo.Text = "Nuevo Cliente";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // Seleccionar
            // 
            this.Seleccionar.HeaderText = "Select";
            this.Seleccionar.Name = "Seleccionar";
            this.Seleccionar.ReadOnly = true;
            // 
            // BusquedaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 529);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.gpoBoxAlta);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.gridClientes);
            this.Name = "BusquedaCliente";
            this.Text = "Busqueda de Clientes";
            this.Load += new System.EventHandler(this.BusquedaCliente_Load);
            this.gpoBoxAlta.ResumeLayout(false);
            this.gpoBoxAlta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridClientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpoBoxAlta;
        private System.Windows.Forms.MaskedTextBox txtDNI;
        private System.Windows.Forms.MaskedTextBox txtMail;
        private System.Windows.Forms.MaskedTextBox txtApellido;
        private System.Windows.Forms.MaskedTextBox txtNombre;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblApell;
        private System.Windows.Forms.ComboBox cboTipo;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.DataGridView gridClientes;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Label lblVariosUsers;
        private System.Windows.Forms.DataGridViewButtonColumn Seleccionar;
    }
}