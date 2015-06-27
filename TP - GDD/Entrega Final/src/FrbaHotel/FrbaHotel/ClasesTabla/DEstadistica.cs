using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace FrbaHotel.ClasesTabla
{
    class DEstadistica
    {

        EntidadBase entidadBase = new EntidadBase();

        public List<HotelEstadistica> EstadisticaTopHotelReservaCancelada(string trim, int anio) 
        {
            DataTable us = entidadBase.TraerDatos("hotel.SP_EstadisticaTopHotelReservaCancelada '" + trim + "',"+anio );
            List<HotelEstadistica> hoteles = new List<HotelEstadistica>();

            foreach (DataRow r in us.Rows)
            {
                HotelEstadistica hotel = new HotelEstadistica();
                hotel.nom_calle = r.Field<string>("nom_calle");
                hotel.num_calle = r.Field<decimal>("num_calle");
                hotel.nombre = r.Field<string>("nombre");
                hotel.pais = r.Field<string>("pais");
                hotel.ciudad = r.Field<string>("ciudad");
                hotel.cantidad = r.Field<int>("cantReservaCanceladas");
                if (hotel.ciudad != null)
                    hotel.ciudad = hotel.ciudad.TrimEnd();
                hoteles.Add(hotel);
            }
            return hoteles;
        }
        
        public List<HotelEstadistica> EstadisticaTopHotelConsumibleFacturado(string trim, int anio) 
        {
            DataTable us = entidadBase.TraerDatos("hotel.SP_EstadisticaTopHotelConsumibleFacturado '" + trim + "'," + anio);
            List<HotelEstadistica> hoteles = new List<HotelEstadistica>();

            foreach (DataRow r in us.Rows)
            {
                HotelEstadistica hotel = new HotelEstadistica();
                hotel.nom_calle = r.Field<string>("nom_calle");
                hotel.num_calle = r.Field<decimal>("num_calle");
                hotel.nombre = r.Field<string>("nombre");
                hotel.pais = r.Field<string>("pais");
                hotel.ciudad = r.Field<string>("ciudad");
                var cant = r.Field<decimal>("cantConsumiblesRegitrados");
                hotel.cantidad = (int)cant;
                if (hotel.ciudad != null)
                    hotel.ciudad = hotel.ciudad.TrimEnd();
                hoteles.Add(hotel);
            }
            return hoteles;
        }

        public List<HotelEstadistica> EstadisticaTopHotelDiasOut(string trim, int anio) 
        {
            DataTable us = entidadBase.TraerDatos("hotel.SP_EstadisticaTopHotelDiasOut '" + trim + "'," + anio);
            List<HotelEstadistica> hoteles = new List<HotelEstadistica>();

            foreach (DataRow r in us.Rows)
            {
                HotelEstadistica hotel = new HotelEstadistica();
                hotel.nom_calle = r.Field<string>("nom_calle");
                hotel.num_calle = r.Field<decimal>("num_calle");
                hotel.nombre = r.Field<string>("nombre");
                hotel.pais = r.Field<string>("pais");
                hotel.ciudad = r.Field<string>("ciudad");
                hotel.cantidad = r.Field<int>("cantConsumiblesRegitrados");
                if (hotel.ciudad != null)
                    hotel.ciudad = hotel.ciudad.TrimEnd();
                hoteles.Add(hotel);
            }
            return hoteles;
        }

        public List<HabitacionEstadistica> EstadisticaTopHabitacionVecesOcupadas(string trim, int anio) 
        {
            DataTable us = entidadBase.TraerDatos("hotel.SP_EstadisticaTopHabitacionVecesOcupadas '" + trim + "'," + anio);
            List<HabitacionEstadistica> habs = new List<HabitacionEstadistica>();

            foreach (DataRow r in us.Rows)
            {
                HabitacionEstadistica h = new HabitacionEstadistica();
                h.CalleHotel = r.Field<string>("CalleHotel");
                h.cantVecesOcupadas = r.Field<int>("cantVecesOcupadas");
                h.NumCalleHotel = r.Field<decimal>("NumCalleHotel");
                h.numero = r.Field<decimal>("numero");
                h.piso = r.Field<decimal>("piso");
                h.ubicacion_frente = r.Field<string>("ubicacion_frente");
                habs.Add(h);
            }
            return habs;
        }

        public List<ClientesEstadistica> EstadisticaTopClientes(string trim, int anio) 
        {
            DataTable us = entidadBase.TraerDatos("hotel.SP_EstadisticaTopClientes '" + trim + "'," + anio);
            List<ClientesEstadistica> clientes = new List<ClientesEstadistica>();

            foreach (DataRow r in us.Rows)
            {
                ClientesEstadistica h = new ClientesEstadistica();
                h.Puntos = r.Field<decimal>("Puntos");
                h.num_doc = r.Field<decimal>("num_doc");
                h.nombre = r.Field<string>("nombre");
                h.nacionalidad = r.Field<string>("nacionalidad");
                h.apellido = r.Field<string>("apellido");
                clientes.Add(h);
            }
            return clientes;
        }
    }
}
