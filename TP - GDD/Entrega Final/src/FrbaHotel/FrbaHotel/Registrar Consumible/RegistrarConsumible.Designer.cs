namespace FrbaHotel.Registrar_Consumible
{
    partial class RegistrarConsumible
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
            this.consumosgrid = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.consumiblecbx = new System.Windows.Forms.ComboBox();
            this.cantidadtxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.codigoReservatxt = new System.Windows.Forms.TextBox();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.gpoBoxAlta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.consumosgrid)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(406, 414);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(98, 25);
            this.btnGuardar.TabIndex = 12;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(12, 414);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(79, 25);
            this.btnLimpiar.TabIndex = 11;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // gpoBoxAlta
            // 
            this.gpoBoxAlta.Controls.Add(this.consumosgrid);
            this.gpoBoxAlta.Controls.Add(this.button1);
            this.gpoBoxAlta.Controls.Add(this.consumiblecbx);
            this.gpoBoxAlta.Controls.Add(this.cantidadtxt);
            this.gpoBoxAlta.Controls.Add(this.label3);
            this.gpoBoxAlta.Controls.Add(this.label2);
            this.gpoBoxAlta.Controls.Add(this.label1);
            this.gpoBoxAlta.Controls.Add(this.codigoReservatxt);
            this.gpoBoxAlta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpoBoxAlta.Location = new System.Drawing.Point(12, 12);
            this.gpoBoxAlta.Name = "gpoBoxAlta";
            this.gpoBoxAlta.Size = new System.Drawing.Size(492, 396);
            this.gpoBoxAlta.TabIndex = 10;
            this.gpoBoxAlta.TabStop = false;
            this.gpoBoxAlta.Text = "Registrar Consumible";
            // 
            // consumosgrid
            // 
            this.consumosgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.consumosgrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Producto,
            this.Cantidad,
            this.Precio,
            this.Eliminar});
            this.consumosgrid.Location = new System.Drawing.Point(9, 171);
            this.consumosgrid.Name = "consumosgrid";
            this.consumosgrid.Size = new System.Drawing.Size(477, 201);
            this.consumosgrid.TabIndex = 7;
            this.consumosgrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.consumosgrid_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(394, 125);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // consumiblecbx
            // 
            this.consumiblecbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.consumiblecbx.FormattingEnabled = true;
            this.consumiblecbx.Location = new System.Drawing.Point(162, 51);
            this.consumiblecbx.Name = "consumiblecbx";
            this.consumiblecbx.Size = new System.Drawing.Size(225, 24);
            this.consumiblecbx.TabIndex = 5;
            // 
            // cantidadtxt
            // 
            this.cantidadtxt.Location = new System.Drawing.Point(162, 81);
            this.cantidadtxt.Name = "cantidadtxt";
            this.cantidadtxt.Size = new System.Drawing.Size(100, 23);
            this.cantidadtxt.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(6, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "* Cantidad";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(6, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "* Consumible";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "* Codigo reserva";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // codigoReservatxt
            // 
            this.codigoReservatxt.Location = new System.Drawing.Point(162, 22);
            this.codigoReservatxt.Name = "codigoReservatxt";
            this.codigoReservatxt.Size = new System.Drawing.Size(121, 23);
            this.codigoReservatxt.TabIndex = 0;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Width = 80;
            // 
            // Producto
            // 
            this.Producto.HeaderText = "Producto";
            this.Producto.Name = "Producto";
            this.Producto.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Cantidad.Width = 80;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            this.Precio.Width = 80;
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Width = 80;
            // 
            // RegistrarConsumible
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 452);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.gpoBoxAlta);
            this.Name = "RegistrarConsumible";
            this.Text = "Consumible";
            this.Load += new System.EventHandler(this.RegistrarConsumible_Load);
            this.gpoBoxAlta.ResumeLayout(false);
            this.gpoBoxAlta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.consumosgrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.GroupBox gpoBoxAlta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox codigoReservatxt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox consumiblecbx;
        private System.Windows.Forms.TextBox cantidadtxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView consumosgrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewButtonColumn Eliminar;
    }
}