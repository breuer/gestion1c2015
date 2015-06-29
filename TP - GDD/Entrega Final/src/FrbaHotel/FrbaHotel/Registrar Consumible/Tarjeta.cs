using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaHotel.ClasesTabla;
using System.Globalization;

namespace FrbaHotel.Registrar_Consumible
{
    public partial class Tarjeta : Form
    {
        public string codigoReserva { get; set; }

        public Tarjeta()
        {
            InitializeComponent();
        }

        private void btnCalendarioHasta_Click(object sender, EventArgs e)
        {
            calendarioHasta.Visible = true;
        }

        private void btnCalendarioDesde_Click(object sender, EventArgs e)
        {
            calendarioDesde.Visible = true;
        }

        private void calendarioDesde_DateSelected(object sender, DateRangeEventArgs e)
        {
            calendarioDesde.Visible = false;
            txtEmision.Text = e.Start.ToShortDateString();
        }

        private void calendarioHasta_DateSelected(object sender, DateRangeEventArgs e)
        {
            calendarioHasta.Visible = false;
            txtFechaVence.Text = e.Start.ToShortDateString();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (DateTime.Compare(FormIni.FechaSistema, DateTime.ParseExact(txtEmision.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture)) == -1)
            {
                MessageBox.Show("La fecha de emision no puede ser posterior a hoy");
            }
            else if (DateTime.Compare(DateTime.ParseExact(txtFechaVence.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture), FormIni.FechaSistema) == -1)
            {
                MessageBox.Show("Tarjeta Expirada");
            }
            else
            {

                SFactura sFactura = new SFactura();

                sFactura.registrarTarjeta(codigoReserva, txtNumTarjeta.Text, txtEmision.Text, txtFechaVence.Text);

                MessageBox.Show("Tarjeta Registrada exitosamente");

                Close();
            }
        }

        private void Tarjeta_Load(object sender, EventArgs e)
        {
            calendarioDesde.TodayDate = FormIni.FechaSistema;
            calendarioHasta.TodayDate = FormIni.FechaSistema;
        }
    }
}