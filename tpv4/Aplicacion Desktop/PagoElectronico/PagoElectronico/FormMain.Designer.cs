namespace PagoElectronico
{
    partial class FormMain
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
            this.btLogout = new System.Windows.Forms.Button();
            this.btChangePassword = new System.Windows.Forms.Button();
            this.pnlSession = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFechaSistema = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btExit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.btLogin = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.welcome_label = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.admin_tab = new System.Windows.Forms.Panel();
            this.btCuentaClientes = new System.Windows.Forms.Button();
            this.btListadosEstadisticos = new System.Windows.Forms.Button();
            this.pnlUsuario = new System.Windows.Forms.Panel();
            this.btUpdateUsuario = new System.Windows.Forms.Button();
            this.btAddUsuario = new System.Windows.Forms.Button();
            this.pnlCliente = new System.Windows.Forms.Panel();
            this.btUpdateCliente = new System.Windows.Forms.Button();
            this.btAddCliente = new System.Windows.Forms.Button();
            this.pnlRol = new System.Windows.Forms.Panel();
            this.btUpdateRol = new System.Windows.Forms.Button();
            this.btAddRol = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_fact_admin = new System.Windows.Forms.Button();
            this.btn_saldo_admin = new System.Windows.Forms.Button();
            this.status_label = new System.Windows.Forms.Label();
            this.cliente_tab = new System.Windows.Forms.Panel();
            this.btCuenta = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_fact_cli = new System.Windows.Forms.Button();
            this.btn_tarjetas = new System.Windows.Forms.Button();
            this.btn_saldo_cli = new System.Windows.Forms.Button();
            this.btn_transf = new System.Windows.Forms.Button();
            this.btn_retiros = new System.Windows.Forms.Button();
            this.btn_depositos = new System.Windows.Forms.Button();
            this.pnlSession.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlLogin.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.admin_tab.SuspendLayout();
            this.pnlUsuario.SuspendLayout();
            this.pnlCliente.SuspendLayout();
            this.pnlRol.SuspendLayout();
            this.cliente_tab.SuspendLayout();
            this.SuspendLayout();
            // 
            // btLogout
            // 
            this.btLogout.Location = new System.Drawing.Point(123, 2);
            this.btLogout.Name = "btLogout";
            this.btLogout.Size = new System.Drawing.Size(75, 53);
            this.btLogout.TabIndex = 1;
            this.btLogout.Text = "Logout";
            this.btLogout.UseVisualStyleBackColor = true;
            this.btLogout.Click += new System.EventHandler(this.btLogout_Click);
            // 
            // btChangePassword
            // 
            this.btChangePassword.Location = new System.Drawing.Point(0, 2);
            this.btChangePassword.Name = "btChangePassword";
            this.btChangePassword.Size = new System.Drawing.Size(119, 53);
            this.btChangePassword.TabIndex = 2;
            this.btChangePassword.Text = "Cambiar contraseña";
            this.btChangePassword.UseVisualStyleBackColor = true;
            this.btChangePassword.Click += new System.EventHandler(this.btChangePassword_Click);
            // 
            // pnlSession
            // 
            this.pnlSession.Controls.Add(this.btLogout);
            this.pnlSession.Controls.Add(this.btChangePassword);
            this.pnlSession.Location = new System.Drawing.Point(562, 11);
            this.pnlSession.Name = "pnlSession";
            this.pnlSession.Size = new System.Drawing.Size(204, 59);
            this.pnlSession.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(546, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Fecha Sistema";
            // 
            // dtpFechaSistema
            // 
            this.dtpFechaSistema.Location = new System.Drawing.Point(642, 17);
            this.dtpFechaSistema.Name = "dtpFechaSistema";
            this.dtpFechaSistema.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaSistema.TabIndex = 21;
            this.dtpFechaSistema.ValueChanged += new System.EventHandler(this.dtpFechaSistema_ValueChanged);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btExit);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.pnlSession);
            this.panel1.Controls.Add(this.pnlLogin);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(855, 86);
            this.panel1.TabIndex = 22;
            // 
            // btExit
            // 
            this.btExit.BackColor = System.Drawing.Color.IndianRed;
            this.btExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btExit.Location = new System.Drawing.Point(767, 14);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(75, 53);
            this.btExit.TabIndex = 23;
            this.btExit.Text = "Salir";
            this.btExit.UseVisualStyleBackColor = false;
            this.btExit.Click += new System.EventHandler(this.btExit_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.ForestGreen;
            this.label2.Location = new System.Drawing.Point(11, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(224, 29);
            this.label2.TabIndex = 11;
            this.label2.Text = "NEW SOLUTION";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(320, 33);
            this.label3.TabIndex = 10;
            this.label3.Text = "Pago electronico V1.0";
            // 
            // pnlLogin
            // 
            this.pnlLogin.Controls.Add(this.btLogin);
            this.pnlLogin.Location = new System.Drawing.Point(680, 11);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(79, 59);
            this.pnlLogin.TabIndex = 17;
            // 
            // btLogin
            // 
            this.btLogin.Location = new System.Drawing.Point(2, 2);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(75, 53);
            this.btLogin.TabIndex = 0;
            this.btLogin.Text = "Login";
            this.btLogin.UseVisualStyleBackColor = true;
            this.btLogin.Click += new System.EventHandler(this.btLogin_Click_1);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.welcome_label);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.dtpFechaSistema);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 86);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(855, 56);
            this.panel2.TabIndex = 23;
            // 
            // welcome_label
            // 
            this.welcome_label.AutoSize = true;
            this.welcome_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcome_label.ForeColor = System.Drawing.Color.Green;
            this.welcome_label.Location = new System.Drawing.Point(28, 17);
            this.welcome_label.Name = "welcome_label";
            this.welcome_label.Size = new System.Drawing.Size(0, 16);
            this.welcome_label.TabIndex = 22;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 142);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(5);
            this.panel3.Size = new System.Drawing.Size(855, 375);
            this.panel3.TabIndex = 24;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel4.Controls.Add(this.admin_tab);
            this.panel4.Controls.Add(this.status_label);
            this.panel4.Controls.Add(this.cliente_tab);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(5, 5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(845, 365);
            this.panel4.TabIndex = 0;
            // 
            // admin_tab
            // 
            this.admin_tab.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.admin_tab.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.admin_tab.Controls.Add(this.btCuentaClientes);
            this.admin_tab.Controls.Add(this.btListadosEstadisticos);
            this.admin_tab.Controls.Add(this.pnlUsuario);
            this.admin_tab.Controls.Add(this.pnlCliente);
            this.admin_tab.Controls.Add(this.pnlRol);
            this.admin_tab.Controls.Add(this.label4);
            this.admin_tab.Controls.Add(this.btn_fact_admin);
            this.admin_tab.Controls.Add(this.btn_saldo_admin);
            this.admin_tab.Location = new System.Drawing.Point(7, 9);
            this.admin_tab.Name = "admin_tab";
            this.admin_tab.Size = new System.Drawing.Size(831, 170);
            this.admin_tab.TabIndex = 34;
            this.admin_tab.Visible = false;
            // 
            // btCuentaClientes
            // 
            this.btCuentaClientes.Location = new System.Drawing.Point(203, 104);
            this.btCuentaClientes.Name = "btCuentaClientes";
            this.btCuentaClientes.Size = new System.Drawing.Size(161, 36);
            this.btCuentaClientes.TabIndex = 0;
            this.btCuentaClientes.Text = "Cuentas";
            this.btCuentaClientes.UseVisualStyleBackColor = true;
            this.btCuentaClientes.Click += new System.EventHandler(this.btCuentaClientes_Click);
            // 
            // btListadosEstadisticos
            // 
            this.btListadosEstadisticos.Location = new System.Drawing.Point(203, 59);
            this.btListadosEstadisticos.Name = "btListadosEstadisticos";
            this.btListadosEstadisticos.Size = new System.Drawing.Size(161, 36);
            this.btListadosEstadisticos.TabIndex = 0;
            this.btListadosEstadisticos.Text = "Listados Estadísticos";
            this.btListadosEstadisticos.UseVisualStyleBackColor = true;
            this.btListadosEstadisticos.Click += new System.EventHandler(this.btListadosEstadisticos_Click);
            // 
            // pnlUsuario
            // 
            this.pnlUsuario.Controls.Add(this.btUpdateUsuario);
            this.pnlUsuario.Controls.Add(this.btAddUsuario);
            this.pnlUsuario.Location = new System.Drawing.Point(653, 59);
            this.pnlUsuario.Name = "pnlUsuario";
            this.pnlUsuario.Size = new System.Drawing.Size(96, 81);
            this.pnlUsuario.TabIndex = 19;
            // 
            // btUpdateUsuario
            // 
            this.btUpdateUsuario.Location = new System.Drawing.Point(0, 40);
            this.btUpdateUsuario.Name = "btUpdateUsuario";
            this.btUpdateUsuario.Size = new System.Drawing.Size(96, 41);
            this.btUpdateUsuario.TabIndex = 2;
            this.btUpdateUsuario.Text = "Editar Usuario";
            this.btUpdateUsuario.UseVisualStyleBackColor = true;
            // 
            // btAddUsuario
            // 
            this.btAddUsuario.Location = new System.Drawing.Point(0, 0);
            this.btAddUsuario.Name = "btAddUsuario";
            this.btAddUsuario.Size = new System.Drawing.Size(96, 36);
            this.btAddUsuario.TabIndex = 0;
            this.btAddUsuario.Text = "Agregar Usuario";
            this.btAddUsuario.UseVisualStyleBackColor = true;
            this.btAddUsuario.Click += new System.EventHandler(this.btAddUsuario_Click);
            // 
            // pnlCliente
            // 
            this.pnlCliente.Controls.Add(this.btUpdateCliente);
            this.pnlCliente.Controls.Add(this.btAddCliente);
            this.pnlCliente.Location = new System.Drawing.Point(518, 59);
            this.pnlCliente.Name = "pnlCliente";
            this.pnlCliente.Size = new System.Drawing.Size(122, 81);
            this.pnlCliente.TabIndex = 20;
            // 
            // btUpdateCliente
            // 
            this.btUpdateCliente.Location = new System.Drawing.Point(0, 40);
            this.btUpdateCliente.Name = "btUpdateCliente";
            this.btUpdateCliente.Size = new System.Drawing.Size(122, 41);
            this.btUpdateCliente.TabIndex = 2;
            this.btUpdateCliente.Text = "Editar Cliente";
            this.btUpdateCliente.UseVisualStyleBackColor = true;
            this.btUpdateCliente.Click += new System.EventHandler(this.btUpdateCliente_Click);
            // 
            // btAddCliente
            // 
            this.btAddCliente.Location = new System.Drawing.Point(0, 0);
            this.btAddCliente.Name = "btAddCliente";
            this.btAddCliente.Size = new System.Drawing.Size(122, 36);
            this.btAddCliente.TabIndex = 0;
            this.btAddCliente.Text = "Agregar Cliente";
            this.btAddCliente.UseVisualStyleBackColor = true;
            this.btAddCliente.Click += new System.EventHandler(this.btAddCliente_Click);
            // 
            // pnlRol
            // 
            this.pnlRol.Controls.Add(this.btUpdateRol);
            this.pnlRol.Controls.Add(this.btAddRol);
            this.pnlRol.Location = new System.Drawing.Point(380, 59);
            this.pnlRol.Name = "pnlRol";
            this.pnlRol.Size = new System.Drawing.Size(123, 81);
            this.pnlRol.TabIndex = 18;
            // 
            // btUpdateRol
            // 
            this.btUpdateRol.Location = new System.Drawing.Point(0, 42);
            this.btUpdateRol.Name = "btUpdateRol";
            this.btUpdateRol.Size = new System.Drawing.Size(123, 39);
            this.btUpdateRol.TabIndex = 2;
            this.btUpdateRol.Text = "Editar Rol";
            this.btUpdateRol.UseVisualStyleBackColor = true;
            this.btUpdateRol.Click += new System.EventHandler(this.btUpdateRol_Click);
            // 
            // btAddRol
            // 
            this.btAddRol.Location = new System.Drawing.Point(0, 0);
            this.btAddRol.Name = "btAddRol";
            this.btAddRol.Size = new System.Drawing.Size(123, 36);
            this.btAddRol.TabIndex = 0;
            this.btAddRol.Text = "Agregar  Rol";
            this.btAddRol.UseVisualStyleBackColor = true;
            this.btAddRol.Click += new System.EventHandler(this.btAddRol_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 24);
            this.label4.TabIndex = 13;
            this.label4.Text = "Adminstrador";
            // 
            // btn_fact_admin
            // 
            this.btn_fact_admin.Location = new System.Drawing.Point(25, 59);
            this.btn_fact_admin.Name = "btn_fact_admin";
            this.btn_fact_admin.Size = new System.Drawing.Size(161, 36);
            this.btn_fact_admin.TabIndex = 31;
            this.btn_fact_admin.Text = "Facturación";
            this.btn_fact_admin.UseVisualStyleBackColor = true;
            this.btn_fact_admin.Visible = false;
            this.btn_fact_admin.Click += new System.EventHandler(this.btn_fact_admin_Click);
            // 
            // btn_saldo_admin
            // 
            this.btn_saldo_admin.Location = new System.Drawing.Point(25, 104);
            this.btn_saldo_admin.Name = "btn_saldo_admin";
            this.btn_saldo_admin.Size = new System.Drawing.Size(161, 36);
            this.btn_saldo_admin.TabIndex = 28;
            this.btn_saldo_admin.Text = "Consulta Saldo";
            this.btn_saldo_admin.UseVisualStyleBackColor = true;
            this.btn_saldo_admin.Click += new System.EventHandler(this.btn_saldo_admin_Click);
            // 
            // status_label
            // 
            this.status_label.AutoSize = true;
            this.status_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status_label.ForeColor = System.Drawing.Color.White;
            this.status_label.Location = new System.Drawing.Point(281, 78);
            this.status_label.Name = "status_label";
            this.status_label.Size = new System.Drawing.Size(321, 20);
            this.status_label.TabIndex = 35;
            this.status_label.Text = "Haga click en Login para iniciar sesión.";
            // 
            // cliente_tab
            // 
            this.cliente_tab.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cliente_tab.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cliente_tab.Controls.Add(this.btCuenta);
            this.cliente_tab.Controls.Add(this.label5);
            this.cliente_tab.Controls.Add(this.btn_fact_cli);
            this.cliente_tab.Controls.Add(this.btn_tarjetas);
            this.cliente_tab.Controls.Add(this.btn_saldo_cli);
            this.cliente_tab.Controls.Add(this.btn_transf);
            this.cliente_tab.Controls.Add(this.btn_retiros);
            this.cliente_tab.Controls.Add(this.btn_depositos);
            this.cliente_tab.Location = new System.Drawing.Point(7, 185);
            this.cliente_tab.Name = "cliente_tab";
            this.cliente_tab.Size = new System.Drawing.Size(831, 170);
            this.cliente_tab.TabIndex = 33;
            this.cliente_tab.Visible = false;
            // 
            // btCuenta
            // 
            this.btCuenta.Location = new System.Drawing.Point(25, 97);
            this.btCuenta.Name = "btCuenta";
            this.btCuenta.Size = new System.Drawing.Size(161, 36);
            this.btCuenta.TabIndex = 1;
            this.btCuenta.Text = "Cuenta";
            this.btCuenta.UseVisualStyleBackColor = true;
            this.btCuenta.Click += new System.EventHandler(this.btCuenta_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 24);
            this.label5.TabIndex = 13;
            this.label5.Text = "Cliente";
            // 
            // btn_fact_cli
            // 
            this.btn_fact_cli.Location = new System.Drawing.Point(25, 55);
            this.btn_fact_cli.Name = "btn_fact_cli";
            this.btn_fact_cli.Size = new System.Drawing.Size(161, 36);
            this.btn_fact_cli.TabIndex = 30;
            this.btn_fact_cli.Text = "Facturacion";
            this.btn_fact_cli.UseVisualStyleBackColor = true;
            this.btn_fact_cli.Click += new System.EventHandler(this.btn_fact_cli_Click);
            // 
            // btn_tarjetas
            // 
            this.btn_tarjetas.Location = new System.Drawing.Point(203, 55);
            this.btn_tarjetas.Name = "btn_tarjetas";
            this.btn_tarjetas.Size = new System.Drawing.Size(161, 36);
            this.btn_tarjetas.TabIndex = 29;
            this.btn_tarjetas.Text = "Tarjetas";
            this.btn_tarjetas.UseVisualStyleBackColor = true;
            this.btn_tarjetas.Click += new System.EventHandler(this.btn_tarjetas_Click);
            // 
            // btn_saldo_cli
            // 
            this.btn_saldo_cli.Location = new System.Drawing.Point(518, 55);
            this.btn_saldo_cli.Name = "btn_saldo_cli";
            this.btn_saldo_cli.Size = new System.Drawing.Size(122, 36);
            this.btn_saldo_cli.TabIndex = 27;
            this.btn_saldo_cli.Text = "Ver Saldo";
            this.btn_saldo_cli.UseVisualStyleBackColor = true;
            this.btn_saldo_cli.Click += new System.EventHandler(this.btn_saldo_cli_Click);
            // 
            // btn_transf
            // 
            this.btn_transf.Location = new System.Drawing.Point(203, 97);
            this.btn_transf.Name = "btn_transf";
            this.btn_transf.Size = new System.Drawing.Size(161, 36);
            this.btn_transf.TabIndex = 24;
            this.btn_transf.Text = "Transferencias";
            this.btn_transf.UseVisualStyleBackColor = true;
            this.btn_transf.Click += new System.EventHandler(this.btn_transf_Click);
            // 
            // btn_retiros
            // 
            this.btn_retiros.Location = new System.Drawing.Point(380, 97);
            this.btn_retiros.Name = "btn_retiros";
            this.btn_retiros.Size = new System.Drawing.Size(123, 36);
            this.btn_retiros.TabIndex = 26;
            this.btn_retiros.Text = "Retiros";
            this.btn_retiros.UseVisualStyleBackColor = true;
            this.btn_retiros.Click += new System.EventHandler(this.btn_retiros_Click);
            // 
            // btn_depositos
            // 
            this.btn_depositos.Location = new System.Drawing.Point(380, 55);
            this.btn_depositos.Name = "btn_depositos";
            this.btn_depositos.Size = new System.Drawing.Size(123, 36);
            this.btn_depositos.TabIndex = 25;
            this.btn_depositos.Text = "Depositos";
            this.btn_depositos.UseVisualStyleBackColor = true;
            this.btn_depositos.Click += new System.EventHandler(this.btn_depositos_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 517);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.Text = "Pago Electronico V 1.0";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.pnlSession.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlLogin.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.admin_tab.ResumeLayout(false);
            this.admin_tab.PerformLayout();
            this.pnlUsuario.ResumeLayout(false);
            this.pnlCliente.ResumeLayout(false);
            this.pnlRol.ResumeLayout(false);
            this.cliente_tab.ResumeLayout(false);
            this.cliente_tab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btLogout;
        private System.Windows.Forms.Button btChangePassword;
        private System.Windows.Forms.Panel pnlSession;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFechaSistema;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btn_fact_admin;
        private System.Windows.Forms.Button btn_fact_cli;
        private System.Windows.Forms.Button btn_tarjetas;
        private System.Windows.Forms.Button btn_saldo_admin;
        private System.Windows.Forms.Button btn_saldo_cli;
        private System.Windows.Forms.Button btn_retiros;
        private System.Windows.Forms.Button btn_depositos;
        private System.Windows.Forms.Button btn_transf;
        private System.Windows.Forms.Button btCuenta;
        private System.Windows.Forms.Button btListadosEstadisticos;
        private System.Windows.Forms.Button btCuentaClientes;
        private System.Windows.Forms.Panel pnlCliente;
        private System.Windows.Forms.Button btUpdateCliente;
        private System.Windows.Forms.Button btAddCliente;
        private System.Windows.Forms.Panel pnlUsuario;
        private System.Windows.Forms.Button btUpdateUsuario;
        private System.Windows.Forms.Button btAddUsuario;
        private System.Windows.Forms.Panel pnlRol;
        private System.Windows.Forms.Button btUpdateRol;
        private System.Windows.Forms.Button btAddRol;
        private System.Windows.Forms.Panel pnlLogin;
        private System.Windows.Forms.Button btLogin;
        private System.Windows.Forms.Panel cliente_tab;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel admin_tab;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label welcome_label;
        private System.Windows.Forms.Label status_label;
    }
}