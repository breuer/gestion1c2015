using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrbaHotel.ClasesTabla
{
    class HotelDTO
    {
        public decimal codigo { get; set; }
        public string nom_calle { get; set; }
        public decimal num_calle { get; set; }
        public string ciudad { get; set; }
        public decimal cant_estrellas { get; set; }
        public string nombre { get; set; }
        public string mail { get; set; }
        public decimal? telefono { get; set; }
        public string pais { get; set; }
    }
}
