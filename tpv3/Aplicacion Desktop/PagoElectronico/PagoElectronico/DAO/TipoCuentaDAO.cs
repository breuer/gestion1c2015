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
    class TipoCuentaDAO : Repository, IDAO<TipoCuenta>
    {
        #region IDAO<TipoCuenta> Members

        public void add(TipoCuenta obj)
        {
            throw new NotImplementedException();
        }

        public void update(TipoCuenta obj)
        {
            throw new NotImplementedException();
        }

        public void get(TipoCuenta obj)
        {
            throw new NotImplementedException();
        }

        public List<TipoCuenta> getAll(TipoCuenta obj)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            DataTable table = list("NEW_SOLUTION.sp_tipo_cuenta_get", parametros);
            List<TipoCuenta> tipoCuentas = new List<TipoCuenta>();
            foreach (DataRow row in table.Rows)
            {
                TipoCuenta tipoCuenta = new TipoCuenta();
                tipoCuenta.Id = int.Parse(row["ctacateg_id"].ToString());
                tipoCuenta.Nombre = row["ctacateg_descrip"].ToString();
                //tipoCuenta.Costo = int.Parse(row["ctacateg_costo"].ToString());
                tipoCuenta.DuracionDias = int.Parse(row["ctacateg_duracion_dias"].ToString());
                tipoCuenta.EstadoInicialCod = int.Parse(row["ctacateg_estado_inicial"].ToString());
                tipoCuentas.Add(tipoCuenta);
            }
            return tipoCuentas;
        }

        #endregion
    }
}
