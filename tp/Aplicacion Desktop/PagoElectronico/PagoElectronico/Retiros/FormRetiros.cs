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
                MessageBox.Show("No hay ninguna cuenta de origen cargada, no se podran hacer transferencias.");
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
            }        
        }

        private void FormRetiros_Load(object sender, EventArgs e)
        {
            //Cargo las cuentas en el combo box.
            cargar_combo_cuentas();

            //Cargo los bancos en el combo.
            cargar_combo_bancos();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Retiro ret = new Retiro();
            int   resu = ret.validar_id_dni(this.usuario, txt_dni.Text);

            //Si coincide el dni ingresado con el ndoc del usuario.
            if (resu==1)
            {
                //Traigo indices.
                int ix_cuenta = combo_ctas_activas.SelectedIndex;  
                int ix_combo  = combo_bancos.SelectedIndex;
                
                //Si estan seleccionados.
                if ((ix_cuenta>=0)&&(ix_combo>=0))
                {
                    String cta_retirar = this.cuentas_usuario.Rows[ix_cuenta]["cta_id"].ToString();
                    String cod_bco     = this.bancos.Rows[ix_combo]["bco_cod"].ToString();

                    //Realizar transferencia.
                    int estado         = ret.retirar(cta_retirar, cod_bco, float.Parse(txt_importe.Text));

                    //Analizo el resultado.
                    switch (estado)
                    {
                        case  1: MessageBox.Show("Retiro realizado correctamente");
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
                    MessageBox.Show("Escoja una cuenta y banco primero.");
                }
            }
            else
            {
                MessageBox.Show("El número de documento no coincide con tu usuario actual, no es posible seguir.");
            }            
        }
    }
}
