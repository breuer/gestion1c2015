using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace FrbaHotel.ClasesTabla
{
    class DPersona
    {
        EntidadBase entidadBase = new EntidadBase();

        public List<Persona> GetAll()
        {
            DataTable us = entidadBase.TraerDatos("select * from hotel.Persona");
            List<Persona> personas = new List<Persona>();

            foreach (DataRow r in us.Rows)
            {
                FrbaHotel.ClasesTabla.Persona per = new FrbaHotel.ClasesTabla.Persona();
                per.codigo = r.Field<decimal>("codigo");
                per.nombre = r.Field<string>("nombre");
                per.apellido = r.Field<string>("apellido");
                per.codigo_tipo_doc = r.Field<decimal>("codigo_tipo_doc");
                per.num_doc = r.Field<decimal>("num_doc");
                per.mail = r.Field<string>("mail");
                per.telefono = r.Field<Nullable<decimal>>("telefono");
                per.nom_calle = r.Field<string>("nom_calle");
                per.num_calle = r.Field<decimal>("num_calle");
                per.localidad = r.Field<string>("localidad");
                per.ciudad = r.Field<string>("ciudad");
                per.pais = r.Field<string>("pais");
                per.nacionalidad = r.Field<string>("nacionalidad");
                per.fecha_nacimiento = r.Field<DateTime>("fecha_nacimiento");
                per.piso = r.Field<Nullable<decimal>>("piso");
                per.depto = r.Field<string>("depto");
                int estado = r.Field<byte>("estado");
                if (estado == 1) per.estado = true;
                else per.estado = false;
                personas.Add(per);
            }
            return personas;
        }


        public Persona GetByCod(decimal cod)
        {
            List<Persona> personas = GetBySQL("select * from hotel.Persona p where p.codigo = " + cod);
            Persona per = personas.Take(1).SingleOrDefault();
            return per;
        }

        public Persona getByCodigo(string codigo)
        {
            DataTable resultID = entidadBase.TraerDatos("SELECT * from hotel.Persona where codigo = " + codigo);
            DataRow row = resultID.Rows[0];
            Persona persona = parsearDatos(row);
            return persona;

        }

        public Persona parsearDatos(DataRow r)
        {
            FrbaHotel.ClasesTabla.Persona per = new FrbaHotel.ClasesTabla.Persona();
            per.codigo = r.Field<decimal>("codigo");
            per.nombre = r.Field<string>("nombre");
            per.apellido = r.Field<string>("apellido");
            per.codigo_tipo_doc = r.Field<decimal>("codigo_tipo_doc");
            per.num_doc = r.Field<decimal>("num_doc");
            per.mail = r.Field<string>("mail");
            per.telefono = r.Field<Nullable<decimal>>("telefono");
            per.nom_calle = r.Field<string>("nom_calle");
            per.num_calle = r.Field<decimal>("num_calle");
            per.localidad = r.Field<string>("localidad");
            per.ciudad = r.Field<string>("ciudad");
            per.pais = r.Field<string>("pais");
            per.nacionalidad = r.Field<string>("nacionalidad");
            per.fecha_nacimiento = r.Field<DateTime>("fecha_nacimiento");
            per.piso = r.Field<Nullable<decimal>>("piso");
            per.depto = r.Field<string>("depto");
            int estado = r.Field<byte>("estado");
            if (estado == 1) per.estado = true;
            else per.estado = false;

            return per;
        }

        public List<Persona> GetAllClientes()
        {
            DataTable us = entidadBase.TraerDatos("select * from hotel.Persona p where p.estado = 1 and p.codigo is not in (select u.cod_persona from hotel.Usuario)");
            List<Persona> personas = new List<Persona>();

            foreach (DataRow r in us.Rows)
            {
                FrbaHotel.ClasesTabla.Persona per = new FrbaHotel.ClasesTabla.Persona();
                per.codigo = r.Field<decimal>("codigo");
                per.nombre = r.Field<string>("nombre");
                per.apellido = r.Field<string>("apellido");
                per.codigo_tipo_doc = r.Field<decimal>("codigo_tipo_doc");
                per.num_doc = r.Field<decimal>("num_doc");
                per.mail = r.Field<string>("mail");
                per.telefono = r.Field<decimal>("telefono");
                per.nom_calle = r.Field<string>("nom_calle");
                per.num_calle = r.Field<decimal>("num_calle");
                per.localidad = r.Field<string>("localidad");
                per.ciudad = r.Field<string>("ciudad");
                per.pais = r.Field<string>("pais");
                per.nacionalidad = r.Field<string>("nacionalidad");
                per.fecha_nacimiento = r.Field<DateTime>("fecha_nacimiento");
                per.piso = r.Field<Nullable<decimal>>("piso");
                per.depto = r.Field<string>("depto");
                int estado = r.Field<byte>("estado");
                if (estado == 1) per.estado = true;
                else per.estado = false;
                personas.Add(per);
            }
            return personas;
        }

        public List<Persona> GetByMailToValidate(string mail, string codigo)
        {
            DataTable us = entidadBase.TraerDatos("select * from hotel.Persona where mail = '" + mail + "' AND codigo != " + codigo);
            List<Persona> personas = new List<Persona>();

            foreach (DataRow r in us.Rows)
            {
                FrbaHotel.ClasesTabla.Persona per = parsearDatos(r);
                personas.Add(per);
            }
            return personas;
        }

        public List<Persona> GetAllActivos()
        {
            DataTable us = entidadBase.TraerDatos("select * from hotel.Persona p where p.estado = 1");
            List<Persona> personas = new List<Persona>();

            foreach (DataRow r in us.Rows)
            {
                FrbaHotel.ClasesTabla.Persona per = new FrbaHotel.ClasesTabla.Persona();
                per.codigo = r.Field<decimal>("codigo");
                per.nombre = r.Field<string>("nombre");
                per.apellido = r.Field<string>("apellido");
                per.codigo_tipo_doc = r.Field<decimal>("codigo_tipo_doc");
                per.num_doc = r.Field<decimal>("num_doc");
                per.mail = r.Field<string>("mail");
                per.telefono = r.Field<decimal>("telefono");
                per.nom_calle = r.Field<string>("nom_calle");
                per.num_calle = r.Field<decimal>("num_calle");
                per.localidad = r.Field<string>("localidad");
                per.ciudad = r.Field<string>("ciudad");
                per.pais = r.Field<string>("pais");
                per.nacionalidad = r.Field<string>("nacionalidad");
                per.fecha_nacimiento = r.Field<DateTime>("fecha_nacimiento");
                per.piso = r.Field<Nullable<decimal>>("piso");
                per.depto = r.Field<string>("depto");
                int estado = r.Field<byte>("estado");
                if (estado == 1) per.estado = true;
                else per.estado = false;
                personas.Add(per);
            }
            return personas;
        }

        private string ArmarValores(Persona per)
        {
            StringBuilder Valores = new StringBuilder();
            if (per.codigo != 0)
                Valores.Append(per.codigo + ",");
            Valores.Append("'" + per.nombre + "',");
            Valores.Append("'" + per.apellido + "',");
            Valores.Append("" + per.codigo_tipo_doc + ",");
            Valores.Append("" + per.num_doc + ",");
            Valores.Append("'" + per.mail + "',");
            Valores.Append("" + per.telefono + ",");
            Valores.Append("'" + per.nom_calle + "',");
            Valores.Append("" + per.num_calle + ",");
            Valores.Append("'" + per.localidad + "',");
            Valores.Append("'" + per.ciudad + "',");
            Valores.Append("'" + per.pais + "',");
            Valores.Append("'" + per.nacionalidad + "',");
            if (per.fecha_nacimiento != null)
                Valores.Append("'" + per.fecha_nacimiento.ToShortDateString() + "',");
            else
                Valores.Append("'" + FormIni.FechaSistema.ToShortDateString() + "',");
            if (per.piso == null)
                Valores.Append("" + 0 + ",");
            else Valores.Append("" + per.piso + ",");
            Valores.Append("'" + per.depto + "',");
            if (per.estado == true)
                Valores.Append("" + 1 + "");
            else Valores.Append("" + 0 + "");
            return Valores.ToString();
        }

        public List<Persona> GetByMail(string mail)
        {
            List<Persona> personas = GetAll();
            List<Persona> per = (from f in personas where f.mail == mail select f).ToList();
            return per;
        }

        public List<Persona> GetBySQL(string consulta)
        {
            DataTable us = entidadBase.TraerDatos(consulta);
            List<Persona> personas = new List<Persona>();

            foreach (DataRow r in us.Rows)
            {
                FrbaHotel.ClasesTabla.Persona per = new FrbaHotel.ClasesTabla.Persona();
                per.codigo = r.Field<decimal>("codigo");
                per.nombre = r.Field<string>("nombre");
                per.apellido = r.Field<string>("apellido");
                per.codigo_tipo_doc = r.Field<decimal>("codigo_tipo_doc");
                per.num_doc = r.Field<decimal>("num_doc");
                per.mail = r.Field<string>("mail");
                per.telefono = r.Field<decimal?>("telefono");
                per.num_calle = r.Field<decimal>("num_calle");
                per.nom_calle = r.Field<string>("nom_calle");
                per.localidad = r.Field<string>("localidad");
                per.ciudad = r.Field<string>("ciudad");
                per.pais = r.Field<string>("pais");
                per.nacionalidad = r.Field<string>("nacionalidad");
                per.fecha_nacimiento = r.Field<DateTime>("fecha_nacimiento");
                per.piso = r.Field<Nullable<decimal>>("piso");
                per.depto = r.Field<string>("depto");
                int estado = r.Field<byte>("estado");
                if (estado == 1) per.estado = true;
                else per.estado = false;
                personas.Add(per);
            }
            return personas;
        }


        public decimal Save(Persona per)
        {
            int ex = entidadBase.EjecutarSQL("insert hotel.Persona (nombre,apellido,codigo_tipo_doc,num_doc,mail,telefono,nom_calle,num_calle,localidad,ciudad,pais,nacionalidad,fecha_nacimiento,piso,depto,estado) values (" + ArmarValores(per) + ")");
            DataTable resultID = entidadBase.TraerDatos("SELECT max(codigo) from hotel.Persona ");
            DataRow row = resultID.Rows[0];
            return Convert.ToInt32(row[0]);
        }

        public decimal Update(Persona per)
        {
            int ex = entidadBase.EjecutarSQL("hotel.SP_UPDPERSONA " + ArmarValores(per));
            return per.codigo;
        }

        public void Delete(decimal codigo)
        {
            int ex = entidadBase.EjecutarSQL("update hotel.Persona set estado = 0 where codigo =" + codigo);
        }


        internal List<Persona> GetByDoc(decimal documento)
        {
            List<Persona> persona = GetBySQL("select * from hotel.Persona p where p.num_doc =" + documento.ToString()).ToList();
            return persona;
        }

        public void updateEstado(string num, decimal estado)
        {
            int ex = entidadBase.EjecutarSQL("update hotel.Persona set estado = " + estado +" where codigo =" + num);
        }
    }
}
