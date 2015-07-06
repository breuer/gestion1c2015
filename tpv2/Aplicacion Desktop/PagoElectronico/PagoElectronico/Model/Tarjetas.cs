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
    class Tarjeta
    {
        public DataTable traer_tarjetas_vinculadas_usuario(Usuario user)
        {
            TarjetaDAO dao = new TarjetaDAO();
            return dao.traer_tarjetas_vinculadas_usuario(user);
        }

        public DataTable traer_emisores_tarjetas()
        {
            TarjetaDAO dao = new TarjetaDAO();
            return dao.traer_emisores_tarjetas();
        }

        public DataTable traer_tarjeta_id(Int64 tarjID)
        {
            TarjetaDAO dao = new TarjetaDAO();
            return dao.traer_tarjeta_id(tarjID);        
        }

        public void editar_tarjeta(int tarjid, string num, int emisor, string emisorFEC, string vencimientoFEC, string codseg)
        {
            TarjetaDAO dao = new TarjetaDAO();
            dao.editar_tarjeta(tarjid,num, emisor, emisorFEC, vencimientoFEC, codseg);       
        }

        public void desvincular_tarjeta(int tarjID)
        { 
             TarjetaDAO dao = new TarjetaDAO();
            dao.desvincular_tarjeta(tarjID);
        }
        
        public void vincular_tarjeta(string num, int emisor, string emisorFEC, string vencimientoFEC, string codseg, int usuID)
        {
            TarjetaDAO dao = new TarjetaDAO();
            dao.vincular_tarjeta(num, emisor, emisorFEC, vencimientoFEC, codseg, usuID);
        }

        public int existe_tarjeta_emisor_usuario(string num, int emisor, int userid)
        {
            TarjetaDAO dao = new TarjetaDAO();
            return dao.existe_tarjeta_emisor_usuario(num,emisor,userid);     
        }
    }
}
