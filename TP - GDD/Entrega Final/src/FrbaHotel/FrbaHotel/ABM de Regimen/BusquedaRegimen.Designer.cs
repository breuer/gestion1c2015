namespace FrbaHotel.ABM_de_Regimen
{
    partial class BusquedaRegimen
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
            this.txtPrecio = new System.Windows.Forms.MaskedTextBox();
            this.txtDescr = new System.Windows.Forms.MaskedTextBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lbldescr = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.gridRegimen = new System.Windows.Forms.DataGridView();
            this.Select = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.gpoBoxAlta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridRegimen)).BeginInit();
            this.SuspendLayout();
            // 
            // gpoBoxAlta
            // 
            this.gpoBoxAlta.Controls.Add(this.txtPrecio);
            this.gpoBoxAlta.Controls.Add(this.txtDescr);
            this.gpoBoxAlta.Controls.Add(this.lblPrecio);
            this.gpoBoxAlta.Controls.Add(this.lbldescr);
            this.gpoBoxAlta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpoBoxAlta.Location = new System.Drawing.Point(12, 12);
            this.gpoBoxAlta.Name = "gpoBoxAlta";
            this.gpoBoxAlta.Size = new System.Drawing.Size(552, 59);
            this.gpoBoxAlta.TabIndex = 12;
            this.gpoBoxAlta.TabStop = false;
            this.gpoBoxAlta.Text = "Filtros de búsqueda";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(365, 22);
            this.txtPrecio.Mask = "99999,99";
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(86, 23);
            this.txtPrecio.TabIndex = 24;
            // 
            // txtDescr
            // 
            this.txtDescr.Location = new System.Drawing.Point(110, 22);
            this.txtDescr.Name = "txtDescr";
            this.txtDescr.Size = new System.Drawing.Size(144, 23);
            this.txtDescr.TabIndex = 23;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(260, 25);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(99, 17);
            this.lblPrecio.TabIndex = 17;
            this.lblPrecio.Text = "Precio base:";
            // 
            // lbldescr
            // 
            this.lbldescr.AutoSize = true;
            this.lbldescr.Location = new System.Drawing.Point(6, 25);
            this.lbldescr.Name = "lbldescr";
            this.lbldescr.Size = new System.Drawing.Size(98, 17);
            this.lbldescr.TabIndex = 4;
            this.lbldescr.Text = "Descripción:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(465, 77);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(99, 23);
            this.btnBuscar.TabIndex = 11;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(12, 77);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(104, 23);
            this.btnLimpiar.TabIndex = 10;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // gridRegimen
            // 
            this.gridRegimen.AllowUserToDeleteRows = false;
            this.gridRegimen.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gridRegimen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridRegimen.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Select,
            this.Delete});
            this.gridRegimen.Location = new System.Drawing.Point(12, 106);
            this.gridRegimen.Name = "gridRegimen";
            this.gridRegimen.Size = new System.Drawing.Size(552, 339);
            this.gridRegimen.TabIndex = 9;
            this.gridRegimen.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Select
            // 
            this.Select.HeaderText = "";
            this.Select.Name = "Select";
            this.Select.Text = "Modificar";
            this.Select.ToolTipText = "Modificar";
            this.Select.UseColumnTextForButtonValue = true;
            this.Select.Width = 21;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "";
            this.Delete.Name = "Delete";
            this.Delete.Text = "Eliminar";
            this.Delete.ToolTipText = "Eliminar";
            this.Delete.UseColumnTextForButtonValue = true;
            this.Delete.Width = 21;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(234, 77);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(99, 23);
            this.btnNuevo.TabIndex = 13;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // BusquedaRegimen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 457);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.gpoBoxAlta);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.gridRegimen);
            this.Name = "BusquedaRegimen";
            this.Text = "BusquedaRegimen";
            this.Load += new System.EventHandler(this.BusquedaRegimen_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BusquedaRegimen_FormClosing);
            this.gpoBoxAlta.ResumeLayout(false);
            this.gpoBoxAlta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridRegimen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpoBoxAlta;
        private System.Windows.Forms.MaskedTextBox txtPrecio;
        private System.Windows.Forms.MaskedTextBox txtDescr;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lbldescr;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.DataGridView gridRegimen;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.DataGridViewButtonColumn Select;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;

    }
}