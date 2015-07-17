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
            this.tbPiso = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.tbLocalidad = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbNroDepartamento = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbNroCalle = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbCalle = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
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
            this.label13 = new System.Windows.Forms.Label();
            this.cbDarBaja = new System.Windows.Forms.CheckBox();
            this.btAceptar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pnlCliente.SuspendLayout();
            this.pnDarBaja.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Apellido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mail";
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(133, 57);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(202, 20);
            this.tbNombre.TabIndex = 3;
            // 
            // tbApellido
            // 
            this.tbApellido.Location = new System.Drawing.Point(133, 85);
            this.tbApellido.Name = "tbApellido";
            this.tbApellido.Size = new System.Drawing.Size(202, 20);
            this.tbApellido.TabIndex = 4;
            // 
            // tbMail
            // 
            this.tbMail.Location = new System.Drawing.Point(133, 118);
            this.tbMail.Name = "tbMail";
            this.tbMail.Size = new System.Drawing.Size(202, 20);
            this.tbMail.TabIndex = 5;
            // 
            // btCloseCliente
            // 
            this.btCloseCliente.Location = new System.Drawing.Point(14, 445);
            this.btCloseCliente.Name = "btCloseCliente";
            this.btCloseCliente.Size = new System.Drawing.Size(100, 33);
            this.btCloseCliente.TabIndex = 7;
            this.btCloseCliente.Text = "Cerrar";
            this.btCloseCliente.UseVisualStyleBackColor = true;
            this.btCloseCliente.Click += new System.EventHandler(this.btCloseCliente_Click);
            // 
            // pnlCliente
            // 
            this.pnlCliente.Controls.Add(this.tbPiso);
            this.pnlCliente.Controls.Add(this.label14);
            this.pnlCliente.Controls.Add(this.dtpFechaNacimiento);
            this.pnlCliente.Controls.Add(this.label12);
            this.pnlCliente.Controls.Add(this.tbLocalidad);
            this.pnlCliente.Controls.Add(this.label11);
            this.pnlCliente.Controls.Add(this.tbNroDepartamento);
            this.pnlCliente.Controls.Add(this.label10);
            this.pnlCliente.Controls.Add(this.tbNroCalle);
            this.pnlCliente.Controls.Add(this.label9);
            this.pnlCliente.Controls.Add(this.tbCalle);
            this.pnlCliente.Controls.Add(this.label5);
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
            this.pnlCliente.Location = new System.Drawing.Point(11, 21);
            this.pnlCliente.Name = "pnlCliente";
            this.pnlCliente.Size = new System.Drawing.Size(718, 268);
            this.pnlCliente.TabIndex = 12;
            // 
            // tbPiso
            // 
            this.tbPiso.Location = new System.Drawing.Point(492, 109);
            this.tbPiso.MaxLength = 9;
            this.tbPiso.Name = "tbPiso";
            this.tbPiso.Size = new System.Drawing.Size(202, 20);
            this.tbPiso.TabIndex = 48;
            this.tbPiso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPiso_KeyPress);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(353, 112);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(31, 13);
            this.label14.TabIndex = 47;
            this.label14.Text = "Piso";
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(493, 178);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaNacimiento.TabIndex = 46;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(352, 183);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(125, 13);
            this.label12.TabIndex = 45;
            this.label12.Text = "Fecha de nacimiento";
            // 
            // tbLocalidad
            // 
            this.tbLocalidad.Location = new System.Drawing.Point(491, 142);
            this.tbLocalidad.Name = "tbLocalidad";
            this.tbLocalidad.Size = new System.Drawing.Size(202, 20);
            this.tbLocalidad.TabIndex = 23;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(352, 145);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "Localidad";
            // 
            // tbNroDepartamento
            // 
            this.tbNroDepartamento.Location = new System.Drawing.Point(491, 79);
            this.tbNroDepartamento.Name = "tbNroDepartamento";
            this.tbNroDepartamento.Size = new System.Drawing.Size(202, 20);
            this.tbNroDepartamento.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(352, 82);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Departamento";
            // 
            // tbNroCalle
            // 
            this.tbNroCalle.Location = new System.Drawing.Point(491, 49);
            this.tbNroCalle.MaxLength = 9;
            this.tbNroCalle.Name = "tbNroCalle";
            this.tbNroCalle.Size = new System.Drawing.Size(202, 20);
            this.tbNroCalle.TabIndex = 19;
            this.tbNroCalle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNroCalle_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(352, 52);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Numero";
            // 
            // tbCalle
            // 
            this.tbCalle.Location = new System.Drawing.Point(491, 14);
            this.tbCalle.Name = "tbCalle";
            this.tbCalle.Size = new System.Drawing.Size(202, 20);
            this.tbCalle.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(352, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Calle";
            // 
            // tbUsuario
            // 
            this.tbUsuario.Location = new System.Drawing.Point(133, 14);
            this.tbUsuario.Name = "tbUsuario";
            this.tbUsuario.Size = new System.Drawing.Size(202, 20);
            this.tbUsuario.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Usuario";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(14, 236);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "País";
            // 
            // cbPais
            // 
            this.cbPais.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPais.FormattingEnabled = true;
            this.cbPais.Location = new System.Drawing.Point(133, 228);
            this.cbPais.Name = "cbPais";
            this.cbPais.Size = new System.Drawing.Size(202, 21);
            this.cbPais.TabIndex = 12;
            // 
            // tbIdentificacion
            // 
            this.tbIdentificacion.Location = new System.Drawing.Point(133, 192);
            this.tbIdentificacion.MaxLength = 9;
            this.tbIdentificacion.Name = "tbIdentificacion";
            this.tbIdentificacion.Size = new System.Drawing.Size(202, 20);
            this.tbIdentificacion.TabIndex = 11;
            this.tbIdentificacion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbIdentificacion_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(14, 199);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Identificacion";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(14, 156);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Tipo Identificación";
            // 
            // cbTipoIdentificacion
            // 
            this.cbTipoIdentificacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoIdentificacion.FormattingEnabled = true;
            this.cbTipoIdentificacion.Location = new System.Drawing.Point(133, 152);
            this.cbTipoIdentificacion.Name = "cbTipoIdentificacion";
            this.cbTipoIdentificacion.Size = new System.Drawing.Size(202, 21);
            this.cbTipoIdentificacion.TabIndex = 8;
            // 
            // lOperacion
            // 
            this.lOperacion.AutoSize = true;
            this.lOperacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lOperacion.Location = new System.Drawing.Point(22, 13);
            this.lOperacion.Name = "lOperacion";
            this.lOperacion.Size = new System.Drawing.Size(79, 13);
            this.lOperacion.TabIndex = 18;
            this.lOperacion.Text = "OPERACION";
            // 
            // pnDarBaja
            // 
            this.pnDarBaja.Controls.Add(this.label13);
            this.pnDarBaja.Controls.Add(this.cbDarBaja);
            this.pnDarBaja.Location = new System.Drawing.Point(14, 361);
            this.pnDarBaja.Name = "pnDarBaja";
            this.pnDarBaja.Size = new System.Drawing.Size(437, 65);
            this.pnDarBaja.TabIndex = 20;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label13.Location = new System.Drawing.Point(15, 14);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(313, 13);
            this.label13.TabIndex = 2;
            this.label13.Text = "Seleccione esta opción si desea desabilitar al cliente.";
            // 
            // cbDarBaja
            // 
            this.cbDarBaja.AutoSize = true;
            this.cbDarBaja.Location = new System.Drawing.Point(17, 34);
            this.cbDarBaja.Name = "cbDarBaja";
            this.cbDarBaja.Size = new System.Drawing.Size(115, 17);
            this.cbDarBaja.TabIndex = 1;
            this.cbDarBaja.Text = "Deshabilitar cliente";
            this.cbDarBaja.UseVisualStyleBackColor = true;
            // 
            // btAceptar
            // 
            this.btAceptar.ForeColor = System.Drawing.Color.Green;
            this.btAceptar.Location = new System.Drawing.Point(122, 445);
            this.btAceptar.Name = "btAceptar";
            this.btAceptar.Size = new System.Drawing.Size(115, 33);
            this.btAceptar.TabIndex = 21;
            this.btAceptar.Text = "Aceptar";
            this.btAceptar.UseVisualStyleBackColor = true;
            this.btAceptar.Click += new System.EventHandler(this.btAceptar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pnlCliente);
            this.groupBox1.Location = new System.Drawing.Point(14, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(743, 305);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del cliente";
            // 
            // FormCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 492);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btAceptar);
            this.Controls.Add(this.pnDarBaja);
            this.Controls.Add(this.lOperacion);
            this.Controls.Add(this.btCloseCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCliente";
            this.Text = "Cliente";
            this.Load += new System.EventHandler(this.FormCliente_Load);
            this.pnlCliente.ResumeLayout(false);
            this.pnlCliente.PerformLayout();
            this.pnDarBaja.ResumeLayout(false);
            this.pnDarBaja.PerformLayout();
            this.groupBox1.ResumeLayout(false);
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
        private System.Windows.Forms.TextBox tbLocalidad;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbNroDepartamento;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbNroCalle;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbCalle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbPiso;
        private System.Windows.Forms.Label label14;
    }
}