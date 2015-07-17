using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PagoElectronico.DAO;

namespace PagoElectronico.Model
{
    public class TipoCuenta : IModel<TipoCuenta>
    {
        private int id;
        private string nombre;
        private string descrip_completa;
        private int costo;
        private int duracionDias;
        private int estadoInicialCod;

        public int Id { get { return id; } set { id = value; } }
        public string Nombre { get { return nombre; } set { nombre = value; } }
        public string Completa { get { return descrip_completa; } set { descrip_completa = value; } }
        public int Costo { get { return costo; } set { costo = value; } }
        public int DuracionDias { get { return duracionDias; } set { duracionDias = value; } }
        public int EstadoInicialCod { get { return estadoInicialCod; } set { estadoInicialCod = value; } }

        #region IModel<TipoCuenta> Members

        public int add()
        {
            throw new NotImplementedException();
        }

        public void update()
        {
            throw new NotImplementedException();
        }

        public void delete()
        {
            throw new NotImplementedException();
        }

        public int get()
        {
            throw new NotImplementedException();
        }

        public List<TipoCuenta> getAll()
        {
            return (new TipoCuentaDAO()).getAll(null);
        }

        #endregion
    }
}
