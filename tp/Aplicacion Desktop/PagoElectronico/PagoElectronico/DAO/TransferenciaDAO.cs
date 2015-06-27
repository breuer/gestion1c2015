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
    }
}
