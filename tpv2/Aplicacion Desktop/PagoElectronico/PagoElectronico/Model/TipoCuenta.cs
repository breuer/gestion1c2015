using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PagoElectronico.DAO;

namespace PagoElectronico.Model
{
    public class TipoCuenta : IModel<TipoCuenta>
    {
        private int id;
        private string nombre;

        public int Id { get { return id; } set { id = value; } }
        public string Nombre { get { return nombre; } set { nombre = value; } }

        #region IModel<TipoCuenta> Members

        public int add()
        {
            throw new NotImplementedException();
        }

        public void update()
        {
            throw new NotImplementedException();
        }

        public void delete()
        {
            throw new NotImplementedException();
        }

        public int get()
        {
            throw new NotImplementedException();
        }

        public List<TipoCuenta> getAll()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
