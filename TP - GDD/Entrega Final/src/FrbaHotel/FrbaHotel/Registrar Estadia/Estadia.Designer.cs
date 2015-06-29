namespace FrbaHotel.Registrar_Estadia
{
    partial class Estadia
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
            this.btnChOut = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.gpoBoxAlta = new System.Windows.Forms.GroupBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPersonas = new System.Windows.Forms.Button();
            this.GridPersonas = new System.Windows.Forms.DataGridView();
            this.Seleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtNumReserva = new System.Windows.Forms.MaskedTextBox();
            this.lblNumRes = new System.Windows.Forms.Label();
            this.btnChIn = new System.Windows.Forms.Button();
            this.gpoBoxAlta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridPersonas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnChOut
            // 
            this.btnChOut.Enabled = false;
            this.btnChOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChOut.Location = new System.Drawing.Point(490, 314);
            this.btnChOut.Name = "btnChOut";
            this.btnChOut.Size = new System.Drawing.Size(99, 25);
            this.btnChOut.TabIndex = 12;
            this.btnChOut.Text = "Egreso";
            this.btnChOut.UseVisualStyleBackColor = true;
            this.btnChOut.Click += new System.EventHandler(this.btnChOut_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(12, 314);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(79, 25);
            this.btnLimpiar.TabIndex = 11;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // gpoBoxAlta
            // 
            this.gpoBoxAlta.Controls.Add(this.lblCantidad);
            this.gpoBoxAlta.Controls.Add(this.label1);
            this.gpoBoxAlta.Controls.Add(this.btnPersonas);
            this.gpoBoxAlta.Controls.Add(this.GridPersonas);
            this.gpoBoxAlta.Controls.Add(this.btnBuscar);
            this.gpoBoxAlta.Controls.Add(this.txtNumReserva);
            this.gpoBoxAlta.Controls.Add(this.lblNumRes);
            this.gpoBoxAlta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpoBoxAlta.Location = new System.Drawing.Point(12, 12);
            this.gpoBoxAlta.Name = "gpoBoxAlta";
            this.gpoBoxAlta.Size = new System.Drawing.Size(577, 296);
            this.gpoBoxAlta.TabIndex = 10;
            this.gpoBoxAlta.TabStop = false;
            this.gpoBoxAlta.Text = "Check In - Out";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(188, 261);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(18, 20);
            this.lblCantidad.TabIndex = 53;
            this.lblCantidad.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 261);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 20);
            this.label1.TabIndex = 52;
            this.label1.Text = "Faltan cargar pasajeros:";
            // 
            // btnPersonas
            // 
            this.btnPersonas.Enabled = false;
            this.btnPersonas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPersonas.Location = new System.Drawing.Point(224, 260);
            this.btnPersonas.Name = "btnPersonas";
            this.btnPersonas.Size = new System.Drawing.Size(186, 25);
            this.btnPersonas.TabIndex = 14;
            this.btnPersonas.Text = "Cargar Datos / Actualizar";
            this.btnPersonas.UseVisualStyleBackColor = true;
            this.btnPersonas.Click += new System.EventHandler(this.btnPersonas_Click);
            // 
            // GridPersonas
            // 
            this.GridPersonas.AllowUserToAddRows = false;
            this.GridPersonas.AllowUserToDeleteRows = false;
            this.GridPersonas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridPersonas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Seleccionar});
            this.GridPersonas.Location = new System.Drawing.Point(14, 97);
            this.GridPersonas.MultiSelect = false;
            this.GridPersonas.Name = "GridPersonas";
            this.GridPersonas.ReadOnly = true;
            this.GridPersonas.Size = new System.Drawing.Size(472, 153);
            this.GridPersonas.TabIndex = 51;
            this.GridPersonas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridPersonas_CellContentClick);
            // 
            // Seleccionar
            // 
            this.Seleccionar.HeaderText = "Informacion";
            this.Seleccionar.Name = "Seleccionar";
            this.Seleccionar.ReadOnly = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(269, 40);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(99, 25);
            this.btnBuscar.TabIndex = 13;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtNumReserva
            // 
            this.txtNumReserva.Location = new System.Drawing.Point(154, 40);
            this.txtNumReserva.Mask = "99999999";
            this.txtNumReserva.Name = "txtNumReserva";
            this.txtNumReserva.Size = new System.Drawing.Size(95, 23);
            this.txtNumReserva.TabIndex = 50;
            // 
            // lblNumRes
            // 
            this.lblNumRes.AutoSize = true;
            this.lblNumRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumRes.Location = new System.Drawing.Point(10, 40);
            this.lblNumRes.Name = "lblNumRes";
            this.lblNumRes.Size = new System.Drawing.Size(138, 20);
            this.lblNumRes.TabIndex = 41;
            this.lblNumRes.Text = "* Núm. de reserva:";
            // 
            // btnChIn
            // 
            this.btnChIn.Enabled = false;
            this.btnChIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChIn.Location = new System.Drawing.Point(385, 314);
            this.btnChIn.Name = "btnChIn";
            this.btnChIn.Size = new System.Drawing.Size(99, 25);
            this.btnChIn.TabIndex = 13;
            this.btnChIn.Text = "Ingreso";
            this.btnChIn.UseVisualStyleBackColor = true;
            this.btnChIn.Click += new System.EventHandler(this.btnChIn_Click);
            // 
            // Estadia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 350);
            this.Controls.Add(this.btnChIn);
            this.Controls.Add(this.btnChOut);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.gpoBoxAlta);
            this.Name = "Estadia";
            this.Text = "Estadia";
            this.gpoBoxAlta.ResumeLayout(false);
            this.gpoBoxAlta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridPersonas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnChOut;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.GroupBox gpoBoxAlta;
        private System.Windows.Forms.Label lblNumRes;
        private System.Windows.Forms.MaskedTextBox txtNumReserva;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView GridPersonas;
        private System.Windows.Forms.DataGridViewButtonColumn Seleccionar;
        private System.Windows.Forms.Button btnChIn;
        private System.Windows.Forms.Button btnPersonas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCantidad;
    }
}