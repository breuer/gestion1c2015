using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PagoElectronico.DAO;
using PagoElectronico.Model;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace PagoElectronico.Depositos
{
    public partial class FormDepositos : Form
    {
        public Usuario   usuario;
        public DataTable cuentas_usuario;
        public DataTable tarjetas_usuario;

        public FormDepositos(Usuario usuario)
        {
            this.usuario = usuario;
            InitializeComponent();
        }

        private void cargar_combo_cuentas()
        {
            Deposito depo = new Deposito();
            DataTable resu = depo.buscar_cuentas_usuario_validas(this.usuario);

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
                this.Close();
            }
        }

        private void cargar_combo_tarjetas()
        {
            Deposito  depo = new Deposito();
            DataTable resu = depo.buscar_tarjetas_usuario_validas(this.usuario);

            //Si hay tarjetas activas.
            if (resu.Rows.Count > 0)
            {
                this.tarjetas_usuario = resu;

                tarj_user.Items.Clear();

                foreach (DataRow row in resu.Rows)
                {
                    tarj_user.Items.Add(row["tarj_numero"].ToString() + " - " + row["tarjemis_nombre"].ToString());
                }
            }
            else
            {
                MessageBox.Show("No hay ninguna tarjeta cargada, no se podran hacer un deposito sin alguna de ellas.");
                this.Close();
            }
        }

        private void Depositos_Load(object sender, EventArgs e)
        {
            cargar_combo_cuentas();
            cargar_combo_tarjetas();
        }

        private void button1_Click(object sender, EventArgs e)
        {
                //Traigo indices.
                int ix_cuenta = combo_ctas_activas.SelectedIndex;
                int ix_tarj   = tarj_user.SelectedIndex;
                float importe = float.Parse(txt_importe.Text);

                //Si estan seleccionados.
                if ((ix_cuenta >= 0) && (ix_tarj >= 0))
                {
                    //Si el importe es mayor que cero.
                    if (importe > 0)
                    {
                        //Obtengo info de la tarjeta y la cuenta.
                        String cta_depo = this.cuentas_usuario.Rows[ix_cuenta]["cta_id"].ToString();
                        String tarj_depo = this.tarjetas_usuario.Rows[ix_tarj]["tarj_id"].ToString();                        

                        //Realizar transferencia.
                        Deposito depo = new Deposito();
                        int    estado = depo.cuenta_retirar_saldo(long.Parse(cta_depo),1,long.Parse(tarj_depo),importe);
                        
                        switch (estado)
                        {
                            case  1: MessageBox.Show("El deposito se realizo correctamente!");
                                    this.Close();
                                    break;
                            case -1: MessageBox.Show("Valor no permitido!");
                                    break;
                            case -2: MessageBox.Show("La tarjeta de credito es invalidad para realizar la operación");
                                    break;
                        }                        
                    }
                    else
                    {
                        MessageBox.Show("El importe debe ser mayor que cero.");                    
                    }
                }
                else
                {
                    MessageBox.Show("Es necesario seleccionar una tarjeta y una cuenta para poder seguir.");
                }
        }
    }
}
