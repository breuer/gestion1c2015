using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace FrbaHotel.ClasesTabla
{
    class DUsuario
    {
        EntidadBase entidadBase = new EntidadBase();

        public List<Usuario> GetAll()
        {
            DataTable us = entidadBase.TraerDatos("hotel.SP_GETUSUARIOS");
            List<Usuario> usuarios = new List<Usuario>();

            foreach (DataRow r in us.Rows)
            {
                FrbaHotel.ClasesTabla.Usuario usuario = new FrbaHotel.ClasesTabla.Usuario();
                usuario.codigo = r.Field<decimal>("codigo");
                usuario.user_nombre = r.Field<string>("user_nombre");
                usuario.user_password = r.Field<string>("user_password");
                usuario.logueado = r.Field<byte>("logueado");
                usuario.intentos_fallidos = r.Field<int>("intentos_fallidos");
                usuario.cod_persona = r.Field<Nullable<decimal>>("cod_persona");
                int estado = r.Field<byte>("estado");
                if (estado == 1) usuario.estado = true;
                else usuario.estado = false;
                usuarios.Add(usuario);
            }
            return usuarios;
        }
        
        public List<UsuarioDTO> GetBySQLGRID(string consulta)
        {
            DataTable us = entidadBase.TraerDatos(consulta);
            List<UsuarioDTO> usuarios = new List<UsuarioDTO>();

            foreach (DataRow r in us.Rows)
            {
                FrbaHotel.ClasesTabla.UsuarioDTO usuario = new FrbaHotel.ClasesTabla.UsuarioDTO();
                usuario.codigo = r.Field<decimal>("codigo");
                usuario.user_nombre = r.Field<string>("user_nombre");
                usuario.logueado = r.Field<byte>("logueado");
                usuario.intentos_fallidos = r.Field<int>("intentos_fallidos");
                //usuario.mail = r.Field<string>("mail");
                int estado = r.Field<byte>("estado");
                if (estado == 1) usuario.estado = true;
                else usuario.estado = false;
                usuarios.Add(usuario);
            }
            return usuarios;
        }

        public List<Usuario> GetAllActivos()
        {
            DataTable us = entidadBase.TraerDatos("hotel.SP_GETUSUARIOSACTIVOS");
            List<Usuario> usuarios = new List<Usuario>();

            foreach (DataRow r in us.Rows)
            {
                FrbaHotel.ClasesTabla.Usuario usuario = new FrbaHotel.ClasesTabla.Usuario();
                usuario.codigo = r.Field<decimal>("codigo");
                usuario.user_nombre = r.Field<string>("user_nombre");
                usuario.user_password = r.Field<string>("user_password");
                usuario.logueado = r.Field<byte>("logueado");
                usuario.intentos_fallidos = r.Field<int>("intentos_fallidos");
                usuario.cod_persona = r.Field<Nullable<decimal>>("cod_persona");
                usuario.estado = true;
                usuarios.Add(usuario);
            }
            return usuarios;
        }

        public Usuario GetByCod(decimal codigo)
        {
            List<Usuario> usuarios = GetAllActivos();
            Usuario user = (from u in usuarios where u.codigo == codigo select u).SingleOrDefault();
            return user;
        }

        public Usuario GetByUser(string username)
        {
            List<Usuario> usuarios = GetAllActivos();
            Usuario user = (from u in usuarios where u.user_nombre == username select u).SingleOrDefault();
            return user;
        }

        private string ArmarValores(Usuario user)
        {
            StringBuilder Valores = new StringBuilder();
            if (user.codigo != 0)
                Valores.Append(user.codigo + ",");
            Valores.Append("'" + user.user_nombre + "',");
            Valores.Append("'" + user.user_password + "',");
            Valores.Append("" + user.logueado + ",");
            Valores.Append("" + user.intentos_fallidos + ",");
            if (user.cod_persona == null) Valores.Append("" + "null" + ",");
            else Valores.Append("" + user.cod_persona + ",");
            if (user.estado == true)
                Valores.Append("" + 1 + "");
            else Valores.Append("" + 0 + "");
            return Valores.ToString();
        }

        public List<Usuario> GetBySQL(string consulta)
        {
            DataTable us = entidadBase.TraerDatos(consulta);
            List<Usuario> usuarios = new List<Usuario>();

            foreach (DataRow r in us.Rows)
            {
                FrbaHotel.ClasesTabla.Usuario usuario = new FrbaHotel.ClasesTabla.Usuario();
                usuario.codigo = r.Field<decimal>("codigo");
                usuario.user_nombre = r.Field<string>("user_nombre");
                usuario.user_password = r.Field<string>("user_password");
                usuario.logueado = r.Field<byte>("logueado");
                usuario.intentos_fallidos = r.Field<int>("intentos_fallidos");
                usuario.cod_persona = r.Field<Nullable<decimal>>("cod_persona");
                int estado = r.Field<byte>("estado");
                if (estado == 1) usuario.estado = true;
                else usuario.estado = false;
                usuarios.Add(usuario);
            }
            return usuarios;
        }


        public decimal Save(Usuario user)
        {
            int ex = entidadBase.EjecutarSQL("insert hotel.Usuario (user_nombre,user_password,logueado,intentos_fallidos,cod_persona,estado) values (" + ArmarValores(user)+")");
            DataTable resultID = entidadBase.TraerDatos("SELECT max(codigo) from hotel.Usuario ");
            DataRow row = resultID.Rows[0];
            return Convert.ToInt32(row[0]);
        }

        public decimal Update(Usuario user)
        {
            int ex = entidadBase.EjecutarSQL("hotel.SP_UPDUSER " + ArmarValores(user));
            return user.codigo;
        }

        public void Delete(decimal codigo)
        {
            int ex = entidadBase.EjecutarSQL("update hotel.Usuario set estado = 0 where codigo=" + codigo);
        }

        internal void DeleteAllByCodUser(decimal codUsuario)
        {
            int ex = entidadBase.EjecutarSQL("delete hotel.Usuario_hotel where cod_usuario =" + codUsuario);
        }
    }
}

