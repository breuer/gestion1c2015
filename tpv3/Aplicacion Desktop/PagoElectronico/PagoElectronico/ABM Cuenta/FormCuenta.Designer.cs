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
            this.cbTipoCuenta = new System.Windows.Forms.ComboBox();
            this.cbMoneda = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbNroCuenta = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbPais = new System.Windows.Forms.ComboBox();
            this.btAceptar = new System.Windows.Forms.Button();
            this.btClose = new System.Windows.Forms.Button();
            this.dtpFechaApertura = new System.Windows.Forms.DateTimePicker();
            this.lOperacion = new System.Windows.Forms.Label();
            this.pnDarBaja = new System.Windows.Forms.Panel();
            this.cbDarBaja = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.pnlEstado = new System.Windows.Forms.Panel();
            this.pnDarBaja.SuspendLayout();
            this.pnlEstado.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbTipoCuenta
            // 
            this.cbTipoCuenta.FormattingEnabled = true;
            this.cbTipoCuenta.Location = new System.Drawing.Point(297, 254);
            this.cbTipoCuenta.Name = "cbTipoCuenta";
            this.cbTipoCuenta.Size = new System.Drawing.Size(202, 21);
            this.cbTipoCuenta.TabIndex = 41;
            // 
            // cbMoneda
            // 
            this.cbMoneda.FormattingEnabled = true;
            this.cbMoneda.Location = new System.Drawing.Point(297, 176);
            this.cbMoneda.Name = "cbMoneda";
            this.cbMoneda.Size = new System.Drawing.Size(202, 21);
            this.cbMoneda.TabIndex = 40;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 263);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 39;
            this.label5.Text = "Tipo de cuenta";
            // 
            // tbNroCuenta
            // 
            this.tbNroCuenta.Location = new System.Drawing.Point(297, 93);
            this.tbNroCuenta.Name = "tbNroCuenta";
            this.tbNroCuenta.Size = new System.Drawing.Size(202, 20);
            this.tbNroCuenta.TabIndex = 37;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 36;
            this.label4.Text = "Fecha de apertura";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 35;
            this.label3.Text = "Moneda";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "País de registro";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "Número de cuenta";
            // 
            // cbPais
            // 
            this.cbPais.FormattingEnabled = true;
            this.cbPais.Location = new System.Drawing.Point(297, 128);
            this.cbPais.Name = "cbPais";
            this.cbPais.Size = new System.Drawing.Size(202, 21);
            this.cbPais.TabIndex = 32;
            // 
            // btAceptar
            // 
            this.btAceptar.Location = new System.Drawing.Point(441, 426);
            this.btAceptar.Name = "btAceptar";
            this.btAceptar.Size = new System.Drawing.Size(75, 23);
            this.btAceptar.TabIndex = 42;
            this.btAceptar.Text = "Aceptar";
            this.btAceptar.UseVisualStyleBackColor = true;
            this.btAceptar.Click += new System.EventHandler(this.btAceptar_Click);
            // 
            // btClose
            // 
            this.btClose.Location = new System.Drawing.Point(67, 426);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(75, 23);
            this.btClose.TabIndex = 43;
            this.btClose.Text = "Cancelar";
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // dtpFechaApertura
            // 
            this.dtpFechaApertura.Location = new System.Drawing.Point(299, 214);
            this.dtpFechaApertura.Name = "dtpFechaApertura";
            this.dtpFechaApertura.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaApertura.TabIndex = 44;
            // 
            // lOperacion
            // 
            this.lOperacion.AutoSize = true;
            this.lOperacion.Location = new System.Drawing.Point(34, 13);
            this.lOperacion.Name = "lOperacion";
            this.lOperacion.Size = new System.Drawing.Size(70, 13);
            this.lOperacion.TabIndex = 45;
            this.lOperacion.Text = "OPERACION";
            // 
            // pnDarBaja
            // 
            this.pnDarBaja.Controls.Add(this.cbDarBaja);
            this.pnDarBaja.Location = new System.Drawing.Point(50, 329);
            this.pnDarBaja.Name = "pnDarBaja";
            this.pnDarBaja.Size = new System.Drawing.Size(113, 57);
            this.pnDarBaja.TabIndex = 46;
            // 
            // cbDarBaja
            // 
            this.cbDarBaja.AutoSize = true;
            this.cbDarBaja.Location = new System.Drawing.Point(22, 21);
            this.cbDarBaja.Name = "cbDarBaja";
            this.cbDarBaja.Size = new System.Drawing.Size(67, 17);
            this.cbDarBaja.TabIndex = 1;
            this.cbDarBaja.Text = "Dar Baja";
            this.cbDarBaja.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 47;
            this.label6.Text = "Estado";
            // 
            // cbEstado
            // 
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Location = new System.Drawing.Point(267, 13);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(202, 21);
            this.cbEstado.TabIndex = 48;
            // 
            // pnlEstado
            // 
            this.pnlEstado.Controls.Add(this.cbEstado);
            this.pnlEstado.Controls.Add(this.label6);
            this.pnlEstado.Location = new System.Drawing.Point(30, 29);
            this.pnlEstado.Name = "pnlEstado";
            this.pnlEstado.Size = new System.Drawing.Size(486, 47);
            this.pnlEstado.TabIndex = 49;
            // 
            // FormCuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 484);
            this.Controls.Add(this.pnlEstado);
            this.Controls.Add(this.pnDarBaja);
            this.Controls.Add(this.lOperacion);
            this.Controls.Add(this.dtpFechaApertura);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.btAceptar);
            this.Controls.Add(this.cbTipoCuenta);
            this.Controls.Add(this.cbMoneda);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbNroCuenta);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbPais);
            this.Name = "FormCuenta";
            this.Text = "FormCuenta";
            this.pnDarBaja.ResumeLayout(false);
            this.pnDarBaja.PerformLayout();
            this.pnlEstado.ResumeLayout(false);
            this.pnlEstado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbTipoCuenta;
        private System.Windows.Forms.ComboBox cbMoneda;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbNroCuenta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbPais;
        private System.Windows.Forms.Button btAceptar;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.DateTimePicker dtpFechaApertura;
        private System.Windows.Forms.Label lOperacion;
        private System.Windows.Forms.Panel pnDarBaja;
        private System.Windows.Forms.CheckBox cbDarBaja;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbEstado;
        private System.Windows.Forms.Panel pnlEstado;
    }
}