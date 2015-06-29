using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace FrbaHotel.ClasesTabla
{
    class DTipoHab
    {
        EntidadBase entidadBase = new EntidadBase();

        public List<TipoHab> GetAll()
        {
            DataTable table = entidadBase.TraerDatos("select * from hotel.Tipo_Habitacion");
            List<TipoHab> tipos = new List<TipoHab>();

            foreach (DataRow r in table.Rows)
            {
                TipoHab tipo = new TipoHab();
                tipo.codigo = r.Field<decimal>("codigo");
                tipo.descripcion = r.Field<string>("descripcion");
                tipos.Add(tipo);
            }
            return tipos;
        }

        /* Regimenes por Hotel Habilitados */
        public List<Regimen> GetRegimenesByHotelHabilitados(String hotel)
        {
            DataTable regs = entidadBase.TraerDatos("hotel.SP_GETREGIMENporHOTELyHABILITADO " + hotel);
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

        /* Regimenes por Hotel */
        public List<Regimen> GetRegimenesByHotel(String hotel)
        {
            DataTable regs = entidadBase.TraerDatos("hotel.SP_GETREGIMENporHOTEL " + hotel);
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

        /* Regimenes por Hotel con opcion Null para select */
        public List<Regimen> GetRegimenesByHotelWithNull(String hotel)
        {
            DataTable regs = entidadBase.TraerDatos("hotel.SP_GETREGIMENporHOTELyHABILITADO " + hotel);
            List<Regimen> regimenes = new List<Regimen>();

            Regimen reg = new Regimen();
            reg.codigo = 0;
            reg.descripcion = "Seleccione...";
            regimenes.Add(reg);

            foreach (DataRow r in regs.Rows)
            {
                Regimen regimen = new Regimen();
                regimen.codigo = r.Field<decimal>("codigo");
                regimen.descripcion = r.Field<string>("descripcion");
                regimenes.Add(regimen);
            }
            return regimenes;
        }

        /* Tipo de Habitaciones por Hotel */
        public List<TipoHab> GetTipoHabByHotel(String hotel)
        {
            DataTable regs = entidadBase.TraerDatos("hotel.SP_GETTIPOHABITACIONporHOTEL " + hotel);
            List<TipoHab> tipos = new List<TipoHab>();

            foreach (DataRow r in regs.Rows)
            {
                TipoHab tipoHab = new TipoHab();
                tipoHab.codigo = r.Field<decimal>("codigo");
                tipoHab.descripcion = r.Field<string>("descripcion");
                tipos.Add(tipoHab);
            }
            return tipos;
        }

    }
}