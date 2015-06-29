using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PagoElectronico.DAO;

namespace PagoElectronico.Model
{
    public class Cuenta : IModel<Cuenta>
    {
        private int numero;
        private int clienteId;
        private string paisApertura;
        private string moneda;
        private string categoria;
        private string estado;



        public int Numero { get { return numero; } set { numero = value; } }
        public int ClienteId { get { return clienteId; } set { clienteId = value; } }
        public string PaisApertura { get { return paisApertura; } set { paisApertura = value; } }
        public string Moneda { get { return moneda; } set { moneda = value; } }
        public string Categoria { get { return categoria; } set { categoria = value; } }
        public string Estado { get { return estado; } set { estado = value; } }

        #region IModel<Cuenta> Members

        public int add()
        {
            CuentaDAO dao = new CuentaDAO();
            dao.add(this);
            return 1;
        }

        public void update()
        {
            CuentaDAO dao = new CuentaDAO();
            dao.update(this);
        }

        public void delete()
        {
            CuentaDAO dao = new CuentaDAO();
            dao.delete(this);
        }

        public int get()
        {
            throw new NotImplementedException();
        }

        public List<Cuenta> getAll()
        {
            CuentaDAO dao = new CuentaDAO();
            return dao.getAll(this);
        }

        #endregion
    }
}
