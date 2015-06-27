namespace FrbaHotel.ABM_de_Habitacion
{
    partial class BusquedaHabitacion
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
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblNum = new System.Windows.Forms.Label();
            this.gpoBoxAlta = new System.Windows.Forms.GroupBox();
            this.numHab = new System.Windows.Forms.NumericUpDown();
            this.cboTipo = new System.Windows.Forms.ComboBox();
            this.upDnPiso = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gridHabitaciones = new System.Windows.Forms.DataGridView();
            this.Seleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.gpoBoxAlta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numHab)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upDnPiso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridHabitaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(12, 99);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(114, 23);
            this.btnLimpiar.TabIndex = 1;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(482, 99);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(106, 23);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Location = new System.Drawing.Point(33, 39);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(69, 17);
            this.lblNum.TabIndex = 3;
            this.lblNum.Text = "Número:";
            // 
            // gpoBoxAlta
            // 
            this.gpoBoxAlta.Controls.Add(this.numHab);
            this.gpoBoxAlta.Controls.Add(this.cboTipo);
            this.gpoBoxAlta.Controls.Add(this.upDnPiso);
            this.gpoBoxAlta.Controls.Add(this.label3);
            this.gpoBoxAlta.Controls.Add(this.label1);
            this.gpoBoxAlta.Controls.Add(this.lblNum);
            this.gpoBoxAlta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpoBoxAlta.Location = new System.Drawing.Point(13, 12);
            this.gpoBoxAlta.Name = "gpoBoxAlta";
            this.gpoBoxAlta.Size = new System.Drawing.Size(575, 81);
            this.gpoBoxAlta.TabIndex = 4;
            this.gpoBoxAlta.TabStop = false;
            this.gpoBoxAlta.Text = "Filtros de búsqueda";
            // 
            // numHab
            // 
            this.numHab.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.numHab.Location = new System.Drawing.Point(108, 36);
            this.numHab.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.numHab.Name = "numHab";
            this.numHab.Size = new System.Drawing.Size(58, 23);
            this.numHab.TabIndex = 17;
            this.numHab.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            // 
            // cboTipo
            // 
            this.cboTipo.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.cboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTipo.FormattingEnabled = true;
            this.cboTipo.Location = new System.Drawing.Point(372, 36);
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.Size = new System.Drawing.Size(157, 24);
            this.cboTipo.TabIndex = 14;
            // 
            // upDnPiso
            // 
            this.upDnPiso.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.upDnPiso.Location = new System.Drawing.Point(243, 36);
            this.upDnPiso.Name = "upDnPiso";
            this.upDnPiso.Size = new System.Drawing.Size(58, 23);
            this.upDnPiso.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(321, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tipo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(193, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Piso:";
            // 
            // gridHabitaciones
            // 
            this.gridHabitaciones.AllowUserToDeleteRows = false;
            this.gridHabitaciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gridHabitaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridHabitaciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Seleccionar,
            this.Delete});
            this.gridHabitaciones.Location = new System.Drawing.Point(12, 128);
            this.gridHabitaciones.Name = "gridHabitaciones";
            this.gridHabitaciones.ReadOnly = true;
            this.gridHabitaciones.Size = new System.Drawing.Size(576, 429);
            this.gridHabitaciones.TabIndex = 18;
            this.gridHabitaciones.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(241, 99);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(89, 23);
            this.btnNuevo.TabIndex = 19;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // BusquedaHabitacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 569);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.gridHabitaciones);
            this.Controls.Add(this.gpoBoxAlta);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnLimpiar);
            this.Name = "BusquedaHabitacion";
            this.Text = "BusquedaHabitacion";
            this.Load += new System.EventHandler(this.BusquedaHabitacion_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BusquedaHabitacion_FormClosing);
            this.gpoBoxAlta.ResumeLayout(false);
            this.gpoBoxAlta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numHab)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upDnPiso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridHabitaciones)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.GroupBox gpoBoxAlta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboTipo;
        private System.Windows.Forms.NumericUpDown upDnPiso;
        private System.Windows.Forms.NumericUpDown numHab;
        private System.Windows.Forms.DataGridView gridHabitaciones;
        private System.Windows.Forms.DataGridViewButtonColumn Seleccionar;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.Button btnNuevo;
    }
}