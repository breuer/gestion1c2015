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
            this.btBajaRol = new System.Windows.Forms.Button();
            this.btAddRol = new System.Windows.Forms.Button();
            this.pnlUsuario = new System.Windows.Forms.Panel();
            this.btUpdateUsuario = new System.Windows.Forms.Button();
            this.btBajaUsuario = new System.Windows.Forms.Button();
            this.btAddUsuario = new System.Windows.Forms.Button();
            this.pnlCliente = new System.Windows.Forms.Panel();
            this.btUpdateCliente = new System.Windows.Forms.Button();
            this.btBajaCliente = new System.Windows.Forms.Button();
            this.btAddCliente = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btExit = new System.Windows.Forms.Button();
            this.btChangePassword = new System.Windows.Forms.Button();
            this.pnlSession = new System.Windows.Forms.Panel();
            this.pnlListados = new System.Windows.Forms.Panel();
            this.btListadosEstadisticos = new System.Windows.Forms.Button();
            this.pnlLogin.SuspendLayout();
            this.pnlRol.SuspendLayout();
            this.pnlUsuario.SuspendLayout();
            this.pnlCliente.SuspendLayout();
            this.pnlSession.SuspendLayout();
            this.pnlListados.SuspendLayout();
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
            this.pnlRol.Controls.Add(this.btBajaRol);
            this.pnlRol.Controls.Add(this.btAddRol);
            this.pnlRol.Location = new System.Drawing.Point(387, 31);
            this.pnlRol.Name = "pnlRol";
            this.pnlRol.Size = new System.Drawing.Size(141, 128);
            this.pnlRol.TabIndex = 1;
            // 
            // btUpdateRol
            // 
            this.btUpdateRol.Location = new System.Drawing.Point(25, 89);
            this.btUpdateRol.Name = "btUpdateRol";
            this.btUpdateRol.Size = new System.Drawing.Size(75, 23);
            this.btUpdateRol.TabIndex = 2;
            this.btUpdateRol.Text = "Update Rol";
            this.btUpdateRol.UseVisualStyleBackColor = true;
            this.btUpdateRol.Click += new System.EventHandler(this.btUpdateRol_Click);
            // 
            // btBajaRol
            // 
            this.btBajaRol.Location = new System.Drawing.Point(25, 50);
            this.btBajaRol.Name = "btBajaRol";
            this.btBajaRol.Size = new System.Drawing.Size(75, 23);
            this.btBajaRol.TabIndex = 1;
            this.btBajaRol.Text = "Baja Rol";
            this.btBajaRol.UseVisualStyleBackColor = true;
            // 
            // btAddRol
            // 
            this.btAddRol.Location = new System.Drawing.Point(25, 12);
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
            this.pnlUsuario.Controls.Add(this.btBajaUsuario);
            this.pnlUsuario.Controls.Add(this.btAddUsuario);
            this.pnlUsuario.Location = new System.Drawing.Point(207, 30);
            this.pnlUsuario.Name = "pnlUsuario";
            this.pnlUsuario.Size = new System.Drawing.Size(143, 164);
            this.pnlUsuario.TabIndex = 2;
            // 
            // btUpdateUsuario
            // 
            this.btUpdateUsuario.Location = new System.Drawing.Point(20, 106);
            this.btUpdateUsuario.Name = "btUpdateUsuario";
            this.btUpdateUsuario.Size = new System.Drawing.Size(103, 23);
            this.btUpdateUsuario.TabIndex = 2;
            this.btUpdateUsuario.Text = "Update Usuario";
            this.btUpdateUsuario.UseVisualStyleBackColor = true;
            // 
            // btBajaUsuario
            // 
            this.btBajaUsuario.Location = new System.Drawing.Point(20, 61);
            this.btBajaUsuario.Name = "btBajaUsuario";
            this.btBajaUsuario.Size = new System.Drawing.Size(75, 23);
            this.btBajaUsuario.TabIndex = 1;
            this.btBajaUsuario.Text = "Baja Usuario";
            this.btBajaUsuario.UseVisualStyleBackColor = true;
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
            this.pnlCliente.Controls.Add(this.btBajaCliente);
            this.pnlCliente.Controls.Add(this.btAddCliente);
            this.pnlCliente.Location = new System.Drawing.Point(45, 236);
            this.pnlCliente.Name = "pnlCliente";
            this.pnlCliente.Size = new System.Drawing.Size(131, 127);
            this.pnlCliente.TabIndex = 3;
            // 
            // btUpdateCliente
            // 
            this.btUpdateCliente.Location = new System.Drawing.Point(14, 88);
            this.btUpdateCliente.Name = "btUpdateCliente";
            this.btUpdateCliente.Size = new System.Drawing.Size(96, 23);
            this.btUpdateCliente.TabIndex = 2;
            this.btUpdateCliente.Text = "Update Cliente";
            this.btUpdateCliente.UseVisualStyleBackColor = true;
            // 
            // btBajaCliente
            // 
            this.btBajaCliente.Location = new System.Drawing.Point(14, 49);
            this.btBajaCliente.Name = "btBajaCliente";
            this.btBajaCliente.Size = new System.Drawing.Size(75, 23);
            this.btBajaCliente.TabIndex = 1;
            this.btBajaCliente.Text = "Baja Cliente";
            this.btBajaCliente.UseVisualStyleBackColor = true;
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
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(207, 236);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 4;
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
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 401);
            this.Controls.Add(this.pnlListados);
            this.Controls.Add(this.pnlSession);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.panel1);
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
            this.pnlSession.ResumeLayout(false);
            this.pnlListados.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLogin;
        private System.Windows.Forms.Button btLogin;
        private System.Windows.Forms.Button btLogout;
        private System.Windows.Forms.Panel pnlRol;
        private System.Windows.Forms.Button btUpdateRol;
        private System.Windows.Forms.Button btBajaRol;
        private System.Windows.Forms.Button btAddRol;
        private System.Windows.Forms.Panel pnlUsuario;
        private System.Windows.Forms.Button btUpdateUsuario;
        private System.Windows.Forms.Button btBajaUsuario;
        private System.Windows.Forms.Button btAddUsuario;
        private System.Windows.Forms.Panel pnlCliente;
        private System.Windows.Forms.Button btUpdateCliente;
        private System.Windows.Forms.Button btBajaCliente;
        private System.Windows.Forms.Button btAddCliente;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Button btChangePassword;
        private System.Windows.Forms.Panel pnlSession;
        private System.Windows.Forms.Panel pnlListados;
        private System.Windows.Forms.Button btListadosEstadisticos;
    }
}