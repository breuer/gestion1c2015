namespace PagoElectronico
{
    partial class FormFechaSistema
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
            this.dtpFechaSistema = new System.Windows.Forms.DateTimePicker();
            this.btUpdateFecha = new System.Windows.Forms.Button();
            this.btClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dtpFechaSistema
            // 
            this.dtpFechaSistema.Location = new System.Drawing.Point(26, 66);
            this.dtpFechaSistema.Name = "dtpFechaSistema";
            this.dtpFechaSistema.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaSistema.TabIndex = 0;
            // 
            // btUpdateFecha
            // 
            this.btUpdateFecha.Location = new System.Drawing.Point(151, 121);
            this.btUpdateFecha.Name = "btUpdateFecha";
            this.btUpdateFecha.Size = new System.Drawing.Size(75, 23);
            this.btUpdateFecha.TabIndex = 1;
            this.btUpdateFecha.Text = "Actualizar";
            this.btUpdateFecha.UseVisualStyleBackColor = true;
            this.btUpdateFecha.Click += new System.EventHandler(this.btUpdateFecha_Click);
            // 
            // btClose
            // 
            this.btClose.Location = new System.Drawing.Point(23, 121);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(75, 23);
            this.btClose.TabIndex = 2;
            this.btClose.Text = "Cerrar";
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "ACTUALIZAR FECHA DE SISTEMA";
            // 
            // FormFechaSistema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 173);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.btUpdateFecha);
            this.Controls.Add(this.dtpFechaSistema);
            this.Name = "FormFechaSistema";
            this.Text = "FormFechaSistema";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpFechaSistema;
        private System.Windows.Forms.Button btUpdateFecha;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.Label label1;
    }
}