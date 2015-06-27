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
    public partial class BusquedaHotel : Form
    {
        public BusquedaHotel()
        {
            InitializeComponent();
        }

        static public decimal codUser = 0;
        static public decimal hotelSelected = 0;
        SHotel sHotel = new SHotel();
        static public ABM_Hotel.BusquedaHotel ventanaHotel;

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtCiudad.Text.Trim() != "" || txtNombre.Text.Trim() != "" || txtPais.Text.Trim() != "" || numUpDnCantEstrellas.Value != 0)
            {

                StringBuilder Valores = new StringBuilder();
                if (txtCiudad.Text.Trim() != "")
                    Valores.Append(" u.ciudad like '%" + txtCiudad.Text + "%' ");

                if (txtCiudad.Text.Trim() != "" && (txtNombre.Text.Trim() != "" || txtPais.Text.Trim() != "" || numUpDnCantEstrellas.Value != 0)) Valores.Append(" and ");

                if (txtNombre.Text.Trim() != "")
                    Valores.Append(" u.nombre like '%" + txtNombre.Text + "%' ");

                if (txtNombre.Text.Trim() != "" && (txtPais.Text.Trim() != "" || numUpDnCantEstrellas.Value != 0))
                    Valores.Append(" and ");

                if (txtPais.Text.Trim() != "")
                    Valores.Append(" u.pais like '%" + txtPais.Text + "%' ");

                if (txtPais.Text.Trim() != "" && numUpDnCantEstrellas.Value > 0)
                    Valores.Append(" and ");

                if (numUpDnCantEstrellas.Value != 0) Valores.Append(" u.cant_estrellas = " + numUpDnCantEstrellas.Value);

                gridHoteles.DataSource = sHotel.GetBySQLGRID("select u.codigo, u.mail,u.telefono,u.cant_estrellas,u.nom_calle,u.num_calle,u.pais, u.ciudad,u.nombre,u.fecha_creacion  from hotel.Hotel u where u.codigo not in (select c.cod_hotel from hotel.cancelacion_hotel c where c.fecha_hasta < '" + FormIni.FechaSistema.ToShortDateString() + "' or c.fecha_desde > '" + FormIni.FechaSistema + "')  and " + Valores.ToString());

            }
            else cargate();
        }

        public void cargate()
        {
            gridHoteles.DataSource = sHotel.GetBySQLGRID("hotel.SP_GETHOTELESACTIVOSBusqueda '" + FormIni.FechaSistema.ToShortDateString() + "'");
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtCiudad.Text = "";
            txtNombre.Text = "";
            txtPais.Text = "";
            numUpDnCantEstrellas.Value = 0;
            cargate();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            ABM_Hotel.ABMHotel cargarHotel = new ABMHotel();
            cargarHotel.Show();
        }

        private void BusquedaHotel_Load(object sender, EventArgs e)
        {
            ventanaHotel = this;
            codUser = Login.Log.user;
            cargate();
        }

        private void BusquedaHotel_FormClosing(object sender, FormClosingEventArgs e)
        {
            ventanaHotel = null;
            hotelSelected = 0;
        }

        private void gridHoteles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                if (e.ColumnIndex == 0)
                {
                    //Seleccionar
                    ABMHotel seleccionar = new ABMHotel();
                    hotelSelected = decimal.Parse(gridHoteles.Rows[e.RowIndex].Cells[2].Value.ToString());
                    seleccionar.Show();
                }

                if (e.ColumnIndex == 1)
                {
                    // Eliminar
                    hotelSelected = decimal.Parse(gridHoteles.Rows[e.RowIndex].Cells[2].Value.ToString());
                    BajaHotel bajar = new BajaHotel();
                    bajar.Show();
                }
            }
        }

    }
}
