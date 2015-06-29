using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using PagoElectronico.Model;

namespace PagoElectronico.DAO
{
    class ListadoDAO : Repository
    {

        public DataTable listarClientesConAlgunaCuentaInhabilitada(Listado listado)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("fecha_inicio", listado.FechaInicio));
            parametros.Add(new SqlParameter("fecha_fin", listado.FechaFin));
            return list("", parametros);
        }

        public DataTable listarClienteConMayorCantidadDeComisionesFacturadas(Listado listado)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("fecha_inicio", listado.FechaInicio));
            parametros.Add(new SqlParameter("fecha_fin", listado.FechaFin));
            return list("", parametros);
        }
         public DataTable listarClientesConMayorCantidadDeTransaccionesRealizadas(Listado listado)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("fecha_inicio", listado.FechaInicio));
            parametros.Add(new SqlParameter("fecha_fin", listado.FechaFin));
            return list("", parametros);
        }
         public DataTable listarPaisesConMayorCantidadDeMovimientos(Listado listado)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("inicio", listado.FechaInicio));
            parametros.Add(new SqlParameter("fin", listado.FechaFin));
            return list("NEW_SOLUTION.sp_stats_4", parametros);
        }
         public DataTable listarTotalFacturadosParaLosDistintosTiposDeCuentas(Listado listado)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("inicio", listado.FechaInicio));
            parametros.Add(new SqlParameter("fin", listado.FechaFin));
            return list("NEW_SOLUTION.sp_stats_5", parametros);
        }
    }
}
