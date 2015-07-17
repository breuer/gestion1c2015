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
            parametros.Add(new SqlParameter("id_usuario", obj.IdUsuario));
            parametros.Add(new SqlParameter("calle", obj.Calle));
            parametros.Add(new SqlParameter("numero", obj.NroCalle.ToString()));
            parametros.Add(new SqlParameter("piso", int.Parse(obj.NroPiso)));
            parametros.Add(new SqlParameter("depto", obj.Depto));
            parametros.Add(new SqlParameter("localidad", obj.Localidad));
            parametros.Add(new SqlParameter("fecnac", Convert.ToDateTime(obj.FechaNacimiento.ToString())));

            int result = callProcedure("NEW_SOLUTION.sp_cliente_add", parametros);

            if (result == 1)
                MessageBox.Show("El cliente se ha guardado correctamente");
            else
                MessageBox.Show("El cliente no se ha podido guardar");
        }

        public void update(Cliente obj)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("id", obj.Id));
            parametros.Add(new SqlParameter("nombre", obj.Nombre));
            parametros.Add(new SqlParameter("apellido", obj.Apellido));
            parametros.Add(new SqlParameter("mail", obj.Mail));
            parametros.Add(new SqlParameter("tipo_documento", obj.TipoDeIdentificacionCod));
            parametros.Add(new SqlParameter("documento", obj.Identificacion));
            parametros.Add(new SqlParameter("nacionalidad", obj.PaisCod));
            parametros.Add(new SqlParameter("estado", obj.Activo ? 1 : 0));
            parametros.Add(new SqlParameter("calle", obj.Calle));
            parametros.Add(new SqlParameter("numero", obj.NroCalle.ToString()));
            parametros.Add(new SqlParameter("piso", int.Parse(obj.NroPiso)));
            parametros.Add(new SqlParameter("depto", obj.Depto));
            parametros.Add(new SqlParameter("localidad", obj.Localidad));
            parametros.Add(new SqlParameter("fecnac", Convert.ToDateTime(obj.FechaNacimiento.ToString())));

            int result = callProcedure("NEW_SOLUTION.sp_cliente_update", parametros);

            if (result==1)
                MessageBox.Show("El cliente se ha guardado correctamente");
            else
                MessageBox.Show("El cliente no se ha podido guardar");
        }

        public void get(Cliente cliente)
        {
            var parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("cliente_id", cliente.Id));       
            var table = list("NEW_SOLUTION.sp_cliente_get", parametros);

            foreach (DataRow row in table.Rows)
            {
                cliente.Apellido                = row["cli_apellido"].ToString();
                cliente.Nombre                  = row["cli_nombre"].ToString();
                cliente.Mail                    = row["cli_mail"].ToString();
                cliente.Identificacion          = int.Parse(row["cli_ndoc"].ToString());
                cliente.TipoDeIdentificacionCod = int.Parse(row["cli_tdoc"].ToString());
                cliente.PaisCod                 = int.Parse(row["cli_nacionalidad"].ToString());
                cliente.Activo                  = int.Parse(row["cli_estado"].ToString()) != 0;
                cliente.IdUsuario               = int.Parse(row["usu_id"].ToString());
                cliente.Calle                   = row["cli_calle"].ToString();
                cliente.NroCalle                = row["cli_numero"].ToString();
                cliente.Depto                   = row["cli_depto"].ToString();
                cliente.Localidad               = row["cli_localidad"].ToString();
                cliente.NroPiso                 = row["cli_piso"].ToString();
                cliente.FechaNacimiento         = row["cli_fecnac"].ToString();
             }
        }

        public List<Cliente> getAll(Cliente obj)
        {
            var parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("nombre", obj.Nombre));
            parametros.Add(new SqlParameter("apellido", obj.Apellido));
            parametros.Add(new SqlParameter("mail", obj.Mail));
            parametros.Add(new SqlParameter("identificacion", obj.Identificacion));
            parametros.Add(new SqlParameter("tipo_identificacion", obj.TipoDeIdentificacionCod));
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
                    cliente.Activo = int.Parse(row["cli_estado"].ToString()) != 0;
                    clientes.Add(cliente);
                }
            }
            return clientes;
        }

        #endregion
    }
}
