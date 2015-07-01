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
    public partial class FormCuenta : Form
    {
        private Cuenta cuenta;

        private void initCBB()
        {
            this.cbPais.DataSource = DataSession.Paices;
            this.cbPais.ValueMember = "id";
            this.cbPais.DisplayMember = "nombre";
            this.cbPais.SelectedIndex = -1;
        }

        public FormCuenta(Cuenta cuenta)
        {
            InitializeComponent();
            this.cuenta = cuenta;
            this.initCBB();
        }

        private void btAddCuenta_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
