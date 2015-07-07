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

        public DataTable traer_facturas_cliente(int cliID)
        {
            FacturaDAO dao = new FacturaDAO();
            return dao.traer_facturas_cliente(cliID);        
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

        public int facturar_cliente(int cliID)
        {
            FacturaDAO dao = new FacturaDAO();
            return dao.facturar_cliente(cliID);
        }

        public DataTable buscar_clientes(int tdoc, int ndoc)
        {
            FacturaDAO dao = new FacturaDAO();
            return dao.buscar_clientes(tdoc,ndoc);        
        }

        public DataTable traer_documentos_tipo()
        {
            FacturaDAO dao = new FacturaDAO();
            return dao.traer_documentos_tipo();   
        }
    }
       
}
