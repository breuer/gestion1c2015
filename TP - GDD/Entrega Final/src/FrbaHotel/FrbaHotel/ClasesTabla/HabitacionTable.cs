using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrbaHotel.ClasesTabla
{
    class HabitacionTable
    {
        public decimal codigo { get; set; }
        public decimal numero { get; set; }
        public decimal cod_hotel { get; set; }
        public decimal piso { get; set; }
        public string ubicacion_frente { get; set; }
        public decimal cod_tipo_habitacion { get; set; }
        public string descripcion { get; set; }
        public bool estado { get; set; }
    }
}
