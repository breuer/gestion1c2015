using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PagoElectronico.DAO;

namespace PagoElectronico.Model
{
    public class TipoIdentificacion : IModel<TipoIdentificacion> 
    {
        private int id;
        private string nombre;        

        public int Id { get { return id; } set { id = value; } }
        public string Nombre { get { return nombre; } set { nombre = value; } }    

    
        #region IModel<Identificacion> Members

        public int  add()
        {
 	        throw new NotImplementedException();
        }

        public void  update()
        {
 	        throw new NotImplementedException();
        }

        public void  delete()
        {
 	        throw new NotImplementedException();
        }

        public int  get()
        {
 	        throw new NotImplementedException();
        }

        public List<TipoIdentificacion>  getAll()
        {
 	        return (new TipoIdentificacionDAO()).getAll(this);
        }

        #endregion
    }
}
