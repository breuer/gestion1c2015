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
        private bool cerrarCuenta = false;

        private void initCBB()
        {
            this.cbPais.DataSource = DataSession.Paises;
            this.cbPais.ValueMember = "id";
            this.cbPais.DisplayMember = "nombre";
            this.cbPais.SelectedIndex = -1;

            this.cbMoneda.DataSource = DataSession.Monedas;
            this.cbMoneda.ValueMember = "id";
            this.cbMoneda.DisplayMember = "nombre";
            this.cbMoneda.SelectedIndex = -1;

            this.cbEstado.DataSource = DataSession.EstadosCuenta;
            this.cbEstado.ValueMember = "id";
            this.cbEstado.DisplayMember = "nombre";
          
        }

        public FormCuenta(Cuenta cuenta, int operacion)
        {
            InitializeComponent();
            this.cuenta = cuenta;
            this.initCBB();
            this.pnlEstado.Enabled = false;
            this.btCerrarCuenta.Enabled = false;
            this.btHabilitarCuenta.Enabled = false;
            this.pnDatosEstatico.Enabled = false;
            this.cbMoneda.Enabled = false;

            switch (operacion)
            {
                case DataSession.ALTA:
                    this.lOperacion.Text = "ALTA CUENTA";
                    this.operacion = DataSession.ALTA;
                    this.btAceptar.Text = "Alta";
                    this.pnDatosEstatico.Enabled = true;
                    this.tbFechaApertura.Text = DataSession.FechaSistema.ToString();
                    this.tbFechaApertura.ReadOnly = true;
                    this.tbFechaVencimiento.ReadOnly = true;
                    this.tbNroCuenta.Text = this.cuenta.getNuevoNumeroCuenta().ToString();
                    this.tbNroCuenta.ReadOnly = true;
                    this.btTipoCuenta.Text = "Elegir tipo de Cuenta";
                    this.cuenta.TipoCuentaCod = -1;
                    this.tbTipoCuenta.Text = "";
                    break;
                case DataSession.MODIFICACION:
                    this.lOperacion.Text = "MODIFICACION CUENTA";
                    this.operacion = DataSession.MODIFICACION;
                    this.cargar();               
                    this.pnlEstado.Enabled = true;
                    this.btAceptar.Text = "Modificar";
                    this.btTipoCuenta.Text = "Cambio de Tipo de Cuenta";
                    switch (cuenta.EstadoCuentaCod)
                    {
                        case DataSession.ESTADO_CUENTA_HABILITADA:
                            this.pnDatosEstatico.Enabled = true;
                            this.btCerrarCuenta.Enabled = true;
                            this.cbPais.Enabled = true;
                            break;
                        case DataSession.ESTADO_CUENTA_INHABILITADA:
                            break;
                        case DataSession.ESTADO_CUENTA_CERRADA:
                                this.btAceptar.Enabled = false;
                            break;
                        case DataSession.ESTADO_CUENTA_PEDIENTE_ACTIVACION:
                            break;
                        case DataSession.ESTADO_CUENTA_VENCIDA:
                            this.btHabilitarCuenta.Enabled = true;
                            break;
                    }
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
            this.tbFechaApertura.Text = this.cuenta.FechaApertura.ToString();
            this.tbFechaApertura.ReadOnly = true;
            this.tbFechaVencimiento.Text = this.cuenta.FechaVencimiento.ToString();
            this.tbFechaVencimiento.ReadOnly = true;
            this.txt_cta_suscrip.Text = this.cuenta.CantSubscripciones.ToString();
            this.txt_cta_saldo.Text = this.cuenta.Saldo.ToString();
            foreach (TipoCuenta t in DataSession.TipoCuentas)
            {
                if (t.Id == this.cuenta.TipoCuentaCod)
                    this.tbTipoCuenta.Text = t.Nombre;
            }
           
            //this.cbTipoCuenta.SelectedValue = this.cuenta.TipoCuentaCod;
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btAceptar_Click(object sender, EventArgs e)
        {
            if ((this.cbPais.SelectedIndex >= 0) && (this.cbMoneda.SelectedIndex >= 0))
            {
                switch (operacion)
                {
                    case DataSession.ALTA:
                        this.cuenta.Numero = long.Parse(this.tbNroCuenta.Text);
                        this.cuenta.PaisCod = int.Parse(this.cbPais.SelectedValue.ToString());
                        this.cuenta.FechaApertura = DataSession.FechaSistema;
                        this.cuenta.MonedaCod = int.Parse(this.cbMoneda.SelectedValue.ToString());

                        if (this.cuenta.TipoCuentaCod == -1)
                            MessageBox.Show("Tiene que ingresar un tipo de cuenta");
                        else
                            this.cuenta.add();

                        break;
                    case DataSession.MODIFICACION:
                        if (this.cerrarCuenta)
                            this.cuenta.cerrar();
                        else
                            this.cuenta.update();
                        break;
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un pais y moneda");
            }
        }

        private void btTipoCuenta_Click(object sender, EventArgs e)
        {
            int tipoCuentaCodAnterior = this.cuenta.TipoCuentaCod;
            FormSubscripcion frm = new FormSubscripcion(this.cuenta);
            frm.ShowDialog();

            if (tipoCuentaCodAnterior != this.cuenta.TipoCuentaCod)
            {
                foreach (TipoCuenta t in DataSession.TipoCuentas)
                {
                    if (t.Id == this.cuenta.TipoCuentaCod)
                    {
                        this.tbTipoCuenta.Text = t.Nombre;
                    }
                }
                //MessageBox.Show("dias: " + dias);
            }
        }

        private void btHabilitarCuenta_Click(object sender, EventArgs e)
        {
            FormSubscripcion frm = new FormSubscripcion(this.cuenta);
            frm.ShowDialog();
            foreach (TipoCuenta t in DataSession.TipoCuentas)
            {
                if (t.Id == this.cuenta.TipoCuentaCod)
                {
                    this.tbTipoCuenta.Text = t.Nombre;
                }
            }
        }

        private void FormCuenta_Load(object sender, EventArgs e)
        {

        }

        private void btCerrarCuenta_Click(object sender, EventArgs e)
        {
            this.cuenta.EstadoCuentaCod = DataSession.ESTADO_CUENTA_CERRADA;
            this.cbEstado.SelectedValue = DataSession.ESTADO_CUENTA_CERRADA;
            this.pnDatosEstatico.Enabled = false;
            this.cerrarCuenta = true;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
