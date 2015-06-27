using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrbaHotel.ClasesTabla
{
    class RegimenDTO
    {
        public decimal cod_regimen { get; set; }
        public string descripcion { get; set; }
        public decimal cod_hotel { get; set; }
        public decimal precio_base { get; set; }
        public bool estado { get; set; }
    }
}
