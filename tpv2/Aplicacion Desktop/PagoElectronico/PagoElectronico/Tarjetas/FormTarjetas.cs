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

namespace PagoElectronico.Tarjetas
{
    public partial class FormTarjetas : Form
    {
        private Usuario   usuario;
        private DataTable tarjetas_vinculadas;

        public FormTarjetas(Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
        }

        //Agrega a la grilla las cuentas.
        private void cargar_grilla_columnas()
        {
            this.grilla_tarjetas.Columns.Clear();

            //Armo las columnas.
            var numero        = new DataGridViewTextBoxColumn();
            numero.HeaderText = "Numero";
            numero.Name       = "numero";

            var emisor        = new DataGridViewTextBoxColumn();
            emisor.HeaderText = "Emisor";
            emisor.Name       = "Emisor";

            var fecvenc        = new DataGridViewTextBoxColumn();
            fecvenc.HeaderText = "Vencimiento";
            fecvenc.Name       = "Vencimiento";

            //Agrego las columnas.
            grilla_tarjetas.Columns.AddRange(new DataGridViewColumn[] { numero, emisor, fecvenc});

            //Seteo propiedades.
            grilla_tarjetas.AllowUserToAddRows = false;
            grilla_tarjetas.MultiSelect        = false;
        }

        //Agrego a la grilla las filas.
        private void cargar_datos_grilla(DataTable data)
        {
            grilla_tarjetas.Rows.Clear();

            foreach (DataRow row in data.Rows)
            {
                grilla_tarjetas.Rows.Add(row["tarj_numero"].ToString(), row["tarjemis_nombre"].ToString(), row["tarj_fecvencimiento"].ToString());
            }
        }

        private void cargar_tarjetas()
        {
            grilla_tarjetas.Rows.Clear();
            Tarjeta tarj = new Tarjeta();
            DataTable resu = tarj.traer_tarjetas_vinculadas_usuario(this.usuario);
            this.tarjetas_vinculadas = resu;

            this.cargar_grilla_columnas();
            this.cargar_datos_grilla(resu);
        }

        private void FormTarjetas_Load(object sender, EventArgs e)
        {

        }

        private void FormTarjetas_Shown(object sender, EventArgs e)
        {
            cargar_tarjetas();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormVincular vinc = new FormVincular(this.usuario);
            vinc.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int ix_grilla = grilla_tarjetas.CurrentCell.RowIndex;

            if (ix_grilla >= 0)
            {
                int tarj_id = int.Parse(this.tarjetas_vinculadas.Rows[ix_grilla]["tarj_id"].ToString());
                FormEditar editfrm = new FormEditar(this.usuario, tarj_id);
                editfrm.Show();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int ix_grilla = grilla_tarjetas.CurrentCell.RowIndex;

            if (ix_grilla >= 0)
            {
                int tarj_id = int.Parse(this.tarjetas_vinculadas.Rows[ix_grilla]["tarj_id"].ToString());
                Tarjeta tarj = new Tarjeta();
                tarj.desvincular_tarjeta(tarj_id);
                MessageBox.Show("Tarjeta desvinculada");
                this.cargar_tarjetas();
            }
        }

        private void grilla_tarjetas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
