using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using FrbaHotel.ClasesTabla;
using System.Globalization;

namespace FrbaHotel.Generar_Modificar_Reserva
{
    public partial class AMReserva : Form
    {
        public static decimal codUSER = Login.Log.user;
        SReserva sReserva = new SReserva();
        STipoHab sTipoHab = new STipoHab();
        SHabitacion sHabitacion = new SHabitacion();
        SHotel sHotel = new SHotel();
        Reserva reservaVista = new Reserva();
        //Indica si se eligieron las fechas o no
        private Boolean fecD = false;
        private Boolean fecH = false;
        List<HabitacionDTO> habSeleccionadas = new List<HabitacionDTO>();
        List<HabitacionDTO> habDisponibles = new List<HabitacionDTO>();
        //Ayudan al calculo del precio de la reserva
        private Decimal cantidad = 0;
        private Decimal alojados;
        private Decimal recEstrella;
        private Decimal precioBase;
        private string habSelected;
        private string tipoHabSelected;
        private decimal totalValorReserva = 0;
        //lo devuelve desde la busqueda del cliente
        public static string user_selected = null;
        //me indica que debo auditar la modificacion
        private bool modificada = false;
        private string regimen = null;

        public AMReserva()
        {
            InitializeComponent();
        }

        //Valores iniciales
        private void AMReserva_Load(object sender, EventArgs e)
        {
            txtFechaCarga.Text = FormIni.FechaSistema.ToShortDateString();
            calendarioDesde.MinDate = FormIni.FechaSistema;
            calendarioDesde.TodayDate = FormIni.FechaSistema;
            calendarioHasta.TodayDate = FormIni.FechaSistema;
            if (Login.Log.hotel == 0)
            {
                List<Hotel> hoteles = sHotel.GetAllActivos();
                cboHotel.DisplayMember = "direccionCompleta";
                cboHotel.ValueMember = "codigo";
                cboHotel.DataSource = hoteles;
            }
            else
            {
                List<Hotel> hotelLoggeado = sHotel.GetBySQL("select * from hotel.Hotel h where h.codigo = " + Login.Log.hotel).ToList();
                cboHotel.DisplayMember = "direccionCompleta";
                cboHotel.ValueMember = "codigo";
                cboHotel.DataSource = hotelLoggeado;
            }

            nmUpDnCantHuesp.Value = 0;
            nmUpDnCantHuesp.Enabled = false;

            cboRegimen.Enabled = false;
            cboRegimen.DataSource = null;

            user_selected = null;
        }

        //Cuando va a elegir una fecha
        private void btnCalendarioDesde_Click(object sender, EventArgs e)
        {
            calendarioDesde.Visible = true;
            btnCalendarioHasta.Enabled = true;
            txtNumeroReserva.Enabled = false;
        }

        private void btnCalendarioHasta_Click(object sender, EventArgs e)
        {
            calendarioHasta.Visible = true;
        }

        private void calendarioHasta_DateSelected(object sender, DateRangeEventArgs e)
        {
            txtHasta.Text = e.Start.ToShortDateString();
            this.fecH = true;
            calendarioHasta.Visible = false;
        }

        private void calendarioDesde_DateChanged(object sender, DateRangeEventArgs e)
        {
            txtDesde.Text = e.Start.ToShortDateString();
            calendarioHasta.MinDate = Convert.ToDateTime(txtDesde.Text).AddDays(1);
            this.fecD = true;
            calendarioDesde.Visible = false;
        }

        //Elije un hotel
        private void cboHotel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (int.Parse(cboHotel.SelectedValue.ToString()) != 0)
            {
                //Eligio el hotel y se obtiene el valor de Recarga Estrella del mismo
                nmUpDnCantHuesp.Enabled = true;
                cboRegimen.Enabled = true;
                recEstrella = Convert.ToDecimal(sHabitacion.getRecargaEstrellaHotel(cboHotel.SelectedValue.ToString()));
            }

            //Carga Regimen del hotel elegido
            List<Regimen> regimenes = sTipoHab.GetRegimenesByHotelWithNull(cboHotel.SelectedValue.ToString());
            cboRegimen.DisplayMember = "descripcion";
            cboRegimen.ValueMember = "codigo";
            cboRegimen.DataSource = regimenes;

        }

