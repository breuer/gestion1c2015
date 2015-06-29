using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace FrbaHotel.ClasesTabla
{
    class DConsumible
    {
        EntidadBase entidadBase = new EntidadBase();

        internal List<Consumible> GetAll()
        {
            DataTable TableFunc = entidadBase.TraerDatos("select c.codigo, c.descripcion, c.precio from hotel.consumo c");
            List<Consumible> consumibles = new List<Consumible>();

            foreach (DataRow c in TableFunc.Rows)
            {
                Consumible consumible = new Consumible();
                consumible.codigo = c.Field<decimal>("codigo");
                consumible.descripcion = c.Field<string>("descripcion");
                consumible.precio = c.Field<decimal>("precio");
                consumibles.Add(consumible);
            }
            return consumibles;
        }

        internal void RegistrarConsumible(string codigoReserva, string codigoProducto, string cantidadProducto, string precioProducto)
        {
            entidadBase.EjecutarSQL("hotel.SP_RegistrarConsumible " + codigoReserva + ", " +
                    codigoProducto + ", " + cantidadProducto + ", " + precioProducto);
        }

        internal void registrarAllInclusive(string codigoReserva, string precioTotal)
        {
            entidadBase.EjecutarSQL("hotel.SP_RegistrarAllInclusive " + codigoReserva + ", " +
                        precioTotal);
        }

        internal List<Consumible> GetConsumiblesPorReserva(string codigoReserva)
        {
            DataTable TableFunc = entidadBase.TraerDatos("hotel.sp_consumos_reserva " + codigoReserva);
            List<Consumible> consumibles = new List<Consumible>();

            foreach (DataRow c in TableFunc.Rows)
            {
                Consumible consumible = new Consumible();
                consumible.codigo = c.Field<decimal>("codigo");
                consumible.descripcion = c.Field<string>("descripcion");
                consumible.cantidad = c.Field<decimal>("cantidad");
                consumible.precio = c.Field<decimal>("precio");
                consumibles.Add(consumible);
            }
            return consumibles;
        }
    }
}