using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PagoElectronico.DAO;

namespace PagoElectronico.Model
{
    public class Pais : IModel<Pais> 
    {
        private int id;
        private int codigo;
        private string nombre;

        public int Id { get { return id; } set { id = value; } }
        public int Codigo { get { return codigo; } set { codigo = value; } }
        public string Nombre { get { return nombre; } set { nombre = value; } }

        #region IModel<Pais> Members

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

        public List<Pais> getAll()
        {
            return (new PaisDAO()).getAll(null);
        }

        #endregion
    }
}
