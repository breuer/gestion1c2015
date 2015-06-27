using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace FrbaHotel.ClasesTabla
{
    class SReserva
    {
        private DReserva _reservaDAO;
        private DReserva reservaDAO
        {
            get
            {
                if (_reservaDAO == null)
                    _reservaDAO = new DReserva();
                return _reservaDAO;
            }
        }
        private DHotel _hotelDao;
        private DHotel hotelDao
        {
            get
            {
                if (_hotelDao == null)
                    _hotelDao = new DHotel();
                return _hotelDao;
            }
        }

        public decimal Save(Reserva reserva)
        {
            return reservaDAO.Save(reserva);
        }

        //Asocia la resera con las distintas habitaciones que se relacionan
        public void asociarReservaHabitacciones(List<HabitacionDTO> habSeleccionadas, decimal num_reserva)
        {
            foreach (HabitacionDTO hab in habSeleccionadas)
            {
                reservaDAO.asociarReservaHabitacion(hab.numero, num_reserva);
            }
        }

        public void desasociarReservaHabitacion(decimal num_reserva)
        {
            reservaDAO.desasociarReservaHabitacion(num_reserva);
            
        }

        //Obtiene la reserva por codigo
        public Reserva getReserva(string num_reserva)
        {
            return reservaDAO.getReserva(num_reserva);
        }

        public void actualizarReserva(Reserva reserva)
        {
            reservaDAO.update(reserva);
        }

        //Audita la reserva
        public void auditarReserva(Reserva reserva, string fecha, string motivo)
        {
            reservaDAO.auditarReserva(reserva, fecha, motivo);
        }

        //Cancela la reserva
        public void cancelarReserva(Reserva reserva)
        {
            reservaDAO.cancelarReserva(reserva);
        }

        public Reserva getReservaParaCheck(string num_reserva)
        {
            return reservaDAO.getReservaParaCheck(num_reserva);
        }

        public void ingresarReserva(string num_reserva)
        {
            reservaDAO.ReservaIngresada(num_reserva);
        }

        public Reserva GetReserva(string codigoReserva)
        {
            EntidadBase entidadBase = new EntidadBase();
            DataTable TableFunc = entidadBase.TraerDatos("select r.codigo from hotel.reserva r where r.codigo = " + codigoReserva);
            Reserva reserva = new Reserva();

            if (TableFunc.Rows.Count == 0)
            {
                return null;
            }
            decimal codigo = TableFunc.Rows[0].Field<decimal>("codigo");
            reserva.codigo = codigo;
            return reserva;
        }

        internal bool isAllInclusive(string codigoReserva)
        {
            EntidadBase entidadBase = new EntidadBase();
            string query = string.Format("select hotel.isAllInclusive({0}) ",
                int.Parse(codigoReserva));

            bool resultado = (bool)entidadBase.EjecutarFuncionEscalarSQL(query);

            return resultado;
        }
    }
}