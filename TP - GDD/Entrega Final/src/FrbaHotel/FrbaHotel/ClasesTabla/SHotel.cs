using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrbaHotel.ClasesTabla
{
    class SHotel
    {
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

            public List<Hotel> GetAllActivos()
            {
                return hotelDao.GetAllActivosCompleto();
            }

            public List<HotelDTO> GetBySQLGRID(string consulta)
            {
                return hotelDao.GetBySQLGRID(consulta);
            }

            public bool hotelOcupado(decimal codHotel, DateTime desde, DateTime hasta)
            {
                return hotelDao.hotelOcupado(codHotel, desde, hasta);
            }

            public bool hotelOcupadoRegimen(decimal codHotel, decimal codReg, DateTime fechaHoy)
            {
                return hotelDao.hotelOcupadoRegimen(codHotel, codReg, fechaHoy);
            }

            public List<Hotel> GetBySQL(string consulta)
            {
                return hotelDao.GetBySQL(consulta);
            }

            public Hotel GetByCod(decimal cod)
            {
                return hotelDao.GetByCod(cod);
            }

            public Hotel GetByDireccion(string direccion)
            {
                return hotelDao.GetByDireccion(direccion);
            }
        
            public decimal Save(Hotel hotel, decimal codUser)
            {
                return hotelDao.Save(hotel, codUser);
            }

            public void SaveCancelacion(CancelacionHotel CancHotel)
            {
                hotelDao.SaveCancelacion(CancHotel);
            }

            public decimal Update(Hotel hotel)
            {
                return hotelDao.Update(hotel);
            }

            public void Delete(int codigo)
            {
                hotelDao.Delete(codigo);
            }
    }
}
