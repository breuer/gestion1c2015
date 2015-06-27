using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrbaHotel.ClasesTabla
{
    class CancelacionHotel
    {
        public decimal codigo { get; set; }
        public decimal cod_hotel { get; set; }
        public DateTime fecha_desde { get; set; }
        public DateTime fecha_hasta { get; set; }
        public string motivo { get; set; }
    }
}
