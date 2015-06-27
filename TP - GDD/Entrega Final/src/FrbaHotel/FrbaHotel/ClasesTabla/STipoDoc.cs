using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrbaHotel.ClasesTabla
{
    class STipoDoc
    {
        private DTipoDoc _tipoDao;
        private DTipoDoc tipoDao
        {
            get
            {
                if (_tipoDao == null)
                    _tipoDao = new DTipoDoc();
                return _tipoDao;
            }
        }

        public List<TipoDoc> GetAll()
        {
            return tipoDao.GetAll();
        }

        public List<TipoDoc> GetAllWithNull()
        {
            return tipoDao.GetAllWithNull();
        }

        public List<TipoDoc> GetBySQL(string consulta)
        {
            return tipoDao.GetBySQL(consulta);
        }

        public TipoDoc getByCod(decimal codigo)
        {
            return tipoDao.GetByCod(codigo);
        }

    }
}
