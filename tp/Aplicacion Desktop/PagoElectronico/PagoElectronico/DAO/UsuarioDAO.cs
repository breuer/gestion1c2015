using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PagoElectronico.Model;
using System.Security.Cryptography;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace PagoElectronico.DAO
{
    public class UsuarioDAO : Repository, IDAO<Usuario>
    {
        public static string GenerarSHA256(string texto)
        {
            SHA256 sha256 = SHA256CryptoServiceProvider.Create();
            Byte[] hash = sha256.ComputeHash(ASCIIEncoding.Default.GetBytes(texto));
            StringBuilder cadena = new StringBuilder();
            foreach (byte xD in hash)
            {
                cadena.AppendFormat("{0:x2}", xD);
            }
            return cadena.ToString();
        }

        public int login(Usuario usuario) {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("username", usuario.Username));
            parametros.Add(new SqlParameter("password", usuario.Password == null ? null : GenerarSHA256(usuario.Password)));
            parametros.Add(new SqlParameter("fecha", DataSession.FechaSistema.ToString(formatDateTime)));
            usuario.Id = callProcedure("NEW_SOLUTION.sp_usuario_login", parametros);
            //MessageBox.Show("Usuario id: "+usuario.Id);
            if (usuario.Id > 0)
            {
                usuario.get();
            }
            return usuario.Id > 0 ? 1 : usuario.Id;
        }

        #region IDAO<Usuario> Members

        public void add(Usuario obj)
        {
            throw new NotImplementedException();
        }

        public void update(Usuario obj)
        {
            throw new NotImplementedException();
        }

        public void get(Usuario usuario)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("id_usuario", usuario.Id));
            parametros.Add(new SqlParameter("username", usuario.Username));
            DataTable data = list("NEW_SOLUTION.sp_usuario_get", parametros);
            if (data != null)
            {
                foreach (DataRow row in data.Rows)
                {
                    usuario.Username = row["usu_nombre"].ToString();
                    if (row["usu_fecCreacion"].ToString().Length > 0)
                        usuario.FechaCreacion = DateTime.Parse(row["usu_fecCreacion"].ToString());
                    if (row["usu_fecUltmodif"].ToString().Length > 0)
                        usuario.FechaUltimaModificacion = DateTime.Parse(row["usu_fecUltmodif"].ToString());
                    usuario.PreguntaSecreta = row["usu_pregSecreta"].ToString();
                    usuario.Activo = row["usu_estado"].ToString().Equals('s');
                }
                //MessageBox.Show("Usuario: "+usuario.Username);
                Rol rol = new Rol();
                rol.IdUsuario = usuario.Id;
                usuario.Roles = rol.getAll();
                //MessageBox.Show("Cant roles: "+usuario.Roles.Count);

            }
        }

        public List<Usuario> getAll(Usuario obj)
        {
            throw new NotImplementedException();
        }

        #endregion

        public void updatePassword(Usuario obj)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("id_usuario", obj.Id));
            parametros.Add(new SqlParameter("password", GenerarSHA256(obj.Password)));
            callProcedure("NEW_SOLUTION.sp_usuario_update_password", parametros);
        }

    }
}
