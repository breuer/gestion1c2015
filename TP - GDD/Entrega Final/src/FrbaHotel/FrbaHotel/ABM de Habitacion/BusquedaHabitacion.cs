using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaHotel.ClasesTabla;

namespace FrbaHotel.ABM_de_Habitacion
{
    public partial class BusquedaHabitacion : Form
    {
        static public BusquedaHabitacion ventana;
        static public decimal codSelected = 0;
        SHabitacion sHabitacion = new SHabitacion();

        public BusquedaHabitacion()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            if (numHab.Value != -1 || upDnPiso.Value != 0 || cboTipo.Text != "Todas")
            {
                StringBuilder Valores = new StringBuilder();
                if (upDnPiso.Value != 0)
                    Valores.Append(" h.piso = " + upDnPiso.Value + " ");
                if (upDnPiso.Value != 0 && (numHab.Value != -1 || cboTipo.Text != "Todas")) Valores.Append(" and ");
                
                if(numHab.Value != -1)
                    Valores.Append(" h.numero = " + numHab.Value + " ");

                if (numHab.Value != -1 && cboTipo.Text != "Todas") Valores.Append(" and ");

                if (cboTipo.Text != "Todas")
                    Valores.Append("t.codigo = " + ((TipoHab)cboTipo.SelectedItem).codigo + " ");

                gridHabitaciones.DataSource = sHabitacion.GetBySQLGrid("select h.codigo, h.numero,h.piso,h.ubicacion_frente,t.descripcion TipoHab,h.descripcion,h.estado from hotel.Habitacion h, hotel.Tipo_Habitacion t where t.codigo = h.cod_tipo_habitacion and h.cod_hotel = " + Login.Log.hotel + " and " + Valores);

                if (numHab.Value != -1) {
                    int cantHabitaciones = gridHabitaciones.RowCount;
                    if (cantHabitaciones > 1)
                        MessageBox.Show("No pueden existir más de una habitación con el mismo número, corrija la información por favor.");
                }
            }
            else cargate();
        }

        public void cargate()
        {
            List<Habitacion> habitaciones = sHabitacion.GetHabitacionesHotel(Login.Log.hotel);
            gridHabitaciones.DataSource = habitaciones;
        }

        private void BusquedaHabitacion_Load(object sender, EventArgs e)
        {
            ventana = this;
            SHotel sHotel = new SHotel();
            Hotel hotel = sHotel.GetByCod(Login.Log.hotel);

            STipoHab sTipoHab = new STipoHab();
            List<TipoHab> TiposHab = sTipoHab.GetAll();
            TipoHab tipo = new TipoHab();
            tipo.descripcion = "Todas";
            tipo.codigo = 0;
            TiposHab.Add(tipo);
            cboTipo.DataSource = TiposHab;
            cboTipo.DisplayMember = "descripcion";
            cboTipo.ValueMember = "codigo";
            cboTipo.SelectedIndex = cboTipo.Items.Count - 1;

            cargate();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                if (e.ColumnIndex == 0)
                {
                    //Seleccionar
                    ABM_de_Habitacion.FormAltaHabitacion select = new FormAltaHabitacion();
                    codSelected = decimal.Parse(gridHabitaciones.Rows[e.RowIndex].Cells[2].Value.ToString());
                    select.Show();
                }

                if (e.ColumnIndex == 1)
                {
                    // Eliminar
                    codSelected = decimal.Parse(gridHabitaciones.Rows[e.RowIndex].Cells[2].Value.ToString());
                    try
                    {
                        sHabitacion.Delete(codSelected);
                        MessageBox.Show("Operación exitosa!");
                        cargate();
                    }
                    catch (Exception) { }
                    codSelected = 0;
                }
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            codSelected = 0;
            ABM_de_Habitacion.FormAltaHabitacion select = new FormAltaHabitacion();
            select.Show();
        }

        private void BusquedaHabitacion_FormClosing(object sender, FormClosingEventArgs e)
        {
            ventana = null;
            codSelected = 0;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        public void limpiar()
        {
            numHab.Value = 0;
            upDnPiso.Value = 0;
            cboTipo.SelectedIndex = cboTipo.Items.Count - 1;
            cargate();
        }

    }
}
