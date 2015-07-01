using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PagoElectronico.DAO;

namespace PagoElectronico.Model
{
    public class Cliente : IModel<Cliente>
    {
        private long? id;
        private string nombre;
        private string apellido;
        private string mail;
        private int? identificacion;
        //private TipoIdentificacion tipoIdentificacion;
        private int tipoIdentificacionCod;
        private int paisCod;
        private bool activo;
        private Usuario usuario;
        private List<Cuenta> cuentas;


        public long? Id { get { return id; } set { id = value; } }
        public string Nombre { get { return nombre; } set { nombre = value; } }
        public string Apellido { get { return apellido; } set { apellido = value; } }
        public string Mail { get { return mail; } set { mail = value; } }
        public int? Identificacion { get { return identificacion; } set { identificacion = value; } }
        //public TipoIdentificacion TipoDeIdentificacion { get { return tipoIdentificacion; } set { tipoIdentificacion = value; } }
        //public int 
        public int TipoDeIdentificacionCod { get { return tipoIdentificacionCod; } set { tipoIdentificacionCod = value; } }
        public int PaisCod { get { return paisCod; } set { paisCod = value; } }
        public bool Activo { get { return activo; } set { activo = value; } }
        public Usuario Usuario { get { return usuario; } set { usuario = value; } }
        public List<Cuenta> Cuentas { 
            get {
                if (cuentas == null)
                {
                    cuentas = new List<Cuenta>();
                }
                return cuentas; 
            } 
            set { cuentas = value; } }
        #region IModel<Cliente> Members

        public int add()
        {
            ClienteDAO dao = new ClienteDAO();
            dao.add(this);
            return 1;
        }

        public void update()
        {
            ClienteDAO dao = new ClienteDAO();
            dao.update(this);
        }

        public void delete()
        {
            throw new NotImplementedException();
        }

        public int get()
        {
            ClienteDAO dao = new ClienteDAO();
            dao.get(this);
            return 1;
        }

        public List<Cliente> getAll()
        {
            ClienteDAO dao = new ClienteDAO();
            return dao.getAll(this);
        }

        #endregion
    }
}
