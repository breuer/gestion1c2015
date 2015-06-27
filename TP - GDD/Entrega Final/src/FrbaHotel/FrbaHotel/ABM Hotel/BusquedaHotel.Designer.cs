namespace FrbaHotel.ABM_Hotel
{
    partial class BusquedaHotel
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
            this.numUpDnCantEstrellas = new System.Windows.Forms.NumericUpDown();
            this.txtPais = new System.Windows.Forms.MaskedTextBox();
            this.txtCiudad = new System.Windows.Forms.MaskedTextBox();
            this.txtNombre = new System.Windows.Forms.MaskedTextBox();
            this.lblPais = new System.Windows.Forms.Label();
            this.lblCiudad = new System.Windows.Forms.Label();
            this.lblCantEstrellas = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.gridHoteles = new System.Windows.Forms.DataGridView();
            this.Seleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.gpoBoxAlta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDnCantEstrellas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridHoteles)).BeginInit();
            this.SuspendLayout();
            // 
            // gpoBoxAlta
            // 
            this.gpoBoxAlta.Controls.Add(this.numUpDnCantEstrellas);
            this.gpoBoxAlta.Controls.Add(this.txtPais);
            this.gpoBoxAlta.Controls.Add(this.txtCiudad);
            this.gpoBoxAlta.Controls.Add(this.txtNombre);
            this.gpoBoxAlta.Controls.Add(this.lblPais);
            this.gpoBoxAlta.Controls.Add(this.lblCiudad);
            this.gpoBoxAlta.Controls.Add(this.lblCantEstrellas);
            this.gpoBoxAlta.Controls.Add(this.lblNombre);
            this.gpoBoxAlta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpoBoxAlta.Location = new System.Drawing.Point(12, 12);
            this.gpoBoxAlta.Name = "gpoBoxAlta";
            this.gpoBoxAlta.Size = new System.Drawing.Size(522, 99);
            this.gpoBoxAlta.TabIndex = 16;
            this.gpoBoxAlta.TabStop = false;
            this.gpoBoxAlta.Text = "Filtros de búsqueda";
            // 
            // numUpDnCantEstrellas
            // 
            this.numUpDnCantEstrellas.Location = new System.Drawing.Point(360, 62);
            this.numUpDnCantEstrellas.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numUpDnCantEstrellas.Name = "numUpDnCantEstrellas";
            this.numUpDnCantEstrellas.Size = new System.Drawing.Size(120, 23);
            this.numUpDnCantEstrellas.TabIndex = 27;
            // 
            // txtPais
            // 
            this.txtPais.Location = new System.Drawing.Point(63, 60);
            this.txtPais.Name = "txtPais";
            this.txtPais.Size = new System.Drawing.Size(160, 23);
            this.txtPais.TabIndex = 26;
            // 
            // txtCiudad
            // 
            this.txtCiudad.Location = new System.Drawing.Point(360, 31);
            this.txtCiudad.Name = "txtCiudad";
            this.txtCiudad.Size = new System.Drawing.Size(151, 23);
            this.txtCiudad.TabIndex = 24;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(81, 31);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(196, 23);
            this.txtNombre.TabIndex = 23;
            // 
            // lblPais
            // 
            this.lblPais.AutoSize = true;
            this.lblPais.Location = new System.Drawing.Point(6, 63);
            this.lblPais.Name = "lblPais";
            this.lblPais.Size = new System.Drawing.Size(44, 17);
            this.lblPais.TabIndex = 18;
            this.lblPais.Text = "Pais:";
            // 
            // lblCiudad
            // 
            this.lblCiudad.AutoSize = true;
            this.lblCiudad.Location = new System.Drawing.Point(283, 34);
            this.lblCiudad.Name = "lblCiudad";
            this.lblCiudad.Size = new System.Drawing.Size(63, 17);
            this.lblCiudad.TabIndex = 17;
            this.lblCiudad.Text = "Ciudad:";
            // 
            // lblCantEstrellas
            // 
            this.lblCantEstrellas.AutoSize = true;
            this.lblCantEstrellas.Location = new System.Drawing.Point(229, 63);
            this.lblCantEstrellas.Name = "lblCantEstrellas";
            this.lblCantEstrellas.Size = new System.Drawing.Size(119, 17);
            this.lblCantEstrellas.TabIndex = 6;
            this.lblCantEstrellas.Text = "Cant. Estrellas:";
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
            this.btnBuscar.Location = new System.Drawing.Point(428, 117);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(106, 23);
            this.btnBuscar.TabIndex = 15;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(12, 117);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(114, 23);
            this.btnLimpiar.TabIndex = 14;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(218, 117);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(106, 23);
            this.btnNuevo.TabIndex = 17;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // gridHoteles
            // 
            this.gridHoteles.AllowUserToDeleteRows = false;
            this.gridHoteles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gridHoteles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridHoteles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Seleccionar,
            this.Delete});
            this.gridHoteles.Location = new System.Drawing.Point(12, 146);
            this.gridHoteles.Name = "gridHoteles";
            this.gridHoteles.ReadOnly = true;
            this.gridHoteles.Size = new System.Drawing.Size(522, 346);
            this.gridHoteles.TabIndex = 18;
            this.gridHoteles.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridHoteles_CellContentClick);
            // 
            // Seleccionar
            // 
            this.Seleccionar.HeaderText = "";
            this.Seleccionar.Name = "Seleccionar";
            this.Seleccionar.ReadOnly = true;
            this.Seleccionar.Text = "Modificar";
            this.Seleccionar.ToolTipText = "Modificar";
            this.Seleccionar.UseColumnTextForButtonValue = true;
            this.Seleccionar.Width = 21;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "";
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Text = "Eliminar";
            this.Delete.ToolTipText = "Eliminar";
            this.Delete.UseColumnTextForButtonValue = true;
            this.Delete.Width = 21;
            // 
            // BusquedaHotel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 504);
            this.Controls.Add(this.gridHoteles);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.gpoBoxAlta);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnLimpiar);
            this.Name = "BusquedaHotel";
            this.Text = "Busqueda de Hotel";
            this.Load += new System.EventHandler(this.BusquedaHotel_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BusquedaHotel_FormClosing);
            this.gpoBoxAlta.ResumeLayout(false);
            this.gpoBoxAlta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDnCantEstrellas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridHoteles)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpoBoxAlta;
        private System.Windows.Forms.NumericUpDown numUpDnCantEstrellas;
        private System.Windows.Forms.MaskedTextBox txtCiudad;
        private System.Windows.Forms.MaskedTextBox txtNombre;
        private System.Windows.Forms.Label lblCiudad;
        private System.Windows.Forms.Label lblCantEstrellas;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.DataGridView gridHoteles;
        private System.Windows.Forms.DataGridViewButtonColumn Seleccionar;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.MaskedTextBox txtPais;
        private System.Windows.Forms.Label lblPais;

    }
}