namespace FrbaHotel.Registrar_Consumible
{
    partial class Facturar
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
            this.tarjetabtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gridItems = new System.Windows.Forms.DataGridView();
            this.cargarReservabtn = new System.Windows.Forms.Button();
            this.fechatxt = new System.Windows.Forms.TextBox();
            this.numFacttxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numReservatxt = new System.Windows.Forms.TextBox();
            this.gridConsumos = new System.Windows.Forms.DataGridView();
            this.lblFecha = new System.Windows.Forms.Label();
            this.cboMetPago = new System.Windows.Forms.ComboBox();
            this.txtMontoTotal = new System.Windows.Forms.MaskedTextBox();
            this.lblConsu = new System.Windows.Forms.Label();
            this.lblMet = new System.Windows.Forms.Label();
            this.lblMontoTot = new System.Windows.Forms.Label();
            this.lblNumRese = new System.Windows.Forms.Label();
            this.gpoBoxAlta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridConsumos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.Enabled = false;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(462, 438);
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
            this.btnLimpiar.Location = new System.Drawing.Point(12, 438);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(79, 25);
            this.btnLimpiar.TabIndex = 14;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // gpoBoxAlta
            // 
            this.gpoBoxAlta.Controls.Add(this.tarjetabtn);
            this.gpoBoxAlta.Controls.Add(this.label1);
            this.gpoBoxAlta.Controls.Add(this.gridItems);
            this.gpoBoxAlta.Controls.Add(this.cargarReservabtn);
            this.gpoBoxAlta.Controls.Add(this.fechatxt);
            this.gpoBoxAlta.Controls.Add(this.numFacttxt);
            this.gpoBoxAlta.Controls.Add(this.label2);
            this.gpoBoxAlta.Controls.Add(this.numReservatxt);
            this.gpoBoxAlta.Controls.Add(this.gridConsumos);
            this.gpoBoxAlta.Controls.Add(this.lblFecha);
            this.gpoBoxAlta.Controls.Add(this.cboMetPago);
            this.gpoBoxAlta.Controls.Add(this.txtMontoTotal);
            this.gpoBoxAlta.Controls.Add(this.lblConsu);
            this.gpoBoxAlta.Controls.Add(this.lblMet);
            this.gpoBoxAlta.Controls.Add(this.lblMontoTot);
            this.gpoBoxAlta.Controls.Add(this.lblNumRese);
            this.gpoBoxAlta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpoBoxAlta.Location = new System.Drawing.Point(12, 12);
            this.gpoBoxAlta.Name = "gpoBoxAlta";
            this.gpoBoxAlta.Size = new System.Drawing.Size(548, 420);
            this.gpoBoxAlta.TabIndex = 13;
            this.gpoBoxAlta.TabStop = false;
            this.gpoBoxAlta.Text = "Factura";
            // 
            // tarjetabtn
            // 
            this.tarjetabtn.Enabled = false;
            this.tarjetabtn.Location = new System.Drawing.Point(360, 77);
            this.tarjetabtn.Name = "tarjetabtn";
            this.tarjetabtn.Size = new System.Drawing.Size(160, 23);
            this.tarjetabtn.TabIndex = 50;
            this.tarjetabtn.Text = "Cargar Tarjeta";
            this.tarjetabtn.UseVisualStyleBackColor = true;
            this.tarjetabtn.Click += new System.EventHandler(this.tarjetabtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 49;
            this.label1.Text = "Items:";
            // 
            // gridItems
            // 
            this.gridItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridItems.Location = new System.Drawing.Point(14, 192);
            this.gridItems.Name = "gridItems";
            this.gridItems.ReadOnly = true;
            this.gridItems.Size = new System.Drawing.Size(517, 91);
            this.gridItems.TabIndex = 48;
            // 
            // cargarReservabtn
            // 
            this.cargarReservabtn.Location = new System.Drawing.Point(147, 119);
            this.cargarReservabtn.Name = "cargarReservabtn";
            this.cargarReservabtn.Size = new System.Drawing.Size(160, 28);
            this.cargarReservabtn.TabIndex = 47;
            this.cargarReservabtn.Text = "Cargar reserva";
            this.cargarReservabtn.UseVisualStyleBackColor = true;
            this.cargarReservabtn.Click += new System.EventHandler(this.cargarReservabtn_Click);
            // 
            // fechatxt
            // 
            this.fechatxt.Location = new System.Drawing.Point(420, 18);
            this.fechatxt.Name = "fechatxt";
            this.fechatxt.ReadOnly = true;
            this.fechatxt.Size = new System.Drawing.Size(100, 23);
            this.fechatxt.TabIndex = 46;
            // 
            // numFacttxt
            // 
            this.numFacttxt.Location = new System.Drawing.Point(157, 19);
            this.numFacttxt.Name = "numFacttxt";
            this.numFacttxt.ReadOnly = true;
            this.numFacttxt.Size = new System.Drawing.Size(150, 23);
            this.numFacttxt.TabIndex = 45;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 20);
            this.label2.TabIndex = 44;
            this.label2.Text = "* Núm. de Factura:";
            // 
            // numReservatxt
            // 
            this.numReservatxt.Location = new System.Drawing.Point(157, 48);
            this.numReservatxt.Name = "numReservatxt";
            this.numReservatxt.Size = new System.Drawing.Size(151, 23);
            this.numReservatxt.TabIndex = 43;
            // 
            // gridConsumos
            // 
            this.gridConsumos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridConsumos.Location = new System.Drawing.Point(14, 318);
            this.gridConsumos.Name = "gridConsumos";
            this.gridConsumos.ReadOnly = true;
            this.gridConsumos.Size = new System.Drawing.Size(517, 66);
            this.gridConsumos.TabIndex = 42;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(356, 18);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(58, 20);
            this.lblFecha.TabIndex = 40;
            this.lblFecha.Text = "Fecha:";
            // 
            // cboMetPago
            // 
            this.cboMetPago.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.cboMetPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMetPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMetPago.FormattingEnabled = true;
            this.cboMetPago.Location = new System.Drawing.Point(157, 77);
            this.cboMetPago.Name = "cboMetPago";
            this.cboMetPago.Size = new System.Drawing.Size(150, 24);
            this.cboMetPago.TabIndex = 23;
            this.cboMetPago.SelectedIndexChanged += new System.EventHandler(this.cboMetPago_SelectedIndexChanged);
            // 
            // txtMontoTotal
            // 
            this.txtMontoTotal.Enabled = false;
            this.txtMontoTotal.Location = new System.Drawing.Point(389, 390);
            this.txtMontoTotal.Name = "txtMontoTotal";
            this.txtMontoTotal.Size = new System.Drawing.Size(142, 23);
            this.txtMontoTotal.TabIndex = 21;
            // 
            // lblConsu
            // 
            this.lblConsu.AutoSize = true;
            this.lblConsu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsu.Location = new System.Drawing.Point(10, 286);
            this.lblConsu.Name = "lblConsu";
            this.lblConsu.Size = new System.Drawing.Size(104, 20);
            this.lblConsu.TabIndex = 15;
            this.lblConsu.Text = "Consumibles:";
            // 
            // lblMet
            // 
            this.lblMet.AutoSize = true;
            this.lblMet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMet.Location = new System.Drawing.Point(10, 77);
            this.lblMet.Name = "lblMet";
            this.lblMet.Size = new System.Drawing.Size(139, 20);
            this.lblMet.TabIndex = 14;
            this.lblMet.Text = "* Método de pago:";
            // 
            // lblMontoTot
            // 
            this.lblMontoTot.AutoSize = true;
            this.lblMontoTot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontoTot.Location = new System.Drawing.Point(335, 390);
            this.lblMontoTot.Name = "lblMontoTot";
            this.lblMontoTot.Size = new System.Drawing.Size(48, 20);
            this.lblMontoTot.TabIndex = 13;
            this.lblMontoTot.Text = "Total:";
            // 
            // lblNumRese
            // 
            this.lblNumRese.AutoSize = true;
            this.lblNumRese.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumRese.Location = new System.Drawing.Point(10, 48);
            this.lblNumRese.Name = "lblNumRese";
            this.lblNumRese.Size = new System.Drawing.Size(145, 20);
            this.lblNumRese.TabIndex = 3;
            this.lblNumRese.Text = "* Núm. de Reserva:";
            // 
            // Facturar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 475);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.gpoBoxAlta);
            this.Name = "Facturar";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Facturar_Load);
            this.gpoBoxAlta.ResumeLayout(false);
            this.gpoBoxAlta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridConsumos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.GroupBox gpoBoxAlta;
        private System.Windows.Forms.ComboBox cboMetPago;
        private System.Windows.Forms.MaskedTextBox txtMontoTotal;
        private System.Windows.Forms.Label lblConsu;
        private System.Windows.Forms.Label lblMet;
        private System.Windows.Forms.Label lblMontoTot;
        private System.Windows.Forms.Label lblNumRese;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DataGridView gridConsumos;
        private System.Windows.Forms.TextBox numReservatxt;
        private System.Windows.Forms.TextBox numFacttxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox fechatxt;
        private System.Windows.Forms.Button cargarReservabtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gridItems;
        private System.Windows.Forms.Button tarjetabtn;
    }
}