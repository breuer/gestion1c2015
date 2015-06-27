using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace FrbaHotel.ClasesTabla
{
    class DEstadia
    {
        EntidadBase entidadBase = new EntidadBase();
        //Salva una nueva por lo que van valores defectos
        public decimal Save(Estadia estadia)
        {
            int ex = entidadBase.EjecutarSQL("insert hotel.Check_In_Out (cod_reserva,fecha_hora_in,fecha_hora_out,cod_usuario_carga_in,cod_usuario_carga_out,cant_noches_estadia) values (" + ArmarValores(estadia) + ")");
            DataTable resultID = entidadBase.TraerDatos("SELECT max(codigo) from hotel.Check_In_Out ");
            DataRow row = resultID.Rows[0];
            return Convert.ToInt32(row[0]);
        }

        public decimal checkOut(string codigo, string fecha_out)
        {
            int ex = entidadBase.EjecutarSQL("hotel.SP_UPDESTADIA " + codigo + ",'" + fecha_out + "'," + Login.Log.user);
            return ex;
        }

        private string ArmarValores(Estadia estadia)
        {
            StringBuilder Valores = new StringBuilder();

            Valores.Append(estadia.cod_reserva + ",");
            Valores.Append("'" + estadia.fecha_hora_in.ToShortDateString() + "',");
            if (estadia.cod_usuario_carga_out != null)
                Valores.Append("'" + estadia.fecha_hora_out + "',");
            else
                Valores.Append("NULL,");
            if (estadia.cod_usuario_carga_in > 0)
                Valores.Append("" + estadia.cod_usuario_carga_in + ",");
            else
                Valores.Append("" + Login.Log.user + ",");

            if (estadia.cod_usuario_carga_in > 0)
                Valores.Append("" + Login.Log.user + ",");
            else
                Valores.Append("NULL,");

            Valores.Append("" + estadia.cant_noches_estadia);

            return Valores.ToString();
        }

        //Devuelve la reserva por codigo
        public Estadia getEstadia(string num_reserva)
        {
            DataTable tabla = entidadBase.TraerDatos("select * from hotel.Check_In_Out where cod_reserva = " + num_reserva);
            if (tabla.Rows.Count != 0)
            {
                DataRow reglon = tabla.Rows[0];
                Estadia estadia = parsearEstadia(reglon);
                return estadia;
            }
            else
                return null;
        }

        //Convierte los datos de la consulta asociandolos con la clase
        public Estadia parsearEstadia(DataRow reglon)
        {
            Estadia estadia = new Estadia();
            estadia.codigo = reglon.Field<decimal>("codigo");
            //Verificas los nulos
            estadia.cod_reserva = reglon.Field<decimal>("cod_reserva");
            estadia.fecha_hora_in = reglon.Field<DateTime>("fecha_hora_in");
            estadia.fecha_hora_out = reglon.Field<DateTime?>("fecha_hora_out");
            estadia.cod_usuario_carga_in = reglon.Field<decimal>("cod_usuario_carga_in");
            estadia.cod_usuario_carga_out = reglon.Field<decimal?>("cod_usuario_carga_out");
            estadia.cant_noches_estadia = reglon.Field<decimal>("cant_noches_estadia");

            return estadia;
        }
    }
}
