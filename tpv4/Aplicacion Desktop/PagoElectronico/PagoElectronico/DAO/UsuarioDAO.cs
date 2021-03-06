﻿using System;
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
            int result = callProcedure("NEW_SOLUTION.sp_usuario_login", parametros);
            //MessageBox.Show("Usuario id: "+usuario.Id);
            if (result > 0)
            {
                usuario.Id = result;
                usuario.get();
                Rol rol = new Rol();
                rol.IdUsuario = usuario.Id;
                usuario.Roles = rol.getAll();

                if (usuario.IdCliente != null)
                {
                    Cliente cliente = new Cliente();
                    cliente.Id = usuario.IdCliente;
                    cliente.get();
                    usuario.Cliente = cliente;
                }
            }
            return result > 0 ? 1 : result;
        }

        #region IDAO<Usuario> Members

        public void add(Usuario obj)
        {
            throw new NotImplementedException();
        }

        public void update(Usuario obj)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("id_usuario", obj.Id));
            parametros.Add(new SqlParameter("id_cliente", obj.IdCliente));
            int result = callProcedure("NEW_SOLUTION.sp_usuario_update", parametros);
        }

        public void get(Usuario usuario)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("id_usuario", usuario.Id));
            parametros.Add(new SqlParameter("id_cliente", usuario.IdCliente));
            DataTable table = list("NEW_SOLUTION.sp_usuario_get", parametros);
            foreach (DataRow row in table.Rows)
            {
                usuario.Username = row["usu_nombre"].ToString();
                if (row["usu_fecCreacion"].ToString().Length > 0)
                    usuario.FechaCreacion = DateTime.Parse(row["usu_fecCreacion"].ToString());
                if (row["usu_fecUltmodif"].ToString().Length > 0)
                    usuario.FechaUltimaModificacion = DateTime.Parse(row["usu_fecUltmodif"].ToString());
                usuario.PreguntaSecreta = row["usu_pregSecreta"].ToString();
                usuario.Activo = int.Parse(row["usu_estado"].ToString()) != 0;
                if (row["usu_cli_id"].ToString().Length > 0)
                    usuario.IdCliente = long.Parse(row["usu_cli_id"].ToString());
            }
        }

        public List<Usuario> getAll(Usuario usuario)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("username", usuario.Username));
            DataTable table = list("NEW_SOLUTION.sp_usuario_get", parametros);
            List<Usuario> usuarios = new List<Usuario>();
            foreach (DataRow row in table.Rows)
            {
                Usuario usu = new Usuario();
                usu.Id = int.Parse(row["usu_id"].ToString());
                usu.Username = row["usu_nombre"].ToString();
                if (row["usu_cli_id"].ToString().Length != 0)
                    usu.IdCliente = long.Parse(row["usu_cli_id"].ToString());
                usu.Activo = int.Parse(row["usu_estado"].ToString()) != 0;
                usuarios.Add(usu);
            }
            //MessageBox.Show("Usuario: " + usuarios.Count);
            return usuarios;
        }

        #endregion

        public void updatePassword(Usuario obj)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("id_usuario", obj.Id));
            parametros.Add(new SqlParameter("password", GenerarSHA256(obj.Password)));
            parametros.Add(new SqlParameter("fecha_sistema", DataSession.FechaSistema.ToString(formatDateTime)));
            callProcedure("NEW_SOLUTION.sp_usuario_update", parametros);
        }
    }
}
