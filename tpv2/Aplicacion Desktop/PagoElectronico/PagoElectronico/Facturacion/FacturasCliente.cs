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

namespace PagoElectronico.Facturacion
{
    public partial class FacturasCliente : Form
    {
        public DataTable facturas_anteriores;
        public Usuario    usuario;
        public int cliente_id;

        public FacturasCliente(Usuario  usuario,int clienteID)
        {
            InitializeComponent();

            Factura fact = new Factura();
            this.facturas_anteriores = fact.traer_facturas_cliente(clienteID);
            this.usuario = usuario;
            this.cliente_id = clienteID;
        }


        //Agrega a la grilla las cuentas.
        private void cargar_grilla_columnas()
        {
            this.grilla_facturas.Columns.Clear();

            //Armo las columnas.
            var numero = new DataGridViewTextBoxColumn();
            numero.HeaderText = "Numero";
            numero.Name = "Numero";

            var fecha = new DataGridViewTextBoxColumn();
            fecha.HeaderText = "Fecha";
            fecha.Name = "Fecha";

            var moneda = new DataGridViewTextBoxColumn();
            moneda.HeaderText = "Moneda";
            moneda.Name = "Moneda";

            var total = new DataGridViewTextBoxColumn();
            total.HeaderText = "Total";
            total.Name = "Total";

            var creador = new DataGridViewTextBoxColumn();
            creador.HeaderText = "Creador";
            creador.Name = "Creador";

            //Agrego las columnas.
            grilla_facturas.Columns.AddRange(new DataGridViewColumn[] { numero, fecha,moneda, total ,creador});

            //Seteo propiedades.
            grilla_facturas.AllowUserToAddRows = false;
            grilla_facturas.MultiSelect = false;
        }

        //Agrego a la grilla las filas.
        private void cargar_datos_grilla(DataTable data)
        {
            grilla_facturas.Rows.Clear();

            foreach (DataRow row in data.Rows)
            {
                String creador;

                if (int.Parse(row["fact_user_gen"].ToString()) == this.usuario.Id)
                    creador = "Tú";
                else
                    creador = "Administrador";

                grilla_facturas.Rows.Add(row["fact_id"].ToString(), row["fact_fecha"].ToString(), row["moneda_descrip"].ToString(), row["fact_total"].ToString(), creador);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FacturasCliente_Load(object sender, EventArgs e)
        {
            this.cargar_grilla_columnas();
            this.cargar_datos_grilla(this.facturas_anteriores);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int ix_grilla = grilla_facturas.CurrentCell.RowIndex;

            if (ix_grilla >= 0)
            {
                FormFactura factfrm = new FormFactura(this.usuario,int.Parse(this.facturas_anteriores.Rows[ix_grilla]["fact_id"].ToString()));
                factfrm.Show();
            }
            else
            {
                MessageBox.Show("Debe escoger alguna factura para verla");
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Factura fact = new Factura();
            int fact_resu = fact.facturar_cliente(this.cliente_id);

            if (fact_resu >= 0)
            {
                MessageBox.Show("Factura generada!");

                FormFactura factWin = new FormFactura(this.usuario, fact_resu);
                factWin.Show();
            }
            else
            {
                MessageBox.Show("No hay elementos que facturar, revise las facturas anteriores o tal vez no se genero un costo nuevo.");
            }
        }
    }
}
