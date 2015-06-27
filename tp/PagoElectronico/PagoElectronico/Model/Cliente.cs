using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PagoElectronico.DAO;

namespace PagoElectronico.Model
{
    public class Cliente : IModel<Cliente>
    {
        private int id;
        private string nombre;
        private string apellido;
        private string mail;
        private int? identificacion;
        private TipoIdentificacion tipoIdentificacion;
        private bool activo;


        public int Id { get { return id; } set { id = value; } }
        public string Nombre { get { return nombre; } set { nombre = value; } }
        public string Apellido { get { return apellido; } set { apellido = value; } }
        public string Mail { get { return mail; } set { mail = value; } }
        public int? Identificacion { get { return identificacion; } set { identificacion = value; } }
        public TipoIdentificacion TipoDeIdentificacion { get { return tipoIdentificacion; } set { tipoIdentificacion = value; } }
        public bool Activo { get { return activo; } set { activo = value; } }

        #region IModel<Cliente> Members

        public int add()
        {
            ClienteDAO dao = new ClienteDAO();
            dao.add(this);
            return 1;
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

        public List<Cliente> getAll()
        {
            ClienteDAO dao = new ClienteDAO();
            return dao.getAll(this);
        }

        #endregion
    }
}
