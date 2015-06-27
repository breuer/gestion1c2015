using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace FrbaHotel
{
    class EntidadBase
    {
        SqlConnection miSqlConnect = new SqlConnection();
        SqlCommand miCommand;

        public void Conectar()
        {
            if (miSqlConnect.State == ConnectionState.Open)
                return;
            miSqlConnect.ConnectionString = "Data Source= localhost" + '\\' + "SQLSERVER2008;Initial Catalog=GD2C2014;User ID=gd;Password=gd2014";
          
            try
            {
                miSqlConnect.Open();
            }
            catch
            {
                throw new Exception("No pudo Conectarse");
            }
        }

        public void Desconectar()
        {

            miSqlConnect.Close();

        }

        public DataTable TraerDatos(string procedimientoAlmacenado)
        {
            Conectar();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(@procedimientoAlmacenado, miSqlConnect);
            DataTable data = new DataTable();
            try
            {
                dataAdapter.Fill(data);
            }
            catch
            {
                throw new Exception("No pudo traer los datos"); 
            }
             return data;
        }
        
        public int EjecutarSQL(string sql)
        {
            int Ok = 0;
            Conectar();
            
            miCommand = miSqlConnect.CreateCommand();
            miCommand.CommandText = sql;

            try
            {
                Ok = miCommand.ExecuteNonQuery();
            }
            catch
            {
                throw new Exception("No se pudo ejecutar la Accion");
            }
            return Ok;
        
        }

        public string Limpiar(string valor)
        {
            if (valor != null)
            {
               valor= valor.ToString().Replace("'", "´");
               valor=valor.ToString().Replace(',', '.');
                return valor.ToString();
            }
            return "";
        }

        public object EjecutarFuncionEscalarSQL(string sql)
        {
            object resultado;
            Conectar();

            miCommand = miSqlConnect.CreateCommand();
            miCommand.CommandText = sql;

            try
            {
                resultado = miCommand.ExecuteScalar();
            }
            catch
            {
                throw new Exception("No se pudo ejecutar la Accion");
            }
            return resultado;

        }
    }
}
