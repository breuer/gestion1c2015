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

    }
}
