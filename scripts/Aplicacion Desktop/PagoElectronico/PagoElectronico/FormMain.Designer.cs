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
            this.btLogout = new System.Windows.Forms.Button();
            this.btLogin = new System.Windows.Forms.Button();
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
            this.pnlLogin.SuspendLayout();
            this.pnlRol.SuspendLayout();
            this.pnlUsuario.SuspendLayout();
            this.pnlCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLogin
            // 
            this.pnlLogin.Controls.Add(this.btLogout);
            this.pnlLogin.Controls.Add(this.btLogin);
            this.pnlLogin.Location = new System.Drawing.Point(45, 30);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(137, 128);
            this.pnlLogin.TabIndex = 0;
            // 
            // btLogout
            // 
            this.btLogout.Location = new System.Drawing.Point(25, 78);
            this.btLogout.Name = "btLogout";
            this.btLogout.Size = new System.Drawing.Size(75, 23);
            this.btLogout.TabIndex = 1;
            this.btLogout.Text = "Logout";
            this.btLogout.UseVisualStyleBackColor = true;
            // 
            // btLogin
            // 
            this.btLogin.Location = new System.Drawing.Point(25, 21);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(75, 23);
            this.btLogin.TabIndex = 0;
            this.btLogin.Text = "Login";
            this.btLogin.UseVisualStyleBackColor = true;
            this.btLogin.Click += new System.EventHandler(this.btLogin_Click);
            // 
            // pnlRol
            // 
            this.pnlRol.Controls.Add(this.btUpdateRol);
            this.pnlRol.Controls.Add(this.btBajaRol);
            this.pnlRol.Controls.Add(this.btAddRol);
            this.pnlRol.Location = new System.Drawing.Point(235, 30);
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
            // 
            // pnlUsuario
            // 
            this.pnlUsuario.Controls.Add(this.btUpdateUsuario);
            this.pnlUsuario.Controls.Add(this.btBajaUsuario);
            this.pnlUsuario.Controls.Add(this.btAddUsuario);
            this.pnlUsuario.Location = new System.Drawing.Point(427, 30);
            this.pnlUsuario.Name = "pnlUsuario";
            this.pnlUsuario.Size = new System.Drawing.Size(143, 128);
            this.pnlUsuario.TabIndex = 2;
            // 
            // btUpdateUsuario
            // 
            this.btUpdateUsuario.Location = new System.Drawing.Point(20, 89);
            this.btUpdateUsuario.Name = "btUpdateUsuario";
            this.btUpdateUsuario.Size = new System.Drawing.Size(103, 23);
            this.btUpdateUsuario.TabIndex = 2;
            this.btUpdateUsuario.Text = "Update Usuario";
            this.btUpdateUsuario.UseVisualStyleBackColor = true;
            // 
            // btBajaUsuario
            // 
            this.btBajaUsuario.Location = new System.Drawing.Point(20, 50);
            this.btBajaUsuario.Name = "btBajaUsuario";
            this.btBajaUsuario.Size = new System.Drawing.Size(75, 23);
            this.btBajaUsuario.TabIndex = 1;
            this.btBajaUsuario.Text = "Baja Usuario";
            this.btBajaUsuario.UseVisualStyleBackColor = true;
            // 
            // btAddUsuario
            // 
            this.btAddUsuario.Location = new System.Drawing.Point(20, 12);
            this.btAddUsuario.Name = "btAddUsuario";
            this.btAddUsuario.Size = new System.Drawing.Size(75, 23);
            this.btAddUsuario.TabIndex = 0;
            this.btAddUsuario.Text = "Add Usuario";
            this.btAddUsuario.UseVisualStyleBackColor = true;
            // 
            // pnlCliente
            // 
            this.pnlCliente.Controls.Add(this.btUpdateCliente);
            this.pnlCliente.Controls.Add(this.btBajaCliente);
            this.pnlCliente.Controls.Add(this.btAddCliente);
            this.pnlCliente.Location = new System.Drawing.Point(605, 31);
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
            this.panel1.Location = new System.Drawing.Point(45, 200);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 4;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 401);
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
    }
}