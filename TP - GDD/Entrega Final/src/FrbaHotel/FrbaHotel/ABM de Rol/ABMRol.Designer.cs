namespace FrbaHotel.ABM_de_Rol
{
    partial class ABMRol
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
            this.lblFuncion = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.MaskedTextBox();
            this.gpoBoxAlta = new System.Windows.Forms.GroupBox();
            this.ckLstFunciones = new System.Windows.Forms.CheckedListBox();
            this.ckActiva = new System.Windows.Forms.CheckBox();
            this.gpoBoxAlta.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(268, 376);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(98, 25);
            this.btnGuardar.TabIndex = 9;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(12, 376);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(79, 25);
            this.btnLimpiar.TabIndex = 8;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // lblFuncion
            // 
            this.lblFuncion.AutoSize = true;
            this.lblFuncion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFuncion.Location = new System.Drawing.Point(10, 63);
            this.lblFuncion.Name = "lblFuncion";
            this.lblFuncion.Size = new System.Drawing.Size(129, 20);
            this.lblFuncion.TabIndex = 2;
            this.lblFuncion.Text = "Funcionalidades:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(10, 30);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(79, 20);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "* Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(95, 30);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(242, 23);
            this.txtNombre.TabIndex = 10;
            // 
            // gpoBoxAlta
            // 
            this.gpoBoxAlta.Controls.Add(this.ckLstFunciones);
            this.gpoBoxAlta.Controls.Add(this.ckActiva);
            this.gpoBoxAlta.Controls.Add(this.txtNombre);
            this.gpoBoxAlta.Controls.Add(this.lblNombre);
            this.gpoBoxAlta.Controls.Add(this.lblFuncion);
            this.gpoBoxAlta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpoBoxAlta.Location = new System.Drawing.Point(12, 12);
            this.gpoBoxAlta.Name = "gpoBoxAlta";
            this.gpoBoxAlta.Size = new System.Drawing.Size(354, 358);
            this.gpoBoxAlta.TabIndex = 7;
            this.gpoBoxAlta.TabStop = false;
            this.gpoBoxAlta.Text = "Rol";
            // 
            // ckLstFunciones
            // 
            this.ckLstFunciones.FormattingEnabled = true;
            this.ckLstFunciones.Location = new System.Drawing.Point(14, 93);
            this.ckLstFunciones.Name = "ckLstFunciones";
            this.ckLstFunciones.Size = new System.Drawing.Size(323, 220);
            this.ckLstFunciones.TabIndex = 39;
            // 
            // ckActiva
            // 
            this.ckActiva.AutoSize = true;
            this.ckActiva.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckActiva.Location = new System.Drawing.Point(18, 320);
            this.ckActiva.Name = "ckActiva";
            this.ckActiva.Size = new System.Drawing.Size(71, 24);
            this.ckActiva.TabIndex = 32;
            this.ckActiva.Text = "Activo";
            this.ckActiva.UseVisualStyleBackColor = true;
            // 
            // ABMRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 413);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.gpoBoxAlta);
            this.Name = "ABMRol";
            this.Text = "ABM Rol";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ABMRol_FormClosing);
            this.Load += new System.EventHandler(this.ABMRol_Load);
            this.gpoBoxAlta.ResumeLayout(false);
            this.gpoBoxAlta.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label lblFuncion;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.MaskedTextBox txtNombre;
        private System.Windows.Forms.GroupBox gpoBoxAlta;
        private System.Windows.Forms.CheckedListBox ckLstFunciones;
        private System.Windows.Forms.CheckBox ckActiva;
    }
}