using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace FrbaHotel.ClasesTabla
{
    class Estadia
    {
        public decimal codigo { get; set; }
        public decimal cod_reserva { get; set; }
        public DateTime fecha_hora_in { get; set; }
        public DateTime? fecha_hora_out { get; set; }
        public decimal? cod_usuario_carga_in { get; set; }
        public decimal? cod_usuario_carga_out { get; set; }
        public decimal cant_noches_estadia { get; set; }
    }
}
