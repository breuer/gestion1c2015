namespace FrbaHotel
{
    partial class FormIni
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
            this.lblNum = new System.Windows.Forms.Label();
            this.cboRoles = new System.Windows.Forms.ComboBox();
            this.lblBien = new System.Windows.Forms.Label();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.cboFunciones = new System.Windows.Forms.ComboBox();
            this.lblFunciones = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNum.Location = new System.Drawing.Point(56, 164);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(170, 18);
            this.lblNum.TabIndex = 4;
            this.lblNum.Text = "Elija un rol para ingresar:";
            // 
            // cboRoles
            // 
            this.cboRoles.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.cboRoles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRoles.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboRoles.FormattingEnabled = true;
            this.cboRoles.Items.AddRange(new object[] {
            "Exterior",
            "Interior"});
            this.cboRoles.Location = new System.Drawing.Point(248, 163);
            this.cboRoles.Name = "cboRoles";
            this.cboRoles.Size = new System.Drawing.Size(241, 24);
            this.cboRoles.TabIndex = 12;
            // 
            // lblBien
            // 
            this.lblBien.AutoSize = true;
            this.lblBien.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBien.Location = new System.Drawing.Point(26, 69);
            this.lblBien.Name = "lblBien";
            this.lblBien.Size = new System.Drawing.Size(521, 37);
            this.lblBien.TabIndex = 13;
            this.lblBien.Text = "Bienvenido a la gestoría de hoteles!";
            // 
            // btnIngresar
            // 
            this.btnIngresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresar.Location = new System.Drawing.Point(146, 215);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(113, 39);
            this.btnIngresar.TabIndex = 14;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnAcept_Click);
            // 
            // cboFunciones
            // 
            this.cboFunciones.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.cboFunciones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFunciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboFunciones.FormattingEnabled = true;
            this.cboFunciones.Location = new System.Drawing.Point(248, 309);
            this.cboFunciones.Name = "cboFunciones";
            this.cboFunciones.Size = new System.Drawing.Size(241, 24);
            this.cboFunciones.TabIndex = 15;
            this.cboFunciones.Visible = false;
            // 
            // lblFunciones
            // 
            this.lblFunciones.AutoSize = true;
            this.lblFunciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFunciones.Location = new System.Drawing.Point(56, 310);
            this.lblFunciones.Name = "lblFunciones";
            this.lblFunciones.Size = new System.Drawing.Size(170, 18);
            this.lblFunciones.TabIndex = 16;
            this.lblFunciones.Text = "Elija la función a realizar:";
            this.lblFunciones.Visible = false;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Location = new System.Drawing.Point(204, 363);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(113, 39);
            this.btnAceptar.TabIndex = 17;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Visible = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnFunc_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Enabled = false;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(299, 215);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(113, 39);
            this.btnSalir.TabIndex = 18;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Visible = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FormIni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 454);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lblFunciones);
            this.Controls.Add(this.cboFunciones);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.lblBien);
            this.Controls.Add(this.cboRoles);
            this.Controls.Add(this.lblNum);
            this.Name = "FormIni";
            this.Text = "Gestión de Hotelería";
            this.Load += new System.EventHandler(this.FormIni_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.ComboBox cboRoles;
        private System.Windows.Forms.Label lblBien;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.ComboBox cboFunciones;
        private System.Windows.Forms.Label lblFunciones;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnSalir;
    }
}

