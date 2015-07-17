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
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("nombre", obj.Nombre));
            obj.Id = callProcedure("NEW_SOLUTION.sp_rol_add", parametros);
            foreach (Funcionalidad funcionalidad in obj.Funcionalidades)
            {
                parametros.Clear();
                parametros.Add(new SqlParameter("rol_id", obj.Id));
                parametros.Add(new SqlParameter("funcionalidad_id", funcionalidad.Id));
                callProcedure("NEW_SOLUTION.sp_rol_add_funcionalidad", parametros);
            }
        }

        public void update(Rol obj)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("rol_id", obj.Id));
            parametros.Add(new SqlParameter("nombre", obj.Nombre));
            callProcedure("NEW_SOLUTION.sp_rol_update", parametros);
            foreach (Funcionalidad funcionalidad in obj.Funcionalidades)
            {
                parametros.Clear();
                parametros.Add(new SqlParameter("rol_id", obj.Id));
                parametros.Add(new SqlParameter("funcionalidad_id", funcionalidad.Id));
                callProcedure("NEW_SOLUTION.sp_rol_add_funcionalidad", parametros);
            }
        }

        public void get(Rol obj)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("id_rol", obj.Id));
            DataTable table = list("NEW_SOLUTION.sp_rol_get", parametros);
            List<Rol> roles = new List<Rol>();
            foreach (DataRow rowRol in table.Rows)
            {
                obj.Id = int.Parse(rowRol["rol_id"].ToString());
                obj.Nombre = rowRol["rol_nombre"].ToString();

                Funcionalidad funcionalidad = new Funcionalidad();
                funcionalidad.IdRol = obj.Id;
                obj.Funcionalidades = funcionalidad.getAll();
            }
        }

        public List<Rol> getAll(Rol obj)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("id_usuario", obj.IdUsuario));
            DataTable table = list("NEW_SOLUTION.sp_rol_get", parametros);
            List<Rol> roles = new List<Rol>();
            foreach (DataRow rowRol in table.Rows)
            {
                Rol rol = new Rol();
                rol.Id = int.Parse(rowRol["rol_id"].ToString());
                rol.Nombre = rowRol["rol_nombre"].ToString();

                Funcionalidad funcionalidad = new Funcionalidad();
                funcionalidad.IdRol = rol.Id;
                rol.Funcionalidades = funcionalidad.getAll();
                roles.Add(rol);
            }
            return roles;
        }

        #endregion
    }
}
