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
            parametros.Add(new SqlParameter("clienteId", obj.ClienteId));
            parametros.Add(new SqlParameter("paisApertura", obj.PaisApertura));
            parametros.Add(new SqlParameter("moneda", obj.Moneda));
            parametros.Add(new SqlParameter("categoria", obj.Categoria));
            parametros.Add(new SqlParameter("estado", obj.Estado));
            int result = callProcedure("NEW_SOLUTION.SP_CUENTA_ADD", parametros);
        }

        public void update(Cuenta obj)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("numero", obj.Numero));
            parametros.Add(new SqlParameter("clienteId", obj.ClienteId));
            parametros.Add(new SqlParameter("paisApertura", obj.PaisApertura));
            parametros.Add(new SqlParameter("moneda", obj.Moneda));
            parametros.Add(new SqlParameter("cateAnt", obj.Categoria));
            parametros.Add(new SqlParameter("cateNva", obj.Categoria));
            int result = callProcedure("NEW_SOLUTION.SP_CUENTA_UPD", parametros);

        }

        public void delete(Cuenta obj)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("numero", obj.Numero));
            parametros.Add(new SqlParameter("clienteId", obj.ClienteId));
            parametros.Add(new SqlParameter("paisApertura", obj.PaisApertura));
            parametros.Add(new SqlParameter("moneda", obj.Moneda));
            parametros.Add(new SqlParameter("categoria", obj.Categoria));
            int result = callProcedure("NEW_SOLUTION.SP_CUENTA_DEL", parametros);
        }

        public void get(Cuenta obj)
        {
            throw new NotImplementedException();
        }

        public List<Cuenta> getAll(Cuenta obj)
        {
            var parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("numero", obj.Numero));
            parametros.Add(new SqlParameter("clienteId", obj.ClienteId));
            parametros.Add(new SqlParameter("paisApertura", obj.PaisApertura));
            parametros.Add(new SqlParameter("moneda", obj.Moneda));
            parametros.Add(new SqlParameter("categoria", obj.Categoria));
            parametros.Add(new SqlParameter("estado", obj.Estado));
            var cuentaTable = list("NEW_SOLUTION.sp_cuenta_get", parametros);
            var cuentas = new List<Cuenta>();
            if (cuentaTable != null)
            {
                foreach (DataRow row in cuentaTable.Rows)
                {
                    var cuenta = new Cuenta();
                    cuenta.Numero = int.Parse(row["cta_num"].ToString());
                    cuenta.ClienteId = int.Parse(row["cta_cli_id"].ToString());
                    cuenta.PaisApertura = row["cta_pais_apertura"].ToString();
                    cuenta.Moneda = row["cta_moneda"].ToString();
                    cuenta.Categoria = row["cta_tipo"].ToString();
                    cuenta.Estado = row["cta_estado"].ToString();

                    cuentas.Add(cuenta);
                }
            }
            return cuentas;
        }

        #endregion
    }
}
