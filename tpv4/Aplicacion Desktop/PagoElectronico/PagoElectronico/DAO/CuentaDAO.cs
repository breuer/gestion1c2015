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

        public void add(Cuenta cuenta)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            //MessageBox.Show("obj.ClienteId: " + cuenta.ClienteId);
            parametros.Add(new SqlParameter("cliente_id", cuenta.ClienteId));
            parametros.Add(new SqlParameter("cuenta_nro", cuenta.Numero));
            parametros.Add(new SqlParameter("pais_cod", cuenta.PaisCod));
            parametros.Add(new SqlParameter("moneda_cod", cuenta.MonedaCod));
            parametros.Add(new SqlParameter("tipo_cuenta_cod", cuenta.TipoCuentaCod));
            parametros.Add(new SqlParameter("fecha_apertura", cuenta.FechaApertura.ToString(formatDateTime)));
            parametros.Add(new SqlParameter("cant_subscripciones", cuenta.CantSubscripciones));
            //parametros.Add(new SqlParameter("fecha_vencimiento", cuenta.FechaVencimiento.ToString(formatDateTime)));
            int result = callProcedure("NEW_SOLUTION.sp_cuenta_add", parametros);
        }

        public void update(Cuenta cuenta)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("cuenta_nro", cuenta.Numero));
            parametros.Add(new SqlParameter("tipo_cuenta_cod", cuenta.TipoCuentaCod));
            parametros.Add(new SqlParameter("fecha_operacion", DataSession.FechaSistema.ToString(formatDateTime)));
            parametros.Add(new SqlParameter("cant_subscripciones", cuenta.CantSubscripciones));
            parametros.Add(new SqlParameter("tipo_moneda_cod", cuenta.MonedaCod));
            parametros.Add(new SqlParameter("estado_cuenta_cod", cuenta.EstadoCuentaCod));
            int result = callProcedure("NEW_SOLUTION.sp_cuenta_update", parametros);
        }

        public void cerrar(Cuenta cuenta)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("cuenta_nro", cuenta.Numero));
            parametros.Add(new SqlParameter("fecha_operacion", DataSession.FechaSistema.ToString(formatDateTime)));
            parametros.Add(new SqlParameter("estado_cuenta_cod", cuenta.EstadoCuentaCod));
            int result = callProcedure("NEW_SOLUTION.sp_cuenta_cerrar", parametros);
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
                cuenta.Saldo = float.Parse(row["cta_saldo"].ToString());
                cuenta.CantSubscripciones = int.Parse(row["cta_num_suscrip"].ToString());

                if (row["cta_fecha_vencimiento"].ToString() != "")
                    cuenta.FechaVencimiento = DateTime.Parse(row["cta_fecha_vencimiento"].ToString());
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
                cuenta.Saldo = float.Parse(row["cta_saldo"].ToString());
                cuenta.CantSubscripciones = int.Parse(row["cta_num_suscrip"].ToString());
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

        public void actualizarEstados(Cuenta cuenta)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("fecha_sistema", cuenta.FechaSistema.ToString(formatDateTime)));
            //MessageBox.Show(cuenta.FechaSistema.ToString(formatDateTime));
            callProcedure("NEW_SOLUTION.sp_cuenta_actualizar_estados", parametros);
        }

        public void actualizarCuentas(Cuenta cuenta)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("fecha_sistema", cuenta.FechaSistema.ToString(formatDateTime)));
            parametros.Add(new SqlParameter("tipo_cuenta", cuenta.TipoCuentaCod));
            callProcedure("NEW_SOLUTION.sp_cuenta_actualizar_fechas_vto", parametros);
        }
    }
}
