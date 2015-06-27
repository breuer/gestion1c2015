using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrbaHotel.ClasesTabla
{
    class Reserva
    {
        public decimal codigo { get; set; }
        public decimal cod_hotel { get; set; }
        public DateTime fecha_desde { get; set; }
        public DateTime fecha_hasta { get; set; }
        public DateTime fecha_creacion { get; set; }
        public decimal? cant_huespedes { get; set; }
        public decimal cod_tipo_regimen { get; set; }
        public decimal cod_estado { get; set; }
        public decimal cod_usuario_carga { get; set; }
        public decimal cant_noches { get; set; }
        public decimal cod_persona { get; set; }
    }

    class Reserva_Habitacion
    {
        public decimal cod_reserva { get; set; }
        public decimal cod_habitacion { get; set; }
    }
}

