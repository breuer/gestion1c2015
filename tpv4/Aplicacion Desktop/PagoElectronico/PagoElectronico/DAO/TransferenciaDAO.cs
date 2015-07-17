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
    class TransferenciaDAO : Repository
    {
        public DataTable buscar_cuentas(String cuentaBuscar)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("cuentaNum", cuentaBuscar));

            DataTable data = new DataTable();
            data = list("NEW_SOLUTION.sp_buscar_cta_num", parametros);

            return data;
        }

        public DataTable buscar_cuentas_usuario(Usuario user)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("cli_Id", user.Id));

            DataTable data = new DataTable();
            data = list("NEW_SOLUTION.sp_buscar_cta_idcli_disponibles", parametros);

            return data;
        }
        
        public int hacer_transferencia(String ctaOrigen,String ctaDestino,float importe)
        { 
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("ctaOrigenId", ctaOrigen));
            parametros.Add(new SqlParameter("ctaDestinoId", ctaDestino));            
            parametros.Add(new SqlParameter("importe", importe));
            parametros.Add(new SqlParameter("idmoneda", 1));
            parametros.Add(new SqlParameter("fechaSys", get_date()));            
            int resu = callProcedure("NEW_SOLUTION.sp_cuenta_hacer_transferencia", parametros);
            return resu;
        }
    }
}
