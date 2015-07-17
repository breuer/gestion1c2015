using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PagoElectronico.Model;

namespace PagoElectronico
{
    class DataSession
    {
        public const int ROL_CLIENTE = 2;
        public const int ROL_ADMINISTRADOR = 1;

        public static string FUNCIONALIDAD_LOGIN = "Login";
        public static string FUNCIONALIDAD_CLIENTES = "Clientes";
        public static string FUNCIONALIDAD_USUARIOS = "Login";
        public static string FUNCIONALIDAD_CUENTAS = "Cuentas";
        public static string FUNCIONALIDAD_TRANSFERENCIAS = "Transferencias";
        public static string FUNCIONALIDAD_DEPOSITOS = "Depositos";
        public static string FUNCIONALIDAD_RETIROS = "Retiros";
        public static string FUNCIONALIDAD_TARJETAS = "Tarjetas";
        public static string FUNCIONALIDAD_ROLES = "Roles";
        public static string FUNCIONALIDAD_FACTURACION = "Facturacion";
        public static string FUNCIONALIDAD_SALDO = "Saldo";
        public static string FUNCIONALIDAD_ESTADISTICAS = "Estadisticas";
        public static string FUNCIONALIDAD_SALDO_ADMIN = "Saldo admin";
        public static string FUNCIONALIDAD_CUENTAS_CLIENTES = "Cuentas admin";
        public static string FUNCIONALIDAD_FACTURACION_ADMIN = "Facturacion admin";

        public const int ESTADO_CUENTA_PEDIENTE_ACTIVACION = 2;
        public const int ESTADO_CUENTA_INHABILITADA = 0;
        public const int ESTADO_CUENTA_HABILITADA = 1;
        public const int ESTADO_CUENTA_CERRADA = 3;
        public const int ESTADO_CUENTA_VENCIDA = 4;

        public const int TIPO_CUENTA_GRATUITA = 3;

        private static Usuario usuario;
        private static DateTime fechaSistema;
        //private static Rol rol;

        public static Usuario Usuario { get { return usuario; } set { usuario = value; } }
        //public static Rol Rol { get { return usuario.RolSeleccionado; } set { usuario = value; } }
        //public static DateTime FechaSistema { get { return Properties.Settings.Default.SYSTEM_DATE; } }
        public static DateTime FechaSistema { get { return fechaSistema; } set { fechaSistema = value; } }


        public const int ALTA = 1;
        public const int MODIFICACION = 2;
        public const int BAJA = 3;

        private static List<TipoIdentificacion> tipoIdentificaciones;
        public static List<TipoIdentificacion> TipoIdentificaciones
        {
            get { return tipoIdentificaciones; } 
            //set { tipoIdentificaciones = value; }
        }

        private static List<Pais> paises;
        public static List<Pais> Paises { get { return paises; } }

        private static List<Moneda> monedas;
        public static List<Moneda> Monedas { get { return monedas; } }
        
        public static List<TipoCuenta> tipoCuentas;
        public static List<TipoCuenta> TipoCuentas { get { return tipoCuentas; } }

        public static List<EstadoCuenta> estadosCuenta;
        public static List<EstadoCuenta> EstadosCuenta { get { return estadosCuenta; } }

        public static void inicializar()
        {
            tipoIdentificaciones = (new TipoIdentificacion()).getAll();
            paises = (new Pais()).getAll();
            monedas = (new Moneda()).getAll();
            tipoCuentas = (new TipoCuenta()).getAll();
            estadosCuenta = (new Cuenta()).getEstadosCuenta();
        }
    }
}
