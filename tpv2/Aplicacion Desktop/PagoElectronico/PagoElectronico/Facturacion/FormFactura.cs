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
    public partial class FormFactura : Form
    {
        private Usuario   usuario;
        private DataTable factura;
        private DataTable factura_detalle;

        public FormFactura(Usuario usuario,int factID)
        {
            Factura fact = new Factura();
            InitializeComponent();

            this.usuario = usuario;
            this.factura = fact.traer_factura_id(factID);
            this.factura_detalle = fact.traer_detalle_factura(factID);
        }

        //Agrega a la grilla las cuentas.
        private void cargar_grilla_columnas()
        {
            this.grilla_detalle.Columns.Clear();

            //Armo las columnas.
            var numero = new DataGridViewTextBoxColumn();
            numero.HeaderText = "Numero Op";
            numero.Name = "Numero Op";

            var fecha = new DataGridViewTextBoxColumn();
            fecha.HeaderText = "Fecha";
            fecha.Name = "Fecha";

            var concepto = new DataGridViewTextBoxColumn();
            concepto.HeaderText = "Concepto";
            concepto.Name = "Concepto";

            var costo = new DataGridViewTextBoxColumn();
            costo.HeaderText = "Costo";
            costo.Name = "Costo";

            var moneda = new DataGridViewTextBoxColumn();
            moneda.HeaderText = "Moneda";
            moneda.Name = "Moneda";

            //Agrego las columnas.
            grilla_detalle.Columns.AddRange(new DataGridViewColumn[] { numero, fecha, costo,concepto, moneda });

            //Seteo propiedades.
            grilla_detalle.AllowUserToAddRows = false;
            grilla_detalle.MultiSelect = false;
        }

        //Agrego a la grilla las filas.
        private void cargar_datos_grilla(DataTable data)
        {
            grilla_detalle.Rows.Clear();

            foreach (DataRow row in data.Rows)
            {
                grilla_detalle.Rows.Add(row["factcto_id"].ToString(), row["factcto_fecha"].ToString(), row["fact_comp_descrip"].ToString(), row["factcto_costo"].ToString(), row["moneda_descrip"].ToString());
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FormFactura_Load(object sender, EventArgs e)
        {
            //Bindeo campos.
            this.txt_total.Text = factura.Rows[0]["moneda_descrip"].ToString()+" " + factura.Rows[0]["fact_total"].ToString();
            this.txt_fact_cliente.Text = factura.Rows[0]["cli_apellido"].ToString() + " " + factura.Rows[0]["cli_nombre"].ToString();
            this.txt_num_factura.Text = factura.Rows[0]["fact_id"].ToString();

            //Cargo la grilla.
            this.cargar_grilla_columnas();
            this.cargar_datos_grilla(this.factura_detalle);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
