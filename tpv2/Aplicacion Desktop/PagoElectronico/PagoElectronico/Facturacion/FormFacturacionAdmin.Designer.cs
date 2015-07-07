namespace PagoElectronico.Facturacion
{
    partial class FormFacturacionAdmin
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.num_doc = new System.Windows.Forms.TextBox();
            this.combo_doc = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Cliente = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.grilla_clientes = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.Cliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grilla_clientes)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 31);
            this.label1.TabIndex = 9;
            this.label1.Text = "Facturación";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.num_doc);
            this.groupBox1.Controls.Add(this.combo_doc);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(18, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(569, 108);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar Cliente";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(478, 58);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // num_doc
            // 
            this.num_doc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_doc.Location = new System.Drawing.Point(197, 58);
            this.num_doc.Name = "num_doc";
            this.num_doc.Size = new System.Drawing.Size(274, 26);
            this.num_doc.TabIndex = 3;
            // 
            // combo_doc
            // 
            this.combo_doc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_doc.FormattingEnabled = true;
            this.combo_doc.Location = new System.Drawing.Point(21, 58);
            this.combo_doc.Name = "combo_doc";
            this.combo_doc.Size = new System.Drawing.Size(161, 28);
            this.combo_doc.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(194, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "N° documento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tipo documento";
            // 
            // Cliente
            // 
            this.Cliente.Controls.Add(this.button3);
            this.Cliente.Controls.Add(this.grilla_clientes);
            this.Cliente.Location = new System.Drawing.Point(18, 180);
            this.Cliente.Name = "Cliente";
            this.Cliente.Size = new System.Drawing.Size(569, 290);
            this.Cliente.TabIndex = 11;
            this.Cliente.TabStop = false;
            this.Cliente.Text = "Cliente";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(21, 255);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(236, 23);
            this.button3.TabIndex = 12;
            this.button3.Text = "Ver facturas del cliente seleccionado";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // grilla_clientes
            // 
            this.grilla_clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grilla_clientes.Location = new System.Drawing.Point(21, 34);
            this.grilla_clientes.Name = "grilla_clientes";
            this.grilla_clientes.ReadOnly = true;
            this.grilla_clientes.Size = new System.Drawing.Size(523, 210);
            this.grilla_clientes.TabIndex = 11;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(512, 486);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "Cerrar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FormFacturacionAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 520);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Cliente);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormFacturacionAdmin";
            this.Text = "Facturación";
            this.Load += new System.EventHandler(this.FormFacturacionAdmin_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Cliente.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grilla_clientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox num_doc;
        private System.Windows.Forms.ComboBox combo_doc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox Cliente;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView grilla_clientes;
        private System.Windows.Forms.Button button3;
    }
}