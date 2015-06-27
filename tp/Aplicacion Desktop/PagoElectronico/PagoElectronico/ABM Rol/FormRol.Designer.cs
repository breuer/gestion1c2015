namespace PagoElectronico.ABM_Rol
{
    partial class FormRol
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.cbFuncionalidades = new System.Windows.Forms.ComboBox();
            this.btQuitarFunionalidad = new System.Windows.Forms.Button();
            this.btAddFuncionalidad = new System.Windows.Forms.Button();
            this.dgvFuncionalidades = new System.Windows.Forms.DataGridView();
            this.btClose = new System.Windows.Forms.Button();
            this.btAceptar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionalidades)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Funcionalidad";
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(186, 26);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(100, 20);
            this.tbNombre.TabIndex = 2;
            // 
            // cbFuncionalidades
            // 
            this.cbFuncionalidades.FormattingEnabled = true;
            this.cbFuncionalidades.Location = new System.Drawing.Point(286, 116);
            this.cbFuncionalidades.Name = "cbFuncionalidades";
            this.cbFuncionalidades.Size = new System.Drawing.Size(218, 21);
            this.cbFuncionalidades.TabIndex = 3;
            // 
            // btQuitarFunionalidad
            // 
            this.btQuitarFunionalidad.Location = new System.Drawing.Point(48, 174);
            this.btQuitarFunionalidad.Name = "btQuitarFunionalidad";
            this.btQuitarFunionalidad.Size = new System.Drawing.Size(75, 23);
            this.btQuitarFunionalidad.TabIndex = 4;
            this.btQuitarFunionalidad.Text = "Quitar";
            this.btQuitarFunionalidad.UseVisualStyleBackColor = true;
            this.btQuitarFunionalidad.Click += new System.EventHandler(this.btQuitarFunionalidad_Click);
            // 
            // btAddFuncionalidad
            // 
            this.btAddFuncionalidad.Location = new System.Drawing.Point(429, 174);
            this.btAddFuncionalidad.Name = "btAddFuncionalidad";
            this.btAddFuncionalidad.Size = new System.Drawing.Size(75, 23);
            this.btAddFuncionalidad.TabIndex = 5;
            this.btAddFuncionalidad.Text = "Agregar";
            this.btAddFuncionalidad.UseVisualStyleBackColor = true;
            this.btAddFuncionalidad.Click += new System.EventHandler(this.btAddFuncionalidad_Click);
            // 
            // dgvFuncionalidades
            // 
            this.dgvFuncionalidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFuncionalidades.Location = new System.Drawing.Point(45, 213);
            this.dgvFuncionalidades.Name = "dgvFuncionalidades";
            this.dgvFuncionalidades.Size = new System.Drawing.Size(459, 150);
            this.dgvFuncionalidades.TabIndex = 6;
            // 
            // btClose
            // 
            this.btClose.Location = new System.Drawing.Point(51, 410);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(75, 23);
            this.btClose.TabIndex = 7;
            this.btClose.Text = "Cerrar";
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // btAceptar
            // 
            this.btAceptar.Location = new System.Drawing.Point(417, 410);
            this.btAceptar.Name = "btAceptar";
            this.btAceptar.Size = new System.Drawing.Size(75, 23);
            this.btAceptar.TabIndex = 8;
            this.btAceptar.Text = "Aceptar";
            this.btAceptar.UseVisualStyleBackColor = true;
            this.btAceptar.Click += new System.EventHandler(this.btAceptar_Click);
            // 
            // FormRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 463);
            this.Controls.Add(this.btAceptar);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.dgvFuncionalidades);
            this.Controls.Add(this.btAddFuncionalidad);
            this.Controls.Add(this.btQuitarFunionalidad);
            this.Controls.Add(this.cbFuncionalidades);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormRol";
            this.Text = "FormRol";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionalidades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.ComboBox cbFuncionalidades;
        private System.Windows.Forms.Button btQuitarFunionalidad;
        private System.Windows.Forms.Button btAddFuncionalidad;
        private System.Windows.Forms.DataGridView dgvFuncionalidades;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.Button btAceptar;
    }
}