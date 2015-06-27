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
using PagoElectronico.Transferencias;

namespace PagoElectronico.Transferencias
{
    public partial class FormTransfer : Form
    {
        public FormTransfer()
        {
            InitializeComponent();
        }

        //Agrega a la grilla las cuentas.
        private void cargar_grilla_columnas()
        {
            grilla_cuentas.Columns.Clear();

            //Armo las columnas.
            var numero = new DataGridViewTextBoxColumn();
            numero.HeaderText = "Numero";
            numero.Name       = "numero";

            var pais = new DataGridViewTextBoxColumn();
            pais.HeaderText = "Pais";
            pais.Name       = "pais";

            var apellido = new DataGridViewTextBoxColumn();
            apellido.HeaderText = "Apellido";
            apellido.Name       = "apellido";

            var nombre = new DataGridViewTextBoxColumn();
            nombre.HeaderText = "Nombre";
            nombre.Name       = "nombre";

            //Agrego las columnas.
            grilla_cuentas.Columns.AddRange(new DataGridViewColumn[] { numero, pais, apellido, nombre});

            //Seteo propiedades.
            grilla_cuentas.AllowUserToAddRows = false;
            grilla_cuentas.MultiSelect = false;
        }

        //Agrego a la grilla las filas.
        private void cargar_datos_grilla(DataTable data)
        {
            grilla_cuentas.Rows.Clear();

            foreach (DataRow row in data.Rows)
            {
                grilla_cuentas.Rows.Add(row["cta_num"].ToString(), row["pais_descrip"].ToString(), row["cli_apellido"].ToString(), row["cli_nombre"].ToString());                   
            }            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Transferencia transf = new Transferencia();
            DataTable resu = transf.buscar_cuentas(txt_cuenta.Text);

            if (resu.Rows.Count > 0)
            {                
                //Cargo los datos en la grilla.
                cargar_grilla_columnas();
                cargar_datos_grilla(resu);
            }
            else
            {
                MessageBox.Show("No se encuentro una cuenta con ese número.");
            }  
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Obtengo info de la columna elegida.
            if (grilla_cuentas.Rows.Count>0)
            {
                String numero = grilla_cuentas.Rows[grilla_cuentas.CurrentCell.RowIndex].Cells[0].Value.ToString();
                String pais   = grilla_cuentas.Rows[grilla_cuentas.CurrentCell.RowIndex].Cells[1].Value.ToString();
                MessageBox.Show(numero + " "+pais);
                
            }
            
        }
    }
}
