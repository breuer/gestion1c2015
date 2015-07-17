using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PagoElectronico.Model;
using System.Security.Cryptography;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace PagoElectronico.DAO
{
    class SaldoDAO : Repository
    {
            public DataTable buscar_cuentas_usuario_validas(Usuario user)
            {
                List<SqlParameter> parametros = new List<SqlParameter>();
                parametros.Add(new SqlParameter("cli_Id", user.Id));

                DataTable data = new DataTable();
                data = list("NEW_SOLUTION.sp_buscar_cta_cli_activa", parametros);

                return data;
            }

            public DataTable consulta_movimientos(String cta_id)
            {
                List<SqlParameter> parametros = new List<SqlParameter>();
                parametros.Add(new SqlParameter("ctaID", cta_id));

                DataTable data = new DataTable();
                data = list("NEW_SOLUTION.sp_cta_movimientos", parametros);

                return data;
            }

            public DataTable saldo_actual(String cta_id)
            {
                List<SqlParameter> parametros = new List<SqlParameter>();
                parametros.Add(new SqlParameter("ctaID", cta_id));

                DataTable data = new DataTable();
                data = list("NEW_SOLUTION.consultar_saldo_cta_id", parametros);

                return data;
            }

            public DataTable buscar_cuentas_num(String cuentaBuscar)
            {
                List<SqlParameter> parametros = new List<SqlParameter>();
                parametros.Add(new SqlParameter("cuentaNum", cuentaBuscar));

                DataTable data = new DataTable();
                data = list("NEW_SOLUTION.sp_buscar_cta_num", parametros);

                return data;
            }
    }
}
