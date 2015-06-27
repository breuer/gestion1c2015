using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrbaHotel.ClasesTabla
{
    class Habitacion
    {
        public decimal codigo { get; set; }
        public decimal numero { get; set; }
        public decimal piso { get; set; }
        public string ubicacion_frente { get; set; }
        public string TipoHab { get; set; }
        public string descripcion { get; set; }
        public bool estado { get; set; }
    }
}
