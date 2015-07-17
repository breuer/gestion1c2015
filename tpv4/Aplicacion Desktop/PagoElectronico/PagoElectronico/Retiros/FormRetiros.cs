using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PagoElectronico.Model;
using PagoElectronico.DAO;
using PagoElectronico.Retiros;

namespace PagoElectronico.Retiros
{
    public partial class FormRetiros : Form
    {
        public Usuario   usuario;
        public DataTable cuentas_usuario;
        private Label label1;
        private GroupBox groupBox2;
        private ComboBox combo_bancos;
        private Label label9;
        private Label label8;
        private Button button1;
        private Label label7;
        private TextBox txt_importe;
        private Label label5;
        private Label label6;
        private TextBox txt_dni;
        private Label label3;
        private Label label2;
        private ComboBox combo_ctas_activas;
        private Label label4;
        public DataTable bancos;

        public FormRetiros(Usuario usuario)
        {
            this.usuario = usuario;
            InitializeComponent();
        }

        private void cargar_combo_cuentas()
        {
            Retiro    ret  = new Retiro();
            DataTable resu = ret.buscar_cuentas_usuario_validas(this.usuario);
         
            //Si hay cuentas activas.
            if (resu.Rows.Count > 0)
            {
                this.cuentas_usuario = resu;

                combo_ctas_activas.Items.Clear();

                foreach (DataRow row in resu.Rows)
                {
                    combo_ctas_activas.Items.Add(row["cta_num"].ToString() + " - " + row["pais_descrip"].ToString());
                }
            }
            else
            {
                MessageBox.Show("No tenes cuentas asociadas activas con saldo para poder realizar un retiro de capital.");
                this.Close();
            }
        }

        private void cargar_combo_bancos()
        {
            Retiro ret = new Retiro();
            DataTable resu = ret.listar_bancos();

            //Si hay cuentas activas.
            if (resu.Rows.Count > 0)
            {
                this.bancos = resu;
                combo_bancos.Items.Clear();

                foreach (DataRow row in resu.Rows)
                {
                    combo_bancos.Items.Add(row["bco_nombre"]);
                }
            }
            else
            {
                MessageBox.Show("No hay ningun banco cargado, no se podra realizar un retiro de dinero.");
                this.Close();
            }        
        }

        private void FormRetiros_Load(object sender, EventArgs e)
        {
            //Cargo las cuentas en el combo box.
            cargar_combo_cuentas();

            //Cargo los bancos en el combo.
            cargar_combo_bancos();
        }

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.combo_bancos = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_importe = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_dni = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.combo_ctas_activas = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "Retiros";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.combo_bancos);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txt_importe);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txt_dni);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.combo_ctas_activas);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(19, 53);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(418, 407);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Realizar Extracción";
            // 
            // combo_bancos
            // 
            this.combo_bancos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_bancos.FormattingEnabled = true;
            this.combo_bancos.Location = new System.Drawing.Point(24, 317);
            this.combo_bancos.Name = "combo_bancos";
            this.combo_bancos.Size = new System.Drawing.Size(369, 21);
            this.combo_bancos.TabIndex = 12;
            this.combo_bancos.SelectedIndexChanged += new System.EventHandler(this.combo_bancos_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 293);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(258, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Seleccione el banco que usara para emitir el cheque.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(21, 274);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Banco";
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.Green;
            this.button1.Location = new System.Drawing.Point(24, 351);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 41);
            this.button1.TabIndex = 9;
            this.button1.Text = "Continuar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Olive;
            this.label7.Location = new System.Drawing.Point(263, 226);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 24);
            this.label7.TabIndex = 8;
            this.label7.Text = "U$$ Dolares";
            // 
            // txt_importe
            // 
            this.txt_importe.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_importe.Location = new System.Drawing.Point(23, 222);
            this.txt_importe.Name = "txt_importe";
            this.txt_importe.Size = new System.Drawing.Size(231, 31);
            this.txt_importe.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Escriba el importe a extraer";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(21, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Importe";
            // 
            // txt_dni
            // 
            this.txt_dni.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_dni.Location = new System.Drawing.Point(24, 136);
            this.txt_dni.Name = "txt_dni";
            this.txt_dni.Size = new System.Drawing.Size(360, 29);
            this.txt_dni.TabIndex = 4;
            this.txt_dni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_dni_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(346, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Escriba su numero de documento, se usa como validacion de seguridad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Numero de documento";
            // 
            // combo_ctas_activas
            // 
            this.combo_ctas_activas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_ctas_activas.FormattingEnabled = true;
            this.combo_ctas_activas.Location = new System.Drawing.Point(24, 49);
            this.combo_ctas_activas.Name = "combo_ctas_activas";
            this.combo_ctas_activas.Size = new System.Drawing.Size(369, 21);
            this.combo_ctas_activas.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Seleccione la cuenta a usar";
            // 
            // FormRetiros
            // 
            this.ClientSize = new System.Drawing.Size(454, 482);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormRetiros";
            this.Text = "Retiros";
            this.Load += new System.EventHandler(this.FormRetiros_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Traigo indices.
            int   ix_cuenta = combo_ctas_activas.SelectedIndex;
            int   ix_combo = combo_bancos.SelectedIndex;
            float f;

            //Si estan seleccionados.
            if ((ix_cuenta >= 0) && (ix_combo >= 0))
            {         
                //Reviso si esta bien el numero.
                if (float.TryParse(this.txt_importe.Text, out f))
                {
                    if (txt_dni.Text!="")
                    {
                        Retiro ret  = new Retiro();
                        int    resu = ret.validar_id_dni(this.usuario, txt_dni.Text);

                        //Si coincide el dni ingresado con el ndoc del usuario.
                        if (resu == 1)
                        {
                            String cta_retirar = this.cuentas_usuario.Rows[ix_cuenta]["cta_id"].ToString();
                            String cod_bco = this.bancos.Rows[ix_combo]["bco_cod"].ToString();

                            //Realizar transferencia.
                            int estado = ret.retirar(cta_retirar, cod_bco, float.Parse(txt_importe.Text));

                            //Analizo el resultado.
                            switch (estado)
                            {
                                case 1 : MessageBox.Show("Retiro realizado correctamente");
                                         this.Close();
                                         break;
                                case -1: MessageBox.Show("La cuenta no esta activa.");
                                         break;
                                case -2: MessageBox.Show("No hay saldo en la cuenta, para realizar la extracción.");
                                         break;
                                case -3: MessageBox.Show("No alcanza el saldo para realizar la extracción.");
                                         break;
                            }
                        }
                        else
                        {
                            MessageBox.Show("El documento no es el correcto");
                        }
                    }
                    else
                    {
                            MessageBox.Show("Debe ingresar el número de documento");                    
                    }
                }
                else
                {
                    MessageBox.Show("El valor del importe debe ser numerico");
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar una cuenta y banco");
            }
        }

        private void combo_bancos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt_dni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
