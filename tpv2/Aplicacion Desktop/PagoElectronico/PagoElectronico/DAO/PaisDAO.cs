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
    class PaisDAO : Repository, IDAO<Pais>
    {
        #region IDAO<Pais> Members

        public void add(Pais obj)
        {
            throw new NotImplementedException();
        }

        public void update(Pais obj)
        {
            throw new NotImplementedException();
        }

        public void get(Pais obj)
        {
            throw new NotImplementedException();
        }

        public List<Pais> getAll(Pais obj)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            DataTable table = list("NEW_SOLUTION.sp_pais_get", parametros);
            List<Pais> paises = new List<Pais>();
            foreach (DataRow row in table.Rows)
            {
                Pais pais = new Pais();
                pais.Id = int.Parse(row["pais_cod"].ToString());
                pais.Nombre = row["pais_descrip"].ToString();
                paises.Add(pais);
            }
            return paises;
        }

        #endregion
    }
}
