namespace FrbaHotel.Listado_Estadistico
{
    partial class ListadoEstadistico
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
            this.cboTrimestre = new System.Windows.Forms.ComboBox();
            this.txtAño = new System.Windows.Forms.MaskedTextBox();
            this.lblAño = new System.Windows.Forms.Label();
            this.cboTop5 = new System.Windows.Forms.ComboBox();
            this.lblDNI = new System.Windows.Forms.Label();
            this.lblTrimestre = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.gridEstadistica = new System.Windows.Forms.DataGridView();
            this.gpoBoxAlta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridEstadistica)).BeginInit();
            this.SuspendLayout();
            // 
            // gpoBoxAlta
            // 
            this.gpoBoxAlta.Controls.Add(this.cboTrimestre);
            this.gpoBoxAlta.Controls.Add(this.txtAño);
            this.gpoBoxAlta.Controls.Add(this.lblAño);
            this.gpoBoxAlta.Controls.Add(this.cboTop5);
            this.gpoBoxAlta.Controls.Add(this.lblDNI);
            this.gpoBoxAlta.Controls.Add(this.lblTrimestre);
            this.gpoBoxAlta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpoBoxAlta.Location = new System.Drawing.Point(12, 12);
            this.gpoBoxAlta.Name = "gpoBoxAlta";
            this.gpoBoxAlta.Size = new System.Drawing.Size(614, 110);
            this.gpoBoxAlta.TabIndex = 16;
            this.gpoBoxAlta.TabStop = false;
            this.gpoBoxAlta.Text = "Filtros obligatorios";
            // 
            // cboTrimestre
            // 
            this.cboTrimestre.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.cboTrimestre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTrimestre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTrimestre.FormattingEnabled = true;
            this.cboTrimestre.Items.AddRange(new object[] {
            "Primero",
            "Segundo",
            "Tercero",
            "Cuarto"});
            this.cboTrimestre.Location = new System.Drawing.Point(364, 31);
            this.cboTrimestre.Name = "cboTrimestre";
            this.cboTrimestre.Size = new System.Drawing.Size(95, 24);
            this.cboTrimestre.TabIndex = 28;
            // 
            // txtAño
            // 
            this.txtAño.Location = new System.Drawing.Point(167, 31);
            this.txtAño.Mask = "9999";
            this.txtAño.Name = "txtAño";
            this.txtAño.Size = new System.Drawing.Size(51, 23);
            this.txtAño.TabIndex = 27;
            // 
            // lblAño
            // 
            this.lblAño.AutoSize = true;
            this.lblAño.Location = new System.Drawing.Point(109, 34);
            this.lblAño.Name = "lblAño";
            this.lblAño.Size = new System.Drawing.Size(52, 17);
            this.lblAño.TabIndex = 18;
            this.lblAño.Text = "* Año:";
            // 
            // cboTop5
            // 
            this.cboTop5.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.cboTop5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTop5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTop5.FormattingEnabled = true;
            this.cboTop5.Items.AddRange(new object[] {
            "Hoteles con mayor cant. reservas canceladas",
            "Hoteles con mayor cant. consumibles facturados",
            "Hoteles con mayor cant. días fuera de servicio",
            "Habitaciones con mayor cant. de días y veces ocupadas",
            "Cliente con mayor cant. de puntos"});
            this.cboTop5.Location = new System.Drawing.Point(124, 74);
            this.cboTop5.Name = "cboTop5";
            this.cboTop5.Size = new System.Drawing.Size(423, 24);
            this.cboTop5.TabIndex = 14;
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Location = new System.Drawing.Point(25, 74);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(89, 17);
            this.lblDNI.TabIndex = 6;
            this.lblDNI.Text = "* Top 5 de:";
            // 
            // lblTrimestre
            // 
            this.lblTrimestre.AutoSize = true;
            this.lblTrimestre.Location = new System.Drawing.Point(265, 34);
            this.lblTrimestre.Name = "lblTrimestre";
            this.lblTrimestre.Size = new System.Drawing.Size(93, 17);
            this.lblTrimestre.TabIndex = 4;
            this.lblTrimestre.Text = "* Trimestre:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(520, 128);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(106, 23);
            this.btnBuscar.TabIndex = 15;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(12, 128);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(114, 23);
            this.btnLimpiar.TabIndex = 14;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // gridEstadistica
            // 
            this.gridEstadistica.AllowUserToDeleteRows = false;
            this.gridEstadistica.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gridEstadistica.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridEstadistica.Location = new System.Drawing.Point(12, 157);
            this.gridEstadistica.Name = "gridEstadistica";
            this.gridEstadistica.ReadOnly = true;
            this.gridEstadistica.Size = new System.Drawing.Size(614, 417);
            this.gridEstadistica.TabIndex = 13;
            // 
            // ListadoEstadistico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 586);
            this.Controls.Add(this.gpoBoxAlta);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.gridEstadistica);
            this.Name = "ListadoEstadistico";
            this.Text = "Listado Estadístico";
            this.gpoBoxAlta.ResumeLayout(false);
            this.gpoBoxAlta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridEstadistica)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpoBoxAlta;
        private System.Windows.Forms.ComboBox cboTrimestre;
        private System.Windows.Forms.MaskedTextBox txtAño;
        private System.Windows.Forms.Label lblAño;
        private System.Windows.Forms.ComboBox cboTop5;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.Label lblTrimestre;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.DataGridView gridEstadistica;

    }
}