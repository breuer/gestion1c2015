using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace FrbaHotel.ClasesTabla
{
    class DTipoDoc
    {
        EntidadBase entidadBase = new EntidadBase();

        public List<TipoDoc> GetAll()
        {
            DataTable table = entidadBase.TraerDatos("select * from hotel.Tipo_Doc");
            List<TipoDoc> tipos = new List<TipoDoc>();

            foreach (DataRow r in table.Rows)
            {
                TipoDoc tip = new TipoDoc();
                tip.codigo = r.Field<decimal>("codigo");
                tip.descripcion = r.Field<string>("descripcion");
                tipos.Add(tip);
            }
            return tipos;
        }

        public List<TipoDoc> GetAllWithNull()
        {
            DataTable table = entidadBase.TraerDatos("select * from hotel.Tipo_Doc");
            List<TipoDoc> tipos = new List<TipoDoc>();
            TipoDoc tipo = new TipoDoc();
            tipo.codigo = 0;
            tipo.descripcion = "seleccione...";
            tipos.Add(tipo);

            foreach (DataRow r in table.Rows)
            {
                TipoDoc tip = new TipoDoc();
                tip.codigo = r.Field<decimal>("codigo");
                tip.descripcion = r.Field<string>("descripcion");
                tipos.Add(tip);
            }
            return tipos;
        }

        public TipoDoc GetByCod(decimal codigo)
        {
            List<TipoDoc> tipos = GetAll();
            TipoDoc tip = (from r in tipos where r.codigo == codigo select r).SingleOrDefault();
            return tip;
        }

        internal List<TipoDoc> GetBySQL(string consulta)
        {
            DataTable table = entidadBase.TraerDatos(consulta);
            List<TipoDoc> tipos = new List<TipoDoc>();

            foreach (DataRow r in table.Rows)
            {
                TipoDoc tip = new TipoDoc();
                tip.codigo = r.Field<decimal>("codigo");
                tip.descripcion = r.Field<string>("descripcion");
                tipos.Add(tip);
            }
            return tipos;
        }
    }
}
