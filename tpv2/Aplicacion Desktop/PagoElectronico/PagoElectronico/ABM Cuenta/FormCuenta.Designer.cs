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
            this.tbFechaApertura = new System.Windows.Forms.TextBox();
            this.tbNroCuenta = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbPais = new System.Windows.Forms.ComboBox();
            this.btAddCuenta = new System.Windows.Forms.Button();
            this.btClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbTipoCuenta
            // 
            this.cbTipoCuenta.FormattingEnabled = true;
            this.cbTipoCuenta.Location = new System.Drawing.Point(313, 212);
            this.cbTipoCuenta.Name = "cbTipoCuenta";
            this.cbTipoCuenta.Size = new System.Drawing.Size(202, 21);
            this.cbTipoCuenta.TabIndex = 41;
            // 
            // cbMoneda
            // 
            this.cbMoneda.FormattingEnabled = true;
            this.cbMoneda.Location = new System.Drawing.Point(313, 134);
            this.cbMoneda.Name = "cbMoneda";
            this.cbMoneda.Size = new System.Drawing.Size(202, 21);
            this.cbMoneda.TabIndex = 40;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(63, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 39;
            this.label5.Text = "Tipo de cuenta";
            // 
            // tbFechaApertura
            // 
            this.tbFechaApertura.Location = new System.Drawing.Point(313, 172);
            this.tbFechaApertura.Name = "tbFechaApertura";
            this.tbFechaApertura.Size = new System.Drawing.Size(202, 20);
            this.tbFechaApertura.TabIndex = 38;
            // 
            // tbNroCuenta
            // 
            this.tbNroCuenta.Location = new System.Drawing.Point(313, 51);
            this.tbNroCuenta.Name = "tbNroCuenta";
            this.tbNroCuenta.Size = new System.Drawing.Size(202, 20);
            this.tbNroCuenta.TabIndex = 37;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 36;
            this.label4.Text = "Fecha de apertura";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 35;
            this.label3.Text = "Moneda";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "País de registro";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "Número de cuenta";
            // 
            // cbPais
            // 
            this.cbPais.FormattingEnabled = true;
            this.cbPais.Location = new System.Drawing.Point(313, 86);
            this.cbPais.Name = "cbPais";
            this.cbPais.Size = new System.Drawing.Size(202, 21);
            this.cbPais.TabIndex = 32;
            // 
            // btAddCuenta
            // 
            this.btAddCuenta.Location = new System.Drawing.Point(400, 276);
            this.btAddCuenta.Name = "btAddCuenta";
            this.btAddCuenta.Size = new System.Drawing.Size(75, 23);
            this.btAddCuenta.TabIndex = 42;
            this.btAddCuenta.Text = "Aceptar";
            this.btAddCuenta.UseVisualStyleBackColor = true;
            this.btAddCuenta.Click += new System.EventHandler(this.btAddCuenta_Click);
            // 
            // btClose
            // 
            this.btClose.Location = new System.Drawing.Point(79, 266);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(75, 23);
            this.btClose.TabIndex = 43;
            this.btClose.Text = "Cancelar";
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // FormCuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 320);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.btAddCuenta);
            this.Controls.Add(this.cbTipoCuenta);
            this.Controls.Add(this.cbMoneda);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbFechaApertura);
            this.Controls.Add(this.tbNroCuenta);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbPais);
            this.Name = "FormCuenta";
            this.Text = "FormCuenta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbTipoCuenta;
        private System.Windows.Forms.ComboBox cbMoneda;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbFechaApertura;
        private System.Windows.Forms.TextBox tbNroCuenta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbPais;
        private System.Windows.Forms.Button btAddCuenta;
        private System.Windows.Forms.Button btClose;
    }
}