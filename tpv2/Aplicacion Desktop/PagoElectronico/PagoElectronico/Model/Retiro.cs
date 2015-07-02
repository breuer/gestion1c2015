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
    class Retiro
    {
        public DataTable buscar_cuentas_usuario_validas(Usuario user)
        {
            RetiroDAO dao = new RetiroDAO();
            DataTable data = dao.buscar_cuentas_usuario_validas(user);

            return data;
        }

        public DataTable listar_bancos()
        {
            RetiroDAO dao = new RetiroDAO();
            DataTable data = dao.listar_bancos();

            return data;
        }

        public int validar_id_dni(Usuario user, String ndoc)
        {
            RetiroDAO dao = new RetiroDAO();
            return dao.validar_id_dni(user,ndoc);     
        }

        public int retirar(String ctaID, String codBco, float importe)
        {
            RetiroDAO dao = new RetiroDAO();
            return dao.retirar(ctaID, codBco, importe);     
        }
    }
}
