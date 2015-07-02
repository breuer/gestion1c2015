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
using PagoElectronico.Saldos;

namespace PagoElectronico.Saldos
{
    public partial class FormSaldo_cliente : Form
    {
        public Usuario   usuario;
        public DataTable cuentas_usuario;

        public FormSaldo_cliente(Usuario usuario)
        {
            this.usuario = usuario;
            InitializeComponent();
        }

        private void cargar_combos()
        {
            Saldo saldo = new Saldo();
            DataTable resu = saldo.buscar_cuentas_usuario_validas(this.usuario);

            //Si hay cuentas activas.
            if (resu.Rows.Count > 0)
            {
                this.cuentas_usuario = resu;
                cta_combo_activas.Items.Clear();

                foreach (DataRow row in resu.Rows)
                {
                    cta_combo_activas.Items.Add(row["cta_num"].ToString()+" "+row["pais_descrip"].ToString());
                }
            }
            else
            {
                MessageBox.Show("No hay ninguna cuenta asociada, nose podra realizar ninguna consulta de saldo");
                this.Close();
            }
        }

        private void FormSaldo_Load(object sender, EventArgs e)
        {
            cargar_combos();
            label_importe.Text = "_____________";
        }


        //Agrega a la grilla las cuentas.
        private void cargar_grilla_columnas()
        {
            grilla_resu.Columns.Clear();

            //Armo las columnas.
            var tipo = new DataGridViewTextBoxColumn();
            tipo.HeaderText = "Tipo";
            tipo.Name = "Tipo";

            var importe = new DataGridViewTextBoxColumn();
            importe.HeaderText = "Importe";
            importe.Name = "Importe";

            var fecha = new DataGridViewTextBoxColumn();
            fecha.HeaderText = "Fecha";
            fecha.Name = "Fecha";

            //Agrego las columnas.
            grilla_resu.Columns.AddRange(new DataGridViewColumn[] { tipo, importe, fecha });

            //Seteo propiedades.
            grilla_resu.AllowUserToAddRows = false;
            grilla_resu.MultiSelect = false;
        }

        //Agrego a la grilla las filas.
        private void cargar_datos_grilla(DataTable data)
        {
            grilla_resu.Rows.Clear();

            foreach (DataRow row in data.Rows)
            {
                grilla_resu.Rows.Add(row["tipo"].ToString(), row["importe"].ToString(), row["fecha"].ToString());
            }
        }

        private void cargar_grilla_movimientos(String ctaId)
        { 
            Saldo saldo = new Saldo();
            DataTable resu = saldo.consulta_movimientos(ctaId);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ix_cuenta = cta_combo_activas.SelectedIndex;

            if (ix_cuenta >= 0)
            {
                //Cuenta.
                String cuenta = this.cuentas_usuario.Rows[ix_cuenta]["cta_id"].ToString();

                //Obtengo el saldo actual.
                Saldo saldo = new Saldo();
                DataTable saldos = saldo.saldo_actual(cuenta);

                //Traigo el saldo.
                if (saldos.Rows.Count > 0)
                {
                    String importe     = saldos.Rows[0]["saldo"].ToString();
                    label_importe.Text = "U$$ "+importe;
                }

                //Muestros los movimientos en la grilla.
                DataTable datos = saldo.consulta_movimientos(cuenta);
                this.cargar_grilla_columnas();
                this.cargar_datos_grilla(datos);
            }
            else
            {
                MessageBox.Show("Tiene que elegir una cuenta.");
            }
        }
    }
}
