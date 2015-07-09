namespace PagoElectronico.ABM_Cuenta
{
    partial class FormListadoCuentas
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
            this.dgvCuentas = new System.Windows.Forms.DataGridView();
            this.btSelect = new System.Windows.Forms.Button();
            this.btClose = new System.Windows.Forms.Button();
            this.btAddCuenta = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCuentas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCuentas
            // 
            this.dgvCuentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCuentas.Location = new System.Drawing.Point(35, 74);
            this.dgvCuentas.Name = "dgvCuentas";
            this.dgvCuentas.Size = new System.Drawing.Size(616, 171);
            this.dgvCuentas.TabIndex = 29;
            // 
            // btSelect
            // 
            this.btSelect.Location = new System.Drawing.Point(576, 262);
            this.btSelect.Name = "btSelect";
            this.btSelect.Size = new System.Drawing.Size(75, 23);
            this.btSelect.TabIndex = 21;
            this.btSelect.Text = "Seleccionar";
            this.btSelect.UseVisualStyleBackColor = true;
            this.btSelect.Click += new System.EventHandler(this.btSelect_Click);
            // 
            // btClose
            // 
            this.btClose.Location = new System.Drawing.Point(35, 262);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(75, 23);
            this.btClose.TabIndex = 20;
            this.btClose.Text = "Cerrar";
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // btAddCuenta
            // 
            this.btAddCuenta.Location = new System.Drawing.Point(35, 28);
            this.btAddCuenta.Name = "btAddCuenta";
            this.btAddCuenta.Size = new System.Drawing.Size(75, 23);
            this.btAddCuenta.TabIndex = 30;
            this.btAddCuenta.Text = "Add Cuenta";
            this.btAddCuenta.UseVisualStyleBackColor = true;
            this.btAddCuenta.Click += new System.EventHandler(this.btAddCuenta_Click);
            // 
            // FormListadoCuentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 319);
            this.Controls.Add(this.btAddCuenta);
            this.Controls.Add(this.dgvCuentas);
            this.Controls.Add(this.btSelect);
            this.Controls.Add(this.btClose);
            this.Name = "FormListadoCuentas";
            this.Text = "FormCuenta";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCuentas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCuentas;
        private System.Windows.Forms.Button btSelect;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.Button btAddCuenta;
    }
}