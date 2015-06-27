using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PagoElectronico.Model;

namespace PagoElectronico.ABM_de_Usuario
{
    public partial class FormSearchUsuario : Form
    {
        private Usuario usuario;


        public FormSearchUsuario(Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
        }



        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btSelect_Click(object sender, EventArgs e)
        {
           
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            this.usuario.Username = tbUsername.Text;
        }
    }

    public class UsuarioRow : DataGridViewRow
    {
        private int? codigo;

        public int? Codigo { get { return codigo; } }

        public UsuarioRow(Usuario usuario)
        {
            this.codigo = usuario.Id;
            var username = new DataGridViewTextBoxCell();
            username.Value = usuario.Username;
            Cells.AddRange(new DataGridViewCell[] { username });
        }
    }
}
