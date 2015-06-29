using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrbaHotel.ClasesTabla
{
    class SHabitacion
    {
        private DHabitacion _habitacion;
        private DHabitacion habitacion
        {
            get
            {
                if (_habitacion == null)
                    _habitacion = new DHabitacion();
                return _habitacion;
            }
        }

        //Devuelve las habitaciones disponible para el hotel en las fechas elegidas
        public List<HabitacionDTO> GetDisponiblesPorHotelyFechas(string hotel, string desde, string hasta)
        {
            return habitacion.GetDisponiblesPorHotelyFechas(hotel, desde, hasta);
        }

        //Devuelve las habitaciones seleccionadas de una reserva
        public List<HabitacionDTO> getHabitacionesPorReserva(string hotel, string reserva)
        {
            return habitacion.getHabitacionesByReserva(hotel, reserva);
        }

        //Devuelve el precio base de una habitacion en particular
        public string GetPrecioByHabitacion(string hotel, string hab, string regimen)
        {
            return habitacion.GetPrecioByHabitacion(hotel, hab, regimen);
        }

        public string getPrecioByRegimen(string hotel, string regimen)
        {
            return habitacion.getPrecioByRegimen(hotel, regimen);
        }

        //Devuelve el precio de recarga estrella del hotel
        public string getRecargaEstrellaHotel(string hotel)
        {
            return habitacion.getRecargaEstrellaHotel(hotel);
        }

        //Devuelve el Codigo del tipo de habitacion para saber la cantidad de personas
        public string getTipoHabitacionByDescripcion(string descripcion)
        {
            return habitacion.getTipoHabitacionByDescripcion(descripcion);
        }

        public void Delete(decimal codHab)
        {
            habitacion.Delete(codHab);
        }

        public void Update(HabitacionTable hab)
        {
            habitacion.Update(hab);
        }

        public decimal Save(HabitacionTable hab)
        {
            return habitacion.Save(hab);
        }

        public List<Habitacion> GetHabitacionesHotel(decimal codHotel)
        {
            return habitacion.GetHabitacionesHotel(codHotel);
        }

        public List<Habitacion> GetBySQLGrid(string consulta)
        {
            return habitacion.GetBySQLGrid(consulta);
        }

        public List<HabitacionTable> GetBySQL(string consulta)
        {
            return habitacion.GetBySQL(consulta);
        }
    }
}