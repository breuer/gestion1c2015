using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PagoElectronico.Model;
using PagoElectronico.ABM_de_Usuario;


namespace PagoElectronico.ABM_Cliente
{
    public partial class FormCliente : Form
    {
        private Cliente cliente;
        private int operacion;

        private void initCBB()
        {
            this.cbTipoIdentificacion.DataSource = DataSession.TipoIdentificaciones;
            this.cbTipoIdentificacion.ValueMember = "id";
            this.cbTipoIdentificacion.DisplayMember = "nombre";

            this.cbPais.DataSource = DataSession.Paices;
            this.cbPais.ValueMember = "id";
            this.cbPais.DisplayMember = "nombre";

        }
        private void cargar()
        {
            
            this.tbApellido.Text = cliente.Apellido;
            this.tbNombre.Text = cliente.Nombre;
            this.tbMail.Text = cliente.Mail;
            this.tbIdentificacion.Text = cliente.Identificacion.ToString();
            this.cbTipoIdentificacion.SelectedValue = cliente.TipoDeIdentificacionCod;
            this.cbPais.SelectedValue = cliente.PaisCod;
            this.cbDarBaja.Checked = cliente.Activo == false;
        }

        public FormCliente(Cliente cliente, int operacion)
        {
            InitializeComponent();
            this.cliente = cliente;
            this.initCBB();
            this.tbUsuario.Text = cliente.Usuario.Username;
            this.tbUsuario.Enabled = false;
            //this.pnlCliente.Enabled = false;
            this.pnDarBaja.Visible = false;
            switch (operacion) 
            { 
                case DataSession.ALTA:
                    this.lOperacion.Text = "ALTA CLIENTE";
                    this.operacion = DataSession.ALTA;
                    this.btAceptar.Text = "Alta";
                    break;
                case DataSession.MODIFICACION:
                    this.lOperacion.Text = "MODIFICACION CLIENTE";
                    this.operacion = DataSession.MODIFICACION;
                    this.cargar();
                    this.pnDarBaja.Visible = true;
                    this.btAceptar.Text = "Modificar";
                    break;   
            }
        }


        private void btCloseCliente_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
        private void btAceptar_Click(object sender, EventArgs e)
        {
            cliente.Apellido = this.tbApellido.Text;
            cliente.Nombre = this.tbNombre.Text;
            cliente.Mail = this.tbMail.Text;
            cliente.TipoDeIdentificacionCod = int.Parse(this.cbTipoIdentificacion.SelectedValue.ToString());
            cliente.Identificacion = int.Parse(this.tbIdentificacion.Text);
            cliente.PaisCod = int.Parse(this.cbPais.SelectedValue.ToString());
            cliente.Activo = this.cbDarBaja.Checked == false;

            switch (this.operacion)
            {
                case DataSession.ALTA:
                    cliente.add();
                    break;
                case DataSession.MODIFICACION:
                    cliente.update();
                    break;
            }
            this.Close();
        }

    }
}
