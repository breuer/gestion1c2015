namespace PagoElectronico.Login
{
    partial class FormChooseRol
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
            this.cbbxRoles = new System.Windows.Forms.ComboBox();
            this.btSelectRol = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbbxRoles
            // 
            this.cbbxRoles.FormattingEnabled = true;
            this.cbbxRoles.Location = new System.Drawing.Point(119, 25);
            this.cbbxRoles.Name = "cbbxRoles";
            this.cbbxRoles.Size = new System.Drawing.Size(226, 21);
            this.cbbxRoles.TabIndex = 0;
            // 
            // btSelectRol
            // 
            this.btSelectRol.Location = new System.Drawing.Point(270, 67);
            this.btSelectRol.Name = "btSelectRol";
            this.btSelectRol.Size = new System.Drawing.Size(75, 23);
            this.btSelectRol.TabIndex = 1;
            this.btSelectRol.Text = "Aceptar";
            this.btSelectRol.UseVisualStyleBackColor = true;
            this.btSelectRol.Click += new System.EventHandler(this.btSelectRol_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Seleccionar Rol";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btSelectRol);
            this.groupBox1.Controls.Add(this.cbbxRoles);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(368, 103);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Roles";
            // 
            // FormChooseRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 133);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormChooseRol";
            this.Text = "Elegir Rol";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbxRoles;
        private System.Windows.Forms.Button btSelectRol;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}