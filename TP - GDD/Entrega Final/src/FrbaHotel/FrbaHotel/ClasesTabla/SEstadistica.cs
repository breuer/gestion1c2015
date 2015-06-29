using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrbaHotel.ClasesTabla
{
    class SEstadistica
    {
        private DEstadistica _estadisticaDao;
        private DEstadistica estadisticaDao
        {
            get
            {
                if (_estadisticaDao == null)
                    _estadisticaDao = new DEstadistica();
                return _estadisticaDao;
            }
        }

        public List<HotelEstadistica> EstadisticaTopHotelReservaCancelada(string trim, int anio) {
            return estadisticaDao.EstadisticaTopHotelReservaCancelada(trim, anio);
        }

        public List<HotelEstadistica> EstadisticaTopHotelConsumibleFacturado(string trim, int anio)
        {
            return estadisticaDao.EstadisticaTopHotelConsumibleFacturado(trim, anio);
        }

        public List<HotelEstadistica> EstadisticaTopHotelDiasOut(string trim, int anio)
        {
            return estadisticaDao.EstadisticaTopHotelDiasOut(trim, anio);
        }

        public List<HabitacionEstadistica> EstadisticaTopHabitacionVecesOcupadas(string trim, int anio)
        {
            return estadisticaDao.EstadisticaTopHabitacionVecesOcupadas(trim, anio);
        }

        public List<ClientesEstadistica> EstadisticaTopClientes(string trim, int anio)
        {
            return estadisticaDao.EstadisticaTopClientes(trim, anio);
        }
    }
}
