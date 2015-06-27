using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrbaHotel.ClasesTabla
{
    class ItemFactura
    {
        public decimal codigo { get; set; }
        public string descripcion { get; set; }
        public int cantidad { get; set; }
        public decimal monto { get; set; }
    }
}