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
    class TarjetaDAO : Repository
    {
        public DataTable traer_tarjetas_vinculadas_usuario(Usuario user)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("usuId", user.Id));

            DataTable data = new DataTable();
            data = list("NEW_SOLUTION.sp_traer_tarjetas_vinculadas_userid", parametros);

            return data;
        }

        public DataTable traer_tarjeta_id(Int64 tarjID)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@tarjID", tarjID));

            DataTable data = new DataTable();
            data = list("NEW_SOLUTION.sp_traer_tarjeta_id", parametros);

            return data;
        }

        public DataTable traer_emisores_tarjetas()
        {
            List<SqlParameter> parametros = new List<SqlParameter>();

            DataTable data = new DataTable();
            data = list("NEW_SOLUTION.sp_emisores_tarjetas_listar", parametros);

            return data;
        }

        public void editar_tarjeta(int tarjid,string num, int emisor, string emisorFEC, string vencimientoFEC, string codseg)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("tarjNum", num));
            parametros.Add(new SqlParameter("tarjFecEmis", emisorFEC));
            parametros.Add(new SqlParameter("tarjVenc", vencimientoFEC));
            parametros.Add(new SqlParameter("tarjSeg", codseg));
            parametros.Add(new SqlParameter("tarjEmis", emisor));
            parametros.Add(new SqlParameter("tarjID", tarjid));

            callProcedure("NEW_SOLUTION.sp_actualizar_tarjeta", parametros);
        }

        public void desvincular_tarjeta(int tarjID)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("tarjID", tarjID));

            callProcedure("NEW_SOLUTION.sp_desvincular_tarjeta", parametros);
        }
    
        public void vincular_tarjeta(string num,int emisor,string emisorFEC,string vencimientoFEC ,string codseg,int usuID)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("tarjNum", num));
            parametros.Add(new SqlParameter("tarjFecEmis", emisorFEC));
            parametros.Add(new SqlParameter("tarjVenc", vencimientoFEC));
            parametros.Add(new SqlParameter("tarjSeg", codseg));
            parametros.Add(new SqlParameter("tarjEmis", emisor));
            parametros.Add(new SqlParameter("usuId", usuID));

           callProcedure("NEW_SOLUTION.sp_vincular_tarjeta", parametros);
        }

        public int existe_tarjeta_emisor_usuario(string num,int emisor,int userid)
        { 
              List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("num", num));
            parametros.Add(new SqlParameter("emisor", emisor));
            parametros.Add(new SqlParameter("userID", userid));

           return callProcedure("NEW_SOLUTION.existe_tarj_num_emisor_cliente", parametros);
        }
    }
}
