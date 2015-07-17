using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PagoElectronico.Model;

namespace PagoElectronico
{
    public partial class FormFechaSistema : Form
    {
        public FormFechaSistema()
        {
            InitializeComponent();
            this.dtpFechaSistema.Value = DataSession.FechaSistema;
        }

        private void btUpdateFecha_Click(object sender, EventArgs e)
        {
            DataSession.FechaSistema = this.dtpFechaSistema.Value;
            Cuenta cuenta = new Cuenta();
            cuenta.FechaSistema = DataSession.FechaSistema;
            cuenta.actualizarEstados();
            this.Close();
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
