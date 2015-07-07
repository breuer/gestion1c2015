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
    class FacturaDAO : Repository
    {
        public DataTable traer_facturas_usuario(Usuario user)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("userID", user.Id));

            DataTable data = new DataTable();
            data = list("NEW_SOLUTION.traer_facturas_usuario", parametros);

            return data;
        }

        public DataTable traer_factura_id(int fact_id)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("factID", fact_id));

            DataTable data = new DataTable();
            data = list("NEW_SOLUTION.sp_traer_factura_id", parametros);

            return data;
        }

        public DataTable traer_detalle_factura(int fact_id)
        { 
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("factID", fact_id));

            DataTable data = new DataTable();
            data = list("NEW_SOLUTION.sp_traer_detalle_factura", parametros);

            return data;
        
        }

        public int facturar_usuario(Usuario user)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("userID", user.Id));
            parametros.Add(new SqlParameter("fechaSys", get_date()));  
            return callProcedure("NEW_SOLUTION.sp_facturar_costos", parametros);
        }
    }
}
