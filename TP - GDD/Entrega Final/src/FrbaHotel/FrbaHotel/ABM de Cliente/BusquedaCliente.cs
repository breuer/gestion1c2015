using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaHotel.ClasesTabla;

namespace FrbaHotel.ABM_de_Cliente
{
    public partial class BusquedaCliente : Form
    {
        SPersona sPersona = new SPersona();
        STipoDoc sTipoDNI = new STipoDoc();
        public static string usrSelected = null;

        public BusquedaCliente()
        {
            InitializeComponent();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtApellido.Text = "";
            txtDNI.Text = "";
            txtMail.Text = "";
            txtNombre.Text = "";
            cboTipo.ResetText();
            gridClientes.DataSource = null;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string tipoDni = "";
            if (int.Parse(cboTipo.SelectedValue.ToString()) != 0)
                tipoDni = cboTipo.SelectedValue.ToString();

            List<Persona> personas = sPersona.GetByGrilla(txtNombre.Text, txtApellido.Text, tipoDni, txtDNI.Text, txtMail.Text);
            gridClientes.DataSource = personas;
            if (personas.Count() > 1)
                lblVariosUsers.Visible = true;
        }

        private void BusquedaCliente_Load(object sender, EventArgs e)
        {
            cboTipo.DisplayMember = "descripcion";
            cboTipo.ValueMember = "codigo";
            cboTipo.DataSource = sTipoDNI.GetAllWithNull();
        }

        private void gridClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                if (e.ColumnIndex == 0)
                {
                    //Selecciona el id del usuario
                    usrSelected = gridClientes.Rows[e.RowIndex].Cells[1].Value.ToString();
                }
            }
            ABMCliente vistaCliente = new ABMCliente();
            vistaCliente.Show();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            ABMCliente cliente = new ABMCliente();
            this.Hide();
            cliente.Show();
        }
    }
}
