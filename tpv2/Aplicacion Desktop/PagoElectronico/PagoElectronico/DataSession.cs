using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PagoElectronico.Model;

namespace PagoElectronico
{
    class DataSession
    {
        private static Usuario usuario;
        //private static Rol rol;

        public static Usuario Usuario { get { return usuario; } set { usuario = value; } }
        //public static Rol Rol { get { return usuario.RolSeleccionado; } set { usuario = value; } }
        public static DateTime FechaSistema { get { return Properties.Settings.Default.SYSTEM_DATE; } }

        public const int ALTA = 1;
        public const int MODIFICACION = 2;
        public const int BAJA = 3;

        private static List<TipoIdentificacion> tipoIdentificaciones;
        public static List<TipoIdentificacion> TipoIdentificaciones
        {
            get { return tipoIdentificaciones; } 
            //set { tipoIdentificaciones = value; }
        }

        private static List<Pais> paices;
        public static List<Pais> Paices
        {
            get { return paices; }
            //set { tipoIdentificaciones = value; }
        }

        public static void inicializar()
        {
            tipoIdentificaciones = (new TipoIdentificacion()).getAll();
            paices = (new Pais()).getAll();
        }
    }
}
