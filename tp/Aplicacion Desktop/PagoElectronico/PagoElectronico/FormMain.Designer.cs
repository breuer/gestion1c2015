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
            this.panel3 = new System.Windows.Forms.Panel();
            this.pnlListados = new System.Windows.Forms.Panel();
            this.btListadosEstadisticos = new System.Windows.Forms.Button();
            this.pnlCliente = new System.Windows.Forms.Panel();
            this.btUpdateCliente = new System.Windows.Forms.Button();
            this.btBajaCliente = new System.Windows.Forms.Button();
            this.btAddCliente = new System.Windows.Forms.Button();
            this.pnlUsuario = new System.Windows.Forms.Panel();
            this.btUpdateUsuario = new System.Windows.Forms.Button();
            this.btBajaUsuario = new System.Windows.Forms.Button();
            this.btAddUsuario = new System.Windows.Forms.Button();
            this.pnlRol = new System.Windows.Forms.Panel();
            this.btBajaRol = new System.Windows.Forms.Button();
            this.btUpdateRol = new System.Windows.Forms.Button();
            this.btAddRol = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label_usuario = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pnlListados.SuspendLayout();
            this.pnlCliente.SuspendLayout();
            this.pnlUsuario.SuspendLayout();
            this.pnlRol.SuspendLayout();
            this.panel4.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(855, 321);
            this.panel1.TabIndex = 9;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel3.Controls.Add(this.pnlListados);
            this.panel3.Controls.Add(this.pnlCliente);
            this.panel3.Controls.Add(this.pnlUsuario);
            this.panel3.Controls.Add(this.pnlRol);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(10, 10);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(833, 299);
            this.panel3.TabIndex = 0;
            // 
            // pnlListados
            // 
            this.pnlListados.Controls.Add(this.btListadosEstadisticos);
            this.pnlListados.Location = new System.Drawing.Point(494, 121);
            this.pnlListados.Name = "pnlListados";
            this.pnlListados.Size = new System.Drawing.Size(166, 74);
            this.pnlListados.TabIndex = 14;
            // 
            // btListadosEstadisticos
            // 
            this.btListadosEstadisticos.Location = new System.Drawing.Point(16, 21);
            this.btListadosEstadisticos.Name = "btListadosEstadisticos";
            this.btListadosEstadisticos.Size = new System.Drawing.Size(135, 23);
            this.btListadosEstadisticos.TabIndex = 0;
            this.btListadosEstadisticos.Text = "Listados Estadísticos";
            this.btListadosEstadisticos.UseVisualStyleBackColor = true;
            // 
            // pnlCliente
            // 
            this.pnlCliente.Controls.Add(this.btUpdateCliente);
            this.pnlCliente.Controls.Add(this.btBajaCliente);
            this.pnlCliente.Controls.Add(this.btAddCliente);
            this.pnlCliente.Location = new System.Drawing.Point(25, 120);
            this.pnlCliente.Name = "pnlCliente";
            this.pnlCliente.Size = new System.Drawing.Size(131, 127);
            this.pnlCliente.TabIndex = 11;
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
            // 
            // pnlUsuario
            // 
            this.pnlUsuario.Controls.Add(this.btUpdateUsuario);
            this.pnlUsuario.Controls.Add(this.btBajaUsuario);
            this.pnlUsuario.Controls.Add(this.btAddUsuario);
            this.pnlUsuario.Location = new System.Drawing.Point(178, 120);
            this.pnlUsuario.Name = "pnlUsuario";
            this.pnlUsuario.Size = new System.Drawing.Size(143, 164);
            this.pnlUsuario.TabIndex = 10;
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
            // 
            // pnlRol
            // 
            this.pnlRol.Controls.Add(this.btBajaRol);
            this.pnlRol.Controls.Add(this.btUpdateRol);
            this.pnlRol.Controls.Add(this.btAddRol);
            this.pnlRol.Location = new System.Drawing.Point(336, 121);
            this.pnlRol.Name = "pnlRol";
            this.pnlRol.Size = new System.Drawing.Size(141, 128);
            this.pnlRol.TabIndex = 9;
            // 
            // btBajaRol
            // 
            this.btBajaRol.Location = new System.Drawing.Point(25, 48);
            this.btBajaRol.Name = "btBajaRol";
            this.btBajaRol.Size = new System.Drawing.Size(75, 23);
            this.btBajaRol.TabIndex = 1;
            this.btBajaRol.Text = "Baja Rol";
            this.btBajaRol.UseVisualStyleBackColor = true;
            // 
            // btUpdateRol
            // 
            this.btUpdateRol.Location = new System.Drawing.Point(25, 89);
            this.btUpdateRol.Name = "btUpdateRol";
            this.btUpdateRol.Size = new System.Drawing.Size(75, 23);
            this.btUpdateRol.TabIndex = 2;
            this.btUpdateRol.Text = "Update Rol";
            this.btUpdateRol.UseVisualStyleBackColor = true;
            // 
            // btAddRol
            // 
            this.btAddRol.Location = new System.Drawing.Point(25, 12);
            this.btAddRol.Name = "btAddRol";
            this.btAddRol.Size = new System.Drawing.Size(75, 23);
            this.btAddRol.TabIndex = 0;
            this.btAddRol.Text = "Add Rol";
            this.btAddRol.UseVisualStyleBackColor = true;
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
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 401);
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
            this.panel3.ResumeLayout(false);
            this.pnlListados.ResumeLayout(false);
            this.pnlCliente.ResumeLayout(false);
            this.pnlUsuario.ResumeLayout(false);
            this.pnlRol.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel pnlListados;
        private System.Windows.Forms.Button btListadosEstadisticos;
        private System.Windows.Forms.Button btLogout;
        private System.Windows.Forms.Button btChangePassword;
        private System.Windows.Forms.Panel pnlCliente;
        private System.Windows.Forms.Button btUpdateCliente;
        private System.Windows.Forms.Button btBajaCliente;
        private System.Windows.Forms.Button btAddCliente;
        private System.Windows.Forms.Panel pnlUsuario;
        private System.Windows.Forms.Button btUpdateUsuario;
        private System.Windows.Forms.Button btBajaUsuario;
        private System.Windows.Forms.Button btAddUsuario;
        private System.Windows.Forms.Panel pnlRol;
        private System.Windows.Forms.Button btBajaRol;
        private System.Windows.Forms.Button btUpdateRol;
        private System.Windows.Forms.Button btAddRol;
        private System.Windows.Forms.Button btLogin;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label_usuario;
    }
}