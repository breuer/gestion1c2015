using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using FrbaHotel.ClasesTabla;

namespace FrbaHotel.ClasesTabla
{
    class DReserva
    {
        EntidadBase entidadBase = new EntidadBase();
        DPersona personaDAO = new DPersona();

        //Devuelve todas las reservas
        public List<Reserva> GetAllReservas()
        {
            DataTable res = entidadBase.TraerDatos("select * from hotel.Reserva");
            List<Reserva> reservas = new List<Reserva>();

            foreach (DataRow reglon in res.Rows)
            {
                Reserva reserva = parsearReserva(reglon);

                reservas.Add(reserva);
            }

            return reservas;
        }

        //Salva una nueva por lo que van valores defectos
        public decimal Save(Reserva reserva)
        {
            reserva.cod_estado = 1;
            reserva.cod_usuario_carga = Login.Log.user;

            int ex = entidadBase.EjecutarSQL("insert hotel.Reserva (codigo,cod_hotel,fecha_desde,fecha_hasta,cant_huespedes,cod_tipo_regimen,cod_estado,cod_usuario_carga,cant_noches, cod_persona,fecha_creacion) values (" + ArmarValores(reserva) + ")");
            DataTable resultID = entidadBase.TraerDatos("SELECT max(codigo) from hotel.Reserva ");
            DataRow row = resultID.Rows[0];
            return Convert.ToInt32(row[0]);
        }

        public void update(Reserva reserva)
        {
            int ex = entidadBase.EjecutarSQL("hotel.SP_UPDRESERVA " + ArmarValores(reserva));
        }

        private string ArmarValores(Reserva reserva)
        {
            StringBuilder Valores = new StringBuilder();
            if (reserva.codigo != 0)
            {
                Valores.Append(reserva.codigo + ",");
            }
            else
            {
                Valores.Append("NULL,");
            }

            Valores.Append("" + reserva.cod_hotel + ",");
            Valores.Append("'" + reserva.fecha_desde.ToShortDateString() + "',");
            Valores.Append("'" + reserva.fecha_hasta.ToShortDateString() + "',");
            Valores.Append("" + reserva.cant_huespedes + ",");
            Valores.Append("" + reserva.cod_tipo_regimen + ",");
            Valores.Append("" + reserva.cod_estado + ",");
            Valores.Append("" + reserva.cod_usuario_carga + ",");
            Valores.Append("" + reserva.cant_noches + ",");
            if (reserva.cod_persona != 0)
            {
                Valores.Append("" + reserva.cod_persona + ",");
            }
            else
            {
                Valores.Append("NULL,");
            }
            Valores.Append("'" + reserva.fecha_creacion.ToShortDateString() + "'");

            return Valores.ToString();
        }

        //Asocia la reserva con las habitaciones
        public void asociarReservaHabitacion(decimal cod_habitaccion, decimal num_reserva)
        {
            int ex = entidadBase.EjecutarSQL("insert hotel.Reserva_Habitacion (cod_reserva,cod_habitacion) values (" + num_reserva + "," + cod_habitaccion + ")");
        }

        public void desasociarReservaHabitacion(decimal num_reserva)
        {
            int ex = entidadBase.EjecutarSQL("delete hotel.Reserva_Habitacion where cod_reserva = " + num_reserva + "");
        }

        //Devuelve la reserva por codigo
        public Reserva getReserva(string num_reserva)
        {
            DataTable tabla = entidadBase.TraerDatos("select * from hotel.Reserva where codigo = " + num_reserva);
            if (tabla.Rows.Count != 0)
            {
                DataRow reglon = tabla.Rows[0];
                Reserva reserva = parsearReserva(reglon);
                return reserva;
            }
            else
                return null;
        }

        //Devuelve la reserva para el checkin
        public Reserva getReservaParaCheck(string num_reserva)
        {
            DataTable tabla = entidadBase.TraerDatos("select * from hotel.Reserva where codigo = " + num_reserva + " AND cod_estado = 1 OR cod_estado = 2");
            if (tabla.Rows.Count != 0)
            {
                DataRow reglon = tabla.Rows[0];
                Reserva reserva = parsearReserva(reglon);
                return reserva;
            }
            else
                return null;
        }

        //Convierte los datos de la consulta asociandolos con la clase
        public Reserva parsearReserva(DataRow reglon)
        {
            Reserva reserva = new Reserva();
            reserva.codigo = reglon.Field<decimal>("codigo");
            //Verificas los nulos
            reserva.cant_huespedes = reglon.Field<Nullable<decimal>>("cant_huespedes");
            reserva.cant_noches = reglon.Field<decimal>("cant_noches");
            reserva.cod_estado = reglon.Field<decimal>("cod_estado");
            reserva.cod_hotel = reglon.Field<decimal>("cod_hotel");
            reserva.cod_persona = reglon.Field<decimal>("cod_persona");
            reserva.cod_tipo_regimen = reglon.Field<decimal>("cod_tipo_regimen");
            reserva.cod_usuario_carga = reglon.Field<decimal>("cod_usuario_carga");
            reserva.fecha_creacion = reglon.Field<DateTime>("fecha_creacion");
            reserva.fecha_desde = reglon.Field<DateTime>("fecha_desde");
            reserva.fecha_hasta = reglon.Field<DateTime>("fecha_hasta");

            return reserva;
        }

        public void auditarReserva(Reserva reserva, string fecha, string motivo)
        {

            decimal usuarioLogueado = Login.Log.user;
            decimal? persona;
            if (usuarioLogueado == 1)
            {
                persona = reserva.cod_persona;
            }
            else if (usuarioLogueado != 2)
            {
                DataTable per = entidadBase.TraerDatos("SELECT u.cod_persona codigo FROM hotel.Usuario u WHERE u.codigo =" + usuarioLogueado);
                DataRow r = per.Rows[0];
                persona = r.Field<decimal>("codigo");
            }
            else
                persona = null;
            if(persona != null)
                entidadBase.EjecutarSQL("insert hotel.Auditoria_Reserva (cod_reserva,motivo,fecha,cod_persona,cod_usuario) values (" + reserva.codigo + ",'" + motivo + "','" + fecha + "'," + persona + "," + usuarioLogueado + ")");

             else
                entidadBase.EjecutarSQL("insert hotel.Auditoria_Reserva (cod_reserva,motivo,fecha,cod_persona,cod_usuario) values (" + reserva.codigo + ",'" + motivo + "','" + fecha + "',null," + usuarioLogueado + ")");

        }

        public void cancelarReserva(Reserva reserva)
        {
            decimal usuarioLogueado = Login.Log.user;
            //cancelado por not show
            decimal codEstado = 5;
            decimal persona;
            if (usuarioLogueado == 1 || usuarioLogueado == 2)
            {
                persona = reserva.cod_persona;
                //cancelado por cliente (guest)
                codEstado = 4;
            }
            else
            {
                DataTable per = entidadBase.TraerDatos("SELECT u.cod_persona codigo FROM hotel.Usuario u WHERE u.codigo =" + usuarioLogueado);
                DataRow r = per.Rows[0];
                persona = r.Field<decimal>("codigo");
                //cancelado por recepcion
                codEstado = 3;
            }
            int ex = entidadBase.EjecutarSQL("UPDATE hotel.Reserva SET cod_estado = " + codEstado + " WHERE codigo = " + reserva.codigo);

        }

        public void ReservaIngresada(string num_reserva)
        {
            int ex = entidadBase.EjecutarSQL("UPDATE hotel.Reserva SET cod_estado = 6 WHERE codigo = " + num_reserva);
        }
    }
}