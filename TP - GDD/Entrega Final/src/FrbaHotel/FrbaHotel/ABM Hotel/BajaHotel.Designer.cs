namespace FrbaHotel.ABM_Hotel
{
    partial class BajaHotel
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
            this.txtMotivo = new System.Windows.Forms.RichTextBox();
            this.lblMotivo = new System.Windows.Forms.Label();
            this.calendHasta = new System.Windows.Forms.MonthCalendar();
            this.btnFechaHasta = new System.Windows.Forms.Button();
            this.txtFechaHasta = new System.Windows.Forms.MaskedTextBox();
            this.lblHasta = new System.Windows.Forms.Label();
            this.btnCalendarioDesde = new System.Windows.Forms.Button();
            this.calendFechaDesde = new System.Windows.Forms.MonthCalendar();
            this.txtFechaDesde = new System.Windows.Forms.MaskedTextBox();
            this.lblDesde = new System.Windows.Forms.Label();
            this.gpoBoxAlta.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(484, 386);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(98, 25);
            this.btnGuardar.TabIndex = 15;
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
            this.btnLimpiar.TabIndex = 14;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // gpoBoxAlta
            // 
            this.gpoBoxAlta.Controls.Add(this.txtMotivo);
            this.gpoBoxAlta.Controls.Add(this.lblMotivo);
            this.gpoBoxAlta.Controls.Add(this.calendHasta);
            this.gpoBoxAlta.Controls.Add(this.btnFechaHasta);
            this.gpoBoxAlta.Controls.Add(this.txtFechaHasta);
            this.gpoBoxAlta.Controls.Add(this.lblHasta);
            this.gpoBoxAlta.Controls.Add(this.btnCalendarioDesde);
            this.gpoBoxAlta.Controls.Add(this.calendFechaDesde);
            this.gpoBoxAlta.Controls.Add(this.txtFechaDesde);
            this.gpoBoxAlta.Controls.Add(this.lblDesde);
            this.gpoBoxAlta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpoBoxAlta.Location = new System.Drawing.Point(12, 12);
            this.gpoBoxAlta.Name = "gpoBoxAlta";
            this.gpoBoxAlta.Size = new System.Drawing.Size(570, 368);
            this.gpoBoxAlta.TabIndex = 13;
            this.gpoBoxAlta.TabStop = false;
            this.gpoBoxAlta.Text = "Baja de hotel";
            // 
            // txtMotivo
            // 
            this.txtMotivo.Location = new System.Drawing.Point(20, 102);
            this.txtMotivo.Name = "txtMotivo";
            this.txtMotivo.Size = new System.Drawing.Size(299, 182);
            this.txtMotivo.TabIndex = 47;
            this.txtMotivo.Text = "";
            // 
            // lblMotivo
            // 
            this.lblMotivo.AutoSize = true;
            this.lblMotivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMotivo.Location = new System.Drawing.Point(14, 79);
            this.lblMotivo.Name = "lblMotivo";
            this.lblMotivo.Size = new System.Drawing.Size(69, 20);
            this.lblMotivo.TabIndex = 46;
            this.lblMotivo.Text = "* Motivo:";
            // 
            // calendHasta
            // 
            this.calendHasta.Location = new System.Drawing.Point(331, 194);
            this.calendHasta.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.calendHasta.Name = "calendHasta";
            this.calendHasta.TabIndex = 45;
            this.calendHasta.Visible = false;
            this.calendHasta.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.calendHasta_DateSelected);
            // 
            // btnFechaHasta
            // 
            this.btnFechaHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechaHasta.Location = new System.Drawing.Point(225, 290);
            this.btnFechaHasta.Name = "btnFechaHasta";
            this.btnFechaHasta.Size = new System.Drawing.Size(94, 25);
            this.btnFechaHasta.TabIndex = 43;
            this.btnFechaHasta.Text = "Seleccionar";
            this.btnFechaHasta.UseVisualStyleBackColor = true;
            this.btnFechaHasta.Click += new System.EventHandler(this.btnFechaHasta_Click);
            // 
            // txtFechaHasta
            // 
            this.txtFechaHasta.Enabled = false;
            this.txtFechaHasta.Location = new System.Drawing.Point(126, 291);
            this.txtFechaHasta.Mask = "00/00/0000";
            this.txtFechaHasta.Name = "txtFechaHasta";
            this.txtFechaHasta.Size = new System.Drawing.Size(93, 23);
            this.txtFechaHasta.TabIndex = 44;
            this.txtFechaHasta.ValidatingType = typeof(System.DateTime);
            // 
            // lblHasta
            // 
            this.lblHasta.AutoSize = true;
            this.lblHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHasta.Location = new System.Drawing.Point(14, 291);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(112, 20);
            this.lblHasta.TabIndex = 42;
            this.lblHasta.Text = "* Fecha hasta:";
            // 
            // btnCalendarioDesde
            // 
            this.btnCalendarioDesde.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalendarioDesde.Location = new System.Drawing.Point(225, 41);
            this.btnCalendarioDesde.Name = "btnCalendarioDesde";
            this.btnCalendarioDesde.Size = new System.Drawing.Size(94, 25);
            this.btnCalendarioDesde.TabIndex = 39;
            this.btnCalendarioDesde.Text = "Seleccionar";
            this.btnCalendarioDesde.UseVisualStyleBackColor = true;
            this.btnCalendarioDesde.Click += new System.EventHandler(this.btnCalendarioDesde_Click);
            // 
            // calendFechaDesde
            // 
            this.calendFechaDesde.Location = new System.Drawing.Point(331, 28);
            this.calendFechaDesde.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.calendFechaDesde.Name = "calendFechaDesde";
            this.calendFechaDesde.TabIndex = 41;
            this.calendFechaDesde.Visible = false;
            this.calendFechaDesde.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.calendFechaDesde_DateSelected);
            // 
            // txtFechaDesde
            // 
            this.txtFechaDesde.Enabled = false;
            this.txtFechaDesde.Location = new System.Drawing.Point(136, 42);
            this.txtFechaDesde.Mask = "00/00/0000";
            this.txtFechaDesde.Name = "txtFechaDesde";
            this.txtFechaDesde.Size = new System.Drawing.Size(83, 23);
            this.txtFechaDesde.TabIndex = 40;
            this.txtFechaDesde.ValidatingType = typeof(System.DateTime);
            // 
            // lblDesde
            // 
            this.lblDesde.AutoSize = true;
            this.lblDesde.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesde.Location = new System.Drawing.Point(14, 42);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(116, 20);
            this.lblDesde.TabIndex = 36;
            this.lblDesde.Text = "* Fecha desde:";
            // 
            // BajaHotel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 420);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.gpoBoxAlta);
            this.Name = "BajaHotel";
            this.Text = "Baja de Hotel";
            this.Load += new System.EventHandler(this.BajaHotel_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BajaHotel_FormClosing);
            this.gpoBoxAlta.ResumeLayout(false);
            this.gpoBoxAlta.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.GroupBox gpoBoxAlta;
        private System.Windows.Forms.MonthCalendar calendHasta;
        private System.Windows.Forms.Button btnFechaHasta;
        private System.Windows.Forms.MaskedTextBox txtFechaHasta;
        private System.Windows.Forms.Label lblHasta;
        private System.Windows.Forms.Button btnCalendarioDesde;
        private System.Windows.Forms.MonthCalendar calendFechaDesde;
        private System.Windows.Forms.MaskedTextBox txtFechaDesde;
        private System.Windows.Forms.Label lblDesde;
        private System.Windows.Forms.RichTextBox txtMotivo;
        private System.Windows.Forms.Label lblMotivo;

    }
}