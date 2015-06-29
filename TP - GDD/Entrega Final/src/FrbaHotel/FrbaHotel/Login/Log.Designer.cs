namespace FrbaHotel.Login
{
    partial class Log
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
            this.lblusuario = new System.Windows.Forms.Label();
            this.lblContra = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtContra = new System.Windows.Forms.TextBox();
            this.btnIn = new System.Windows.Forms.Button();
            this.lblHotel = new System.Windows.Forms.Label();
            this.cboHotel = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblusuario
            // 
            this.lblusuario.AutoSize = true;
            this.lblusuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusuario.Location = new System.Drawing.Point(15, 22);
            this.lblusuario.Name = "lblusuario";
            this.lblusuario.Size = new System.Drawing.Size(98, 25);
            this.lblusuario.TabIndex = 5;
            this.lblusuario.Text = "* Usuario:";
            // 
            // lblContra
            // 
            this.lblContra.AutoSize = true;
            this.lblContra.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContra.Location = new System.Drawing.Point(15, 63);
            this.lblContra.Name = "lblContra";
            this.lblContra.Size = new System.Drawing.Size(133, 25);
            this.lblContra.TabIndex = 6;
            this.lblContra.Text = "* Contraseña:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(154, 19);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(189, 30);
            this.txtUsuario.TabIndex = 7;
            // 
            // txtContra
            // 
            this.txtContra.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContra.Location = new System.Drawing.Point(154, 60);
            this.txtContra.Name = "txtContra";
            this.txtContra.PasswordChar = '-';
            this.txtContra.Size = new System.Drawing.Size(189, 30);
            this.txtContra.TabIndex = 8;
            // 
            // btnIn
            // 
            this.btnIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIn.Location = new System.Drawing.Point(128, 145);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(88, 39);
            this.btnIn.TabIndex = 9;
            this.btnIn.Text = "Ingresar";
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // lblHotel
            // 
            this.lblHotel.AutoSize = true;
            this.lblHotel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHotel.Location = new System.Drawing.Point(15, 103);
            this.lblHotel.Name = "lblHotel";
            this.lblHotel.Size = new System.Drawing.Size(76, 25);
            this.lblHotel.TabIndex = 10;
            this.lblHotel.Text = "* Hotel:";
            this.lblHotel.Visible = false;
            // 
            // cboHotel
            // 
            this.cboHotel.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.cboHotel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHotel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboHotel.FormattingEnabled = true;
            this.cboHotel.Items.AddRange(new object[] {
            "Exterior",
            "Interior"});
            this.cboHotel.Location = new System.Drawing.Point(97, 103);
            this.cboHotel.Name = "cboHotel";
            this.cboHotel.Size = new System.Drawing.Size(246, 26);
            this.cboHotel.TabIndex = 31;
            this.cboHotel.Visible = false;
            // 
            // Log
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 205);
            this.Controls.Add(this.cboHotel);
            this.Controls.Add(this.lblHotel);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.txtContra);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lblContra);
            this.Controls.Add(this.lblusuario);
            this.Name = "Log";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Log_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblusuario;
        private System.Windows.Forms.Label lblContra;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtContra;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Label lblHotel;
        private System.Windows.Forms.ComboBox cboHotel;
    }
}