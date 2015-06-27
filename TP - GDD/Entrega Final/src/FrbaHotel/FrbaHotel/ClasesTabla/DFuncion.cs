using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace FrbaHotel.ClasesTabla
{
    class DFuncion
    {
        EntidadBase entidadBase = new EntidadBase();

        public List<Funcion> GetAll()
        {
            DataTable TableFunc = entidadBase.TraerDatos("select f.codigo, f.descripcion from hotel.Funcion f");
            List<Funcion> funciones = new List<Funcion>();

            foreach (DataRow f in TableFunc.Rows)
            {
                Funcion func = new Funcion();
                func.codigo = f.Field<decimal>("codigo");
                func.descripcion = f.Field<string>("descripcion");
                funciones.Add(func);
            }
            return funciones;
        }

        public Funcion GetByCod(int codigo)
        {
            List<Funcion> funciones = GetAll();
            Funcion func = (from f in funciones where f.codigo == codigo select f).SingleOrDefault();
            return func;
        }

        private string ArmarValores(Funcion func)
        {
            StringBuilder Valores = new StringBuilder();
            if (func.codigo != 0)
                Valores.Append(func.codigo + ",");
            Valores.Append("'" + func.descripcion + "'");
            return Valores.ToString();
        }

        internal List<Funcion> GetBySQL(string consulta)
        {
            DataTable func = entidadBase.TraerDatos(consulta);
            List<Funcion> funciones = new List<Funcion>();

            foreach (DataRow r in func.Rows)
            {
                FrbaHotel.ClasesTabla.Funcion funcion = new FrbaHotel.ClasesTabla.Funcion();
                funcion.codigo = r.Field<decimal>("codigo");
                funcion.descripcion = r.Field<string>("descripcion");
                funciones.Add(funcion);
            }
            return funciones;
        }

        public List<Funcion> GetRolPorFuncion(int cod_rol)
        {
            DataTable funcTab = entidadBase.TraerDatos("hotel.SP_GETFUNCIONESporROL " + cod_rol);
            List<Funcion> funciones = new List<Funcion>();

            foreach (DataRow r in funcTab.Rows)
            {
                Funcion fun = new Funcion();
                fun.codigo = r.Field<decimal>("codigo");
                fun.descripcion = r.Field<string>("descripcion");
                funciones.Add(fun);
            }
            return funciones;
        }

        internal void DeleteAllByCodRol(decimal codRol)
        {
            int ex = entidadBase.EjecutarSQL("delete from hotel.Rol_Funcion where cod_rol =" + codRol);
        }

        internal void SaveCodRol(decimal codRol, decimal codFunc)
        {
            int ex = entidadBase.EjecutarSQL("insert hotel.Rol_Funcion (cod_rol,cod_funcion) values (" + codRol.ToString() + "," + codFunc.ToString() + ")");
        }
    }
}
