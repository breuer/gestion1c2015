using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PagoElectronico.DAO;

//---Pongo esto para poder usar los messagebox
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using PagoElectronico.Model;


namespace PagoElectronico.Model
{
    public class Usuario : IModel<Usuario>
    {
        private int id;
        private string username;
        private string password;
        private DateTime fechaCreacion;
        private DateTime fechaUltimaModificacion;
        private string preguntaSecreta;
        private List<Rol> roles;
        private Rol rolSeleccionado;
        private Cliente cliente;
        private bool activo;

        public int      Id { get { return id; } set { id = value; } }
        public string   Username { get { return username; } set { username = value; } }
        public string   Password { get { return password; } set { password = value; } }
        public DateTime FechaCreacion { get { return fechaCreacion; } set { fechaCreacion = value; } }
        public DateTime FechaUltimaModificacion { get { return fechaUltimaModificacion; } set { fechaUltimaModificacion = value; } }
        public string   PreguntaSecreta { get { return preguntaSecreta; } set { preguntaSecreta = value; } }
        public Cliente  Cliente { get { return cliente; } set { cliente = value; } }
        public bool     Activo { get { return activo; } set { activo = value; } }
        
        public List<Rol> Roles
        {
            get {
                if (roles == null) 
                    roles = new List<Rol>(); 
                return roles;
            }
            set { roles = value; }
        }

        public Rol RolSeleccionado
        {
            get { return rolSeleccionado; } set { rolSeleccionado = value; } 
        }
        
        public void rolPorDefecto() 
        {
            foreach (Rol rol in roles) 
            {
                this.rolSeleccionado = rol;
            }
        }

        public int login()
        {
            UsuarioDAO dao = new UsuarioDAO();
            return dao.login(this);
        }

        #region IModel<Usuario> Members

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
            UsuarioDAO dao = new UsuarioDAO();
            dao.get(this);
            return 1;
        }

        public List<Usuario> getAll()
        {
            throw new NotImplementedException();
        }

        #endregion

        public void updatePassword()
        {
            UsuarioDAO dao = new UsuarioDAO();
            dao.updatePassword(this);
        }
    }
}
