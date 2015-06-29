namespace PagoElectronico.ABM_Cliente
{
    partial class FormCliente
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbApellido = new System.Windows.Forms.TextBox();
            this.tbMail = new System.Windows.Forms.TextBox();
            this.btCloseCliente = new System.Windows.Forms.Button();
            this.pnlCliente = new System.Windows.Forms.Panel();
            this.tbUsuario = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbPais = new System.Windows.Forms.ComboBox();
            this.tbIdentificacion = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbTipoIdentificacion = new System.Windows.Forms.ComboBox();
            this.lOperacion = new System.Windows.Forms.Label();
            this.pnDarBaja = new System.Windows.Forms.Panel();
            this.cbDarBaja = new System.Windows.Forms.CheckBox();
            this.btAceptar = new System.Windows.Forms.Button();
            this.pnlCliente.SuspendLayout();
            this.pnDarBaja.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Apellido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mail";
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(182, 57);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(202, 20);
            this.tbNombre.TabIndex = 3;
            // 
            // tbApellido
            // 
            this.tbApellido.Location = new System.Drawing.Point(182, 85);
            this.tbApellido.Name = "tbApellido";
            this.tbApellido.Size = new System.Drawing.Size(202, 20);
            this.tbApellido.TabIndex = 4;
            // 
            // tbMail
            // 
            this.tbMail.Location = new System.Drawing.Point(182, 118);
            this.tbMail.Name = "tbMail";
            this.tbMail.Size = new System.Drawing.Size(202, 20);
            this.tbMail.TabIndex = 5;
            // 
            // btCloseCliente
            // 
            this.btCloseCliente.Location = new System.Drawing.Point(31, 511);
            this.btCloseCliente.Name = "btCloseCliente";
            this.btCloseCliente.Size = new System.Drawing.Size(75, 23);
            this.btCloseCliente.TabIndex = 7;
            this.btCloseCliente.Text = "Close";
            this.btCloseCliente.UseVisualStyleBackColor = true;
            this.btCloseCliente.Click += new System.EventHandler(this.btCloseCliente_Click);
            // 
            // pnlCliente
            // 
            this.pnlCliente.Controls.Add(this.tbUsuario);
            this.pnlCliente.Controls.Add(this.label4);
            this.pnlCliente.Controls.Add(this.label8);
            this.pnlCliente.Controls.Add(this.cbPais);
            this.pnlCliente.Controls.Add(this.tbIdentificacion);
            this.pnlCliente.Controls.Add(this.label6);
            this.pnlCliente.Controls.Add(this.label7);
            this.pnlCliente.Controls.Add(this.cbTipoIdentificacion);
            this.pnlCliente.Controls.Add(this.label1);
            this.pnlCliente.Controls.Add(this.label2);
            this.pnlCliente.Controls.Add(this.label3);
            this.pnlCliente.Controls.Add(this.tbNombre);
            this.pnlCliente.Controls.Add(this.tbApellido);
            this.pnlCliente.Controls.Add(this.tbMail);
            this.pnlCliente.Location = new System.Drawing.Point(31, 89);
            this.pnlCliente.Name = "pnlCliente";
            this.pnlCliente.Size = new System.Drawing.Size(411, 263);
            this.pnlCliente.TabIndex = 12;
            // 
            // tbUsuario
            // 
            this.tbUsuario.Location = new System.Drawing.Point(182, 14);
            this.tbUsuario.Name = "tbUsuario";
            this.tbUsuario.Size = new System.Drawing.Size(202, 20);
            this.tbUsuario.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Usuario";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 236);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "País";
            // 
            // cbPais
            // 
            this.cbPais.FormattingEnabled = true;
            this.cbPais.Location = new System.Drawing.Point(182, 228);
            this.cbPais.Name = "cbPais";
            this.cbPais.Size = new System.Drawing.Size(202, 21);
            this.cbPais.TabIndex = 12;
            // 
            // tbIdentificacion
            // 
            this.tbIdentificacion.Location = new System.Drawing.Point(182, 192);
            this.tbIdentificacion.Name = "tbIdentificacion";
            this.tbIdentificacion.Size = new System.Drawing.Size(202, 20);
            this.tbIdentificacion.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 199);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Identificacion";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 156);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Tipo Identificación";
            // 
            // cbTipoIdentificacion
            // 
            this.cbTipoIdentificacion.FormattingEnabled = true;
            this.cbTipoIdentificacion.Location = new System.Drawing.Point(182, 148);
            this.cbTipoIdentificacion.Name = "cbTipoIdentificacion";
            this.cbTipoIdentificacion.Size = new System.Drawing.Size(202, 21);
            this.cbTipoIdentificacion.TabIndex = 8;
            // 
            // lOperacion
            // 
            this.lOperacion.AutoSize = true;
            this.lOperacion.Location = new System.Drawing.Point(28, 9);
            this.lOperacion.Name = "lOperacion";
            this.lOperacion.Size = new System.Drawing.Size(70, 13);
            this.lOperacion.TabIndex = 18;
            this.lOperacion.Text = "OPERACION";
            // 
            // pnDarBaja
            // 
            this.pnDarBaja.Controls.Add(this.cbDarBaja);
            this.pnDarBaja.Location = new System.Drawing.Point(31, 380);
            this.pnDarBaja.Name = "pnDarBaja";
            this.pnDarBaja.Size = new System.Drawing.Size(113, 57);
            this.pnDarBaja.TabIndex = 20;
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
            // btAceptar
            // 
            this.btAceptar.Location = new System.Drawing.Point(339, 511);
            this.btAceptar.Name = "btAceptar";
            this.btAceptar.Size = new System.Drawing.Size(75, 23);
            this.btAceptar.TabIndex = 21;
            this.btAceptar.Text = "button1";
            this.btAceptar.UseVisualStyleBackColor = true;
            this.btAceptar.Click += new System.EventHandler(this.btAceptar_Click);
            // 
            // FormCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 560);
            this.Controls.Add(this.btAceptar);
            this.Controls.Add(this.pnDarBaja);
            this.Controls.Add(this.lOperacion);
            this.Controls.Add(this.pnlCliente);
            this.Controls.Add(this.btCloseCliente);
            this.Name = "FormCliente";
            this.Text = "FormCliente";
            this.pnlCliente.ResumeLayout(false);
            this.pnlCliente.PerformLayout();
            this.pnDarBaja.ResumeLayout(false);
            this.pnDarBaja.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.TextBox tbApellido;
        private System.Windows.Forms.TextBox tbMail;
        private System.Windows.Forms.Button btCloseCliente;
        private System.Windows.Forms.Panel pnlCliente;
        private System.Windows.Forms.TextBox tbIdentificacion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbTipoIdentificacion;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbPais;
        private System.Windows.Forms.TextBox tbUsuario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lOperacion;
        private System.Windows.Forms.Panel pnDarBaja;
        private System.Windows.Forms.CheckBox cbDarBaja;
        private System.Windows.Forms.Button btAceptar;
    }
}