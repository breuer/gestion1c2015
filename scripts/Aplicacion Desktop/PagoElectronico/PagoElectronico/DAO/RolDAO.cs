using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PagoElectronico.Model;
using System.Data.SqlClient;
using System.Data;

namespace PagoElectronico.DAO
{
    public class RolDAO : Repository, IDAO<Rol>
    {
        #region IDAO<Rol> Members

        public void add(Rol obj)
        {
            throw new NotImplementedException();
        }

        public void update(Rol obj)
        {
            throw new NotImplementedException();
        }

        public void get(Rol obj)
        {
            throw new NotImplementedException();
        }

        public List<Rol> getAll(Rol obj)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("idusuario", obj.IdUsuario));
            DataTable table = list("NEW_SOLUTION.SP_ROL_GET", parametros);
            List<Rol> roles = new List<Rol>();
            foreach (DataRow row in table.Rows)
            {
                Rol rol = new Rol();
                rol.Id = int.Parse(row["idrol"].ToString());
                rol.Nombre = row["nombre"].ToString();
                /*parametros.Clear();
                parametros.Add(new SqlParameter("codigo_rol", rol.Codigo));
                DataTable tableFuncionalidad = list("HEMINGWAY.SP_GET_FUNCIONALIDAD", parametros);
                rol.Funcionalidades = new List<FuncionalidadDTO>();
                foreach (DataRow rowFuncionalidad in tableFuncionalidad.Rows)
                {
                    FuncionalidadDTO funcionalidad = new FuncionalidadDTO();
                    funcionalidad.Codigo = rowFuncionalidad["codigo"].ToString();
                    funcionalidad.Descripcion = rowFuncionalidad["descripcion"].ToString();
                    rol.Funcionalidades.Add(funcionalidad);
                }*/
                roles.Add(rol);
            }
            return roles;
        }

        #endregion
    }
}
