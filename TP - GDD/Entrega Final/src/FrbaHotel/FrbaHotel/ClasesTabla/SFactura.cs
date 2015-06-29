using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace FrbaHotel.ClasesTabla
{
    class SFactura
    {
        private EntidadBase entidadBase = new EntidadBase();

        internal decimal getNextNumber()
        {

            string query = string.Format("select hotel.getNextNumeroFactura()");

            decimal resultado = (decimal)entidadBase.EjecutarFuncionEscalarSQL(query);

            return resultado;
        }

        internal List<ItemFactura> getItemsFactura(string codigoReserva)
        {
            DataTable TableFunc = entidadBase.TraerDatos("hotel.sp_getItemsFactura " + codigoReserva);
            List<ItemFactura> items = new List<ItemFactura>();

            foreach (DataRow i in TableFunc.Rows)
            {
                ItemFactura item = new ItemFactura();
                item.descripcion = i.Field<string>("descripcion");
                item.cantidad = i.Field<int>("cantidad");
                item.monto = i.Field<decimal>("monto");
                items.Add(item);
            }
            return items;
        }

        internal void GrabarFactura(string numFact, string fecha, string numReserva, int metodoPago, string total, List<ItemFactura> gridItemsList, List<Consumible> gridConsumosList)
        {
            entidadBase.EjecutarSQL("hotel.sp_registrar_cabecera_factura " + numFact + ", '" +
                    fecha + "', " + numReserva + ", " + metodoPago + ", " + total.Replace(',', '.'));

            foreach (ItemFactura itemFactura in gridItemsList)
            {
                entidadBase.EjecutarSQL("hotel.sp_registrar_item " + numFact + ", " + numReserva + ", " + itemFactura.cantidad + ", " + itemFactura.monto.ToString().Replace(',', '.') + ", NULL");
            }

            foreach (Consumible consumible in gridConsumosList)
            {
                entidadBase.EjecutarSQL("hotel.sp_registrar_item " + numFact + ", " + numReserva + ", " + consumible.cantidad + ", " + consumible.precio.ToString().Replace(',', '.') + ", " + consumible.codigo);
            }

        }

        internal List<MetodoPago> GetMetodosPago()
        {
            DataTable TableFunc = entidadBase.TraerDatos("select codigo, descripcion from hotel.metodo_pago where codigo <> 0");
            List<MetodoPago> metodosPago = new List<MetodoPago>();

            foreach (DataRow m in TableFunc.Rows)
            {
                MetodoPago metodoPago = new MetodoPago();
                metodoPago.codigo = m.Field<byte>("codigo");
                metodoPago.descripcion = m.Field<string>("descripcion");
                metodosPago.Add(metodoPago);
            }
            return metodosPago;
        }

        internal void registrarTarjeta(string codigoReserva, string numeroTarjeta, string emision, string vencimiento)
        {
            entidadBase.EjecutarSQL("hotel.sp_registrar_tarjeta " + codigoReserva + ", '" +
                    numeroTarjeta + "', '" + emision + "', '" + vencimiento + "'");
        }
    }
}