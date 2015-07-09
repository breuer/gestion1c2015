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
    class CuentaDAO : Repository, IDAO<Cuenta>
    {
        #region IDAO<Cuenta> Members

        public void add(Cuenta obj)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("cliente_id", obj.ClienteId));
            parametros.Add(new SqlParameter("cuenta_nro", obj.Numero));
            parametros.Add(new SqlParameter("pais_cod", obj.PaisCod));
            parametros.Add(new SqlParameter("moneda_cod", obj.MonedaCod));
            parametros.Add(new SqlParameter("tipo_cuenta_cod", obj.TipoCuentaCod));
            parametros.Add(new SqlParameter("fecha_apertura", obj.FechaApertura.ToString(formatDateTime)));
            int result = callProcedure("NEW_SOLUTION.sp_cuenta_add", parametros);
        }

        public void update(Cuenta obj)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("cuenta_nro", obj.Numero));
            parametros.Add(new SqlParameter("tipo_cuenta_cod", obj.TipoCuentaCod));
            int result = callProcedure("NEW_SOLUTION.sp_cuenta_update", parametros);
        }

        public void delete(Cuenta obj)
        {
            
        }

        public void get(Cuenta cuenta)
        {
            var parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("cuenta_id", cuenta.Id));
            var cuentaTable = list("NEW_SOLUTION.sp_cuenta_get", parametros);
            var cuentas = new List<Cuenta>();
            foreach (DataRow row in cuentaTable.Rows)
            {
                cuenta.Numero = long.Parse(row["cta_num"].ToString());
                cuenta.ClienteId = long.Parse(row["cta_cli_id"].ToString());
                cuenta.PaisCod = int.Parse(row["cta_pais_apertura"].ToString());
                cuenta.MonedaCod = int.Parse(row["cta_moneda"].ToString());
                cuenta.TipoCuentaCod = int.Parse(row["cta_tipo"].ToString());
                cuenta.EstadoCuentaCod = int.Parse(row["cta_estado"].ToString());
                cuenta.FechaApertura = DateTime.Parse(row["cta_fecha_apertura"].ToString());
            }
        }

        public List<Cuenta> getAll(Cuenta obj)
        {
            var parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("cliente_id", obj.ClienteId));
            var cuentaTable = list("NEW_SOLUTION.sp_cuenta_get", parametros);
            var cuentas = new List<Cuenta>();
            foreach (DataRow row in cuentaTable.Rows)
            {

                var cuenta = new Cuenta();
                cuenta.Id = long.Parse(row["cta_id"].ToString());
                cuenta.Numero = long.Parse(row["cta_num"].ToString());
                cuenta.PaisCod = int.Parse(row["cta_pais_apertura"].ToString());
                cuenta.MonedaCod = int.Parse(row["cta_moneda"].ToString());
                cuenta.TipoCuentaCod = int.Parse(row["cta_tipo"].ToString());
                cuenta.EstadoCuentaCod = int.Parse(row["cta_estado"].ToString());
                cuenta.FechaApertura = DateTime.Parse(row["cta_fecha_apertura"].ToString());
               cuentas.Add(cuenta);                
            }
            return cuentas;
        }

        #endregion

        public long getNuevoNumeroCuenta()
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            long result = 0;
            var table = list("NEW_SOLUTION.sp_cuenta_get_nuevo_numero_cuenta", parametros);
            foreach (DataRow row in table.Rows)
            {
                result = long.Parse(row["numero_cuenta"].ToString());
            }
            return result;
        }


        public List<EstadoCuenta> getEstadosCuenta()
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            var table = list("NEW_SOLUTION.sp_cuenta_get_estados", parametros);
            var estados = new List<EstadoCuenta>();
            foreach (DataRow row in table.Rows)
            {
                var estadoCuenta = new EstadoCuenta();
                estadoCuenta.Id = int.Parse(row["cta_estado_id"].ToString());
                estadoCuenta.Nombre = row["cta_estado_descrip"].ToString();
                estados.Add(estadoCuenta);
            }
            return estados;
        }
    }
}
