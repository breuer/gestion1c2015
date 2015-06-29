using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrbaHotel.ClasesTabla
{
    class SUsuario
    {
        private DUsuario _userDao;
        private DUsuario userDao
        {
            get
            {
                if (_userDao == null)
                    _userDao = new DUsuario();
                return _userDao;
            }
        }

        public List<Usuario> GetAllActivos()
        {
            return userDao.GetAllActivos();
        }

        public List<UsuarioDTO> GetBySQLGRID(string consulta)
        {
            return userDao.GetBySQLGRID(consulta);
        }
        
        public Usuario GetByCod(decimal codigo)
        {
            return userDao.GetByCod(codigo);
        }

        public Usuario GetByUser(string username)
        {
            return userDao.GetByUser(username);
        }

        public List<Usuario> GetAll()
        {
            return userDao.GetAll();
        }

        public List<Usuario> GetBySQL(string consulta)
        {
            return userDao.GetBySQL(consulta);
        }

        public decimal Save(Usuario user)
        {
            return userDao.Save(user);
        }

        public decimal Update(Usuario user)
        {
           return userDao.Update(user);
        }

        public void Delete(decimal codigo)
        {
            userDao.Delete(codigo);
        }

        internal void DeleteAllByCodUser(decimal codUsuario)
        {
            userDao.DeleteAllByCodUser(codUsuario);
        }
    }
}
