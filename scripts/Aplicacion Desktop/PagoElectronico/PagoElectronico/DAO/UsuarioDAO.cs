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

        public int login(Usuario obj) {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("username", obj.Username));
            parametros.Add(new SqlParameter("password", obj.Password == null ? null : GenerarSHA256(obj.Password)));
            obj.Id = callProcedure("NEW_SOLUTION.SP_USUARIO_LOGIN", parametros);
            return obj.Id < 0 ? -1 : 1;
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

        public void get(Usuario obj)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("id_usuario", obj.Id));
            //parametros.Add(new SqlParameter("username", obj.Username));
            DataTable data = list("NEW_SOLUTION.SP_USUARIO_GET", parametros);
            if (data != null)
            {
                foreach (DataRow row in data.Rows)
                {
                    //obj.Username = row["usuario"].ToString();
                    obj.FechaCreacion = DateTime.Parse(row["fechaCreacion"].ToString());
                    obj.Password = null;
                }
                Rol rol = new Rol();
                rol.IdUsuario = obj.Id;
                obj.Roles = rol.getAll();
            }
        }

        public List<Usuario> getAll(Usuario obj)
        {
            throw new NotImplementedException();
        }

        #endregion



    }
}
