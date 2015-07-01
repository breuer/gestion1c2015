using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PagoElectronico.Model
{
    public class Cuenta : IModel<Cuenta>
    {
        private int numero;
        private int paisCod;
        private DateTime fechaApertura;
        //tipoCuenta

        public int Numero { get { return numero; } set { numero = value; } }
        public int PaisCod { get { return paisCod; } set { paisCod = value; } }
        public DateTime FechaApertura { get { return fechaApertura; } set { fechaApertura = value; } }

        #region IModel<Cuenta> Members

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

        public List<Cuenta> getAll()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
