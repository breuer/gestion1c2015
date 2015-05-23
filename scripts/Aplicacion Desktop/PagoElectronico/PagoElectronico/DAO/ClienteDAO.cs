using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PagoElectronico.Model;
using System.Data.SqlClient;

namespace PagoElectronico.DAO
{
    class ClienteDAO : Repository, IDAO<Cliente>
    {
        #region IDAO<Cliente> Members

        public void add(Cliente obj)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("nombre", obj.Nombre));
            parametros.Add(new SqlParameter("apellido", obj.Apellido));
            parametros.Add(new SqlParameter("mail", obj.Mail));
            int result = callProcedure("NEW_SOLUTION.SP_CLIENTE_ADD", parametros);
           
        }

        public void update(Cliente obj)
        {
            throw new NotImplementedException();
        }

        public void get(Cliente obj)
        {
            throw new NotImplementedException();
        }

        public List<Cliente> getAll(Cliente obj)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
