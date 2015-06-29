using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PagoElectronico.Model;

namespace PagoElectronico.Login
{
    public partial class FormChooseRol : Form
    {
        private Usuario usuario;

        public FormChooseRol()
        {
            InitializeComponent();
        }

        public FormChooseRol(Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
            this.cbbxRoles.DataSource = usuario.Roles;
            this.cbbxRoles.ValueMember = "id";
            this.cbbxRoles.DisplayMember = "Nombre";
        }
   
        private void btSelectRol_Click(object sender, EventArgs e)
        {
            foreach (Rol rol in usuario.Roles)
            {
                if (rol.Id == int.Parse(this.cbbxRoles.SelectedValue.ToString()))
                {
                    this.usuario.RolSeleccionado = rol;
                }
            }
            this.Close();
        }
    }
}
