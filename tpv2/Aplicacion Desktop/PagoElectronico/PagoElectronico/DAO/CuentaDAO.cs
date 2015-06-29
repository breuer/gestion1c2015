using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PagoElectronico.Model;
using System.Data.SqlClient;
using System.Data;

namespace PagoElectronico.DAO
{
    class CuentaDAO : Repository, IDAO<Cuenta>
    {
        #region IDAO<Cuenta> Members

        public void add(Cuenta obj)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("clienteId", obj.clienteId));
            parametros.Add(new SqlParameter("paisApertura", obj.paisApertura));
            parametros.Add(new SqlParameter("moneda", obj.moneda));
            parametros.Add(new SqlParameter("categoria", obj.categoria));
            parametros.Add(new SqlParameter("estado", obj.estado));
            int result = callProcedure("NEW_SOLUTION.SP_CUENTA_ADD", parametros);
           
        }

        public void update(Cuenta obj)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("numero", obj.numero));
            parametros.Add(new SqlParameter("clienteId", obj.clienteId));
            parametros.Add(new SqlParameter("paisApertura", obj.paisApertura));
            parametros.Add(new SqlParameter("moneda", obj.moneda));
            parametros.Add(new SqlParameter("cateAnt", obj.categoria));
            parametros.Add(new SqlParameter("cateNva", obj.categoria));
            int result = callProcedure("NEW_SOLUTION.SP_CUENTA_UPD", parametros);

        }

        public void delete(Cuenta obj)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("numero", obj.numero));
            parametros.Add(new SqlParameter("clienteId", obj.clienteId));
            parametros.Add(new SqlParameter("paisApertura", obj.paisApertura));
            parametros.Add(new SqlParameter("moneda", obj.moneda));
            parametros.Add(new SqlParameter("categoria", obj.categoria));
            int result = callProcedure("NEW_SOLUTION.SP_CUENTA_DEL", parametros);
        }

        public void get(Cuenta obj)
        {
            throw new NotImplementedException();
        }

        public List<Cuenta> getAll(Cuenta obj)
        {
            var parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("numero", obj.numero));
            parametros.Add(new SqlParameter("clienteId", obj.clienteId));
            parametros.Add(new SqlParameter("paisApertura", obj.paisApertura));
            parametros.Add(new SqlParameter("moneda", obj.moneda));
            parametros.Add(new SqlParameter("categoria", obj.categoria));
            parametros.Add(new SqlParameter("estado", obj.estado));
            var cuentaTable = list("NEW_SOLUTION.sp_cuenta_get", parametros);
            var cuentas = new List<Cuenta>();
            if (cuentaTable != null)
            {
                foreach (DataRow row in cuentaTable.Rows)
                {
                    var cuenta = new Cuenta();
                    cuenta.numero = int.Parse(row["cta_num"].ToString());
                    cuenta.clienteId = int.Parse(row["cta_cli_id"].ToString());
                    cuenta.paisApertura = row["cta_pais_apertura"].ToString();
                    cuenta.moneda = row["cta_moneda"].ToString();
                    cuenta.categoria = row["cta_tipo"].ToString();
                    cuenta.estado = row["cta_estado"].ToString();

                    cuentas.Add(cuenta);
                }
            }
            return cuentas;
        }

        #endregion
    }
}
