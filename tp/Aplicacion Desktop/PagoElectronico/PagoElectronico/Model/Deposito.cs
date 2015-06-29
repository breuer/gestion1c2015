using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using PagoElectronico.Model;
using PagoElectronico.DAO;

namespace PagoElectronico.Model
{
    class Deposito
    {
        public DataTable buscar_cuentas_usuario_validas(Usuario user)
        {
            DepositoDAO dao = new DepositoDAO();
            DataTable data = dao.buscar_cuentas_usuario_validas(user);

            return data;
        }

        public DataTable buscar_tarjetas_usuario_validas(Usuario user)
        {
            DepositoDAO dao = new DepositoDAO();
            DataTable data = dao.buscar_tarjetas_usuario_validas(user);

            return data;
        }

        public int cuenta_retirar_saldo(Int64 ctaID, int moneda, Int64 tarjid, float importe)
        {
            DepositoDAO dao = new DepositoDAO();
            return dao.cuenta_retirar_saldo(ctaID, moneda, tarjid, importe);
        }

        /*
        public DataTable listar_bancos()
        {
            RetiroDAO dao = new RetiroDAO();
            DataTable data = dao.listar_bancos();

            return data;
        }

        public int validar_id_dni(Usuario user, String ndoc)
        {
            RetiroDAO dao = new RetiroDAO();
            return dao.validar_id_dni(user, ndoc);
        }

        public int retirar(String ctaID, String codBco, float importe)
        {
            RetiroDAO dao = new RetiroDAO();
            return dao.retirar(ctaID, codBco, importe);
        }
        */
    }
}
