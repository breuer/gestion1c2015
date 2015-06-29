using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace FrbaHotel.ClasesTabla
{
    class DRol
    {
        EntidadBase entidadBase = new EntidadBase();

        public List<Rol> GetAllActivos()
        {
            DataTable rols = entidadBase.TraerDatos("hotel.SP_GETROLES");
            List<Rol> roles = new List<Rol>();

            foreach (DataRow r in rols.Rows)
            {
                Rol rol = new Rol();
                rol.codigo = r.Field<decimal>("codigo");
                rol.descripcion = r.Field<string>("descripcion");
                rol.estado = true;
                roles.Add(rol);
            }
            return roles;
        }

        public List<Rol> GetAllTODOS()
        {
            DataTable rols = entidadBase.TraerDatos("select * from hotel.Rol");
            List<Rol> roles = new List<Rol>();

            foreach (DataRow r in rols.Rows)
            {
                Rol rol = new Rol();
                rol.codigo = r.Field<decimal>("codigo");
                rol.descripcion = r.Field<string>("descripcion");
                int estado = r.Field<byte>("estado");
                if (estado == 1) rol.estado = true;
                else rol.estado = false;
                roles.Add(rol);
            }
            return roles;
        }

        public Rol GetByCod(int codigo)
        {
            List<Rol> roles = GetAllTODOS();
            Rol rol = (from r in roles where r.codigo == codigo select r).SingleOrDefault();
            return rol;
        }

        public List<Rol> GetRolesUser(decimal codUser)
        {
            List<Rol> roles = GetBySQL("select r.codigo, r.descripcion,r.estado from hotel.Rol r, hotel.Rol_usuario u where r.codigo = u.cod_rol and u.cod_usuario=" + codUser);
            return roles;
        }

        public decimal Save(Rol rol)
        {
            int ex = entidadBase.EjecutarSQL("insert hotel.Rol (descripcion,estado) values (" + ArmarValores(rol) + ")");
            DataTable resultID = entidadBase.TraerDatos("SELECT max(codigo) from hotel.Rol ");
            DataRow row = resultID.Rows[0];
            return Convert.ToInt32(row[0]);
        }

        public void Update(Rol rol)
        {
            int ex = entidadBase.EjecutarSQL("hotel.SP_UPDROL " + ArmarValores(rol));
        }

        private string ArmarValores(Rol rol)
        {
            StringBuilder Valores = new StringBuilder();
            if (rol.codigo != 0)
                Valores.Append(rol.codigo + ",");
            Valores.Append("'" + rol.descripcion + "',");
            if (rol.estado == true)
                Valores.Append("" + 1 + "");
            else Valores.Append("" + 0 + "");
            return Valores.ToString();
        }

        public void Delete(decimal codigo)
        {
            //int ex1 = entidadBase.EjecutarSQL("delete from hotel.Rol_Funcion where cod_rol = " + codigo);
            int ex = entidadBase.EjecutarSQL("update hotel.Rol set estado = 0 where codigo = " + codigo);
        }

        internal List<Rol> GetBySQL(string consulta)
        {
            DataTable rols = entidadBase.TraerDatos(consulta);
            List<Rol> roles = new List<Rol>();

            foreach (DataRow r in rols.Rows)
            {
                FrbaHotel.ClasesTabla.Rol rol = new FrbaHotel.ClasesTabla.Rol();
                rol.codigo = r.Field<decimal>("codigo");
                rol.descripcion = r.Field<string>("descripcion");
                int estado = r.Field<byte>("estado");
                if (estado == 1) rol.estado = true;
                else rol.estado = false;
                roles.Add(rol);
            }
            return roles;
        }

    }
}


