namespace FrbaHotel.Registrar_Consumible
{
    partial class Tarjeta
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
            this.calendarioHasta = new System.Windows.Forms.MonthCalendar();
            this.btnCalendarioHasta = new System.Windows.Forms.Button();
            this.calendarioDesde = new System.Windows.Forms.MonthCalendar();
            this.btnCalendarioDesde = new System.Windows.Forms.Button();
            this.txtEmision = new System.Windows.Forms.MaskedTextBox();
            this.lblEmision = new System.Windows.Forms.Label();
            this.txtFechaVence = new System.Windows.Forms.MaskedTextBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.txtNumTarjeta = new System.Windows.Forms.MaskedTextBox();
            this.lblNum = new System.Windows.Forms.Label();
            this.gpoBoxAlta.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(531, 292);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(98, 25);
            this.btnGuardar.TabIndex = 18;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(12, 292);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(79, 25);
            this.btnLimpiar.TabIndex = 17;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // gpoBoxAlta
            // 
            this.gpoBoxAlta.Controls.Add(this.calendarioHasta);
            this.gpoBoxAlta.Controls.Add(this.btnCalendarioHasta);
            this.gpoBoxAlta.Controls.Add(this.calendarioDesde);
            this.gpoBoxAlta.Controls.Add(this.btnCalendarioDesde);
            this.gpoBoxAlta.Controls.Add(this.txtEmision);
            this.gpoBoxAlta.Controls.Add(this.lblEmision);
            this.gpoBoxAlta.Controls.Add(this.txtFechaVence);
            this.gpoBoxAlta.Controls.Add(this.lblFecha);
            this.gpoBoxAlta.Controls.Add(this.txtNumTarjeta);
            this.gpoBoxAlta.Controls.Add(this.lblNum);
            this.gpoBoxAlta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpoBoxAlta.Location = new System.Drawing.Point(12, 12);
            this.gpoBoxAlta.Name = "gpoBoxAlta";
            this.gpoBoxAlta.Size = new System.Drawing.Size(617, 274);
            this.gpoBoxAlta.TabIndex = 16;
            this.gpoBoxAlta.TabStop = false;
            this.gpoBoxAlta.Text = "Datos de la Tarjeta";
            // 
            // calendarioHasta
            // 
            this.calendarioHasta.Location = new System.Drawing.Point(381, 100);
            this.calendarioHasta.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.calendarioHasta.Name = "calendarioHasta";
            this.calendarioHasta.SelectionRange = new System.Windows.Forms.SelectionRange(new System.DateTime(2000, 11, 8, 0, 0, 0, 0), new System.DateTime(2000, 11, 14, 0, 0, 0, 0));
            this.calendarioHasta.TabIndex = 47;
            this.calendarioHasta.Visible = false;
            this.calendarioHasta.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.calendarioHasta_DateSelected);
            // 
            // btnCalendarioHasta
            // 
            this.btnCalendarioHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalendarioHasta.Location = new System.Drawing.Point(275, 58);
            this.btnCalendarioHasta.Name = "btnCalendarioHasta";
            this.btnCalendarioHasta.Size = new System.Drawing.Size(94, 25);
            this.btnCalendarioHasta.TabIndex = 46;
            this.btnCalendarioHasta.Text = "Seleccionar";
            this.btnCalendarioHasta.UseVisualStyleBackColor = true;
            this.btnCalendarioHasta.Click += new System.EventHandler(this.btnCalendarioHasta_Click);
            // 
            // calendarioDesde
            // 
            this.calendarioDesde.Location = new System.Drawing.Point(381, 17);
            this.calendarioDesde.Name = "calendarioDesde";
            this.calendarioDesde.SelectionRange = new System.Windows.Forms.SelectionRange(new System.DateTime(2000, 11, 8, 0, 0, 0, 0), new System.DateTime(2000, 11, 14, 0, 0, 0, 0));
            this.calendarioDesde.TabIndex = 45;
            this.calendarioDesde.Visible = false;
            this.calendarioDesde.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.calendarioDesde_DateSelected);
            // 
            // btnCalendarioDesde
            // 
            this.btnCalendarioDesde.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalendarioDesde.Location = new System.Drawing.Point(275, 88);
            this.btnCalendarioDesde.Name = "btnCalendarioDesde";
            this.btnCalendarioDesde.Size = new System.Drawing.Size(94, 25);
            this.btnCalendarioDesde.TabIndex = 44;
            this.btnCalendarioDesde.Text = "Seleccionar";
            this.btnCalendarioDesde.UseVisualStyleBackColor = true;
            this.btnCalendarioDesde.Click += new System.EventHandler(this.btnCalendarioDesde_Click);
            // 
            // txtEmision
            // 
            this.txtEmision.Enabled = false;
            this.txtEmision.Location = new System.Drawing.Point(176, 89);
            this.txtEmision.Mask = "00/00/0000";
            this.txtEmision.Name = "txtEmision";
            this.txtEmision.Size = new System.Drawing.Size(93, 23);
            this.txtEmision.TabIndex = 43;
            this.txtEmision.ValidatingType = typeof(System.DateTime);
            // 
            // lblEmision
            // 
            this.lblEmision.AutoSize = true;
            this.lblEmision.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmision.Location = new System.Drawing.Point(6, 89);
            this.lblEmision.Name = "lblEmision";
            this.lblEmision.Size = new System.Drawing.Size(126, 20);
            this.lblEmision.TabIndex = 42;
            this.lblEmision.Text = "* Fecha emisión:";
            // 
            // txtFechaVence
            // 
            this.txtFechaVence.Enabled = false;
            this.txtFechaVence.Location = new System.Drawing.Point(176, 60);
            this.txtFechaVence.Mask = "00/00/0000";
            this.txtFechaVence.Name = "txtFechaVence";
            this.txtFechaVence.Size = new System.Drawing.Size(93, 23);
            this.txtFechaVence.TabIndex = 41;
            this.txtFechaVence.ValidatingType = typeof(System.DateTime);
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(6, 60);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(156, 20);
            this.lblFecha.TabIndex = 40;
            this.lblFecha.Text = "* Fecha vencimiento:";
            // 
            // txtNumTarjeta
            // 
            this.txtNumTarjeta.Location = new System.Drawing.Point(157, 31);
            this.txtNumTarjeta.Mask = "999999999";
            this.txtNumTarjeta.Name = "txtNumTarjeta";
            this.txtNumTarjeta.Size = new System.Drawing.Size(112, 23);
            this.txtNumTarjeta.TabIndex = 20;
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNum.Location = new System.Drawing.Point(6, 31);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(135, 20);
            this.lblNum.TabIndex = 3;
            this.lblNum.Text = "* Núm. de Tarjeta:";
            // 
            // Tarjeta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 331);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.gpoBoxAlta);
            this.Name = "Tarjeta";
            this.Text = "Tarjeta";
            this.Load += new System.EventHandler(this.Tarjeta_Load);
            this.gpoBoxAlta.ResumeLayout(false);
            this.gpoBoxAlta.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.GroupBox gpoBoxAlta;
        private System.Windows.Forms.MaskedTextBox txtFechaVence;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.MaskedTextBox txtNumTarjeta;
        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.MaskedTextBox txtEmision;
        private System.Windows.Forms.Label lblEmision;
        private System.Windows.Forms.MonthCalendar calendarioHasta;
        private System.Windows.Forms.Button btnCalendarioHasta;
        private System.Windows.Forms.MonthCalendar calendarioDesde;
        private System.Windows.Forms.Button btnCalendarioDesde;
    }
}