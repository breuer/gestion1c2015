using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PagoElectronico.DAO;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace PagoElectronico.Model
{
    class Transferencia
    {
        //public Int64 cuentaDestino;       

        public DataTable buscar_cuentas(String ctaNum)
        {
            TransferenciaDAO dao  = new TransferenciaDAO();
            DataTable        data = dao.buscar_cuentas(ctaNum);

            return data;         
        }
    }
}
