using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace FrbaHotel.ClasesTabla
{
    class DHabitacion
    {
        EntidadBase entidadBase = new EntidadBase();

        //Devuelve las habitaciones disponible para el hotel en las fechas elegidas
        public List<HabitacionDTO> GetDisponiblesPorHotelyFechas(string hotel, string desde, string hasta)
        {
            DataTable table = entidadBase.TraerDatos("hotel.SP_GETHAB_DISPporHotel " + this.ArmarValores(hotel, desde, hasta));
            List<HabitacionDTO> habitaciones = new List<HabitacionDTO>();

            foreach (DataRow r in table.Rows)
            {
                HabitacionDTO habitacion = new HabitacionDTO();
                habitacion.numero = r.Field<decimal>("cod_habitacion");
                habitacion.descripcion = r.Field<string>("descripcion");
                habitaciones.Add(habitacion);
            }
            return habitaciones;
        }

        public List<HabitacionDTO> getHabitacionesByReserva(string hotel, string reserva)
        {
            DataTable table = entidadBase.TraerDatos("hotel.SP_GETHAB_BY_RESERVA " + hotel + "," + reserva);
            List<HabitacionDTO> habitaciones = new List<HabitacionDTO>();

            foreach (DataRow r in table.Rows)
            {
                HabitacionDTO habitacion = new HabitacionDTO();
                habitacion.numero = r.Field<decimal>("cod_habitacion");
                habitacion.descripcion = r.Field<string>("descripcion");
                habitaciones.Add(habitacion);
            }
            return habitaciones;
        }

        //Devuelve el precio de una habitacion en particular
        public string GetPrecioByHabitacion(string hotel, string habitacion, string regimen)
        {

            DataTable precioBase = entidadBase.TraerDatos("select (hotel.FN_GET_PRECIO_BASE (" + habitacion + "," + hotel + "," + regimen + "))");
            DataRow reg = precioBase.Rows[0];

            return Convert.ToString(reg[0]);
        }

        public string getPrecioByRegimen(string hotel, string regimen)
        {
            DataTable precio = entidadBase.TraerDatos("select precio_base from hotel.Regimen_Hotel where cod_hotel = " + hotel + " and estado = 1 and cod_regimen = " + regimen);
            DataRow reg = precio.Rows[0];

            return Convert.ToString(reg[0]);
        }

        private string ArmarValores(string hotel, string desde, string hasta)
        {
            StringBuilder Valores = new StringBuilder();
            Valores.Append(hotel + ",");
            Valores.Append("'" + desde + "',");
            Valores.Append("'" + hasta + "'");

            return Valores.ToString();
        }

        public string getRecargaEstrellaHotel(string hotel)
        {
            DataTable recargaEstrella = entidadBase.TraerDatos("SELECT h.recarga_estrella FROM hotel.Hotel h WHERE h.codigo =" + hotel);
            DataRow row = recargaEstrella.Rows[0];
            return Convert.ToString(row[0]);
        }

        public string getTipoHabitacionByDescripcion(string descripcion)
        {
            DataTable tipoHabitacion = entidadBase.TraerDatos("SELECT codigo FROM hotel.Tipo_Habitacion ha WHERE ha.descripcion like '%" + descripcion + "%'");
            DataRow row = tipoHabitacion.Rows[0];
            return Convert.ToString(row[0]);
        }

        public void Delete(decimal codHab)
        {
            int ex = entidadBase.EjecutarSQL("update hotel.Habitacion set estado = 0 where codigo=" + codHab);
        }

        public List<Habitacion> GetHabitacionesHotel(decimal codHotel)
        {
            DataTable table = entidadBase.TraerDatos("hotel.GETHabitacionesHotel " + codHotel);
            List<Habitacion> habitaciones = new List<Habitacion>();

            foreach (DataRow r in table.Rows)
            {
                Habitacion habitacion = new Habitacion();
                habitacion.codigo = r.Field<decimal>("codigo");
                habitacion.numero = r.Field<decimal>("numero");
                habitacion.descripcion = r.Field<string>("descripcion");
                int estado = r.Field<byte>("estado");
                if (estado == 1) habitacion.estado = true;
                else habitacion.estado = false;
                habitacion.piso = r.Field<decimal>("piso");
                habitacion.TipoHab = r.Field<string>("TipoHab");
                habitacion.ubicacion_frente = r.Field<string>("ubicacion_frente");
                habitaciones.Add(habitacion);
            }
            return habitaciones;
        }

        public List<Habitacion> GetBySQLGrid(string consulta)
        {
            DataTable table = entidadBase.TraerDatos(consulta);
            List<Habitacion> habitaciones = new List<Habitacion>();

            foreach (DataRow r in table.Rows)
            {
                Habitacion habitacion = new Habitacion();
                habitacion.codigo = r.Field<decimal>("codigo");
                habitacion.numero = r.Field<decimal>("numero");
                habitacion.descripcion = r.Field<string>("descripcion");
                int estado = r.Field<byte>("estado");
                if (estado == 1) habitacion.estado = true;
                else habitacion.estado = false;
                habitacion.piso = r.Field<decimal>("piso");
                habitacion.TipoHab = r.Field<string>("TipoHab");
                habitacion.ubicacion_frente = r.Field<string>("ubicacion_frente");
                habitaciones.Add(habitacion);
            }
            return habitaciones;
        }

        public List<HabitacionTable> GetBySQL(string consulta)
        {
            DataTable table = entidadBase.TraerDatos(consulta);
            List<HabitacionTable> habitaciones = new List<HabitacionTable>();

            foreach (DataRow r in table.Rows)
            {
                HabitacionTable habitacion = new HabitacionTable();
                habitacion.codigo = r.Field<decimal>("codigo");
                habitacion.numero = r.Field<decimal>("numero");
                habitacion.descripcion = r.Field<string>("descripcion");
                int estado = r.Field<byte>("estado");
                if (estado == 1) habitacion.estado = true;
                else habitacion.estado = false;
                habitacion.piso = r.Field<decimal>("piso");
                habitacion.cod_hotel = r.Field<decimal>("cod_hotel");
                habitacion.cod_tipo_habitacion = r.Field<decimal>("cod_tipo_habitacion");
                habitacion.ubicacion_frente = r.Field<string>("ubicacion_frente");
                habitaciones.Add(habitacion);
            }
            return habitaciones;
        }

        public decimal Save(HabitacionTable hab)
        {
            decimal estado = 0;
            if (hab.estado == true)
                estado = 1;
            else estado = 0;
            int ex = entidadBase.EjecutarSQL("insert hotel.Habitacion (cod_hotel,cod_tipo_habitacion,descripcion,estado,numero,piso,ubicacion_frente) values (" + hab.cod_hotel + "," + hab.cod_tipo_habitacion + ",'" + hab.descripcion + "'," + estado + "," + hab.numero + "," + hab.piso + ",'" + hab.ubicacion_frente + "')");
            DataTable resultID = entidadBase.TraerDatos("SELECT max(codigo) from hotel.Habitacion ");
            DataRow row = resultID.Rows[0];
            return Convert.ToInt32(row[0]);
        }

        public void Update(HabitacionTable hab)
        {
            int ex = entidadBase.EjecutarSQL("update hotel.Habitacion set numero = " + hab.numero + ", piso = " + hab.piso + ",ubicacion_frente = '" + hab.ubicacion_frente + "', descripcion = '" + hab.descripcion + "'  where codigo=" + hab.codigo);
        }
    }
}
