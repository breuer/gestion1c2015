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
    class Factura
    {

        public DataTable traer_facturas_usuario(Usuario user)
        {
            FacturaDAO dao = new FacturaDAO();
            return dao.traer_facturas_usuario(user);
        }

        public DataTable traer_factura_id(int fact_id)
        {
            FacturaDAO dao = new FacturaDAO();
            return dao.traer_factura_id(fact_id);        
        }

        public DataTable traer_detalle_factura(int fact_id)
        {
            FacturaDAO dao = new FacturaDAO();
            return dao.traer_detalle_factura(fact_id);        
        }

        public int facturar_usuario(Usuario user)
        {
            FacturaDAO dao = new FacturaDAO();
            return dao.facturar_usuario(user);            
        }
    }
       
}
