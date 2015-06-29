namespace FrbaHotel.ABM_de_Habitacion
{
    partial class FormAltaHabitacion
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblPiso = new System.Windows.Forms.Label();
            this.lblUbicacion = new System.Windows.Forms.Label();
            this.lblComodidades = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.cboUbicacion = new System.Windows.Forms.ComboBox();
            this.cboTipo = new System.Windows.Forms.ComboBox();
            this.gpoBoxAlta = new System.Windows.Forms.GroupBox();
            this.ckActiva = new System.Windows.Forms.CheckBox();
            this.numUpNumHab = new System.Windows.Forms.NumericUpDown();
            this.rcTxtComodidades = new System.Windows.Forms.RichTextBox();
            this.upDnPiso = new System.Windows.Forms.NumericUpDown();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.gpoBoxAlta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpNumHab)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upDnPiso)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(6, 33);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(69, 20);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Número:";
            // 
            // lblPiso
            // 
            this.lblPiso.AutoSize = true;
            this.lblPiso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPiso.Location = new System.Drawing.Point(191, 33);
            this.lblPiso.Name = "lblPiso";
            this.lblPiso.Size = new System.Drawing.Size(43, 20);
            this.lblPiso.TabIndex = 1;
            this.lblPiso.Text = "Piso:";
            // 
            // lblUbicacion
            // 
            this.lblUbicacion.AutoSize = true;
            this.lblUbicacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUbicacion.Location = new System.Drawing.Point(6, 67);
            this.lblUbicacion.Name = "lblUbicacion";
            this.lblUbicacion.Size = new System.Drawing.Size(83, 20);
            this.lblUbicacion.TabIndex = 2;
            this.lblUbicacion.Text = "Ubicación:";
            // 
            // lblComodidades
            // 
            this.lblComodidades.AutoSize = true;
            this.lblComodidades.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComodidades.Location = new System.Drawing.Point(6, 129);
            this.lblComodidades.Name = "lblComodidades";
            this.lblComodidades.Size = new System.Drawing.Size(111, 20);
            this.lblComodidades.TabIndex = 3;
            this.lblComodidades.Text = "Comodidades:";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.Location = new System.Drawing.Point(6, 97);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(142, 20);
            this.lblTipo.TabIndex = 4;
            this.lblTipo.Text = "Tipo de habitación:";
            // 
            // cboUbicacion
            // 
            this.cboUbicacion.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.cboUbicacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUbicacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboUbicacion.FormattingEnabled = true;
            this.cboUbicacion.Items.AddRange(new object[] {
            "Exterior",
            "Interior"});
            this.cboUbicacion.Location = new System.Drawing.Point(104, 63);
            this.cboUbicacion.Name = "cboUbicacion";
            this.cboUbicacion.Size = new System.Drawing.Size(139, 24);
            this.cboUbicacion.TabIndex = 7;
            // 
            // cboTipo
            // 
            this.cboTipo.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.cboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTipo.FormattingEnabled = true;
            this.cboTipo.Location = new System.Drawing.Point(154, 93);
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.Size = new System.Drawing.Size(139, 24);
            this.cboTipo.TabIndex = 8;
            // 
            // gpoBoxAlta
            // 
            this.gpoBoxAlta.Controls.Add(this.ckActiva);
            this.gpoBoxAlta.Controls.Add(this.numUpNumHab);
            this.gpoBoxAlta.Controls.Add(this.rcTxtComodidades);
            this.gpoBoxAlta.Controls.Add(this.upDnPiso);
            this.gpoBoxAlta.Controls.Add(this.lblComodidades);
            this.gpoBoxAlta.Controls.Add(this.cboTipo);
            this.gpoBoxAlta.Controls.Add(this.lblTipo);
            this.gpoBoxAlta.Controls.Add(this.cboUbicacion);
            this.gpoBoxAlta.Controls.Add(this.lblNombre);
            this.gpoBoxAlta.Controls.Add(this.lblPiso);
            this.gpoBoxAlta.Controls.Add(this.lblUbicacion);
            this.gpoBoxAlta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpoBoxAlta.Location = new System.Drawing.Point(12, 12);
            this.gpoBoxAlta.Name = "gpoBoxAlta";
            this.gpoBoxAlta.Size = new System.Drawing.Size(396, 381);
            this.gpoBoxAlta.TabIndex = 1;
            this.gpoBoxAlta.TabStop = false;
            this.gpoBoxAlta.Text = "Habitación nueva";
            // 
            // ckActiva
            // 
            this.ckActiva.AutoSize = true;
            this.ckActiva.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckActiva.Location = new System.Drawing.Point(317, 96);
            this.ckActiva.Name = "ckActiva";
            this.ckActiva.Size = new System.Drawing.Size(71, 24);
            this.ckActiva.TabIndex = 17;
            this.ckActiva.Text = "Activa";
            this.ckActiva.UseVisualStyleBackColor = true;
            // 
            // numUpNumHab
            // 
            this.numUpNumHab.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.numUpNumHab.Location = new System.Drawing.Point(81, 30);
            this.numUpNumHab.Name = "numUpNumHab";
            this.numUpNumHab.Size = new System.Drawing.Size(84, 23);
            this.numUpNumHab.TabIndex = 13;
            // 
            // rcTxtComodidades
            // 
            this.rcTxtComodidades.Location = new System.Drawing.Point(10, 152);
            this.rcTxtComodidades.Name = "rcTxtComodidades";
            this.rcTxtComodidades.Size = new System.Drawing.Size(378, 223);
            this.rcTxtComodidades.TabIndex = 11;
            this.rcTxtComodidades.Text = "";
            // 
            // upDnPiso
            // 
            this.upDnPiso.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.upDnPiso.Location = new System.Drawing.Point(240, 30);
            this.upDnPiso.Name = "upDnPiso";
            this.upDnPiso.Size = new System.Drawing.Size(84, 23);
            this.upDnPiso.TabIndex = 9;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(12, 399);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(79, 25);
            this.btnLimpiar.TabIndex = 2;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(310, 399);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(98, 25);
            this.btnGuardar.TabIndex = 3;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // FormAltaHabitacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 436);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.gpoBoxAlta);
            this.Name = "FormAltaHabitacion";
            this.Text = "ABM Habitación";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormAltaHabitacion_FormClosing);
            this.gpoBoxAlta.ResumeLayout(false);
            this.gpoBoxAlta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpNumHab)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upDnPiso)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblPiso;
        private System.Windows.Forms.Label lblUbicacion;
        private System.Windows.Forms.Label lblComodidades;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.ComboBox cboUbicacion;
        private System.Windows.Forms.ComboBox cboTipo;
        private System.Windows.Forms.GroupBox gpoBoxAlta;
        private System.Windows.Forms.NumericUpDown upDnPiso;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.RichTextBox rcTxtComodidades;
        private System.Windows.Forms.NumericUpDown numUpNumHab;
        private System.Windows.Forms.CheckBox ckActiva;



    }
}