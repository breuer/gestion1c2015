using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PagoElectronico.Model;


namespace PagoElectronico.ABM_Cliente
{
    public partial class FormCliente : Form
    {
        private Cliente cliente;

        public FormCliente(Cliente cliente)
        {
            InitializeComponent();
            this.cliente = cliente;
        }

        private void btAddCliente_Click(object sender, EventArgs e)
        {
            cliente.Apellido = this.tbApellido.Text;
            cliente.Nombre = this.tbNombre.Text;
            cliente.Mail = this.tbMail.Text;
            
        }
    }
}
