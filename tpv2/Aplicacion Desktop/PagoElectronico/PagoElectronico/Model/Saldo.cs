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
    class Saldo
    {        
        public DataTable buscar_cuentas_usuario_validas(Usuario user)
        {
            SaldoDAO dao = new SaldoDAO();
            DataTable data = dao.buscar_cuentas_usuario_validas(user);

            return data;
        }

        public DataTable saldo_actual(String cta_id)
        {
            SaldoDAO dao = new SaldoDAO();
            DataTable data = dao.saldo_actual(cta_id);

            return data;
        }

        public DataTable consulta_movimientos(String cta_id)
        {
            SaldoDAO dao   = new SaldoDAO();
            DataTable data = dao.consulta_movimientos(cta_id);

            return data;        
        }

        public DataTable buscar_cuentas_num(String cuentaBuscar)
        {
            SaldoDAO dao   = new SaldoDAO();
            DataTable data = dao.buscar_cuentas_num(cuentaBuscar);

            return data;                
        }
    }
}
