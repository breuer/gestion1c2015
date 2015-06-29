using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrbaHotel.ClasesTabla
{
    class SRegimen
    {
        private DRegimen _regDao;
        private DRegimen regDao
        {
            get
            {
                if (_regDao == null)
                    _regDao = new DRegimen();
                return _regDao;
            }
        }

        public List<Regimen> GetAll()
        {
            return regDao.GetAll();
        }

        public List<RegimenDTO> GetAllHotel(decimal codHotel)
        {
            return regDao.GetAllHotel(codHotel);
        }

        public List<RegimenDTO> GetBySQLDTO(string consulta)
        {
            return regDao.GetBySQLDTO(consulta);
        }

        public List<Regimen> GetBySQL(string consulta)
        {
            return regDao.GetBySQL(consulta);
        }

        public decimal Save(Regimen reg)
        {
            return regDao.Save(reg);
        }

        public RegimenDTO GetByCodDTO(decimal codReg, decimal codHotel)
        {
            return regDao.GetByCodDTO(codReg, codHotel);
        }

        public decimal SaveDTO(Regimen reg, decimal codHotel)
        {
            return regDao.SaveDTO(reg, codHotel);
        }

        public decimal SaveDTO(RegimenDTO reg)
        {
            return regDao.SaveDTO(reg);
        }

        public decimal UpdateDTO(RegimenDTO reg)
        {
            return regDao.UpdateDTO(reg);
        }
        
        public void Update(Regimen reg)
        {
            regDao.Update(reg);
        }

        public void Delete(decimal codigo, decimal codHotel)
        {
            regDao.Delete(codigo, codHotel);
        }
    }
}
