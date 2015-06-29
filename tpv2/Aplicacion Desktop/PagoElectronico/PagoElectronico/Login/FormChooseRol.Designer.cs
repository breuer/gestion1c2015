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
            this.SuspendLayout();
            // 
            // cbbxRoles
            // 
            this.cbbxRoles.FormattingEnabled = true;
            this.cbbxRoles.Location = new System.Drawing.Point(139, 66);
            this.cbbxRoles.Name = "cbbxRoles";
            this.cbbxRoles.Size = new System.Drawing.Size(226, 21);
            this.cbbxRoles.TabIndex = 0;
            // 
            // btSelectRol
            // 
            this.btSelectRol.Location = new System.Drawing.Point(290, 155);
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
            this.label1.Location = new System.Drawing.Point(26, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Seleccionar Rol";
            // 
            // FormChooseRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 218);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btSelectRol);
            this.Controls.Add(this.cbbxRoles);
            this.Name = "FormChooseRol";
            this.Text = "FormChooseRol";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbxRoles;
        private System.Windows.Forms.Button btSelectRol;
        private System.Windows.Forms.Label label1;
    }
}