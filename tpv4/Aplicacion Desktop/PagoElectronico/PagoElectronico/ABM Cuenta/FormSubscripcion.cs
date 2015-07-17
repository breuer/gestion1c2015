using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PagoElectronico.Model;

namespace PagoElectronico.ABM_Cuenta
{
    public partial class FormSubscripcion : Form
    {
        private Cuenta cuenta;

        private void initCBB()
        {
            this.cbTipoCuenta.DataSource = DataSession.TipoCuentas;
            this.cbTipoCuenta.ValueMember = "id";
            this.cbTipoCuenta.DisplayMember = "Completa";
            this.cbTipoCuenta.SelectedIndex = -1;
        }

        public FormSubscripcion(Cuenta cuenta)
        {
            InitializeComponent();
            this.initCBB();
            this.cuenta = cuenta;
            this.tbCantSubscripciones.Text = "1";
            this.cbTipoCuenta.SelectedValue = this.cuenta.TipoCuentaCod;
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btAceptar_Click(object sender, EventArgs e)
        {
            if ((this.cbTipoCuenta.SelectedIndex >= 0) && (this.tbCantSubscripciones.Text!=""))
            {
                this.cuenta.TipoCuentaCod = int.Parse(this.cbTipoCuenta.SelectedValue.ToString());
                this.cuenta.CantSubscripciones = int.Parse(this.tbCantSubscripciones.Text);
                this.Close();
            }
            else
            {
                MessageBox.Show("Seleccione un tipo de cuenta y escribir la cantidad de subscripciones.");
            }
        }

        private void FormSubscripcion_Load(object sender, EventArgs e)
        {

        }

        private void tbCantSubscripciones_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
