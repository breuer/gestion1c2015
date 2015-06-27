using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrbaHotel.ClasesTabla
{
    class HabitacionEstadistica
    {
        public decimal numero { get; set; }
        public decimal piso { get; set; }
        public string ubicacion_frente { get; set; }
        public string CalleHotel { get; set; }
        public decimal NumCalleHotel { get; set; }
        public int cantVecesOcupadas { get; set; }
    }
}
