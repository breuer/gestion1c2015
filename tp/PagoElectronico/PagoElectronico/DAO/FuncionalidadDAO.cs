using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using PagoElectronico.Model;

namespace PagoElectronico.DAO
{
    class FuncionalidadDAO : Repository, IDAO<Funcionalidad>
    {
        #region IDAO<Funcionalidad> Members

        public void add(Funcionalidad obj)
        {
            throw new NotImplementedException();
        }

        public void update(Funcionalidad obj)
        {
            throw new NotImplementedException();
        }

        public void get(Funcionalidad obj)
        {
            throw new NotImplementedException();
        }

        public List<Funcionalidad> getAll(Funcionalidad obj)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("rol_id", obj.IdRol));
            DataTable table = list("NEW_SOLUTION.sp_funcionalidad_get", parametros);
            List<Funcionalidad> funcionalidades = new List<Funcionalidad>();
            foreach (DataRow row in table.Rows)
            {
                Funcionalidad funcionalidad = new Funcionalidad();
                funcionalidad.Id = int.Parse(row["func_id"].ToString());
                funcionalidad.Nombre = row["func_nombre"].ToString();
                funcionalidades.Add(funcionalidad);
            }
            return funcionalidades;
        }

        #endregion
    }
}
