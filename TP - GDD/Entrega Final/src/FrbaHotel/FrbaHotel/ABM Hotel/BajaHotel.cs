using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaHotel.ClasesTabla;

namespace FrbaHotel.ABM_Hotel
{
    public partial class BajaHotel : Form
    {
        public BajaHotel()
        {
            InitializeComponent();
        }

        private void BajaHotel_Load(object sender, EventArgs e)
        {
          calendFechaDesde.TodayDate = FormIni.FechaSistema;
          calendHasta.TodayDate = FormIni.FechaSistema;
            codHotel = ABM_Hotel.BusquedaHotel.hotelSelected;
        }

        static public decimal codHotel = 0;

        SHotel sHotel = new SHotel();

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                CancelacionHotel bajaH = new CancelacionHotel();

                bajaH.cod_hotel = codHotel;
                bajaH.fecha_desde = DateTime.Parse(txtFechaDesde.Text.Replace('-', ' ').Replace(" ", "").Trim().ToString());
                bajaH.fecha_hasta = DateTime.Parse(txtFechaHasta.Text.Replace('-', ' ').Replace(" ", "").Trim().ToString());
                bajaH.motivo = txtMotivo.Text;

                try
                {
                    sHotel.SaveCancelacion(bajaH);
                    MessageBox.Show("Operación exitosa!");
                }
                catch (Exception)
                {
                    MessageBox.Show("Error en la operación!");
                }
                this.Close();
                ABM_Hotel.BusquedaHotel.hotelSelected = 0;
            }
            else
                limpiar();
        }

        private bool validar()
        {
            bool valido = false;
            
            if (codHotel != 0 && txtFechaDesde.Text.Replace('-', ' ').Replace(" ", "").Trim() != "" && txtFechaHasta.Text.Replace('-', ' ').Replace(" ", "").Trim() != "" && txtMotivo.Text.Trim() != "")
            {
                var fechaDesd= DateTime.Parse(txtFechaDesde.Text.Replace('-', ' ').Replace(" ", "").Trim());
                var fechaHasta = DateTime.Parse(txtFechaHasta.Text.Replace('-', ' ').Replace(" ", "").Trim());
                if (fechaDesd < fechaHasta)
                {
                    //no haya gente hospedada para esa fecha
                    bool HayGente = sHotel.hotelOcupado(codHotel, DateTime.Parse(txtFechaDesde.Text.Replace('-', ' ').Replace(" ", "").Trim()), DateTime.Parse(txtFechaHasta.Text.Replace('-', ' ').Replace(" ", "").Trim()));
                    if (HayGente)
                    {
                        MessageBox.Show("No puede dar de baja el hotel en esa fecha, se encuentra reservado!");
                    }
                    else
                        valido = true;
                }
                else
                {
                    MessageBox.Show("La fecha de inicio de baja debe ser anterior a la fecha final!");
                    valido = false;
                }
            }

            return valido;
        }

        private void limpiar()
        {
            txtFechaDesde.Text = "";
            txtFechaHasta.Text = "";
            txtMotivo.Text = "";
            calendHasta.Visible = false;
            calendFechaDesde.Visible = false;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void btnFechaHasta_Click(object sender, EventArgs e)
        {
            calendHasta.Visible = true;
        }

        private void btnCalendarioDesde_Click(object sender, EventArgs e)
        {
            calendFechaDesde.Visible = true;
        }

        private void calendFechaDesde_DateSelected(object sender, DateRangeEventArgs e)
        {
            txtFechaDesde.Text = e.Start.ToShortDateString();
        }

        private void calendHasta_DateSelected(object sender, DateRangeEventArgs e)
        {
            txtFechaHasta.Text = e.Start.ToShortDateString();
        }

        private void BajaHotel_FormClosing(object sender, FormClosingEventArgs e)
        {
            ABM_Hotel.BusquedaHotel.ventanaHotel.cargate();
            codHotel = 0;
            ABM_Hotel.BusquedaHotel.hotelSelected = 0;
        }
    }
}
