namespace PagoElectronico.Saldos
{
    partial class FormSaldo_admin
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
            this.label5 = new System.Windows.Forms.Label();
            this.label_importe = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.grilla_resu = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.grilla_cuentas = new System.Windows.Forms.DataGridView();
            this.txt_cuenta = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_saldo = new System.Windows.Forms.Panel();
            this.panel_movimientos = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.grilla_resu)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grilla_cuentas)).BeginInit();
            this.panel_saldo.SuspendLayout();
            this.panel_movimientos.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(173, 20);
            this.label5.TabIndex = 26;
            this.label5.Text = "Ultimos movimientos";
            // 
            // label_importe
            // 
            this.label_importe.AutoSize = true;
            this.label_importe.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_importe.Location = new System.Drawing.Point(17, 42);
            this.label_importe.Name = "label_importe";
            this.label_importe.Size = new System.Drawing.Size(64, 18);
            this.label_importe.TabIndex = 25;
            this.label_importe.Text = "0000000";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 20);
            this.label3.TabIndex = 24;
            this.label3.Text = "Saldo actual";
            // 
            // grilla_resu
            // 
            this.grilla_resu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grilla_resu.Location = new System.Drawing.Point(20, 104);
            this.grilla_resu.Name = "grilla_resu";
            this.grilla_resu.Size = new System.Drawing.Size(514, 262);
            this.grilla_resu.TabIndex = 23;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.grilla_cuentas);
            this.groupBox1.Controls.Add(this.txt_cuenta);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(9, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(539, 324);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cuenta";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(19, 280);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 32);
            this.button2.TabIndex = 25;
            this.button2.Text = "Ver saldo";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // grilla_cuentas
            // 
            this.grilla_cuentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grilla_cuentas.Location = new System.Drawing.Point(19, 92);
            this.grilla_cuentas.Name = "grilla_cuentas";
            this.grilla_cuentas.Size = new System.Drawing.Size(506, 174);
            this.grilla_cuentas.TabIndex = 24;
            // 
            // txt_cuenta
            // 
            this.txt_cuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cuenta.Location = new System.Drawing.Point(19, 49);
            this.txt_cuenta.Name = "txt_cuenta";
            this.txt_cuenta.Size = new System.Drawing.Size(414, 24);
            this.txt_cuenta.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(439, 46);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 29);
            this.button1.TabIndex = 7;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Seleccione la cuenta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 31);
            this.label1.TabIndex = 21;
            this.label1.Text = "Saldo";
            // 
            // panel_saldo
            // 
            this.panel_saldo.Controls.Add(this.label1);
            this.panel_saldo.Controls.Add(this.groupBox1);
            this.panel_saldo.Location = new System.Drawing.Point(12, 9);
            this.panel_saldo.Name = "panel_saldo";
            this.panel_saldo.Size = new System.Drawing.Size(559, 392);
            this.panel_saldo.TabIndex = 27;
            // 
            // panel_movimientos
            // 
            this.panel_movimientos.Controls.Add(this.label3);
            this.panel_movimientos.Controls.Add(this.grilla_resu);
            this.panel_movimientos.Controls.Add(this.label5);
            this.panel_movimientos.Controls.Add(this.label_importe);
            this.panel_movimientos.Location = new System.Drawing.Point(12, 407);
            this.panel_movimientos.Name = "panel_movimientos";
            this.panel_movimientos.Size = new System.Drawing.Size(559, 392);
            this.panel_movimientos.TabIndex = 28;
            this.panel_movimientos.Visible = false;
            // 
            // FormSaldo_admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 818);
            this.Controls.Add(this.panel_movimientos);
            this.Controls.Add(this.panel_saldo);
            this.Name = "FormSaldo_admin";
            this.Text = "Consultar Saldo";
            this.Load += new System.EventHandler(this.FormSaldo_admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grilla_resu)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grilla_cuentas)).EndInit();
            this.panel_saldo.ResumeLayout(false);
            this.panel_saldo.PerformLayout();
            this.panel_movimientos.ResumeLayout(false);
            this.panel_movimientos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label_importe;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView grilla_resu;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_cuenta;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView grilla_cuentas;
        private System.Windows.Forms.Panel panel_saldo;
        private System.Windows.Forms.Panel panel_movimientos;
    }
}