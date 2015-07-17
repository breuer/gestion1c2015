using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PagoElectronico.DAO;
using System.Windows.Forms;

namespace PagoElectronico.Model
{
    public class Rol : IModel<Rol>
    {
        private int id;
        private string nombre;
        private int? idUsuario;
        private List<Funcionalidad> funcionalidades;

        public int Id { get { return id; } set { id = value; } }
        public string Nombre { get { return nombre; } set { nombre = value; } }
        public int? IdUsuario { get { return idUsuario; } set { idUsuario = value; } }
        public List<Funcionalidad> Funcionalidades
        {
            get
            {
                if (funcionalidades == null)
                {
                    funcionalidades = new List<Funcionalidad>();
                }
                return funcionalidades;
            }
            set { funcionalidades = value; }
        }


        #region IModel<Rol> Members

        public int add()
        {
            (new RolDAO()).add(this);
            return 1;
        }

        public void update()
        {
            (new RolDAO()).update(this);
        }

        public void delete()
        {
            throw new NotImplementedException();
        }

        public int get()
        {
            (new RolDAO()).get(this);
            return 1;
        }

        public List<Rol> getAll()
        {
            return (new RolDAO()).getAll(this);
        }

        #endregion
    }



}
