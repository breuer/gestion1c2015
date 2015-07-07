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
    public partial class FormFacturacionAdmin : Form
    {
        public DataTable  documentos_tipos;
        public DataTable  clientes;
        private Usuario   usuario;

        public FormFacturacionAdmin(Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
        }

        private void cargar_combo_docs()
        { 
            Factura     fact  = new Factura();
            DataTable   tdocs = fact.traer_documentos_tipo();

            //Si hay cuentas activas.
            if (tdocs.Rows.Count > 0)
            {
                this.documentos_tipos = tdocs;

                foreach (DataRow row in tdocs.Rows)
                {
                    combo_doc.Items.Add(row["tdoc_descrip"].ToString());
                }
            }
            else
            {
                MessageBox.Show("No hay ninguna documento cargado, no se podra buscar clientes.");
                this.Close();
            }
        }

        //Agrega a la grilla las cuentas.
        private void cargar_grilla_columnas()
        {
            this.grilla_clientes.Columns.Clear();

            //Armo las columnas.
            var nombre = new DataGridViewTextBoxColumn();
            nombre.HeaderText = "Nombre";
            nombre.Name = "Nombre";

            var apellido = new DataGridViewTextBoxColumn();
            apellido.HeaderText = "Apellido";
            apellido.Name = "Apellido";

            var pais = new DataGridViewTextBoxColumn();
            pais.HeaderText = "Pais";
            pais.Name = "Pais";

            //Agrego las columnas.
            grilla_clientes.Columns.AddRange(new DataGridViewColumn[] { nombre ,apellido,pais});

            //Seteo propiedades.
            grilla_clientes.AllowUserToAddRows = false;
            grilla_clientes.MultiSelect = false;
        }

        //Agrego a la grilla las filas.
        private void cargar_datos_grilla(DataTable data)
        {
            grilla_clientes.Rows.Clear();

            foreach (DataRow row in data.Rows)
            {
                grilla_clientes.Rows.Add(row["cli_nombre"].ToString(), row["cli_apellido"].ToString(), row["pais_descrip"].ToString());
            }
        }

        private void buscar_clientes()
        {            
            int tdoc_ix = combo_doc.SelectedIndex;

            if (tdoc_ix >= 0)
            {
                if (this.num_doc.Text.ToString() != "")
                {
                    Factura fact = new Factura();
                    DataTable resu = fact.buscar_clientes(int.Parse(documentos_tipos.Rows[tdoc_ix]["tdoc_cod"].ToString()), int.Parse(this.num_doc.Text.ToString()));
                    this.clientes = resu;

                    this.cargar_grilla_columnas();
                    this.cargar_datos_grilla(resu);
                }
                else
                {
                    MessageBox.Show("Debe escribir el numero de documento.");
                }
            }
            else
            {
                MessageBox.Show("Debe elegir un documento primero");
            }
        }

        private void FormFacturacionAdmin_Load(object sender, EventArgs e)
        {
            this.cargar_combo_docs();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.buscar_clientes();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int ix_grilla = grilla_clientes.CurrentCell.RowIndex;

            if (ix_grilla >= 0)
            {
                int cli_id = int.Parse(this.clientes.Rows[ix_grilla]["cli_id"].ToString());
                FacturasCliente frm = new FacturasCliente(this.usuario,cli_id);
                frm.Show();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un cliente");

            }
        }
    }
}