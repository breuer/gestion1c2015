using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaHotel.ClasesTabla;

namespace FrbaHotel.Listado_Estadistico
{
    public partial class ListadoEstadistico : Form
    {
        public ListadoEstadistico()
        {
            InitializeComponent();
        }
        SEstadistica sEstadistica = new SEstadistica();

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (validar()) {
                switch (cboTop5.Text) {
                    case "Hoteles con mayor cant. reservas canceladas":
                        gridEstadistica.DataSource = sEstadistica.EstadisticaTopHotelReservaCancelada(cboTrimestre.Text,int.Parse(txtAño.Text));
                        break;
                   case "Hoteles con mayor cant. consumibles facturados":
                        gridEstadistica.DataSource = sEstadistica.EstadisticaTopHotelConsumibleFacturado(cboTrimestre.Text,int.Parse(txtAño.Text));
                        break;
                    case "Hoteles con mayor cant. días fuera de servicio":
                        gridEstadistica.DataSource = sEstadistica.EstadisticaTopHotelDiasOut(cboTrimestre.Text,int.Parse(txtAño.Text));
                        break;
                    case "Habitaciones con mayor cant. de días y veces ocupadas":
                        gridEstadistica.DataSource = sEstadistica.EstadisticaTopHabitacionVecesOcupadas(cboTrimestre.Text,int.Parse(txtAño.Text));
                        break;
                    case "Cliente con mayor cant. de puntos":
                        gridEstadistica.DataSource = sEstadistica.EstadisticaTopClientes(cboTrimestre.Text,int.Parse(txtAño.Text));
                        break;
                }
             }
        }

        public bool validar()
        {
            if (txtAño.Text != "" && cboTrimestre.Text != "" && cboTop5.Text != "")
                return true;
            else
            {
                MessageBox.Show("Todos los datos son obligatorios para filtrar.");
                return false;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtAño.Text = "";
            cboTop5.SelectedIndex = 1;
            cboTrimestre.SelectedIndex = 1;
            gridEstadistica.DataSource = null;
        }
    }
}
