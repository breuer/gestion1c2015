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
    class TipoIdentificacionDAO : Repository, IDAO<TipoIdentificacion>
    {
        #region IDAO<TipoIdentificacion> Members

        public void add(TipoIdentificacion obj)
        {
            throw new NotImplementedException();
        }

        public void update(TipoIdentificacion obj)
        {
            throw new NotImplementedException();
        }

        public void get(TipoIdentificacion obj)
        {
            throw new NotImplementedException();
        }

        public List<TipoIdentificacion> getAll(TipoIdentificacion obj)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            DataTable table = list("NEW_SOLUTION.sp_tipo_identificacion_get", parametros);
            List<TipoIdentificacion> tipoIdentificaciones = new List<TipoIdentificacion>();
            foreach (DataRow row in table.Rows)
            {
                TipoIdentificacion tipoIdentificacion = new TipoIdentificacion();
                tipoIdentificacion.Id = int.Parse(row["tdoc_cod"].ToString());
                tipoIdentificacion.Nombre = row["tdoc_descrip"].ToString();
                tipoIdentificaciones.Add(tipoIdentificacion);
            }
            return tipoIdentificaciones;
        }

        #endregion
    }
}
