namespace PagoElectronico.ABM_Cuenta
{
    partial class FormCuenta
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
            this.cbMoneda = new System.Windows.Forms.ComboBox();
            this.tbNroCuenta = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbPais = new System.Windows.Forms.ComboBox();
            this.btAceptar = new System.Windows.Forms.Button();
            this.btClose = new System.Windows.Forms.Button();
            this.lOperacion = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.pnlEstado = new System.Windows.Forms.Panel();
            this.btCerrarCuenta = new System.Windows.Forms.Button();
            this.btHabilitarCuenta = new System.Windows.Forms.Button();
            this.pnDatosEstatico = new System.Windows.Forms.Panel();
            this.tbFechaVencimiento = new System.Windows.Forms.TextBox();
            this.tbFechaApertura = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbTipoCuenta = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btTipoCuenta = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_cta_saldo = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_cta_suscrip = new System.Windows.Forms.Label();
            this.pnlEstado.SuspendLayout();
            this.pnDatosEstatico.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbMoneda
            // 
            this.cbMoneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMoneda.FormattingEnabled = true;
            this.cbMoneda.Location = new System.Drawing.Point(157, 147);
            this.cbMoneda.Name = "cbMoneda";
            this.cbMoneda.Size = new System.Drawing.Size(208, 21);
            this.cbMoneda.TabIndex = 40;
            // 
            // tbNroCuenta
            // 
            this.tbNroCuenta.Location = new System.Drawing.Point(157, 15);
            this.tbNroCuenta.Name = "tbNroCuenta";
            this.tbNroCuenta.Size = new System.Drawing.Size(208, 20);
            this.tbNroCuenta.TabIndex = 37;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 36;
            this.label4.Text = "Fecha de apertura";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(94, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 35;
            this.label3.Text = "Moneda";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "País de registro";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "Número de cuenta";
            // 
            // cbPais
            // 
            this.cbPais.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPais.FormattingEnabled = true;
            this.cbPais.Location = new System.Drawing.Point(157, 179);
            this.cbPais.Name = "cbPais";
            this.cbPais.Size = new System.Drawing.Size(208, 21);
            this.cbPais.TabIndex = 32;
            // 
            // btAceptar
            // 
            this.btAceptar.ForeColor = System.Drawing.Color.Green;
            this.btAceptar.Location = new System.Drawing.Point(107, 528);
            this.btAceptar.Name = "btAceptar";
            this.btAceptar.Size = new System.Drawing.Size(86, 25);
            this.btAceptar.TabIndex = 42;
            this.btAceptar.Text = "Aceptar";
            this.btAceptar.UseVisualStyleBackColor = true;
            this.btAceptar.Click += new System.EventHandler(this.btAceptar_Click);
            // 
            // btClose
            // 
            this.btClose.Location = new System.Drawing.Point(15, 528);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(86, 25);
            this.btClose.TabIndex = 43;
            this.btClose.Text = "Cancelar";
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // lOperacion
            // 
            this.lOperacion.AutoSize = true;
            this.lOperacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lOperacion.Location = new System.Drawing.Point(12, 9);
            this.lOperacion.Name = "lOperacion";
            this.lOperacion.Size = new System.Drawing.Size(96, 16);
            this.lOperacion.TabIndex = 45;
            this.lOperacion.Text = "OPERACION";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(108, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 47;
            this.label6.Text = "Estado";
            // 
            // cbEstado
            // 
            this.cbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Location = new System.Drawing.Point(165, 5);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(208, 21);
            this.cbEstado.TabIndex = 48;
            // 
            // pnlEstado
            // 
            this.pnlEstado.Controls.Add(this.cbEstado);
            this.pnlEstado.Controls.Add(this.label6);
            this.pnlEstado.Location = new System.Drawing.Point(6, 26);
            this.pnlEstado.Name = "pnlEstado";
            this.pnlEstado.Size = new System.Drawing.Size(401, 31);
            this.pnlEstado.TabIndex = 49;
            // 
            // btCerrarCuenta
            // 
            this.btCerrarCuenta.Location = new System.Drawing.Point(14, 29);
            this.btCerrarCuenta.Name = "btCerrarCuenta";
            this.btCerrarCuenta.Size = new System.Drawing.Size(116, 34);
            this.btCerrarCuenta.TabIndex = 50;
            this.btCerrarCuenta.Text = "Cerrar Cuenta";
            this.btCerrarCuenta.UseVisualStyleBackColor = true;
            this.btCerrarCuenta.Click += new System.EventHandler(this.btCerrarCuenta_Click);
            // 
            // btHabilitarCuenta
            // 
            this.btHabilitarCuenta.Location = new System.Drawing.Point(136, 29);
            this.btHabilitarCuenta.Name = "btHabilitarCuenta";
            this.btHabilitarCuenta.Size = new System.Drawing.Size(114, 34);
            this.btHabilitarCuenta.TabIndex = 51;
            this.btHabilitarCuenta.Text = "Habilitar Cuenta";
            this.btHabilitarCuenta.UseVisualStyleBackColor = true;
            this.btHabilitarCuenta.Click += new System.EventHandler(this.btHabilitarCuenta_Click);
            // 
            // pnDatosEstatico
            // 
            this.pnDatosEstatico.Controls.Add(this.txt_cta_suscrip);
            this.pnDatosEstatico.Controls.Add(this.label10);
            this.pnDatosEstatico.Controls.Add(this.txt_cta_saldo);
            this.pnDatosEstatico.Controls.Add(this.label8);
            this.pnDatosEstatico.Controls.Add(this.tbFechaVencimiento);
            this.pnDatosEstatico.Controls.Add(this.tbFechaApertura);
            this.pnDatosEstatico.Controls.Add(this.cbMoneda);
            this.pnDatosEstatico.Controls.Add(this.label7);
            this.pnDatosEstatico.Controls.Add(this.label3);
            this.pnDatosEstatico.Controls.Add(this.label2);
            this.pnDatosEstatico.Controls.Add(this.tbTipoCuenta);
            this.pnDatosEstatico.Controls.Add(this.cbPais);
            this.pnDatosEstatico.Controls.Add(this.label5);
            this.pnDatosEstatico.Controls.Add(this.label1);
            this.pnDatosEstatico.Controls.Add(this.tbNroCuenta);
            this.pnDatosEstatico.Controls.Add(this.label4);
            this.pnDatosEstatico.Location = new System.Drawing.Point(14, 22);
            this.pnDatosEstatico.Name = "pnDatosEstatico";
            this.pnDatosEstatico.Size = new System.Drawing.Size(393, 249);
            this.pnDatosEstatico.TabIndex = 52;
            // 
            // tbFechaVencimiento
            // 
            this.tbFechaVencimiento.Location = new System.Drawing.Point(157, 67);
            this.tbFechaVencimiento.Name = "tbFechaVencimiento";
            this.tbFechaVencimiento.Size = new System.Drawing.Size(208, 20);
            this.tbFechaVencimiento.TabIndex = 59;
            // 
            // tbFechaApertura
            // 
            this.tbFechaApertura.Location = new System.Drawing.Point(157, 41);
            this.tbFechaApertura.Name = "tbFechaApertura";
            this.tbFechaApertura.Size = new System.Drawing.Size(208, 20);
            this.tbFechaApertura.TabIndex = 58;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(75, 98);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 56;
            this.label7.Text = "Tipo Cuenta";
            // 
            // tbTipoCuenta
            // 
            this.tbTipoCuenta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.tbTipoCuenta.Location = new System.Drawing.Point(157, 95);
            this.tbTipoCuenta.Name = "tbTipoCuenta";
            this.tbTipoCuenta.ReadOnly = true;
            this.tbTipoCuenta.Size = new System.Drawing.Size(208, 20);
            this.tbTipoCuenta.TabIndex = 57;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 13);
            this.label5.TabIndex = 54;
            this.label5.Text = "Fecha de venciemiento";
            // 
            // btTipoCuenta
            // 
            this.btTipoCuenta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btTipoCuenta.Location = new System.Drawing.Point(256, 29);
            this.btTipoCuenta.Name = "btTipoCuenta";
            this.btTipoCuenta.Size = new System.Drawing.Size(151, 34);
            this.btTipoCuenta.TabIndex = 53;
            this.btTipoCuenta.Text = "Button";
            this.btTipoCuenta.UseVisualStyleBackColor = true;
            this.btTipoCuenta.Click += new System.EventHandler(this.btTipoCuenta_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pnDatosEstatico);
            this.groupBox1.Location = new System.Drawing.Point(15, 128);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(429, 288);
            this.groupBox1.TabIndex = 53;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de la cuenta";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pnlEstado);
            this.groupBox2.Location = new System.Drawing.Point(15, 40);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(429, 70);
            this.groupBox2.TabIndex = 54;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Estado de la cuenta";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btCerrarCuenta);
            this.groupBox3.Controls.Add(this.btHabilitarCuenta);
            this.groupBox3.Controls.Add(this.btTipoCuenta);
            this.groupBox3.Location = new System.Drawing.Point(15, 436);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(429, 79);
            this.groupBox3.TabIndex = 55;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Acciones";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(62, 221);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 13);
            this.label8.TabIndex = 60;
            this.label8.Text = "Saldo actual";
            // 
            // txt_cta_saldo
            // 
            this.txt_cta_saldo.AutoSize = true;
            this.txt_cta_saldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cta_saldo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txt_cta_saldo.Location = new System.Drawing.Point(154, 221);
            this.txt_cta_saldo.Name = "txt_cta_saldo";
            this.txt_cta_saldo.Size = new System.Drawing.Size(70, 13);
            this.txt_cta_saldo.TabIndex = 61;
            this.txt_cta_saldo.Text = "000000000";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(43, 124);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 13);
            this.label10.TabIndex = 62;
            this.label10.Text = "Subscripciones:";
            // 
            // txt_cta_suscrip
            // 
            this.txt_cta_suscrip.AutoSize = true;
            this.txt_cta_suscrip.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cta_suscrip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txt_cta_suscrip.Location = new System.Drawing.Point(156, 124);
            this.txt_cta_suscrip.Name = "txt_cta_suscrip";
            this.txt_cta_suscrip.Size = new System.Drawing.Size(70, 13);
            this.txt_cta_suscrip.TabIndex = 63;
            this.txt_cta_suscrip.Text = "000000000";
            // 
            // FormCuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 560);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lOperacion);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.btAceptar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCuenta";
            this.Text = "Cuenta";
            this.Load += new System.EventHandler(this.FormCuenta_Load);
            this.pnlEstado.ResumeLayout(false);
            this.pnlEstado.PerformLayout();
            this.pnDatosEstatico.ResumeLayout(false);
            this.pnDatosEstatico.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbMoneda;
        private System.Windows.Forms.TextBox tbNroCuenta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbPais;
        private System.Windows.Forms.Button btAceptar;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.Label lOperacion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbEstado;
        private System.Windows.Forms.Panel pnlEstado;
        private System.Windows.Forms.Button btCerrarCuenta;
        private System.Windows.Forms.Button btHabilitarCuenta;
        private System.Windows.Forms.Panel pnDatosEstatico;
        private System.Windows.Forms.Button btTipoCuenta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbTipoCuenta;
        private System.Windows.Forms.TextBox tbFechaVencimiento;
        private System.Windows.Forms.TextBox tbFechaApertura;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label txt_cta_saldo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label txt_cta_suscrip;
        private System.Windows.Forms.Label label10;
    }
}