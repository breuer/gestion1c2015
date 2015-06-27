using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace FrbaHotel.ClasesTabla
{
    class DRegimen
    {
        EntidadBase entidadBase = new EntidadBase();

        public List<Regimen> GetAll()
        {
            DataTable regs = entidadBase.TraerDatos("select * from hotel.Regimen");
            List<Regimen> regimenes = new List<Regimen>();

            foreach (DataRow r in regs.Rows)
            {
                Regimen regimen = new Regimen();
                regimen.codigo = r.Field<decimal>("codigo");
                regimen.descripcion = r.Field<string>("descripcion");
                regimenes.Add(regimen);
            }
            return regimenes;
        }

        public Regimen GetByCod(int codigo)
        {
            List<Regimen> regimenes = GetAll();
            Regimen reg = (from r in regimenes where r.codigo == codigo select r).SingleOrDefault();
            return reg;
        }

        public decimal Save(Regimen regimen)
        {
            int ex = entidadBase.EjecutarSQL("insert hotel.Regimen (descripcion) values (" + ArmarValores(regimen) + ")");
            DataTable resultID = entidadBase.TraerDatos("SELECT max(codigo) from hotel.Regimen ");
            DataRow row = resultID.Rows[0];
            return Convert.ToInt32(row[0]);
        }

        public decimal SaveDTO(Regimen regimen, decimal codHotel)
        {
            int ex = entidadBase.EjecutarSQL("insert hotel.Regimen_hotel (cod_regimen,cod_hotel,precio_base,estado) values (" + regimen.codigo + ","+ codHotel + ",0,0 )");
            return ex;
        }

        public decimal SaveDTO(RegimenDTO regimen)
        {
            int estado;
            if (regimen.estado == true)
                estado = 1;
            else
                estado = 0;
            var precioBase = regimen.precio_base.ToString().Replace(',', '.');
            int ex2 = entidadBase.EjecutarSQL("insert hotel.Regimen (descripcion) values ('" + regimen.descripcion + "')");
            DataTable resultID = entidadBase.TraerDatos("SELECT max(codigo) from hotel.Regimen ");
            DataRow row = resultID.Rows[0];
            var codReg = Convert.ToInt32(row[0]);
            int ex = entidadBase.EjecutarSQL("insert hotel.Regimen_hotel (cod_regimen,cod_hotel,precio_base,estado) values (" + codReg + ','+ regimen.cod_hotel +',' + precioBase + ','+ estado + ")");
            return ex;
        }

        public decimal UpdateDTO(RegimenDTO regimen)
        {
            int estado;
            if (regimen.estado == true)
                estado = 1;
            else
                estado = 0;
            var precioBase = regimen.precio_base.ToString().Replace(',', '.');
            int ex = entidadBase.EjecutarSQL("update hotel.Regimen_hotel set precio_base = " + precioBase + ", estado = " + estado + " where cod_regimen = "+ regimen.cod_regimen + " and cod_hotel = " + regimen.cod_hotel);
            int ex2 = entidadBase.EjecutarSQL("update hotel.Regimen set descripcion = '" + regimen.descripcion + "' where codigo = " + regimen.cod_regimen);
            return ex;
        }

        public void Update(Regimen regimen)
        {
            int ex = entidadBase.EjecutarSQL("update hotel.Regimen set descripcion = " + regimen.descripcion + " where codigo = " + regimen.codigo);
        }

        private string ArmarValores(Regimen regimen)
        {
            StringBuilder Valores = new StringBuilder();
            if (regimen.codigo != 0)
                Valores.Append(regimen.codigo + ",");
            Valores.Append("'" + regimen.descripcion + "'");
            return Valores.ToString();
        }

        public RegimenDTO GetByCodDTO(decimal codigo, decimal codHotel)
        {
            RegimenDTO reg = GetBySQLDTO("select h.cod_regimen, r.descripcion, h.cod_hotel, h.precio_base, h.estado from hotel.Regimen r, hotel.Regimen_Hotel h where h.cod_regimen = r.codigo and h.cod_hotel = " + codHotel + " and h.cod_regimen = " + codigo).SingleOrDefault();
            return reg;
        }

        public void Delete(decimal codigo, decimal codHotel)
        {
            int ex = entidadBase.EjecutarSQL("update hotel.Regimen_Hotel set estado = 0 where cod_regimen = " + codigo + " and cod_hotel = " + codHotel);
        }

        public List<RegimenDTO> GetAllHotel(decimal codigoHotel)
        {
            List<RegimenDTO> regimenes = GetBySQLDTO("select h.cod_regimen, r.descripcion, h.cod_hotel, h.precio_base, h.estado from hotel.Regimen r, hotel.Regimen_Hotel h where h.cod_regimen = r.codigo and h.cod_hotel = "+codigoHotel);
            return regimenes;
        }

        internal List<Regimen> GetBySQL(string consulta)
        {
            DataTable regs = entidadBase.TraerDatos(consulta);
            List<Regimen> regimenes = new List<Regimen>();

            foreach (DataRow r in regs.Rows)
            {
                Regimen reg = new Regimen();
                reg.codigo = r.Field<decimal>("codigo");
                reg.descripcion = r.Field<string>("descripcion");
                regimenes.Add(reg);
            }
            return regimenes;
        }

        public List<RegimenDTO> GetBySQLDTO(string consulta)
        {
            DataTable regs = entidadBase.TraerDatos(consulta);
            List<RegimenDTO> regimenes = new List<RegimenDTO>();

            foreach (DataRow r in regs.Rows)
            {
                RegimenDTO reg = new RegimenDTO();
                reg.cod_regimen = r.Field<decimal>("cod_regimen");
                reg.descripcion = r.Field<string>("descripcion");
                reg.precio_base = r.Field<decimal>("precio_base");
                reg.cod_hotel = r.Field<decimal>("cod_hotel");
                int estado = r.Field<byte>("estado");
                if (estado == 1) reg.estado = true;
                else reg.estado = false;
                regimenes.Add(reg);
            }
            return regimenes;
        }
    }
}
