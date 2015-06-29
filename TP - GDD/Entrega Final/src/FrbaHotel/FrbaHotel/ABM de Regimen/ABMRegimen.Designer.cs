namespace FrbaHotel.ABM_de_Regimen
{
    partial class ABMRegimen
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
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.gpoBoxAlta = new System.Windows.Forms.GroupBox();
            this.cboDescrip = new System.Windows.Forms.MaskedTextBox();
            this.ckActivo = new System.Windows.Forms.CheckBox();
            this.txtPrecio = new System.Windows.Forms.MaskedTextBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblDescrip = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gpoBoxAlta.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(258, 148);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(98, 25);
            this.btnGuardar.TabIndex = 15;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(12, 148);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(79, 25);
            this.btnLimpiar.TabIndex = 14;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // gpoBoxAlta
            // 
            this.gpoBoxAlta.Controls.Add(this.label1);
            this.gpoBoxAlta.Controls.Add(this.cboDescrip);
            this.gpoBoxAlta.Controls.Add(this.ckActivo);
            this.gpoBoxAlta.Controls.Add(this.txtPrecio);
            this.gpoBoxAlta.Controls.Add(this.lblPrecio);
            this.gpoBoxAlta.Controls.Add(this.lblDescrip);
            this.gpoBoxAlta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpoBoxAlta.Location = new System.Drawing.Point(12, 12);
            this.gpoBoxAlta.Name = "gpoBoxAlta";
            this.gpoBoxAlta.Size = new System.Drawing.Size(344, 130);
            this.gpoBoxAlta.TabIndex = 13;
            this.gpoBoxAlta.TabStop = false;
            this.gpoBoxAlta.Text = "Regimen";
            // 
            // cboDescrip
            // 
            this.cboDescrip.Location = new System.Drawing.Point(122, 32);
            this.cboDescrip.Name = "cboDescrip";
            this.cboDescrip.Size = new System.Drawing.Size(197, 23);
            this.cboDescrip.TabIndex = 29;
            // 
            // ckActivo
            // 
            this.ckActivo.AutoSize = true;
            this.ckActivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckActivo.Location = new System.Drawing.Point(14, 95);
            this.ckActivo.Name = "ckActivo";
            this.ckActivo.Size = new System.Drawing.Size(71, 24);
            this.ckActivo.TabIndex = 27;
            this.ckActivo.Text = "Activo";
            this.ckActivo.UseVisualStyleBackColor = true;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(122, 61);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(184, 23);
            this.txtPrecio.TabIndex = 26;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.Location = new System.Drawing.Point(10, 62);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(106, 20);
            this.lblPrecio.TabIndex = 17;
            this.lblPrecio.Text = "* Precio base:";
            // 
            // lblDescrip
            // 
            this.lblDescrip.AutoSize = true;
            this.lblDescrip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescrip.Location = new System.Drawing.Point(10, 32);
            this.lblDescrip.Name = "lblDescrip";
            this.lblDescrip.Size = new System.Drawing.Size(106, 20);
            this.lblDescrip.TabIndex = 15;
            this.lblDescrip.Text = "* Descripción:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(310, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 20);
            this.label1.TabIndex = 30;
            this.label1.Text = "dll.";
            // 
            // ABMRegimen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 188);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.gpoBoxAlta);
            this.Name = "ABMRegimen";
            this.Text = "ABM Regimen";
            this.Load += new System.EventHandler(this.ABMRegimen_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ABMRegimen_FormClosing);
            this.gpoBoxAlta.ResumeLayout(false);
            this.gpoBoxAlta.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.GroupBox gpoBoxAlta;
        private System.Windows.Forms.MaskedTextBox txtPrecio;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblDescrip;
        private System.Windows.Forms.CheckBox ckActivo;
        private System.Windows.Forms.MaskedTextBox cboDescrip;
        private System.Windows.Forms.Label label1;
    }
}