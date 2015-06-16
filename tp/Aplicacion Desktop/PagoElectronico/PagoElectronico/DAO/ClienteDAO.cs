using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PagoElectronico.Model;
using System.Data.SqlClient;
using System.Data;

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
            var parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("nombre", obj.Nombre));
            parametros.Add(new SqlParameter("apellido", obj.Apellido));
            parametros.Add(new SqlParameter("mail", obj.Mail));
            parametros.Add(new SqlParameter("identificacion", obj.Identificacion));
            parametros.Add(new SqlParameter("tipo_identificacion", obj.TipoDeIdentificacion.Id));
            var clienteTable = list("NEW_SOLUTION.sp_cliente_get", parametros);
            var clientes = new List<Cliente>();
            if (clienteTable != null)
            {
                foreach (DataRow row in clienteTable.Rows)
                {
                    var cliente = new Cliente();
                    cliente.Id = int.Parse(row["cli_id"].ToString());
                    cliente.Apellido = row["cli_apellido"].ToString();
                    cliente.Nombre = row["cli_nombre"].ToString();
                    cliente.Mail = row["cli_mail"].ToString();
                    cliente.Identificacion = int.Parse(row["cli_ndoc"].ToString());
                    //cliente.CodigoTipoIdentificacion = row["codigo_tipo_identificacion"].ToString();
                    cliente.Activo = char.Parse(row["cli_estado"].ToString()) == 's';

                    clientes.Add(cliente);
                }
            }
            return clientes;
        }

        #endregion
    }
}
