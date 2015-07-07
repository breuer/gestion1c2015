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
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.btLogin = new System.Windows.Forms.Button();
            this.btLogout = new System.Windows.Forms.Button();
            this.pnlRol = new System.Windows.Forms.Panel();
            this.btUpdateRol = new System.Windows.Forms.Button();
            this.btAddRol = new System.Windows.Forms.Button();
            this.pnlUsuario = new System.Windows.Forms.Panel();
            this.btUpdateUsuario = new System.Windows.Forms.Button();
            this.btAddUsuario = new System.Windows.Forms.Button();
            this.pnlCliente = new System.Windows.Forms.Panel();
            this.btUpdateCliente = new System.Windows.Forms.Button();
            this.btAddCliente = new System.Windows.Forms.Button();
            this.pnlCuentasClientes = new System.Windows.Forms.Panel();
            this.btCuentaClientes = new System.Windows.Forms.Button();
            this.btCuenta = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.btChangePassword = new System.Windows.Forms.Button();
            this.pnlSession = new System.Windows.Forms.Panel();
            this.pnlListados = new System.Windows.Forms.Panel();
            this.btListadosEstadisticos = new System.Windows.Forms.Button();
            this.pnlCuenta = new System.Windows.Forms.Panel();
            this.btn_transf = new System.Windows.Forms.Button();
            this.btn_depositos = new System.Windows.Forms.Button();
            this.btn_retiros = new System.Windows.Forms.Button();
            this.btn_saldo_cli = new System.Windows.Forms.Button();
            this.btn_saldo_admin = new System.Windows.Forms.Button();
            this.btn_tarjetas = new System.Windows.Forms.Button();
            this.btn_fact_cli = new System.Windows.Forms.Button();
            this.pnlLogin.SuspendLayout();
            this.pnlRol.SuspendLayout();
            this.pnlUsuario.SuspendLayout();
            this.pnlCliente.SuspendLayout();
            this.pnlCuentasClientes.SuspendLayout();
            this.pnlSession.SuspendLayout();
            this.pnlListados.SuspendLayout();
            this.pnlCuenta.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLogin
            // 
            this.pnlLogin.Controls.Add(this.btLogin);
            this.pnlLogin.Location = new System.Drawing.Point(45, 30);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(137, 44);
            this.pnlLogin.TabIndex = 0;
            // 
            // btLogin
            // 
            this.btLogin.Location = new System.Drawing.Point(25, 13);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(75, 23);
            this.btLogin.TabIndex = 0;
            this.btLogin.Text = "Login";
            this.btLogin.UseVisualStyleBackColor = true;
            this.btLogin.Click += new System.EventHandler(this.btLogin_Click);
            // 
            // btLogout
            // 
            this.btLogout.Location = new System.Drawing.Point(22, 13);
            this.btLogout.Name = "btLogout";
            this.btLogout.Size = new System.Drawing.Size(75, 23);
            this.btLogout.TabIndex = 1;
            this.btLogout.Text = "Logout";
            this.btLogout.UseVisualStyleBackColor = true;
            this.btLogout.Click += new System.EventHandler(this.btLogout_Click);
            // 
            // pnlRol
            // 
            this.pnlRol.Controls.Add(this.btUpdateRol);
            this.pnlRol.Controls.Add(this.btAddRol);
            this.pnlRol.Location = new System.Drawing.Point(387, 31);
            this.pnlRol.Name = "pnlRol";
            this.pnlRol.Size = new System.Drawing.Size(141, 118);
            this.pnlRol.TabIndex = 1;
            // 
            // btUpdateRol
            // 
            this.btUpdateRol.Location = new System.Drawing.Point(25, 49);
            this.btUpdateRol.Name = "btUpdateRol";
            this.btUpdateRol.Size = new System.Drawing.Size(75, 23);
            this.btUpdateRol.TabIndex = 2;
            this.btUpdateRol.Text = "Update Rol";
            this.btUpdateRol.UseVisualStyleBackColor = true;
            this.btUpdateRol.Click += new System.EventHandler(this.btUpdateRol_Click);
            // 
            // btAddRol
            // 
            this.btAddRol.Location = new System.Drawing.Point(25, 20);
            this.btAddRol.Name = "btAddRol";
            this.btAddRol.Size = new System.Drawing.Size(75, 23);
            this.btAddRol.TabIndex = 0;
            this.btAddRol.Text = "Add Rol";
            this.btAddRol.UseVisualStyleBackColor = true;
            this.btAddRol.Click += new System.EventHandler(this.btAddRol_Click);
            // 
            // pnlUsuario
            // 
            this.pnlUsuario.Controls.Add(this.btUpdateUsuario);
            this.pnlUsuario.Controls.Add(this.btAddUsuario);
            this.pnlUsuario.Location = new System.Drawing.Point(217, 30);
            this.pnlUsuario.Name = "pnlUsuario";
            this.pnlUsuario.Size = new System.Drawing.Size(143, 119);
            this.pnlUsuario.TabIndex = 2;
            // 
            // btUpdateUsuario
            // 
            this.btUpdateUsuario.Location = new System.Drawing.Point(20, 50);
            this.btUpdateUsuario.Name = "btUpdateUsuario";
            this.btUpdateUsuario.Size = new System.Drawing.Size(103, 23);
            this.btUpdateUsuario.TabIndex = 2;
            this.btUpdateUsuario.Text = "Update Usuario";
            this.btUpdateUsuario.UseVisualStyleBackColor = true;
            // 
            // btAddUsuario
            // 
            this.btAddUsuario.Location = new System.Drawing.Point(20, 21);
            this.btAddUsuario.Name = "btAddUsuario";
            this.btAddUsuario.Size = new System.Drawing.Size(75, 23);
            this.btAddUsuario.TabIndex = 0;
            this.btAddUsuario.Text = "Add Usuario";
            this.btAddUsuario.UseVisualStyleBackColor = true;
            this.btAddUsuario.Click += new System.EventHandler(this.btAddUsuario_Click);
            // 
            // pnlCliente
            // 
            this.pnlCliente.Controls.Add(this.btUpdateCliente);
            this.pnlCliente.Controls.Add(this.btAddCliente);
            this.pnlCliente.Location = new System.Drawing.Point(45, 236);
            this.pnlCliente.Name = "pnlCliente";
            this.pnlCliente.Size = new System.Drawing.Size(131, 90);
            this.pnlCliente.TabIndex = 3;
            // 
            // btUpdateCliente
            // 
            this.btUpdateCliente.Location = new System.Drawing.Point(14, 40);
            this.btUpdateCliente.Name = "btUpdateCliente";
            this.btUpdateCliente.Size = new System.Drawing.Size(96, 23);
            this.btUpdateCliente.TabIndex = 2;
            this.btUpdateCliente.Text = "Update Cliente";
            this.btUpdateCliente.UseVisualStyleBackColor = true;
            this.btUpdateCliente.Click += new System.EventHandler(this.btUpdateCliente_Click);
            // 
            // btAddCliente
            // 
            this.btAddCliente.Location = new System.Drawing.Point(14, 11);
            this.btAddCliente.Name = "btAddCliente";
            this.btAddCliente.Size = new System.Drawing.Size(75, 23);
            this.btAddCliente.TabIndex = 0;
            this.btAddCliente.Text = "Add Cliente";
            this.btAddCliente.UseVisualStyleBackColor = true;
            this.btAddCliente.Click += new System.EventHandler(this.btAddCliente_Click);
            // 
            // pnlCuentasClientes
            // 
            this.pnlCuentasClientes.Controls.Add(this.btCuentaClientes);
            this.pnlCuentasClientes.Location = new System.Drawing.Point(207, 236);
            this.pnlCuentasClientes.Name = "pnlCuentasClientes";
            this.pnlCuentasClientes.Size = new System.Drawing.Size(200, 53);
            this.pnlCuentasClientes.TabIndex = 4;
            // 
            // btCuentaClientes
            // 
            this.btCuentaClientes.Location = new System.Drawing.Point(41, 11);
            this.btCuentaClientes.Name = "btCuentaClientes";
            this.btCuentaClientes.Size = new System.Drawing.Size(112, 23);
            this.btCuentaClientes.TabIndex = 0;
            this.btCuentaClientes.Text = "Cuentas Clientes";
            this.btCuentaClientes.UseVisualStyleBackColor = true;
            this.btCuentaClientes.Click += new System.EventHandler(this.btCuentaClientes_Click);
            // 
            // btCuenta
            // 
            this.btCuenta.Location = new System.Drawing.Point(41, 15);
            this.btCuenta.Name = "btCuenta";
            this.btCuenta.Size = new System.Drawing.Size(92, 23);
            this.btCuenta.TabIndex = 1;
            this.btCuenta.Text = "Cuenta";
            this.btCuenta.UseVisualStyleBackColor = true;
            this.btCuenta.Click += new System.EventHandler(this.btCuenta_Click);
            // 
            // btExit
            // 
            this.btExit.Location = new System.Drawing.Point(768, 357);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(75, 23);
            this.btExit.TabIndex = 5;
            this.btExit.Text = "Exit";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // btChangePassword
            // 
            this.btChangePassword.Location = new System.Drawing.Point(22, 42);
            this.btChangePassword.Name = "btChangePassword";
            this.btChangePassword.Size = new System.Drawing.Size(109, 26);
            this.btChangePassword.TabIndex = 2;
            this.btChangePassword.Text = "Change Password";
            this.btChangePassword.UseVisualStyleBackColor = true;
            this.btChangePassword.Click += new System.EventHandler(this.btChangePassword_Click);
            // 
            // pnlSession
            // 
            this.pnlSession.Controls.Add(this.btLogout);
            this.pnlSession.Controls.Add(this.btChangePassword);
            this.pnlSession.Location = new System.Drawing.Point(45, 81);
            this.pnlSession.Name = "pnlSession";
            this.pnlSession.Size = new System.Drawing.Size(137, 98);
            this.pnlSession.TabIndex = 6;
            // 
            // pnlListados
            // 
            this.pnlListados.Controls.Add(this.btListadosEstadisticos);
            this.pnlListados.Location = new System.Drawing.Point(585, 30);
            this.pnlListados.Name = "pnlListados";
            this.pnlListados.Size = new System.Drawing.Size(166, 74);
            this.pnlListados.TabIndex = 7;
            // 
            // btListadosEstadisticos
            // 
            this.btListadosEstadisticos.Location = new System.Drawing.Point(16, 21);
            this.btListadosEstadisticos.Name = "btListadosEstadisticos";
            this.btListadosEstadisticos.Size = new System.Drawing.Size(135, 23);
            this.btListadosEstadisticos.TabIndex = 0;
            this.btListadosEstadisticos.Text = "Listados Estadísticos";
            this.btListadosEstadisticos.UseVisualStyleBackColor = true;
            this.btListadosEstadisticos.Click += new System.EventHandler(this.btListadosEstadisticos_Click);
            // 
            // pnlCuenta
            // 
            this.pnlCuenta.Controls.Add(this.btCuenta);
            this.pnlCuenta.Location = new System.Drawing.Point(207, 307);
            this.pnlCuenta.Name = "pnlCuenta";
            this.pnlCuenta.Size = new System.Drawing.Size(200, 52);
            this.pnlCuenta.TabIndex = 8;
            // 
            // btn_transf
            // 
            this.btn_transf.Location = new System.Drawing.Point(692, 203);
            this.btn_transf.Name = "btn_transf";
            this.btn_transf.Size = new System.Drawing.Size(136, 23);
            this.btn_transf.TabIndex = 9;
            this.btn_transf.Text = "Transferencias";
            this.btn_transf.UseVisualStyleBackColor = true;
            this.btn_transf.Click += new System.EventHandler(this.btn_transf_Click);
            // 
            // btn_depositos
            // 
            this.btn_depositos.Location = new System.Drawing.Point(692, 232);
            this.btn_depositos.Name = "btn_depositos";
            this.btn_depositos.Size = new System.Drawing.Size(136, 23);
            this.btn_depositos.TabIndex = 10;
            this.btn_depositos.Text = "Depositos";
            this.btn_depositos.UseVisualStyleBackColor = true;
            this.btn_depositos.Click += new System.EventHandler(this.btn_depositos_Click);
            // 
            // btn_retiros
            // 
            this.btn_retiros.Location = new System.Drawing.Point(692, 261);
            this.btn_retiros.Name = "btn_retiros";
            this.btn_retiros.Size = new System.Drawing.Size(136, 23);
            this.btn_retiros.TabIndex = 11;
            this.btn_retiros.Text = "Retiros";
            this.btn_retiros.UseVisualStyleBackColor = true;
            this.btn_retiros.Click += new System.EventHandler(this.btn_retiros_Click);
            // 
            // btn_saldo_cli
            // 
            this.btn_saldo_cli.Location = new System.Drawing.Point(692, 290);
            this.btn_saldo_cli.Name = "btn_saldo_cli";
            this.btn_saldo_cli.Size = new System.Drawing.Size(136, 23);
            this.btn_saldo_cli.TabIndex = 12;
            this.btn_saldo_cli.Text = "Saldo Cli";
            this.btn_saldo_cli.UseVisualStyleBackColor = true;
            this.btn_saldo_cli.Click += new System.EventHandler(this.btn_saldo_cli_Click);
            // 
            // btn_saldo_admin
            // 
            this.btn_saldo_admin.Location = new System.Drawing.Point(585, 110);
            this.btn_saldo_admin.Name = "btn_saldo_admin";
            this.btn_saldo_admin.Size = new System.Drawing.Size(166, 23);
            this.btn_saldo_admin.TabIndex = 13;
            this.btn_saldo_admin.Text = "Saldo Admin";
            this.btn_saldo_admin.UseVisualStyleBackColor = true;
            this.btn_saldo_admin.Click += new System.EventHandler(this.btn_saldo_admin_Click);
            // 
            // btn_tarjetas
            // 
            this.btn_tarjetas.Location = new System.Drawing.Point(692, 319);
            this.btn_tarjetas.Name = "btn_tarjetas";
            this.btn_tarjetas.Size = new System.Drawing.Size(136, 23);
            this.btn_tarjetas.TabIndex = 14;
            this.btn_tarjetas.Text = "Tarjetas";
            this.btn_tarjetas.UseVisualStyleBackColor = true;
            this.btn_tarjetas.Click += new System.EventHandler(this.btn_tarjetas_Click);
            // 
            // btn_fact_cli
            // 
            this.btn_fact_cli.Location = new System.Drawing.Point(692, 174);
            this.btn_fact_cli.Name = "btn_fact_cli";
            this.btn_fact_cli.Size = new System.Drawing.Size(136, 23);
            this.btn_fact_cli.TabIndex = 15;
            this.btn_fact_cli.Text = "Facturacion";
            this.btn_fact_cli.UseVisualStyleBackColor = true;
            this.btn_fact_cli.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 401);
            this.Controls.Add(this.btn_fact_cli);
            this.Controls.Add(this.btn_tarjetas);
            this.Controls.Add(this.btn_saldo_admin);
            this.Controls.Add(this.btn_saldo_cli);
            this.Controls.Add(this.btn_retiros);
            this.Controls.Add(this.btn_depositos);
            this.Controls.Add(this.btn_transf);
            this.Controls.Add(this.pnlCuenta);
            this.Controls.Add(this.pnlListados);
            this.Controls.Add(this.pnlSession);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.pnlCuentasClientes);
            this.Controls.Add(this.pnlCliente);
            this.Controls.Add(this.pnlUsuario);
            this.Controls.Add(this.pnlRol);
            this.Controls.Add(this.pnlLogin);
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.pnlLogin.ResumeLayout(false);
            this.pnlRol.ResumeLayout(false);
            this.pnlUsuario.ResumeLayout(false);
            this.pnlCliente.ResumeLayout(false);
            this.pnlCuentasClientes.ResumeLayout(false);
            this.pnlSession.ResumeLayout(false);
            this.pnlListados.ResumeLayout(false);
            this.pnlCuenta.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLogin;
        private System.Windows.Forms.Button btLogin;
        private System.Windows.Forms.Button btLogout;
        private System.Windows.Forms.Panel pnlRol;
        private System.Windows.Forms.Button btUpdateRol;
        private System.Windows.Forms.Button btAddRol;
        private System.Windows.Forms.Panel pnlUsuario;
        private System.Windows.Forms.Button btUpdateUsuario;
        private System.Windows.Forms.Button btAddUsuario;
        private System.Windows.Forms.Panel pnlCliente;
        private System.Windows.Forms.Button btUpdateCliente;
        private System.Windows.Forms.Button btAddCliente;
        private System.Windows.Forms.Panel pnlCuentasClientes;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Button btChangePassword;
        private System.Windows.Forms.Panel pnlSession;
        private System.Windows.Forms.Panel pnlListados;
        private System.Windows.Forms.Button btListadosEstadisticos;
        private System.Windows.Forms.Button btCuenta;
        private System.Windows.Forms.Button btCuentaClientes;
        private System.Windows.Forms.Panel pnlCuenta;
        private System.Windows.Forms.Button btn_transf;
        private System.Windows.Forms.Button btn_depositos;
        private System.Windows.Forms.Button btn_retiros;
        private System.Windows.Forms.Button btn_saldo_cli;
        private System.Windows.Forms.Button btn_saldo_admin;
        private System.Windows.Forms.Button btn_tarjetas;
        private System.Windows.Forms.Button btn_fact_cli;
    }
}