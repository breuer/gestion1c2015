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
    public partial class FormAltaHabitacion : Form
    {
        public FormAltaHabitacion()
        {
            InitializeComponent();
        }

        SHabitacion sHabitacion = new SHabitacion();
        HabitacionTable habitacion = new HabitacionTable();
        public static decimal valorL = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            valorL = ABM_de_Habitacion.BusquedaHabitacion.codSelected;

            STipoHab sTipoHab = new STipoHab();
            List<TipoHab> tiposHab = sTipoHab.GetAll();
            cboTipo.DataSource = tiposHab;
            cboTipo.DisplayMember = "descripcion";
            cboTipo.ValueMember = "codigo";

            if (valorL > 0)
            {
                LoadHabitacion(valorL);
            }

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            BuildHabitacion();
            try
            {
                if (validar())
                {
                    if (valorL > 0)
                    {
                        sHabitacion.Update(habitacion);
                    }
                    else
                    {
                        sHabitacion.Save(habitacion);
                    }
                    MessageBox.Show("Operación exitosa!");
                }
            }

            catch (Exception)
            {
                MessageBox.Show("Error en la operación!");
                if (valorL == 0) limpiar();
            }
            finally
            {
                if (valorL > 0)
                    this.Close();
                else
                    limpiar();
            }
        }

        private void limpiar()
        {
            upDnPiso.Value = 0;
            cboUbicacion.Text = "";
            cboTipo.SelectedIndex = 1;
            ckActiva.Checked = false;
            valorL = 0;
            habitacion = new HabitacionTable();
        }

        private void LoadHabitacion(decimal codHab)
        {
            //Exterior - Interior
            HabitacionTable hab = sHabitacion.GetBySQL("select * from hotel.Habitacion r where r.codigo = " + codHab).SingleOrDefault();
            cboTipo.SelectedValue = hab.cod_tipo_habitacion;
            if (hab.ubicacion_frente == "N")
                cboUbicacion.Text = "Interior";
            else
                cboUbicacion.Text = "Exterior";
            ckActiva.Checked = hab.estado;
            numUpNumHab.Value = hab.numero;
            upDnPiso.Value = hab.piso;
            rcTxtComodidades.Text = hab.descripcion;
            if (ckActiva.Checked == true) ckActiva.Enabled = false;
            cboTipo.Enabled = false;
        }

        private void BuildHabitacion()
        {
            if (valorL > 0)
                habitacion.codigo = valorL;
            habitacion.descripcion = rcTxtComodidades.Text;
            habitacion.estado = ckActiva.Checked;
            habitacion.cod_hotel = Login.Log.hotel;
            habitacion.cod_tipo_habitacion = ((TipoHab)cboTipo.SelectedItem).codigo;
            if (cboUbicacion.Text == "Interior")
                habitacion.ubicacion_frente = "N";
            else
                habitacion.ubicacion_frente = "S";
            habitacion.numero = numUpNumHab.Value;
            habitacion.piso = upDnPiso.Value;
        }

        private bool validar()
        {
            if (cboTipo.Text != "" && cboUbicacion.Text != "") {

                if (valorL == 0)
                {
                    var numHab = numUpNumHab.Value;
                    List<HabitacionTable> habitacionesNum = sHabitacion.GetBySQL("select * from hotel.Habitacion h where h.cod_hotel = " + Login.Log.hotel + " and h.numero = " + numHab).ToList();
                    if (habitacionesNum.Count != 0)
                    {
                        MessageBox.Show("Ya existe una habitación con ese número dentro del hotel.");
                        return false;
                    }
                    else
                        return true;
                }
                else {

                    HabitacionTable hab = sHabitacion.GetBySQL("select * from hotel.Habitacion h where h.codigo = " + valorL).SingleOrDefault();
                    if (numUpNumHab.Value != hab.numero)
                    {
                        var numHab = numUpNumHab.Value;
                        List<HabitacionTable> habitacionesNum = sHabitacion.GetBySQL("select * from hotel.Habitacion h where h.cod_hotel = " + Login.Log.hotel + " and h.numero = " + numHab).ToList();
                        if (habitacionesNum.Count != 0)
                        {
                            MessageBox.Show("Ya existe una habitación con ese número dentro del hotel.");
                            return false;
                        }
                        else
                            return true;
                    }
                    else
                        return true;
                }
            
            }
            else
                return false;
        }

        private void FormAltaHabitacion_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (ABM_de_Habitacion.BusquedaHabitacion.ventana != null)
                ABM_de_Habitacion.BusquedaHabitacion.ventana.cargate();
            ABM_de_Habitacion.BusquedaHabitacion.codSelected = 0;
            valorL = 0;
        }
    }
}
