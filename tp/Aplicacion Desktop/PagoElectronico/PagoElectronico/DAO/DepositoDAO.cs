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
    class DepositoDAO : Repository
    {    
        public DataTable buscar_cuentas_usuario_validas(Usuario user)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("cli_Id", user.Id));

            DataTable data = new DataTable();
            data = list("NEW_SOLUTION.sp_buscar_cta_idcli_disponibles", parametros);

            return data;
        }

        public DataTable buscar_tarjetas_usuario_validas(Usuario user)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("userID", user.Id));
            parametros.Add(new SqlParameter("fechaSYS", get_date()));

            DataTable data = new DataTable();
            data = list("NEW_SOLUTION.sp_traer_tarjetas_user_id", parametros);

            return data;
        }

        public int cuenta_retirar_saldo(Int64 ctaID,int moneda,Int64 tarjid,float importe)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("ctaID", ctaID));
            parametros.Add(new SqlParameter("importe", importe));
            parametros.Add(new SqlParameter("moneda", moneda));
            parametros.Add(new SqlParameter("tarjId", tarjid));
            parametros.Add(new SqlParameter("fechaSys", get_date()));

            return callProcedure("NEW_SOLUTION.cuenta_depositar", parametros);        
        }
    }
}
