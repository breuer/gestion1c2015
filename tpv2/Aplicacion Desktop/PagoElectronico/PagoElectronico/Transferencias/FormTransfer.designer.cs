namespace PagoElectronico.Transferencias
{
    partial class FormTransfer
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.grilla_cuentas = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_cuenta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.combo_ctas_activas = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel_transf = new System.Windows.Forms.Panel();
            this.panel_importe = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_importe = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label_cta_pais = new System.Windows.Forms.Label();
            this.label_cta_num = new System.Windows.Forms.Label();
            this.label_cta_nomb = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grilla_cuentas)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.panel_transf.SuspendLayout();
            this.panel_importe.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.grilla_cuentas);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txt_cuenta);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(3, 110);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(756, 324);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cuenta destino";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(24, 284);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(139, 23);
            this.button2.TabIndex = 17;
            this.button2.Text = "Elegir Cuenta";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Cuentas encontradas:";
            // 
            // grilla_cuentas
            // 
            this.grilla_cuentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grilla_cuentas.Location = new System.Drawing.Point(24, 136);
            this.grilla_cuentas.Name = "grilla_cuentas";
            this.grilla_cuentas.Size = new System.Drawing.Size(708, 133);
            this.grilla_cuentas.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Escriba el numero de cuenta";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(351, 74);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(65, 22);
            this.button1.TabIndex = 3;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_cuenta
            // 
            this.txt_cuenta.Location = new System.Drawing.Point(24, 76);
            this.txt_cuenta.Name = "txt_cuenta";
            this.txt_cuenta.Size = new System.Drawing.Size(321, 20);
            this.txt_cuenta.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(324, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Seleccione la cuenta destino a realizar la transferencia:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.combo_ctas_activas);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(756, 89);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cuenta origén";
            // 
            // combo_ctas_activas
            // 
            this.combo_ctas_activas.FormattingEnabled = true;
            this.combo_ctas_activas.Location = new System.Drawing.Point(24, 49);
            this.combo_ctas_activas.Name = "combo_ctas_activas";
            this.combo_ctas_activas.Size = new System.Drawing.Size(708, 21);
            this.combo_ctas_activas.TabIndex = 1;
            this.combo_ctas_activas.Text = "Escoja alguna de sus cuentas";
            this.combo_ctas_activas.SelectedIndexChanged += new System.EventHandler(this.combo_ctas_activas_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Seleccione la cuenta origén";
            // 
            // panel_transf
            // 
            this.panel_transf.Controls.Add(this.groupBox1);
            this.panel_transf.Controls.Add(this.groupBox2);
            this.panel_transf.Location = new System.Drawing.Point(12, 12);
            this.panel_transf.Name = "panel_transf";
            this.panel_transf.Size = new System.Drawing.Size(764, 442);
            this.panel_transf.TabIndex = 2;
            // 
            // panel_importe
            // 
            this.panel_importe.Controls.Add(this.groupBox3);
            this.panel_importe.Location = new System.Drawing.Point(12, 471);
            this.panel_importe.Name = "panel_importe";
            this.panel_importe.Size = new System.Drawing.Size(764, 442);
            this.panel_importe.TabIndex = 3;
            this.panel_importe.Visible = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txt_importe);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label_cta_pais);
            this.groupBox3.Controls.Add(this.label_cta_num);
            this.groupBox3.Controls.Add(this.label_cta_nomb);
            this.groupBox3.Location = new System.Drawing.Point(3, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(758, 436);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Transferir";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Olive;
            this.label9.Location = new System.Drawing.Point(21, 339);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(123, 24);
            this.label9.TabIndex = 9;
            this.label9.Text = "U$$ Dolares";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(21, 315);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 18);
            this.label8.TabIndex = 8;
            this.label8.Text = "Moneda:";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(24, 378);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(117, 41);
            this.button3.TabIndex = 7;
            this.button3.Text = "Transferir";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(22, 233);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(698, 18);
            this.label7.TabIndex = 6;
            this.label7.Text = "Escriba el importe a transferir, el sistema verificara si posee saldo disponible " +
                "para realizar la transferencia";
            // 
            // txt_importe
            // 
            this.txt_importe.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_importe.Location = new System.Drawing.Point(24, 266);
            this.txt_importe.Name = "txt_importe";
            this.txt_importe.Size = new System.Drawing.Size(561, 31);
            this.txt_importe.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(21, 197);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 24);
            this.label6.TabIndex = 4;
            this.label6.Text = "IMPORTE";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(222, 37);
            this.label5.TabIndex = 3;
            this.label5.Text = "Datos destino:";
            // 
            // label_cta_pais
            // 
            this.label_cta_pais.AutoSize = true;
            this.label_cta_pais.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_cta_pais.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label_cta_pais.Location = new System.Drawing.Point(20, 150);
            this.label_cta_pais.Name = "label_cta_pais";
            this.label_cta_pais.Size = new System.Drawing.Size(274, 24);
            this.label_cta_pais.TabIndex = 2;
            this.label_cta_pais.Text = "000000000000000000000000";
            // 
            // label_cta_num
            // 
            this.label_cta_num.AutoSize = true;
            this.label_cta_num.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_cta_num.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label_cta_num.Location = new System.Drawing.Point(20, 116);
            this.label_cta_num.Name = "label_cta_num";
            this.label_cta_num.Size = new System.Drawing.Size(274, 24);
            this.label_cta_num.TabIndex = 1;
            this.label_cta_num.Text = "000000000000000000000000";
            // 
            // label_cta_nomb
            // 
            this.label_cta_nomb.AutoSize = true;
            this.label_cta_nomb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_cta_nomb.Location = new System.Drawing.Point(20, 80);
            this.label_cta_nomb.Name = "label_cta_nomb";
            this.label_cta_nomb.Size = new System.Drawing.Size(144, 24);
            this.label_cta_nomb.TabIndex = 0;
            this.label_cta_nomb.Text = "Indeterminado";
            // 
            // FormTransfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 922);
            this.Controls.Add(this.panel_importe);
            this.Controls.Add(this.panel_transf);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormTransfer";
            this.Text = "Transferencias";
            this.Load += new System.EventHandler(this.FormTransfer_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grilla_cuentas)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel_transf.ResumeLayout(false);
            this.panel_importe.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_cuenta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView grilla_cuentas;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox combo_ctas_activas;
        private System.Windows.Forms.Panel panel_transf;
        private System.Windows.Forms.Panel panel_importe;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label_cta_num;
        private System.Windows.Forms.Label label_cta_nomb;
        private System.Windows.Forms.Label label_cta_pais;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_importe;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}