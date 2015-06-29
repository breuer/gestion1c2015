using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaHotel.ClasesTabla;
using FrbaHotel.ABM_de_Cliente;

namespace FrbaHotel.Generar_Modificar_Reserva
{
    public partial class BusquedaReserva : Form
    {
        STipoDoc sTipoDoc = new STipoDoc();
        SPersona sPersona = new SPersona();
        Persona usrSel = null;
        private string usrSelected = null;
        //User a modificar
        public static string modUsr = null;
        //Vengo de AMReserva
        public static bool amRes = false;
        public static bool cheInOut = false;

        public BusquedaReserva()
        {
            InitializeComponent();
        }

        private void BusquedaReserva_Load(object sender, EventArgs e)
        {
            cboTipo.DisplayMember = "descripcion";
            cboTipo.ValueMember = "codigo";
            cboTipo.DataSource = sTipoDoc.GetAll();
            usrSelected = null;
            modUsr = null;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtDNI.Text = null;
            txtMail.Text = null;
            txtApellido.Text = null;
            txtNombre.Text = null;
            txtDniSel.Text = null;
            txtMailSel.Text = null;
            txtTipoSel.Text = null;
            usrSelected = null;
            gridPersonas.DataSource = null;
            modUsr = null;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            ABMCliente cliente = new ABMCliente();
            AMReserva.user_selected = "0";
            this.Hide();
            cliente.Show();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtMail.Text != "" || (txtDNI.Text != "" && cboTipo.Text != ""))
            {
                string mail = txtMail.Text;
                string dni = txtDNI.Text;
                string tipoDni = cboTipo.SelectedValue.ToString();

                StringBuilder Valores = new StringBuilder();

                if (mail != "")
                {
                    Valores.Append("p.mail = '" + mail + "'");
                    if (dni != "")
                        Valores.Append(" AND ");
                }
                if (dni != "")
                {
                    Valores.Append("p.num_doc = " + dni + "AND p.codigo_tipo_doc = " + tipoDni);
                }

                Valores.Append(" AND estado != 0");
                List<Persona> personas = sPersona.GetBySQL("SELECT * FROM hotel.persona p WHERE " + Valores.ToString());
                gridPersonas.DataSource = personas;
                if (personas.Count() > 1)
                    lblVariosUsers.Visible = true;
            }
            else
            {
                MessageBox.Show("Debe ingresar valores para la búsqueda");
            }
        }

        private void gridPersonas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                if (e.ColumnIndex == 0)
                {
                    //Selecciona el id del usuario
                    usrSelected = gridPersonas.Rows[e.RowIndex].Cells[1].Value.ToString();

                    //Cargar los datos para que los vea
                    txtApellido.Text = gridPersonas.Rows[e.RowIndex].Cells[3].Value.ToString();
                    txtNombre.Text = gridPersonas.Rows[e.RowIndex].Cells[2].Value.ToString();
                    txtDniSel.Text = gridPersonas.Rows[e.RowIndex].Cells[5].Value.ToString();
                    txtMailSel.Text = gridPersonas.Rows[e.RowIndex].Cells[6].Value.ToString();
                    //Ver que guarde el campo del Tipo
                    TipoDoc tipo = sTipoDoc.getByCod(Decimal.Parse(cboTipo.SelectedValue.ToString()));
                    txtTipoSel.Text = tipo.descripcion;
                }
            }
        }

        private void BtnConfirmar_Click(object sender, EventArgs e)
        {
            usrSel = sPersona.getByCodigo(usrSelected);
            if (usrSel.estado)
            {
                if (amRes)
                    //Vine de AMReserva
                    AMReserva.user_selected = usrSelected;
                if (cheInOut)
                {    //Vine de Estadia
                    Registrar_Estadia.Estadia.user_selected = usrSelected;
                }
                this.Hide();
            }
            else
                MessageBox.Show("Un usuario deshabilitado no puede generar reservas");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (amRes)
                AMReserva.user_selected = null;
            if (cheInOut)
                Registrar_Estadia.Estadia.user_selected = null;
            this.Hide();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            modUsr = usrSelected;
            ABMCliente cliente = new ABMCliente();
            cliente.Show();
        }


    }
}