        //Limpia los valores del formulario
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            resetearValores();
        }

        public void resetearValores()
        {
            cboRegimen.Enabled = false;
            btnModificarReserva.Visible = false;
            btnGuardar.Enabled = false;
            btnDatosClie.Enabled = false;
            btnAgregar.Enabled = false;
            btnEliminarHab.Enabled = false;
            gridHabSeleccionada.Enabled = false;
            gridHabSeleccionada.DataSource = null;
            habSeleccionadas = new List<HabitacionDTO>();
            habDisponibles = new List<HabitacionDTO>();
            btnCalendarioHasta.Enabled = false;
            cboRegimen.DataSource = null;
            GridRegimen.DataSource = null;
            txtDesde.Text = null;
            txtHasta.Text = null;
            txtNumeroReserva.Enabled = true;
            txtNumeroReserva.Text = null;
            txtValor.Text = null;
            txtValorReserva.Text = null;
            this.fecD = false;
            this.fecH = false;
            this.cantidad = 0;
            totalValorReserva = 0;
            nmUpDnCantHuesp.Enabled = false;
        }

        //Verifica la disponibilidad de habitaciones para los valores elegidos de la reserva
        private void btnVerif_Click(object sender, EventArgs e)
        {
            //Valida si las fechas son nulas e informa
            if (fecD && fecH)
            {
                if (Convert.ToDateTime(txtHasta.Text) > Convert.ToDateTime(txtDesde.Text))
                {
                    //Fechas validas
                    if (cboRegimen.SelectedItem == null)
                    {
                        //No eligio un Hotel
                        MessageBox.Show("Elija un Hotel");
                    }
                    else
                    {
                        //Eligio un hotel
                        //Se setea "alojados" para validar luego la cantidad de habitaciones y los alojados necesarios
                        alojados = nmUpDnCantHuesp.Value;
                        if (int.Parse(cboRegimen.SelectedValue.ToString()) == 0)
                        {
                            //No eligio un regimen de habitacion
                            //Muestro los disponibles por el hotel
                            GridRegimen.DataSource = sTipoHab.GetRegimenesByHotelHabilitados(cboHotel.SelectedValue.ToString());
                        }
                        else
                        {
                            //Eligio un regimen muestro las posibles reservas
                            //Cargo la grilla con las distintas habitaciones disponibles
                            habDisponibles = sHabitacion.GetDisponiblesPorHotelyFechas(cboHotel.SelectedValue.ToString(), txtDesde.Text, txtHasta.Text);
                            GridRegimen.DataSource = habDisponibles;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("La fecha Hasta debe ser Mayor a Desde");
                }
            }
            else
            {
                MessageBox.Show("Debe elegir las fechas");
            }
        }

        //Selecciones en la grilla de habitaciones
        private void GridRegimen_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Valida que haya elegido un numero de personas mayor que 0
            if (nmUpDnCantHuesp.Value > 0)
            {
                var senderGrid = (DataGridView)sender;
                if (int.Parse(cboRegimen.SelectedValue.ToString()) == 0)
                {
                    //Sin regimen
                    if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
                    {
                        if (e.ColumnIndex == 0)
                        {
                            //Selecciona el id de la habitacion
                            string regimenSeleccionado = GridRegimen.Rows[e.RowIndex].Cells[1].Value.ToString();

                            precioBase = Convert.ToDecimal(sHabitacion.getPrecioByRegimen(cboHotel.SelectedValue.ToString(), regimenSeleccionado));

                            //obtengo el precio base de la habitacion
                            txtValor.Text = (precioBase + recEstrella).ToString();

                        }
                    }
                }
                else
                {
                    //Con regimen
                    //Activa el boton agregar en caso que no lo este
                    if (!btnAgregar.Enabled)
                        btnAgregar.Enabled = true;

                    if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
                    {
                        if (e.ColumnIndex == 0)
                        {
                            //Selecciona el id de la habitacion
                            habSelected = GridRegimen.Rows[e.RowIndex].Cells[1].Value.ToString();
                            //Selecciona el Tipo de habitacion y Obtengo la cantidad de persona por la habitacion
                            tipoHabSelected = GridRegimen.Rows[e.RowIndex].Cells[2].Value.ToString();
                            decimal personas = getTipoHabitacion(tipoHabSelected);

                            //obtengo el precio base de la habitacion
                            precioBase = Convert.ToDecimal(sHabitacion.GetPrecioByHabitacion(cboHotel.SelectedValue.ToString(), habSelected, cboRegimen.SelectedValue.ToString()));
                            txtValor.Text = ((precioBase * personas) + recEstrella).ToString();
                            btnAgregar.Enabled = true;
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("La cantidad de Personas debe ser mayor que 0");
            }
        }

        //Permite agregar habitaciones a la grilla de seleccionadas
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!gridHabSeleccionada.Enabled)
                gridHabSeleccionada.Enabled = true;

            if (!btnEliminarHab.Enabled)
                btnEliminarHab.Enabled = true;
            //Se agrega la habitacion al listado de seleccionadas
            HabitacionDTO habitacion = new HabitacionDTO();
            habitacion.numero = Convert.ToDecimal(habSelected);
            habitacion.descripcion = tipoHabSelected;
            habSeleccionadas.Add(habitacion);
            //Se la elimina del listado de disponibles
            var itemToRemove = habDisponibles.SingleOrDefault(r => r.numero == Convert.ToDecimal(habSelected));
            if (itemToRemove != null)
                habDisponibles.Remove(itemToRemove);
            resetearGrillaDisponibles();

            //Actualiza los valores de los hospedados
            cantidad += getTipoHabitacion(habitacion.descripcion);
            resetearGrillaHabSeleccionadas();
            //Actualiza el valor total de la reserva
            totalValorReserva = totalValorReserva + (decimal.Parse(txtValor.Text) * cantidadNoches());
            txtValorReserva.Text = totalValorReserva.ToString();
            //verifica si se completo el cupo
            cupoCompleto();
            btnAgregar.Enabled = false;
            //para que no cambien los calculos
            btnCalendarioDesde.Enabled = false;
            btnCalendarioHasta.Enabled = false;
            btnVerif.Enabled = false;
            cboHotel.Enabled = false;
            cboRegimen.Enabled = false;
        }

        //De acuerdo al tipo de habitacion me devuelve la cantidad de personas
        private decimal getTipoHabitacion(string descripcion)
        {
            int tipo = Convert.ToInt32(sHabitacion.getTipoHabitacionByDescripcion(descripcion));
            decimal total = 0;
            //Codigo Tipo Habitacion
            switch (tipo)
            {
                case 1001:
                    /* Base Simple */
                    total = 1;
                    break;
                case 1002:
                    /*Base Doble */
                    total = 2;
                    break;
                case 1003:
                    /* Base Triple */
                    total = 3;
                    break;
                case 1004:
                    /* Base Cuadruple */
                    total = 4;
                    break;
                case 1005:
                    /* King */
                    total = 5;
                    break;
            }
            return total;
        }

        //guarda la reserva y devuelve el codigo
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (modificada)
            {
                modificarReserva();
            }
            else
            {
                if (user_selected != null)
                {
                    crearReserva();
                    decimal num_reserva = guardarReserva(reservaVista);
                    sReserva.asociarReservaHabitacciones(habSeleccionadas, num_reserva);
                    MessageBox.Show("El número de reserva creada es: " + num_reserva.ToString() + " le será útil para modificar/cancelar la misma");
                    resetearValores();
                }
                else
                {
                    MessageBox.Show("Cargue los datos del cliente");
                }
            }
        }

        //Actualiza la reserva
        private void modificarReserva()
        {
            crearReserva();
            reservaVista.cod_estado = 2;
            sReserva.actualizarReserva(reservaVista);
            sReserva.auditarReserva(reservaVista, txtFechaCarga.Text, "reserva modificada");

            //VALIDAR LAS HABITACIONES
            sReserva.desasociarReservaHabitacion(reservaVista.codigo);
            sReserva.asociarReservaHabitacciones(habSeleccionadas, reservaVista.codigo);
            //PARA LA RESERVA
            MessageBox.Show("Datos actualizados correctamente");
            resetearValores();
        }

        private decimal guardarReserva(Reserva reserva)
        {
            decimal codReserva = sReserva.Save(reserva);
            return codReserva;
        }

        //Crea el objeto reserva
        private void crearReserva()
        {
            reservaVista.cant_huespedes = nmUpDnCantHuesp.Value;
            reservaVista.cant_noches = cantidadNoches();
            //reservaVista.cod_estado = ; El estado lo voy a setear en el DAO
            reservaVista.cod_hotel = decimal.Parse(cboHotel.SelectedValue.ToString());
            reservaVista.cod_persona = decimal.Parse(user_selected);
            reservaVista.cod_tipo_regimen = decimal.Parse(cboRegimen.SelectedValue.ToString());
            //reservaVista.cod_usuario_carga = ; Lo busco de la persona logueada si es que tiene Usuario en el DAO
            reservaVista.fecha_creacion = Convert.ToDateTime(txtFechaCarga.Text);
            reservaVista.fecha_desde = Convert.ToDateTime(txtDesde.Text);
            reservaVista.fecha_hasta = Convert.ToDateTime(txtHasta.Text);
        }


        //verifica si se hospeda a todos los pasajeros indicados
        private void cupoCompleto()
        {
            if (cantidad >= alojados)
            {
                btnGuardar.Enabled = true;
                btnDatosClie.Enabled = true;
            }
            else
            {
                btnGuardar.Enabled = false;
                btnDatosClie.Enabled = false;
            }
        }

        //Calcula la cantidad de noches
        private decimal cantidadNoches()
        {
            return Convert.ToDecimal(((Convert.ToDateTime(txtHasta.Text) - Convert.ToDateTime(txtDesde.Text)).TotalDays));
        }

        //actualiza la grilla de habitaciones seleccionadas
        private void resetearGrillaHabSeleccionadas()
        {
            gridHabSeleccionada.DataSource = null;
            gridHabSeleccionada.DataSource = habSeleccionadas;
        }

        private void resetearGrillaDisponibles()
        {
            GridRegimen.DataSource = null;
            GridRegimen.DataSource = habDisponibles;
        }

        //Busca la reserva por codigo
        private void btnFindReserva_Click(object sender, EventArgs e)
        {
            if (txtNumeroReserva.Text != "")
            {
                Reserva reserva = sReserva.getReserva(txtNumeroReserva.Text);
                //Cargar el formulario con los datos obtenidos
                if (reserva != null)
                {
                    if (Login.Log.user == 1)
                    {
                        reservaVista = reserva;
                        cargarFormularioParaReserva(reservaVista);
                        btnModificarReserva.Visible = true;
                        if (reserva.cod_estado == 5)
                            MessageBox.Show("Esta reserva fue cancelada por not-show!");
                    }
                    else
                    { 
                        if(Login.Log.hotel == reserva.cod_hotel){
                            reservaVista = reserva;
                            cargarFormularioParaReserva(reservaVista);
                            btnModificarReserva.Visible = true;
                            if (reserva.cod_estado == 5)
                                MessageBox.Show("Esta reserva fue cancelada por not-show!");
                        }
                        else
                            MessageBox.Show("No puede modificar reservas de otros hoteles.");
                    }
                }
                else
                    MessageBox.Show("El número de reserva no es válido");
            }
            else
            {
                MessageBox.Show("Debe ingresar un numero de reserva");
            }
        }

        //Busca cliente o crea uno nuevo!
        private void btnDatosClie_Click(object sender, EventArgs e)
        {
            BusquedaReserva busquedaReserva = new BusquedaReserva();
            BusquedaReserva.amRes = true;
            busquedaReserva.Show();
        }

        //Muestra la info de la habitacion seleccionada en el listado de habitaciones seleccionadas
        private void gridHabSeleccionada_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                if (e.ColumnIndex == 0)
                {
                    //Selecciona el id de la habitacion
                    habSelected = gridHabSeleccionada.Rows[e.RowIndex].Cells[1].Value.ToString();
                    //Selecciona el Tipo de habitacion
                    tipoHabSelected = gridHabSeleccionada.Rows[e.RowIndex].Cells[2].Value.ToString();
                    //Obtengo la cantidad de persona por la habitacion
                    decimal personas = getTipoHabitacion(tipoHabSelected);

                    //obtengo el precio base de la habitacion
                    precioBase = Convert.ToDecimal(sHabitacion.GetPrecioByHabitacion(cboHotel.SelectedValue.ToString(), habSelected, cboRegimen.SelectedValue.ToString()));
                    txtValor.Text = ((precioBase * personas) + recEstrella).ToString();
                    btnEliminarHab.Enabled = true;
                }
            }
        }

        private void btnEliminarHab_Click(object sender, EventArgs e)
        {
            //Eliminar el item de la lista dde habitaciones seleccionadas
            HabitacionDTO habitacion = new HabitacionDTO();
            habitacion.numero = Convert.ToDecimal(habSelected);
            habitacion.descripcion = tipoHabSelected;
            //Actualiza los valores de los hospedados
            cantidad = cantidad - getTipoHabitacion(habitacion.descripcion);
            cupoCompleto();
            //Eliminar la habitacion
            var itemToRemove = habSeleccionadas.SingleOrDefault(r => r.numero == Convert.ToDecimal(habSelected));
            if (itemToRemove != null)
                habSeleccionadas.Remove(itemToRemove);
            //La agrego en las disponibles
            habDisponibles.Add(habitacion);
            resetearGrillaDisponibles();
            //Actualizar el valor de hospedados y
            //Actualiza el valor total de la reserva
            totalValorReserva = totalValorReserva - (decimal.Parse(txtValor.Text) * cantidadNoches());
            txtValorReserva.Text = totalValorReserva.ToString();

            resetearGrillaHabSeleccionadas();
            btnEliminarHab.Enabled = false;
        }


        //Carga los datos de la reserva en el formulario
        private void cargarFormularioParaReserva(Reserva reserva)
        {
            //Fechas
            txtDesde.Text = reserva.fecha_desde.ToShortDateString();
            btnCalendarioDesde.Enabled = false;
            txtHasta.Text = reserva.fecha_hasta.ToShortDateString();
            btnCalendarioHasta.Enabled = false;
            txtFechaCarga.Text = reserva.fecha_creacion.ToShortDateString();
            fecD = true;
            fecH = true;

            //Hotel y Regimenes
            recEstrella = Convert.ToDecimal(sHabitacion.getRecargaEstrellaHotel(reserva.cod_hotel.ToString()));
            cboHotel.DisplayMember = "direccionCompleta";
            cboHotel.ValueMember = "codigo";
            cboHotel.DataSource = sHotel.GetAllActivos();
            cboHotel.SelectedValue = reserva.cod_hotel;
            cboHotel.Enabled = false;

            List<Regimen> regimenes = sTipoHab.GetRegimenesByHotelWithNull(reserva.cod_hotel.ToString());
            cboRegimen.DisplayMember = "descripcion";
            cboRegimen.ValueMember = "codigo";
            cboRegimen.DataSource = regimenes;
            cboRegimen.SelectedValue = reserva.cod_tipo_regimen;
            cboRegimen.Enabled = false;

            //Usuario que carga
            user_selected = reserva.cod_persona.ToString();

            //Cantidad de Huespedes
            if(reserva.cant_huespedes != null)
                cantidad = (decimal)reserva.cant_huespedes;
            nmUpDnCantHuesp.Enabled = false;
            btnVerif.Enabled = false;

            //Grillas de Habitaciones
            GridRegimen.Enabled = false;
            List<HabitacionDTO> habitacionesElegidas = sHabitacion.getHabitacionesPorReserva(reserva.cod_hotel.ToString(), reserva.codigo.ToString());
            gridHabSeleccionada.DataSource = habitacionesElegidas;
            gridHabSeleccionada.Enabled = false;


            //Valor total de la reserva
            decimal reservaTotal = 0;
            foreach (HabitacionDTO hab in habitacionesElegidas)
            {
                precioBase = Convert.ToDecimal(sHabitacion.GetPrecioByHabitacion(reserva.cod_hotel.ToString(), hab.numero.ToString(), reserva.cod_tipo_regimen.ToString()));
                decimal personas = getTipoHabitacion(hab.descripcion);
                reservaTotal = reservaTotal + ((precioBase * personas) + recEstrella);

                if(reserva.cant_huespedes == null)
                    cantidad = personas + cantidad;
            }
            nmUpDnCantHuesp.Value = cantidad;
            txtValorReserva.Text = (reservaTotal * reserva.cant_noches).ToString();
        }

        private void btnModificarReserva_Click(object sender, EventArgs e)
        {
            if (reservaVista.cod_estado == 1 || reservaVista.cod_estado == 2)
            {
                //Fechas
                btnCalendarioDesde.Enabled = true;
                btnCalendarioHasta.Enabled = true;

                cboHotel.Enabled = false;
                cboRegimen.Enabled = true;

                //Cantidad de Huespedes
                nmUpDnCantHuesp.Enabled = true;
                btnVerif.Enabled = true;

                //Grillas de Habitaciones
                GridRegimen.Enabled = true;
                gridHabSeleccionada.Enabled = true;

                modificada = true;
                cupoCompleto();
            }
            else
            {
                if (reservaVista.cod_estado == 6)
                    MessageBox.Show("La reserva ya ha sido utilizada");
                else
                    MessageBox.Show("Reserva cancelada con anterioridad");
            }
        }
    }
}
