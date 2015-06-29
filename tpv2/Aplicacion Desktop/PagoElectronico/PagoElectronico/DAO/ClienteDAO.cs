using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PagoElectronico.Model;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

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
            parametros.Add(new SqlParameter("tipo_documento", obj.TipoDeIdentificacionCod));
            parametros.Add(new SqlParameter("documento", obj.Identificacion));
            parametros.Add(new SqlParameter("nacionalidad", obj.PaisCod));
            int result = callProcedure("NEW_SOLUTION.sp_cliente_add", parametros);
            obj.Usuario.IdCliente = result;
            obj.Usuario.update();
           
        }

        public void update(Cliente obj)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("id", obj.Id));
            parametros.Add(new SqlParameter("nombre", obj.Nombre));
            parametros.Add(new SqlParameter("apellido", obj.Apellido));
            //parametros.Add(new SqlParameter("mail", obj.Mail));
            parametros.Add(new SqlParameter("tipo_documento", obj.TipoDeIdentificacionCod));
            parametros.Add(new SqlParameter("documento", obj.Identificacion));
            parametros.Add(new SqlParameter("nacionalidad", obj.PaisCod));
            parametros.Add(new SqlParameter("estado", obj.Activo ? "s" : "n"));
            int result = callProcedure("NEW_SOLUTION.sp_cliente_update", parametros);
        }

        public void get(Cliente cliente)
        {
            var parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("cliente_id", cliente.Id));
            //MessageBox.Show("id "+cliente.Id);
            var table = list("NEW_SOLUTION.sp_cliente_get", parametros);
            foreach (DataRow row in table.Rows)
            {
                
                cliente.Apellido = row["cli_apellido"].ToString();
                cliente.Nombre = row["cli_nombre"].ToString();
                cliente.Mail = row["cli_mail"].ToString();
                cliente.Identificacion = int.Parse(row["cli_ndoc"].ToString());
                cliente.TipoDeIdentificacionCod = int.Parse(row["cli_tdoc"].ToString());
                cliente.PaisCod = int.Parse(row["cli_nacionalidad"].ToString());
                cliente.Usuario = new Usuario();
                cliente.Usuario.Id = int.Parse(row["usu_id"].ToString());
                cliente.Usuario.get();
                //MessageBox.Show("us id" + cliente.Usuario.Id);
               /* foreach(TipoIdentificacion ti in DataSession.TipoIdentificaciones)
                {
                    if (ti.Id == int.Parse(row["cli_tdoc"].ToString()) )
                        cliente.TipoDeIdentificacion = ti;
                }*/
               //cliente.CodigoTipoIdentificacion = row["codigo_tipo_identificacion"].ToString();
                //cliente.Activo = char.Parse(row["cli_estado"].ToString()) == 's';
             }
        }

        public List<Cliente> getAll(Cliente obj)
        {
            var parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("nombre", obj.Nombre));
            parametros.Add(new SqlParameter("apellido", obj.Apellido));
            parametros.Add(new SqlParameter("mail", obj.Mail));
            parametros.Add(new SqlParameter("identificacion", obj.Identificacion));
            //parametros.Add(new SqlParameter("tipo_identificacion", obj.TipoDeIdentificacion.Id));
            var clienteTable = list("NEW_SOLUTION.sp_cliente_get", parametros);
            var clientes = new List<Cliente>();
            if (clienteTable != null)
            {
                foreach (DataRow row in clienteTable.Rows)
                {
                    var cliente = new Cliente();
                    cliente.Id = long.Parse(row["cli_id"].ToString());
                    cliente.Apellido = row["cli_apellido"].ToString();
                    cliente.Nombre = row["cli_nombre"].ToString();
                    cliente.Mail = row["cli_mail"].ToString();
                    cliente.Identificacion = int.Parse(row["cli_ndoc"].ToString());
                    cliente.TipoDeIdentificacionCod = int.Parse(row["cli_tdoc"].ToString());
                    cliente.Activo = char.Parse(row["cli_estado"].ToString()) == 's';

                    clientes.Add(cliente);
                }
            }
            return clientes;
        }

        #endregion
    }
}
