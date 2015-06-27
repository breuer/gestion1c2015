using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaHotel.ClasesTabla;
using FrbaHotel.Generar_Modificar_Reserva;

namespace FrbaHotel.Registrar_Estadia
{
    public partial class Estadia : Form
    {
        SReserva sReserva = new SReserva();
        SPersona sPersona = new SPersona();
        SEstadia sEstadia = new ClasesTabla.SEstadia();
        Reserva reserva = null;
        ClasesTabla.Estadia estadia = null;
        DateTime fechaHoy = FormIni.FechaSistema;
        List<Persona> personasReserva = new List<Persona>();
        //lo devuelve desde la busqueda del cliente
        public static string user_selected = null;
        private decimal indexList = 0;
        private decimal personasAcargar = 0;
        private string reserva_elegida;

        public Estadia()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtNumReserva.Text != "")
            {

                reserva_elegida = txtNumReserva.Text;
                reserva = sReserva.getReserva(txtNumReserva.Text);
                if (reserva != null)
                {
                    cargarGrilla();
                }
                else
                {
                    MessageBox.Show("Ingrese un nùmero de reserva válido");
                }
            }
            else
            {
                MessageBox.Show("Ingrese un nùmero de reserva");
            }
        }

        private void cargarGrilla()
        {
            if (reserva.cod_estado == 6)
            {
                //Cargar la grilla de las personas
                cargarDatosEstadia();
                btnChOut.Enabled = true;
            }
            else
            {
                int result = DateTime.Compare(fechaHoy.Date, reserva.fecha_desde.Date);
                if (reserva.cod_estado == 1 || reserva.cod_estado == 2)
                {
                    if (result < 0)
                        MessageBox.Show("Solo puede registrarse la estadía el mismo día de inicio de la reserva: " + fechaHoy.ToShortDateString());
                    else if (result == 0)
                    {
                        //Cargar la grilla de las personas
                        cargarGrillaPersonas();
                    }
                    else
                    {
                        MessageBox.Show("La fecha de la reserva ha caducado. Si desea hospedarse debe generar una reserva nueva");
                        caducarReserva();
                    }
                }
            }


        }

        //Cancela la reserva.
        private void caducarReserva()
        {
            sReserva.auditarReserva(reserva, fechaHoy.ToShortDateString(), "chek-in caducado");
            sReserva.cancelarReserva(reserva);
        }

        //Carga las personas en la grilla
        private void cargarGrillaPersonas()
        {
            Persona persona = sPersona.getByCodigo(reserva.cod_persona.ToString());
            personasReserva.Add(persona);

            GridPersonas.DataSource = personasReserva;
            verificarPersonas();
            actualizarLabel();
            if (0 < personasAcargar)
                btnPersonas.Enabled = true;
        }

        private void cargarDatosEstadia()
        {
            List<ClasesTabla.Estadia> estadiaInfo = new List<ClasesTabla.Estadia>();
            estadia = sEstadia.getEstadia(txtNumReserva.Text);
            estadiaInfo.Add(estadia);
            GridPersonas.DataSource = estadiaInfo;
        }

        //Limpia los datos
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            resetear();
        }

        private void resetear()
        {
            btnChIn.Enabled = false;
            btnChOut.Enabled = false;
            personasReserva = null;
            GridPersonas.DataSource = personasReserva;
            txtNumReserva.Text = "";
            btnPersonas.Enabled = false;
            personasAcargar = 0;
        }

        //Verifica que en la grilla estén cargadas todas las personas
        private void verificarPersonas()
        {
            if (personasReserva.Count() < reserva.cant_huespedes)
                btnChIn.Enabled = false;
            else
                btnChIn.Enabled = true;
        }

        //Genera el check-in
        private void btnChIn_Click(object sender, EventArgs e)
        {
            decimal est = sEstadia.guardarEstadia(armarEstadia());
            if (est > 0)
            {
                resetear();
                sReserva.ingresarReserva(reserva_elegida);
                sReserva.auditarReserva(sReserva.getReserva(reserva_elegida), fechaHoy.ToShortDateString(), "reserva ingresada");
                MessageBox.Show("operación exitosa");
            }
        }

        //Arma la estadía
        private ClasesTabla.Estadia armarEstadia()
        {
            ClasesTabla.Estadia estadia = new ClasesTabla.Estadia();
            estadia.cod_reserva = Convert.ToDecimal(txtNumReserva.Text);
            estadia.fecha_hora_in = fechaHoy;
            estadia.fecha_hora_out = null;
            estadia.cant_noches_estadia = reserva.cant_noches;
            return estadia;
        }

        //Realiza el checkout
        private void btnChOut_Click(object sender, EventArgs e)
        {
            ClasesTabla.Estadia estadia = sEstadia.getEstadia(txtNumReserva.Text);
            decimal est = sEstadia.generarCheckOut(estadia.codigo.ToString(), fechaHoy.ToShortDateString());
            if (est > 0)
            {
                MessageBox.Show("operación exitosa");
                resetear();
            }
        }

        private void GridPersonas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                if (e.ColumnIndex == 0)
                {
                    //Selecciona el id de la habitacion
                    string personaSel = GridPersonas.Rows[e.RowIndex].Cells[1].Value.ToString();
                    indexList = GridPersonas.CurrentCell.RowIndex;
                    //Selecciona el Tipo de habitacion y Obtengo la cantidad de persona por la habitacion
                }
            }

        }

        private void btnPersonas_Click(object sender, EventArgs e)
        {
            if (user_selected != null)
            {
                personasReserva.Add(sPersona.getByCodigo(user_selected));
                user_selected = null;
                GridPersonas.DataSource = null;
                GridPersonas.DataSource = personasReserva;
                actualizarLabel();
                verificarPersonas();
            }
            if (personasAcargar > 0)
            {
                BusquedaReserva busquedaReserva = new BusquedaReserva();
                BusquedaReserva.cheInOut = true;
                busquedaReserva.Show();
            }
        }

        private void actualizarLabel()
        {
            personasAcargar = ((decimal)reserva.cant_huespedes - personasReserva.Count());
            lblCantidad.Text = personasAcargar.ToString();
        }

    }
}
