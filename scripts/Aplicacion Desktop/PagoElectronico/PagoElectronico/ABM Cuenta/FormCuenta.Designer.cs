namespace PagoElectronico.ABM_Cliente
{
    partial class FormCuenta
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
            this.btModCliente = new System.Windows.Forms.Button();
            this.btAddCuenta = new System.Windows.Forms.Button();
            this.btModCuenta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btModCliente
            // 
            this.btModCliente.Location = new System.Drawing.Point(67, 101);
            this.btModCliente.Name = "btModCliente";
            this.btModCliente.Size = new System.Drawing.Size(75, 29);
            this.btModCliente.TabIndex = 6;
            this.btModCliente.Text = "Baja";
            this.btModCliente.UseVisualStyleBackColor = true;
            this.btModCliente.Click += new System.EventHandler(this.btAddCliente_Click);
            // 
            // btAddCuenta
            // 
            this.btAddCuenta.Location = new System.Drawing.Point(67, 44);
            this.btAddCuenta.Name = "btAddCuenta";
            this.btAddCuenta.Size = new System.Drawing.Size(75, 28);
            this.btAddCuenta.TabIndex = 7;
            this.btAddCuenta.Text = "Alta";
            this.btAddCuenta.UseVisualStyleBackColor = true;
            // 
            // btModCuenta
            // 
            this.btModCuenta.Location = new System.Drawing.Point(67, 161);
            this.btModCuenta.Name = "btModCuenta";
            this.btModCuenta.Size = new System.Drawing.Size(75, 27);
            this.btModCuenta.TabIndex = 8;
            this.btModCuenta.Text = "Modificacion";
            this.btModCuenta.UseVisualStyleBackColor = true;
            // 
            // FormCuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.btModCuenta);
            this.Controls.Add(this.btAddCuenta);
            this.Controls.Add(this.btModCliente);
            this.Name = "FormCuenta";
            this.Text = "FormCuenta";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btModCliente;
        private System.Windows.Forms.Button btAddCuenta;
        private System.Windows.Forms.Button btModCuenta;
    }
}