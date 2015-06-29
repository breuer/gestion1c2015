using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrbaHotel.ClasesTabla
{
    class STipoHab
    {
        private DTipoHab _tipoHab;
        private DTipoHab tipoHab
        {
            get
            {
                if (_tipoHab == null)
                    _tipoHab = new DTipoHab();
                return _tipoHab;
            }
        }

        /* Obtiene todos los tipos de habitaciones disponibles en la aplicacion */
        public List<TipoHab> GetAll()
        {
            return tipoHab.GetAll();
        }

        /* Obtiene los regimenes disponibles en el hotel */
        public List<Regimen> GetRegimenesByHotel(String hotel)
        {
            return tipoHab.GetRegimenesByHotel(hotel);
        }

        /* Obtiene los regimenes disponibles en el hotel */
        public List<Regimen> GetRegimenesByHotelHabilitados(String hotel)
        {
            return tipoHab.GetRegimenesByHotelHabilitados(hotel);
        }

        /* Para el listado vuelve con un item nulo de "seleccione" */
        public List<Regimen> GetRegimenesByHotelWithNull(String hotel)
        {
            return tipoHab.GetRegimenesByHotelWithNull(hotel);
        }

        /* Obtiene los tipos de habitaciones que hayan en el hotel */
        public List<TipoHab> GetTipoHabByHotel(String hotel)
        {
            return tipoHab.GetTipoHabByHotel(hotel);
        }
    }
}