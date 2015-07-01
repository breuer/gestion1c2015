using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PagoElectronico.DAO;

namespace PagoElectronico.Model
{
    public class Moneda : IModel<Moneda> 
    {
        private int id;
        private string nombre;

        public int Id { get { return id; } set { id = value; } }
        public string Nombre { get { return nombre; } set { nombre = value; } }

        #region IModel<Moneda> Members

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

        public List<Moneda> getAll()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
