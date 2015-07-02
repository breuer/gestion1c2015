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
    class RetiroDAO : Repository
    {
        public DataTable buscar_cuentas_usuario_validas(Usuario user)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("cli_Id", user.Id));

            DataTable data = new DataTable();
            data = list("NEW_SOLUTION.sp_buscar_cta_idcli_disponibles", parametros);

            return data;
        }

        public DataTable listar_bancos()
        { 
            DataTable data = new DataTable();
            List<SqlParameter> parametros = new List<SqlParameter>();
            data = list("NEW_SOLUTION.sp_traer_bancos", parametros);

            return data;        
        }

        public int validar_id_dni(Usuario user, String ndoc)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("usu_id", user.Id));
            parametros.Add(new SqlParameter("ndoc" , ndoc));

            return callProcedure("NEW_SOLUTION.sp_valida_id_dni", parametros);;        
        }
       
        public int retirar(String ctaID,String codBco,float importe)
        { 
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("ctaID", ctaID));
            parametros.Add(new SqlParameter("importe", importe));
            parametros.Add(new SqlParameter("codBco", codBco));
            parametros.Add(new SqlParameter("fechaSys", get_date()));
            int resu = callProcedure("NEW_SOLUTION.sp_cuenta_retirar", parametros);
            return resu;
        }
    }
}
