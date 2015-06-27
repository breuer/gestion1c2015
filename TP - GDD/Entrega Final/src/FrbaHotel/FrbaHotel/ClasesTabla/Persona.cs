using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrbaHotel.ClasesTabla
{
    class Persona
    {
        public decimal codigo { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public decimal codigo_tipo_doc { get; set; }
        public decimal num_doc { get; set; }
        public string mail { get; set; }
        public decimal? telefono { get; set; }
        public string nom_calle { get; set; }
        public decimal num_calle { get; set; }
        public string localidad { get; set; }
        public string ciudad { get; set; }
        public string pais { get; set; }
        public string nacionalidad { get; set; }
        public DateTime fecha_nacimiento { get; set; }
        public decimal? piso { get; set; }
        public string depto { get; set; }
        public bool estado { get; set; }
    }
}
