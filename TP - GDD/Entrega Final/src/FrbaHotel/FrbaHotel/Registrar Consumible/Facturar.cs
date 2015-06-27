using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaHotel.ClasesTabla;

namespace FrbaHotel.Registrar_Consumible
{
    public partial class Facturar : Form
    {
        private SFactura sFactura = new SFactura();
        private SReserva sReserva = new SReserva();

        private decimal total = 0;

        public Facturar()
        {
            InitializeComponent();
        }

        private void Facturar_Load(object sender, EventArgs e)
        {
            numFacttxt.Text = sFactura.getNextNumber().ToString();
            fechatxt.Text = FormIni.FechaSistema.ToString("dd/MM/yyyy");

            List<MetodoPago> metodosPago = sFactura.GetMetodosPago();
            cboMetPago.DisplayMember = "descripcion";
            cboMetPago.ValueMember = "codigo";
            cboMetPago.DataSource = metodosPago;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            List<ItemFactura> gridItemsList = gridItems.DataSource as List<ItemFactura>;
            List<Consumible> gridConsumosList = gridConsumos.DataSource as List<Consumible>;

            int metodoPago = ((MetodoPago)cboMetPago.SelectedItem).codigo;
            sFactura.GrabarFactura(numFacttxt.Text, fechatxt.Text, numReservatxt.Text, metodoPago, txtMontoTotal.Text, gridItemsList, gridConsumosList);

            MessageBox.Show("Factura registrada correctamente");
            btnGuardar.Enabled = false;
        }

        private void cargarReservabtn_Click(object sender, EventArgs e)
        {
            bool valido = validarCampos();

            if (valido)
            {

                List<ItemFactura> itemsFactura = sFactura.getItemsFactura(numReservatxt.Text);

                gridItems.DataSource = itemsFactura;

                total += calcularTotal(itemsFactura);

                SConsumible sConsumible = new SConsumible();

                List<Consumible> consumibles = sConsumible.GetConsumiblesPorReserva(numReservatxt.Text);

                gridConsumos.DataSource = consumibles;

                total += calcularTotal(consumibles);

                txtMontoTotal.Text = total.ToString();
                btnGuardar.Enabled = true;
            }
        }

        private bool validarCampos()
        {
            if (numReservatxt.Text == "" || cboMetPago.Text == "")
            {
                MessageBox.Show("Complete los datos requeridos con *");
                return false;
            }

            if (sReserva.GetReserva(numReservatxt.Text) == null)
            {
                MessageBox.Show("El codigo de reserva ingresado no existe");
                return false;
            }

            return true;
        }

        private decimal calcularTotal(List<ItemFactura> itemsFactura)
        {
            decimal subTotal = 0;
            foreach (ItemFactura i in itemsFactura)
            {
                subTotal += (i.monto * i.cantidad);
            }

            return subTotal;
        }

        private decimal calcularTotal(List<Consumible> consumibles)
        {
            decimal subTotal = 0;
            foreach (Consumible c in consumibles)
            {
                subTotal += (c.precio * c.cantidad);
            }

            return subTotal;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            numReservatxt.Text = "";
            cboMetPago.Text = "";
            cargarReservabtn.Enabled = true;
            tarjetabtn.Enabled = false;

            gridConsumos.DataSource = null;
            gridItems.DataSource = null;
        }

        private void cboMetPago_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (((MetodoPago)cboMetPago.SelectedItem).codigo == 2)
            {
                tarjetabtn.Enabled = true;
                cargarReservabtn.Enabled = false;
                btnGuardar.Enabled = false;
            }
            else
            {
                tarjetabtn.Enabled = false;
                cargarReservabtn.Enabled = true;
                btnGuardar.Enabled = true;
            }
        }

        private void tarjetabtn_Click(object sender, EventArgs e)
        {
            Registrar_Consumible.Tarjeta tarjetaScreen = new FrbaHotel.Registrar_Consumible.Tarjeta();
            tarjetaScreen.codigoReserva = numReservatxt.Text;
            tarjetaScreen.Show();
            cargarReservabtn.Enabled = true;
        }
    }
}
