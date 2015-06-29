using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrbaHotel.ClasesTabla
{
    class SConsumible
    {
        private DConsumible _consumibleDao;
        private DConsumible consumibleDao
        {
            get
            {
                if (_consumibleDao == null)
                    _consumibleDao = new DConsumible();
                return _consumibleDao;
            }
        }

        public List<Consumible> GetAll()
        {
            return consumibleDao.GetAll();
        }

        internal void RegistrarConsumible(string codigoReserva, string codigoProducto, string cantidadProducto, string precioProducto)
        {
            consumibleDao.RegistrarConsumible(codigoReserva, codigoProducto, cantidadProducto, precioProducto);
        }

        internal void registrarAllInclusive(string codigoReserva, string precioTotal)
        {
            consumibleDao.registrarAllInclusive(codigoReserva, precioTotal);
        }

        internal List<Consumible> GetConsumiblesPorReserva(string codigoReserva)
        {
            return consumibleDao.GetConsumiblesPorReserva(codigoReserva);
        }
    }
}