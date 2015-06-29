using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrbaHotel.ClasesTabla
{
    class SFuncion
    {
        private DFuncion _funcionDao;
        private DFuncion funcionDao
        {
            get
            {
                if (_funcionDao == null)
                    _funcionDao = new DFuncion();
                return _funcionDao;
            }
        }

        public Funcion GetByCod(int codigo)
        {
            return funcionDao.GetByCod(codigo);
        }

        public List<Funcion> GetAll()
        {
            return funcionDao.GetAll();
        }

        public List<Funcion> GetBySQL(string consulta)
        {
            return funcionDao.GetBySQL(consulta);
        }

        public List<Funcion> GetRolPorFuncion(int cod_rol)
        {
            return funcionDao.GetRolPorFuncion(cod_rol);
        }

        public void DeleteAllByCodRol(decimal codRol)
        {
            funcionDao.DeleteAllByCodRol(codRol);
        }

        internal void SaveCodRol(decimal codRol, decimal codFunc)
        {
            funcionDao.SaveCodRol(codRol, codFunc);
        }
    }
}
