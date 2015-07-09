using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PagoElectronico.Model;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace PagoElectronico.DAO
{
    class MonedaDAO : Repository, IDAO<Moneda>
    {
        #region IDAO<Moneda> Members

        public void add(Moneda obj)
        {
            throw new NotImplementedException();
        }

        public void update(Moneda obj)
        {
            throw new NotImplementedException();
        }

        public void get(Moneda obj)
        {
            throw new NotImplementedException();
        }

        public List<Moneda> getAll(Moneda obj)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            DataTable table = list("NEW_SOLUTION.sp_moneda_get", parametros);
            List<Moneda> monedas = new List<Moneda>();
            foreach (DataRow row in table.Rows)
            {
                Moneda moneda = new Moneda();
                moneda.Id = int.Parse(row["moneda_id"].ToString());
                moneda.Nombre = row["moneda_descrip"].ToString();
                monedas.Add(moneda);
            }
            return monedas;
        }

        #endregion
    }
}
