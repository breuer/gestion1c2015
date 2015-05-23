using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PagoElectronico.DAO;

namespace PagoElectronico.Model
{
    public class Cliente
    {
        private int id;
        private string nombre;
        private string apellido;
        private string mail;
        //private List<Funcionalidad> funcionalidades;

        public int Id { get { return id; } set { id = value; } }
        public string Nombre { get { return nombre; } set { nombre = value; } }
        public string Apellido { get { return apellido; } set { apellido = value; } }
        public string Mail { get { return mail; } set { mail = value; } }

        public void add()
        {
            ClienteDAO dao = new ClienteDAO();
            dao.add(this);
        }
    }
}
