using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using PagoElectronico.DAO;

namespace PagoElectronico.Model
{
    class Listado
    {
        private int year;
        private int mesInicio;
        private int mesFin;
        private int tipoListado;

        public int Year { get { return year; } set { year = value; } }
        public int MesInicio { get { return mesInicio; } set { mesInicio = value; } }
        public int MesFin { get { return mesFin; } set { mesFin = value; } }
        public int TipoListado { get { return tipoListado; } set { tipoListado = value; } }

        public DateTime FechaInicio { get { return new DateTime(year, mesInicio, 1); } }
        public DateTime FechaFin { get { return new DateTime(year, mesFin, DateTime.DaysInMonth(year, mesFin)); } }

        public DataTable listar()
        {
            ListadoDAO dao = new ListadoDAO();
            DataTable table = null;
            switch (tipoListado)
            {
                case 1:
                    table = dao.listarClientesConAlgunaCuentaInhabilitada(this);
                    break;
                case 2:
                    table = dao.listarClienteConMayorCantidadDeComisionesFacturadas(this);
                    break;
                case 3:
                    table = dao.listarClientesConMayorCantidadDeTransaccionesRealizadas(this);
                    break;
                case 4:
                    table = dao.listarPaisesConMayorCantidadDeMovimientos(this);
                    break;
                case 5:
                    table = dao.listarTotalFacturadosParaLosDistintosTiposDeCuentas(this);
                    break;
            }
            return table;
        }
    }
}
