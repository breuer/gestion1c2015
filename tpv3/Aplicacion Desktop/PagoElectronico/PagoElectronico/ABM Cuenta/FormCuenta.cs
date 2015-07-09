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
        private int operacion;

        private void initCBB()
        {
            this.cbPais.DataSource = DataSession.Paices;
            this.cbPais.ValueMember = "id";
            this.cbPais.DisplayMember = "nombre";
            this.cbPais.SelectedIndex = -1;

            this.cbMoneda.DataSource = DataSession.Monedas;
            this.cbMoneda.ValueMember = "id";
            this.cbMoneda.DisplayMember = "nombre";
            this.cbMoneda.SelectedIndex = -1;

            this.cbTipoCuenta.DataSource = DataSession.TipoCuentas;
            this.cbTipoCuenta.ValueMember = "id";
            this.cbTipoCuenta.DisplayMember = "nombre";
            this.cbTipoCuenta.SelectedIndex = -1;

            this.cbEstado.DataSource = DataSession.EstadosCuenta;
            this.cbEstado.ValueMember = "id";
            this.cbEstado.DisplayMember = "nombre";
          
        }

        public FormCuenta(Cuenta cuenta, int operacion)
        {
            InitializeComponent();
            this.cuenta = cuenta;
            this.initCBB();
            this.pnDarBaja.Visible = false;
            this.pnlEstado.Visible = false;
            switch (operacion)
            {
                case DataSession.ALTA:
                    this.lOperacion.Text = "ALTA CUENTA";
                    this.operacion = DataSession.ALTA;
                    this.btAceptar.Text = "Alta";
                    this.dtpFechaApertura.Value = DataSession.FechaSistema;
                    this.dtpFechaApertura.Enabled = false;
                    this.tbNroCuenta.Text = this.cuenta.getNuevoNumeroCuenta().ToString();
                    this.tbNroCuenta.ReadOnly = true;
                    break;
                case DataSession.MODIFICACION:
                    this.lOperacion.Text = "MODIFICACION CUENTA";
                    this.operacion = DataSession.MODIFICACION;
                    this.cargar();
                    this.pnDarBaja.Visible = true;
                    this.pnlEstado.Visible = true;
                    this.btAceptar.Text = "Modificar";
                    break;
            }
        }

        private void cargar()
        {
            this.tbNroCuenta.Text = this.cuenta.Numero.ToString();
            this.tbNroCuenta.ReadOnly = true;
            this.cbPais.SelectedValue = this.cuenta.PaisCod;
            this.cbPais.Enabled = false;
            this.cbMoneda.SelectedValue = this.cuenta.MonedaCod;
            this.cbEstado.SelectedValue = this.cuenta.EstadoCuentaCod;
            this.cbEstado.Enabled = false;
            //this.dtpFechaApertura.Value = this.cuenta.FechaApertura;
            this.dtpFechaApertura.Enabled = false;
            this.cbTipoCuenta.SelectedValue = this.cuenta.TipoCuentaCod;
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btAceptar_Click(object sender, EventArgs e)
        {

            switch (operacion)
            {
                case DataSession.ALTA:
                    this.cuenta.Numero = long.Parse(this.tbNroCuenta.Text);
                    this.cuenta.PaisCod = int.Parse(this.cbPais.SelectedValue.ToString());
                    this.cuenta.FechaApertura = this.dtpFechaApertura.Value;
                    this.cuenta.MonedaCod = int.Parse(this.cbMoneda.SelectedValue.ToString());
                    this.cuenta.TipoCuentaCod = int.Parse(this.cbTipoCuenta.SelectedValue.ToString());
                    cuenta.add();
                    
                    break;
                case DataSession.MODIFICACION:
                    if (this.cuenta.TipoCuentaCod != int.Parse(this.cbTipoCuenta.SelectedValue.ToString()))
                    {
                        this.cuenta.TipoCuentaCod = int.Parse(this.cbTipoCuenta.SelectedValue.ToString());
                        cuenta.update();
                    }
                    break;
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
