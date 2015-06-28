using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using PagoElectronico.Model;

namespace PagoElectronico.DAO
{
    public class Repository
    {
        public string formatDateTime = "yyyy-MM-dd HH:MM:ss";
        
        public DateTime get_date()
        {
          return  Properties.Settings.Default.SYSTEM_DATE;        
        }

        public DataTable list(String spName, List<SqlParameter> parametros)
        {
            SqlConnection sqlConnection = new SqlConnection(Properties.Settings.Default.dbConnection);
            SqlCommand sqlCommand = new SqlCommand(spName, sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            if (parametros.Count != 0)
            {
                sqlCommand.Parameters.AddRange(parametros.ToArray());
            }
            try
            {
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                return (dataTable);
            }
            catch (Exception e)
            {
                MessageBox.Show(
                    e.Message,
                    Application.ProductName,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                Application.Exit();
                return null;
            }
            finally
            {
                sqlCommand.Parameters.Clear();
                sqlConnection.Dispose();
                sqlCommand.Dispose();
            }

        }

        /*public class Container
        {
            public T InstantiateType<T>(DataTable data) where T : IPerson, new()
            {
                T obj = new T();
                obj.FirstName = firstName;
                obj.LastName = lastName;
                return obj;
            }
        }

        public void getList<T>(String spName, List<SqlParameter> parametros)
        {
            DataTable data = list("H.SP_ROLES", parametros);
            List<T> listT = new List<T>();
            foreach (DataRow row in data.Rows)
            {
                T temp;
                listT.Add(new temp(row));
            }
            return listT;   
        }*/

        public  List<SqlParameter> callProcedure_old(String spName, List<SqlParameter> parametros)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Properties.Settings.Default.dbConnection))
            {
                SqlCommand sqlCommand = new SqlCommand(
                    spName,
                    sqlConnection
                );
                sqlCommand.CommandType = CommandType.StoredProcedure;
                if (parametros.Count != 0)
                {
                    sqlCommand.Parameters.AddRange(parametros.ToArray());
                }
                try
                {
                    sqlConnection.Open();
                    sqlCommand.ExecuteNonQuery();
                    List<SqlParameter> listReturn = new List<SqlParameter>();
                    foreach (SqlParameter param in sqlCommand.Parameters)
                    {
                        if (param.Direction == ParameterDirection.ReturnValue)
                        {
                            listReturn.Add(param);
                        }
                        else if (param.Direction == ParameterDirection.Output || param.Direction == ParameterDirection.InputOutput)
                        {
                            listReturn.Add(param);
                        }
                    }
                    return listReturn;
                }
                catch (Exception e)
                {
                    throw new Exception(e.Message);
                }
                finally
                {
                    sqlCommand.Parameters.Clear();
                    sqlConnection.Dispose();
                    sqlCommand.Dispose();
                }
            }
        }

        public int callProcedure(String spName, List<SqlParameter> parametros)
        {
            SqlConnection sqlConnection = new SqlConnection(Properties.Settings.Default.dbConnection);
            SqlCommand sqlCommand = new SqlCommand(spName, sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            if (parametros.Count != 0)
            {
                sqlCommand.Parameters.AddRange(parametros.ToArray());
            }
            try
            {
                SqlParameter returnValue = new SqlParameter("@RETURN_VALUE", SqlDbType.Int);
                returnValue.Direction = ParameterDirection.ReturnValue;
                sqlCommand.Parameters.Add(returnValue);

                sqlConnection.Open();
                sqlCommand.ExecuteNonQuery();

                return (int)sqlCommand.Parameters["@RETURN_VALUE"].Value;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                sqlCommand.Parameters.Clear();
                sqlConnection.Dispose();
                sqlCommand.Dispose();
            }
        }
    }
}
