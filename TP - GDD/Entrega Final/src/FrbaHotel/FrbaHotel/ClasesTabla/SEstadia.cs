using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrbaHotel.ClasesTabla
{
    class SEstadia
    {
        private DEstadia _estadiaDAO;
        private DEstadia estadiaDAO
        {
            get
            {
                if (_estadiaDAO == null)
                    _estadiaDAO = new DEstadia();
                return _estadiaDAO;
            }
        }

        public decimal guardarEstadia(Estadia estadia)
        {
            return estadiaDAO.Save(estadia);
        }

        public decimal generarCheckOut(string codigo, string fecha_out)
        {
            return estadiaDAO.checkOut(codigo, fecha_out);
        }

        public Estadia getEstadia(string num_reserva)
        {
            return estadiaDAO.getEstadia(num_reserva);
        }
    }
}