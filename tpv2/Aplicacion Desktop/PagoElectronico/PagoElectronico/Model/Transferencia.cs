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

        public DataTable buscar_cuentas_usuario(Usuario user)
        {
            TransferenciaDAO dao = new TransferenciaDAO();
            DataTable data = dao.buscar_cuentas_usuario(user);

            return data;
        }

        public int hacer_transferencia(String ctaOrigen, String ctaDestino, float importe)
        {
            TransferenciaDAO dao = new TransferenciaDAO();
            int resu = dao.hacer_transferencia(ctaOrigen, ctaDestino, importe);
            return resu;        
        }
    }
}
