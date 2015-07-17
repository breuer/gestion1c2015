using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PagoElectronico.DAO;

namespace PagoElectronico.Model
{
    public class Cuenta : IModel<Cuenta>
    {
        private long id;
        private long numero;
        private long? clienteId;
        private DateTime fechaApertura;
        private int paisCod;
        private int monedaCod;
        private int tipoCuentaCod;
        private int estadoCuentaCod;
        private DateTime fechaVencimiento;
        private int cantSubscripciones;
        private DateTime fechaSistema;
        private float saldo;

        public long Id { get { return id; } set { id = value; } }
        public long Numero { get { return numero; } set { numero = value; } }
        public long? ClienteId { get { return clienteId; } set { clienteId = value; } }
        public DateTime FechaApertura { get { return fechaApertura; } set { fechaApertura = value; } }
        public int PaisCod { get { return paisCod; } set { paisCod = value; } }
        public int MonedaCod { get { return monedaCod; } set { monedaCod = value; } }
        public int TipoCuentaCod { get { return tipoCuentaCod; } set { tipoCuentaCod = value; } }
        public int EstadoCuentaCod { get { return estadoCuentaCod; } set { estadoCuentaCod = value; } }
        public DateTime FechaVencimiento { get { return fechaVencimiento; } set { fechaVencimiento = value; } }
        public int CantSubscripciones { get { return cantSubscripciones; } set { cantSubscripciones = value; } }
        public DateTime FechaSistema { get { return fechaSistema; } set { fechaSistema = value; } }
        public float Saldo { get { return saldo; } set { saldo = value; } }

        #region IModel<Cuenta> Members

        public int add()
        {
            CuentaDAO dao = new CuentaDAO();
            dao.add(this);
            return 1;
        }

        public void update()
        {
            CuentaDAO dao = new CuentaDAO();
            dao.update(this);
        }

        public void delete()
        {
            CuentaDAO dao = new CuentaDAO();
            dao.delete(this);
        }

        public int get()
        {
            CuentaDAO dao = new CuentaDAO();
            dao.get(this);
            return 1;
        }

        public List<Cuenta> getAll()
        {
            CuentaDAO dao = new CuentaDAO();
            return dao.getAll(this);
        }

        #endregion

        public long getNuevoNumeroCuenta()
        {
            CuentaDAO dao = new CuentaDAO();
            return dao.getNuevoNumeroCuenta();
        }

        public List<EstadoCuenta> getEstadosCuenta()
        {
            CuentaDAO dao = new CuentaDAO();
            return dao.getEstadosCuenta();
        }

        public void actualizarEstados()
        {
            CuentaDAO dao = new CuentaDAO();
            dao.actualizarEstados(this);
        }
        public void cerrar()
        {
            CuentaDAO dao = new CuentaDAO();
            dao.cerrar(this);
        }
        public void actualizarCuentas() 
        {
            CuentaDAO dao = new CuentaDAO();
            dao.actualizarCuentas(this);
        }
    }
}
