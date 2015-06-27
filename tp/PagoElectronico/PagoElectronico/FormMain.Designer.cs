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
            this.btExit = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btChangePassword = new System.Windows.Forms.Button();
            this.btLogout = new System.Windows.Forms.Button();
            this.btLogin = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label_usuario = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cliente_tab = new System.Windows.Forms.Panel();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btn_retiros = new System.Windows.Forms.Button();
            this.btn_cli_facturacion = new System.Windows.Forms.Button();
            this.btn_saldo = new System.Windows.Forms.Button();
            this.btn_cli_abm_cuentas = new System.Windows.Forms.Button();
            this.btn_transferencias = new System.Windows.Forms.Button();
            this.btn_depositos = new System.Windows.Forms.Button();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.btn_tarj_vincular = new System.Windows.Forms.Button();
            this.btn_tarj_desvincular = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.admin_tab = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btn_abm_cuentas = new System.Windows.Forms.Button();
            this.btn_facturacion = new System.Windows.Forms.Button();
            this.btn_estadisticas = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_add_rol = new System.Windows.Forms.Button();
            this.btn_del_rol = new System.Windows.Forms.Button();
            this.btn_upd_rol = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_add_cliente = new System.Windows.Forms.Button();
            this.btn_del_cliente = new System.Windows.Forms.Button();
            this.btn_upd_cliente = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_add_user = new System.Windows.Forms.Button();
            this.btn_del_user = new System.Windows.Forms.Button();
            this.btn_upd_user = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label_hacer_login = new System.Windows.Forms.Label();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.button24 = new System.Windows.Forms.Button();
            this.button25 = new System.Windows.Forms.Button();
            this.button26 = new System.Windows.Forms.Button();
            this.button27 = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.cliente_tab.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.admin_tab.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btExit
            // 
            this.btExit.BackColor = System.Drawing.Color.IndianRed;
            this.btExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btExit.Location = new System.Drawing.Point(767, 8);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(75, 62);
            this.btExit.TabIndex = 5;
            this.btExit.Text = "Salir";
            this.btExit.UseVisualStyleBackColor = false;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btChangePassword);
            this.panel2.Controls.Add(this.btLogout);
            this.panel2.Controls.Add(this.btLogin);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btExit);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(855, 80);
            this.panel2.TabIndex = 8;
            // 
            // btChangePassword
            // 
            this.btChangePassword.Location = new System.Drawing.Point(571, 8);
            this.btChangePassword.Name = "btChangePassword";
            this.btChangePassword.Size = new System.Drawing.Size(109, 59);
            this.btChangePassword.TabIndex = 2;
            this.btChangePassword.Text = "Change Password";
            this.btChangePassword.UseVisualStyleBackColor = true;
            this.btChangePassword.Visible = false;
            this.btChangePassword.Click += new System.EventHandler(this.btChangePassword_Click_1);
            // 
            // btLogout
            // 
            this.btLogout.Location = new System.Drawing.Point(686, 8);
            this.btLogout.Name = "btLogout";
            this.btLogout.Size = new System.Drawing.Size(75, 59);
            this.btLogout.TabIndex = 1;
            this.btLogout.Text = "Logout";
            this.btLogout.UseVisualStyleBackColor = true;
            this.btLogout.Visible = false;
            this.btLogout.Click += new System.EventHandler(this.btLogout_Click);
            // 
            // btLogin
            // 
            this.btLogin.Location = new System.Drawing.Point(686, 8);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(75, 59);
            this.btLogin.TabIndex = 10;
            this.btLogin.Text = "Login";
            this.btLogin.UseVisualStyleBackColor = true;
            this.btLogin.Click += new System.EventHandler(this.btLogin_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.ForestGreen;
            this.label2.Location = new System.Drawing.Point(11, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(224, 29);
            this.label2.TabIndex = 9;
            this.label2.Text = "NEW SOLUTION";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pago electronico V1.0";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 80);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10);
            this.panel1.Size = new System.Drawing.Size(855, 557);
            this.panel1.TabIndex = 9;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label_usuario);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(10, 10);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(833, 34);
            this.panel4.TabIndex = 1;
            // 
            // label_usuario
            // 
            this.label_usuario.AutoSize = true;
            this.label_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_usuario.ForeColor = System.Drawing.Color.OliveDrab;
            this.label_usuario.Location = new System.Drawing.Point(10, 9);
            this.label_usuario.Name = "label_usuario";
            this.label_usuario.Size = new System.Drawing.Size(182, 16);
            this.label_usuario.TabIndex = 0;
            this.label_usuario.Text = "No hay una sesión activa";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel3.Controls.Add(this.cliente_tab);
            this.panel3.Controls.Add(this.admin_tab);
            this.panel3.Controls.Add(this.label_hacer_login);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(10, 10);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(10);
            this.panel3.Size = new System.Drawing.Size(833, 535);
            this.panel3.TabIndex = 0;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // cliente_tab
            // 
            this.cliente_tab.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cliente_tab.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cliente_tab.Controls.Add(this.groupBox5);
            this.cliente_tab.Controls.Add(this.groupBox8);
            this.cliente_tab.Controls.Add(this.label5);
            this.cliente_tab.Location = new System.Drawing.Point(13, 291);
            this.cliente_tab.Name = "cliente_tab";
            this.cliente_tab.Size = new System.Drawing.Size(807, 236);
            this.cliente_tab.TabIndex = 3;
            this.cliente_tab.Visible = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btn_retiros);
            this.groupBox5.Controls.Add(this.btn_cli_facturacion);
            this.groupBox5.Controls.Add(this.btn_saldo);
            this.groupBox5.Controls.Add(this.btn_cli_abm_cuentas);
            this.groupBox5.Controls.Add(this.btn_transferencias);
            this.groupBox5.Controls.Add(this.btn_depositos);
            this.groupBox5.Location = new System.Drawing.Point(211, 50);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(273, 160);
            this.groupBox5.TabIndex = 15;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Cuentas";
            // 
            // btn_retiros
            // 
            this.btn_retiros.Location = new System.Drawing.Point(145, 105);
            this.btn_retiros.Name = "btn_retiros";
            this.btn_retiros.Size = new System.Drawing.Size(113, 33);
            this.btn_retiros.TabIndex = 7;
            this.btn_retiros.Text = "Retiros";
            this.btn_retiros.UseVisualStyleBackColor = true;
            // 
            // btn_cli_facturacion
            // 
            this.btn_cli_facturacion.Location = new System.Drawing.Point(145, 66);
            this.btn_cli_facturacion.Name = "btn_cli_facturacion";
            this.btn_cli_facturacion.Size = new System.Drawing.Size(113, 33);
            this.btn_cli_facturacion.TabIndex = 3;
            this.btn_cli_facturacion.Text = "Facturacion";
            this.btn_cli_facturacion.UseVisualStyleBackColor = true;
            // 
            // btn_saldo
            // 
            this.btn_saldo.Location = new System.Drawing.Point(145, 25);
            this.btn_saldo.Name = "btn_saldo";
            this.btn_saldo.Size = new System.Drawing.Size(113, 33);
            this.btn_saldo.TabIndex = 6;
            this.btn_saldo.Text = "Saldo";
            this.btn_saldo.UseVisualStyleBackColor = true;
            // 
            // btn_cli_abm_cuentas
            // 
            this.btn_cli_abm_cuentas.Location = new System.Drawing.Point(19, 25);
            this.btn_cli_abm_cuentas.Name = "btn_cli_abm_cuentas";
            this.btn_cli_abm_cuentas.Size = new System.Drawing.Size(113, 33);
            this.btn_cli_abm_cuentas.TabIndex = 3;
            this.btn_cli_abm_cuentas.Text = "ABM";
            this.btn_cli_abm_cuentas.UseVisualStyleBackColor = true;
            // 
            // btn_transferencias
            // 
            this.btn_transferencias.Location = new System.Drawing.Point(19, 64);
            this.btn_transferencias.Name = "btn_transferencias";
            this.btn_transferencias.Size = new System.Drawing.Size(113, 33);
            this.btn_transferencias.TabIndex = 4;
            this.btn_transferencias.Text = "Transferencias";
            this.btn_transferencias.UseVisualStyleBackColor = true;
            // 
            // btn_depositos
            // 
            this.btn_depositos.Location = new System.Drawing.Point(19, 103);
            this.btn_depositos.Name = "btn_depositos";
            this.btn_depositos.Size = new System.Drawing.Size(113, 33);
            this.btn_depositos.TabIndex = 5;
            this.btn_depositos.Text = "Depositos";
            this.btn_depositos.UseVisualStyleBackColor = true;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.btn_tarj_vincular);
            this.groupBox8.Controls.Add(this.btn_tarj_desvincular);
            this.groupBox8.Location = new System.Drawing.Point(19, 50);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(172, 160);
            this.groupBox8.TabIndex = 14;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Tarjetas";
            // 
            // btn_tarj_vincular
            // 
            this.btn_tarj_vincular.Location = new System.Drawing.Point(28, 27);
            this.btn_tarj_vincular.Name = "btn_tarj_vincular";
            this.btn_tarj_vincular.Size = new System.Drawing.Size(112, 33);
            this.btn_tarj_vincular.TabIndex = 0;
            this.btn_tarj_vincular.Text = "Vincular";
            this.btn_tarj_vincular.UseVisualStyleBackColor = true;
            // 
            // btn_tarj_desvincular
            // 
            this.btn_tarj_desvincular.Location = new System.Drawing.Point(28, 66);
            this.btn_tarj_desvincular.Name = "btn_tarj_desvincular";
            this.btn_tarj_desvincular.Size = new System.Drawing.Size(112, 33);
            this.btn_tarj_desvincular.TabIndex = 1;
            this.btn_tarj_desvincular.Text = "Desvincular";
            this.btn_tarj_desvincular.UseVisualStyleBackColor = true;
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
            // admin_tab
            // 
            this.admin_tab.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.admin_tab.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.admin_tab.Controls.Add(this.label4);
            this.admin_tab.Controls.Add(this.groupBox4);
            this.admin_tab.Controls.Add(this.groupBox3);
            this.admin_tab.Controls.Add(this.groupBox2);
            this.admin_tab.Controls.Add(this.groupBox1);
            this.admin_tab.Controls.Add(this.label3);
            this.admin_tab.Location = new System.Drawing.Point(13, 49);
            this.admin_tab.Name = "admin_tab";
            this.admin_tab.Size = new System.Drawing.Size(807, 236);
            this.admin_tab.TabIndex = 2;
            this.admin_tab.Visible = false;
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
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btn_abm_cuentas);
            this.groupBox4.Controls.Add(this.btn_facturacion);
            this.groupBox4.Controls.Add(this.btn_estadisticas);
            this.groupBox4.Location = new System.Drawing.Point(573, 53);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(152, 160);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Cuentas";
            // 
            // btn_abm_cuentas
            // 
            this.btn_abm_cuentas.Location = new System.Drawing.Point(19, 25);
            this.btn_abm_cuentas.Name = "btn_abm_cuentas";
            this.btn_abm_cuentas.Size = new System.Drawing.Size(113, 33);
            this.btn_abm_cuentas.TabIndex = 3;
            this.btn_abm_cuentas.Text = "ABM";
            this.btn_abm_cuentas.UseVisualStyleBackColor = true;
            // 
            // btn_facturacion
            // 
            this.btn_facturacion.Location = new System.Drawing.Point(19, 64);
            this.btn_facturacion.Name = "btn_facturacion";
            this.btn_facturacion.Size = new System.Drawing.Size(113, 33);
            this.btn_facturacion.TabIndex = 4;
            this.btn_facturacion.Text = "Facturacion";
            this.btn_facturacion.UseVisualStyleBackColor = true;
            // 
            // btn_estadisticas
            // 
            this.btn_estadisticas.Location = new System.Drawing.Point(19, 103);
            this.btn_estadisticas.Name = "btn_estadisticas";
            this.btn_estadisticas.Size = new System.Drawing.Size(113, 33);
            this.btn_estadisticas.TabIndex = 5;
            this.btn_estadisticas.Text = "Estadisticas";
            this.btn_estadisticas.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_add_rol);
            this.groupBox3.Controls.Add(this.btn_del_rol);
            this.groupBox3.Controls.Add(this.btn_upd_rol);
            this.groupBox3.Location = new System.Drawing.Point(216, 53);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(152, 160);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Roles";
            // 
            // btn_add_rol
            // 
            this.btn_add_rol.Location = new System.Drawing.Point(20, 25);
            this.btn_add_rol.Name = "btn_add_rol";
            this.btn_add_rol.Size = new System.Drawing.Size(112, 33);
            this.btn_add_rol.TabIndex = 3;
            this.btn_add_rol.Text = "Agregar rol";
            this.btn_add_rol.UseVisualStyleBackColor = true;
            // 
            // btn_del_rol
            // 
            this.btn_del_rol.Location = new System.Drawing.Point(20, 64);
            this.btn_del_rol.Name = "btn_del_rol";
            this.btn_del_rol.Size = new System.Drawing.Size(112, 33);
            this.btn_del_rol.TabIndex = 4;
            this.btn_del_rol.Text = "Baja rol";
            this.btn_del_rol.UseVisualStyleBackColor = true;
            // 
            // btn_upd_rol
            // 
            this.btn_upd_rol.Location = new System.Drawing.Point(20, 103);
            this.btn_upd_rol.Name = "btn_upd_rol";
            this.btn_upd_rol.Size = new System.Drawing.Size(112, 33);
            this.btn_upd_rol.TabIndex = 5;
            this.btn_upd_rol.Text = "Actualizar rol";
            this.btn_upd_rol.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_add_cliente);
            this.groupBox2.Controls.Add(this.btn_del_cliente);
            this.groupBox2.Controls.Add(this.btn_upd_cliente);
            this.groupBox2.Location = new System.Drawing.Point(396, 53);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(152, 160);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Clientes";
            // 
            // btn_add_cliente
            // 
            this.btn_add_cliente.Location = new System.Drawing.Point(19, 25);
            this.btn_add_cliente.Name = "btn_add_cliente";
            this.btn_add_cliente.Size = new System.Drawing.Size(113, 33);
            this.btn_add_cliente.TabIndex = 3;
            this.btn_add_cliente.Text = "Agregar cliente";
            this.btn_add_cliente.UseVisualStyleBackColor = true;
            // 
            // btn_del_cliente
            // 
            this.btn_del_cliente.Location = new System.Drawing.Point(19, 64);
            this.btn_del_cliente.Name = "btn_del_cliente";
            this.btn_del_cliente.Size = new System.Drawing.Size(113, 33);
            this.btn_del_cliente.TabIndex = 4;
            this.btn_del_cliente.Text = "Baja cliente";
            this.btn_del_cliente.UseVisualStyleBackColor = true;
            // 
            // btn_upd_cliente
            // 
            this.btn_upd_cliente.Location = new System.Drawing.Point(19, 103);
            this.btn_upd_cliente.Name = "btn_upd_cliente";
            this.btn_upd_cliente.Size = new System.Drawing.Size(113, 33);
            this.btn_upd_cliente.TabIndex = 5;
            this.btn_upd_cliente.Text = "Actualizar cliente";
            this.btn_upd_cliente.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_add_user);
            this.groupBox1.Controls.Add(this.btn_del_user);
            this.groupBox1.Controls.Add(this.btn_upd_user);
            this.groupBox1.Location = new System.Drawing.Point(19, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(172, 160);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Usuario";
            // 
            // btn_add_user
            // 
            this.btn_add_user.Location = new System.Drawing.Point(28, 27);
            this.btn_add_user.Name = "btn_add_user";
            this.btn_add_user.Size = new System.Drawing.Size(112, 33);
            this.btn_add_user.TabIndex = 0;
            this.btn_add_user.Text = "Agregar usuario";
            this.btn_add_user.UseVisualStyleBackColor = true;
            // 
            // btn_del_user
            // 
            this.btn_del_user.Location = new System.Drawing.Point(28, 66);
            this.btn_del_user.Name = "btn_del_user";
            this.btn_del_user.Size = new System.Drawing.Size(112, 33);
            this.btn_del_user.TabIndex = 1;
            this.btn_del_user.Text = "Baja usuario";
            this.btn_del_user.UseVisualStyleBackColor = true;
            // 
            // btn_upd_user
            // 
            this.btn_upd_user.Location = new System.Drawing.Point(28, 105);
            this.btn_upd_user.Name = "btn_upd_user";
            this.btn_upd_user.Size = new System.Drawing.Size(112, 33);
            this.btn_upd_user.TabIndex = 2;
            this.btn_upd_user.Text = "Actualizar usuario";
            this.btn_upd_user.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(276, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 8;
            // 
            // label_hacer_login
            // 
            this.label_hacer_login.AutoSize = true;
            this.label_hacer_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_hacer_login.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_hacer_login.Location = new System.Drawing.Point(246, 140);
            this.label_hacer_login.Name = "label_hacer_login";
            this.label_hacer_login.Size = new System.Drawing.Size(377, 20);
            this.label_hacer_login.TabIndex = 1;
            this.label_hacer_login.Text = "No hay una sesion activa, haga click en Login.";
            this.label_hacer_login.Visible = false;
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(19, 25);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(113, 33);
            this.button13.TabIndex = 3;
            this.button13.Text = "ABM";
            this.button13.UseVisualStyleBackColor = true;
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(19, 64);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(113, 33);
            this.button14.TabIndex = 4;
            this.button14.Text = "Facturacion";
            this.button14.UseVisualStyleBackColor = true;
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(19, 103);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(113, 33);
            this.button15.TabIndex = 5;
            this.button15.Text = "Estadisticas";
            this.button15.UseVisualStyleBackColor = true;
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(20, 25);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(112, 33);
            this.button16.TabIndex = 3;
            this.button16.Text = "Agregar rol";
            this.button16.UseVisualStyleBackColor = true;
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(20, 64);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(112, 33);
            this.button17.TabIndex = 4;
            this.button17.Text = "Baja rol";
            this.button17.UseVisualStyleBackColor = true;
            // 
            // button18
            // 
            this.button18.Location = new System.Drawing.Point(20, 103);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(112, 33);
            this.button18.TabIndex = 5;
            this.button18.Text = "Actualizar rol";
            this.button18.UseVisualStyleBackColor = true;
            // 
            // button19
            // 
            this.button19.Location = new System.Drawing.Point(19, 25);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(113, 33);
            this.button19.TabIndex = 3;
            this.button19.Text = "Agregar cliente";
            this.button19.UseVisualStyleBackColor = true;
            // 
            // button20
            // 
            this.button20.Location = new System.Drawing.Point(19, 64);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(113, 33);
            this.button20.TabIndex = 4;
            this.button20.Text = "Baja cliente";
            this.button20.UseVisualStyleBackColor = true;
            // 
            // button21
            // 
            this.button21.Location = new System.Drawing.Point(19, 103);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(113, 33);
            this.button21.TabIndex = 5;
            this.button21.Text = "Actualizar cliente";
            this.button21.UseVisualStyleBackColor = true;
            // 
            // button22
            // 
            this.button22.Location = new System.Drawing.Point(28, 27);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(112, 33);
            this.button22.TabIndex = 0;
            this.button22.Text = "Agregar usuario";
            this.button22.UseVisualStyleBackColor = true;
            // 
            // button23
            // 
            this.button23.Location = new System.Drawing.Point(28, 66);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(112, 33);
            this.button23.TabIndex = 1;
            this.button23.Text = "Baja usuario";
            this.button23.UseVisualStyleBackColor = true;
            // 
            // button24
            // 
            this.button24.Location = new System.Drawing.Point(28, 105);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(112, 33);
            this.button24.TabIndex = 2;
            this.button24.Text = "Actualizar usuario";
            this.button24.UseVisualStyleBackColor = true;
            // 
            // button25
            // 
            this.button25.Location = new System.Drawing.Point(28, 27);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(112, 33);
            this.button25.TabIndex = 0;
            this.button25.Text = "Agregar usuario";
            this.button25.UseVisualStyleBackColor = true;
            // 
            // button26
            // 
            this.button26.Location = new System.Drawing.Point(28, 66);
            this.button26.Name = "button26";
            this.button26.Size = new System.Drawing.Size(112, 33);
            this.button26.TabIndex = 1;
            this.button26.Text = "Baja usuario";
            this.button26.UseVisualStyleBackColor = true;
            // 
            // button27
            // 
            this.button27.Location = new System.Drawing.Point(28, 105);
            this.button27.Name = "button27";
            this.button27.Size = new System.Drawing.Size(112, 33);
            this.button27.TabIndex = 2;
            this.button27.Text = "Actualizar usuario";
            this.button27.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 637);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.Text = "Pago electronico";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.cliente_tab.ResumeLayout(false);
            this.cliente_tab.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.admin_tab.ResumeLayout(false);
            this.admin_tab.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btLogout;
        private System.Windows.Forms.Button btChangePassword;
        private System.Windows.Forms.Button btLogin;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label_usuario;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Button button24;
        private System.Windows.Forms.Button button25;
        private System.Windows.Forms.Button button26;
        private System.Windows.Forms.Button button27;
        private System.Windows.Forms.Label label_hacer_login;
        private System.Windows.Forms.Panel admin_tab;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btn_abm_cuentas;
        private System.Windows.Forms.Button btn_facturacion;
        private System.Windows.Forms.Button btn_estadisticas;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_add_rol;
        private System.Windows.Forms.Button btn_del_rol;
        private System.Windows.Forms.Button btn_upd_rol;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_add_cliente;
        private System.Windows.Forms.Button btn_del_cliente;
        private System.Windows.Forms.Button btn_upd_cliente;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_add_user;
        private System.Windows.Forms.Button btn_del_user;
        private System.Windows.Forms.Button btn_upd_user;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel cliente_tab;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btn_retiros;
        private System.Windows.Forms.Button btn_cli_facturacion;
        private System.Windows.Forms.Button btn_saldo;
        private System.Windows.Forms.Button btn_cli_abm_cuentas;
        private System.Windows.Forms.Button btn_transferencias;
        private System.Windows.Forms.Button btn_depositos;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Button btn_tarj_vincular;
        private System.Windows.Forms.Button btn_tarj_desvincular;
    }
}