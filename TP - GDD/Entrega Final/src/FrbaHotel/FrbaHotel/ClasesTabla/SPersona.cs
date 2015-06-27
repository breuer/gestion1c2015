using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrbaHotel.ClasesTabla
{
    class SPersona
    {
        private DPersona _perDao;
        private DPersona perDao
        {
            get
            {
                if (_perDao == null)
                    _perDao = new DPersona();
                return _perDao;
            }
        }

        public Persona getByCodigo(string codigo)
        {
            return perDao.getByCodigo(codigo);
        }

        public List<Persona> GetByMail(string mail)
        {
            return perDao.GetByMail(mail);
        }

        public List<Persona> GetByGrilla(string nombre, string apellido, string tipoDni, string dni, string email)
        {
            return perDao.GetBySQL(ordernarItemsParaConsulta(nombre, apellido, tipoDni, dni, email));
        }

        public string ordernarItemsParaConsulta(string nombre, string apellido, string tipoDni, string dni, string email)
        {
            StringBuilder consulta = new StringBuilder();
            bool inicial = true;
            consulta.Append("SELECT * FROM hotel.Persona ");
            string sqlWhere = " p WHERE ";

            if (nombre != "")
            {
                if (!inicial)
                    consulta.Append(" AND ");
                else
                {
                    inicial = false;
                    consulta.Append(sqlWhere);
                }
                consulta.Append("p.nombre LIKE '%" + nombre + "%'");
            }
            if (apellido != "")
            {
                if (!inicial)
                    consulta.Append(" AND ");
                else
                {
                    inicial = false;
                    consulta.Append(sqlWhere);
                }
                consulta.Append("p.apellido LIKE '%" + apellido + "%'");
            }
            if (tipoDni != "")
            {
                if (!inicial)
                    consulta.Append(" AND ");
                else
                {
                    inicial = false;
                    consulta.Append(sqlWhere);
                }
                consulta.Append("p.codigo_tipo_doc = " + tipoDni);
            }
            if (dni != "")
            {
                if (!inicial)
                    consulta.Append(" AND ");
                else
                {
                    inicial = false;
                    consulta.Append(sqlWhere);
                }
                consulta.Append("p.num_doc = " + dni);
            }
            if (email != "")
            {
                if (!inicial)
                    consulta.Append(" AND ");
                else
                {
                    inicial = false;
                    consulta.Append(sqlWhere);
                }
                consulta.Append("p.mail LIKE '%" + email + "%'");
            }
            return consulta.ToString();
        }

        public Persona GetByCod(decimal cod)
        {
            return perDao.GetByCod(cod);
        }

        public List<Persona> GetAllActivos()
        {
            return perDao.GetAllActivos();
        }

        public List<Persona> GetAllClientes()
        {
            return perDao.GetAllClientes();
        }

        public List<Persona> GetBySQL(string consulta)
        {
            return perDao.GetBySQL(consulta);
        }

        public decimal Save(Persona per)
        {
            return perDao.Save(per);
        }

        public decimal Update(Persona per)
        {
            return perDao.Update(per);
        }

        public void Delete(decimal codigo)
        {
            perDao.Delete(codigo);
        }

        internal List<Persona> GetByDoc(decimal documento)
        {
            return perDao.GetByDoc(documento);
        }

        public List<Persona> GetByMailToValidate(string mail, string codigo)
        {
            return perDao.GetByMailToValidate(mail, codigo);
        }

        public void deshabilitarCliente(string num)
        {
            perDao.updateEstado(num, 0);
        }

        public void habilitarCliente(string num)
        {
            perDao.updateEstado(num, 1);
        }
    }
}
