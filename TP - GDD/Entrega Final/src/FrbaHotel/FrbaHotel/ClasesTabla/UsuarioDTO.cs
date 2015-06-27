using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrbaHotel.ClasesTabla
{
    class UsuarioDTO
    {
        public decimal codigo { get; set; }
        public string user_nombre { get; set; }
        public decimal logueado { get; set; }
        public decimal intentos_fallidos { get; set; }
        public bool estado { get; set; }
    }
}
