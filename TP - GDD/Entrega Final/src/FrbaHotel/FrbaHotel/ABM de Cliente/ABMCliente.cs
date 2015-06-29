using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaHotel.ClasesTabla;
using FrbaHotel.Generar_Modificar_Reserva;

namespace FrbaHotel.ABM_de_Cliente
{
    public partial class ABMCliente : Form
    {
        SPersona sPersona = new SPersona();
        STipoDoc sTipoDoc = new STipoDoc();
        Persona perVentana = new Persona();
        //cuando lo llaman desde ABMCliente
        private bool busqCliente = false;
        //Cuando lo llaman de AMReserva
        private bool busqReserva = false;
        private bool modfAMReserva = false;

        public ABMCliente()
        {
            InitializeComponent();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            resetearValores();
        }

        private void resetearValores()
        {
            txtApellido.Text = "";
            txtCalle.Text = "";
            txtLocalidad.Text = "";
            txtMail.Text = "";
            txtNacimiento.Text = "";
            txtNacionalidad.Text = "";
            txtNombre.Text = "";
            txtNumCalle.Text = "";
            txtNumDNI.Text = "";
            txtPais.Text = "";
            txtTelefono.Text = "";
            txtCiudad.Text = "";
            btnHabDeshab.Visible = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (camposObligatorios() && validarMail())
            {
                parsearPersona();
                if (busqCliente || modfAMReserva)
                {
                    decimal codigo = sPersona.Update(perVentana);
                    MessageBox.Show("El cliente " + codigo + " se ha actualizado con éxito");
                    if (modfAMReserva)
                        this.Hide();
                }
                else
                {
                    nuevoCliente();
                }
            }
        }

        private void nuevoCliente()
        {
            //Ver cuando llama desde Reserva
            decimal codigo = sPersona.Save(perVentana);
            MessageBox.Show("El cliente " + codigo + " se ha creado con éxito");
            if (busqReserva)
            {
                AMReserva.user_selected = codigo.ToString();
                this.Hide();
            }
            else
            {
                perVentana = new Persona();
                resetearValores();
            }
        }

        //Muestra el calendario y guarda la fecha elegida
        private void btnCalendario_Click(object sender, EventArgs e)
        {
            calendNacimiento.Visible = true;
        }

        private void calendNacimiento_DateSelected(object sender, DateRangeEventArgs e)
        {
            txtNacimiento.Text = e.Start.ToShortDateString();
            calendNacimiento.Visible = false;
        }

        //Valida el mail para la creacion
        private bool validarMail()
        {
            List<Persona> clientesMail = sPersona.GetByMailToValidate(txtMail.Text, perVentana.codigo.ToString());
            if (clientesMail.Count != 0)
            {
                MessageBox.Show("El mail debe ser único! Ya está registrado.");
                return false;
            }
            else
            {
                return true;
            }
        }

        //Valida los campos obligatorios
        private bool camposObligatorios()
        {
            string telefono = txtTelefono.Text.Replace('-', ' ').Replace(" ", "").Trim();
            if (txtPais.Text != "" && txtCiudad.Text != "" && txtCalle.Text != "" && txtNumCalle.Text != "" && telefono != "" &&
            txtMail.Text != "" && cboTipoDNI.SelectedValue.ToString() != "" && txtNumDNI.Text != "" && txtNombre.Text != "" && txtApellido.Text != "")
            {

                try
                {
                    DateTime.Parse(txtNacimiento.Text);
                }
                catch
                {
                    MessageBox.Show("La fecha de nacimiento ingresada es invalida");
                    return false;
                }
                return true;
            }
            else
            {
                MessageBox.Show("Complete los campos obligatorios");
                return false;
            }
        }

        //Guarda los datos para la nueva persona
        private void parsearPersona()
        {
            perVentana.nombre = txtNombre.Text;
            perVentana.apellido = txtApellido.Text;
            perVentana.codigo_tipo_doc = int.Parse(cboTipoDNI.SelectedValue.ToString());
            perVentana.num_doc = decimal.Parse(txtNumDNI.Text);
            perVentana.mail = txtMail.Text;
            string tel = txtTelefono.Text.Replace('-', ' ').Replace(" ", "").Trim().ToString();
            perVentana.telefono = decimal.Parse(tel);
            perVentana.nom_calle = txtCalle.Text;
            perVentana.num_calle = decimal.Parse(txtNumCalle.Text);
            perVentana.fecha_nacimiento = DateTime.Parse(txtNacimiento.Text);
            perVentana.localidad = txtLocalidad.Text;
            perVentana.pais = txtPais.Text;
            perVentana.nacionalidad = txtNacionalidad.Text;
            perVentana.ciudad = txtCiudad.Text;
            if (perVentana.codigo != 0)
                perVentana.estado = true;

        }

        private void ABMCliente_Load(object sender, EventArgs e)
        {
            calendNacimiento.TodayDate = FormIni.FechaSistema;
            calendNacimiento.MaxDate = FormIni.FechaSistema;
            cboTipoDNI.DisplayMember = "descripcion";
            cboTipoDNI.ValueMember = "codigo";
            cboTipoDNI.DataSource = sTipoDoc.GetAll();
            if (BusquedaCliente.usrSelected != null)
            {
                busqCliente = true;
                loadDatosPersona(BusquedaCliente.usrSelected);
            }
            if (AMReserva.user_selected != null)
            {
                busqReserva = true;
            }
            if (BusquedaReserva.modUsr != null)
            {
                modfAMReserva = true;
                loadDatosPersona(BusquedaReserva.modUsr);
            }
            else
                perVentana.codigo = 0;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void loadDatosPersona(string usuario)
        {
            perVentana = sPersona.getByCodigo(usuario);
            txtApellido.Text = perVentana.apellido;
            txtCalle.Text = perVentana.nom_calle;
            txtLocalidad.Text = perVentana.localidad;
            txtMail.Text = perVentana.mail;
            txtNacimiento.Text = perVentana.fecha_nacimiento.ToShortDateString();
            txtNacionalidad.Text = perVentana.nacionalidad;
            txtNombre.Text = perVentana.nombre;
            txtNumCalle.Text = perVentana.num_calle.ToString();
            txtNumDNI.Text = perVentana.num_doc.ToString();
            txtPais.Text = perVentana.pais;
            txtTelefono.Text = perVentana.telefono.ToString();
            txtCiudad.Text = perVentana.ciudad;
            cboTipoDNI.SelectedValue = perVentana.codigo_tipo_doc;
            btnHabDeshab.Visible = true;
            if (perVentana.estado)
                btnHabDeshab.Text = "Deshabilitar";
            else
                btnHabDeshab.Text = "Habilitar";
        }

        private void btnHabDeshab_Click(object sender, EventArgs e)
        {
            if (perVentana.estado)
                deshabilitarUsuario();
            else
                habilitarUsuario();
        }

        private void deshabilitarUsuario()
        {
            sPersona.deshabilitarCliente(perVentana.codigo.ToString());
            this.Hide();
        }

        private void habilitarUsuario()
        {
            sPersona.habilitarCliente(perVentana.codigo.ToString());
            this.Hide();
        }
    }
}
