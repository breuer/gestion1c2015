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
    public partial class FormFacturacion : Form
    {
        public  DataTable facturas_anteriores;
        private Usuario   usuario;

        public FormFacturacion(Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
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

            //Agrego las columnas.
            grilla_facturas.Columns.AddRange(new DataGridViewColumn[] { numero, fecha});

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
                grilla_facturas.Rows.Add(row["fact_id"].ToString(), row["fact_fecha"].ToString());
            }
        }

        private void FormFacturacion_Load(object sender, EventArgs e)
        {
           Factura fact = new Factura();
           DataTable facturas = fact.traer_facturas_usuario(this.usuario);
           this.facturas_anteriores = facturas;
            cargar_grilla_columnas();
            cargar_datos_grilla(facturas);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int ix_grilla = grilla_facturas.CurrentCell.RowIndex;

            if (ix_grilla >= 0)
            {
                int fact_id = int.Parse(this.facturas_anteriores.Rows[ix_grilla]["fact_id"].ToString());
                FormFactura fact = new FormFactura(this.usuario,fact_id);
                fact.Show();
            }
            else
            {
                MessageBox.Show("No hay facturas anteriores que visualizar.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Factura fact = new Factura();
            int fact_resu = fact.facturar_usuario(this.usuario);

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
