using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using PagoElectronico.DAO;

namespace PagoElectronico.Model
{
    public class Funcionalidad : IModel<Funcionalidad> 
    {
        private int id;
        private string nombre;
        private int? idRol;

        public int Id { get { return id; } set { id = value; } }
        public string Nombre { get { return nombre; } set { nombre = value; } }
        public int? IdRol { get { return idRol; } set { idRol = value; } }

        #region IModel<Funcionalidad> Members

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

        public List<Funcionalidad> getAll()
        {
            return (new FuncionalidadDAO()).getAll(this);
        }

        #endregion
    }


}
