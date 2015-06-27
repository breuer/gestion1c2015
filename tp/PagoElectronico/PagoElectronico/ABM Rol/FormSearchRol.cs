using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PagoElectronico.Model;

namespace PagoElectronico.ABM_Rol
{
    public partial class FormSearchRol : Form
    {
        private Rol rol;
        private List<Rol> roles;

        private Rol getRol(int codigo)
        {
            foreach (Rol r in roles)
            {
                if (r.Id == codigo)
                {
                    MessageBox.Show("rol: "+r.Id);
                    return r;
                }
            }
            return null;
        }

        private void inicializarCB()
        {
            //MessageBox.Show("roles"+(new Rol()).getAll().Count());
            this.cbRoles.DataSource = roles;
            this.cbRoles.ValueMember = "id";
            this.cbRoles.DisplayMember = "nombre";
        }

        public FormSearchRol(Rol rol)
        {
            InitializeComponent();
            this.rol = rol;
            this.roles = (new Rol()).getAll();
            inicializarCB();
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btAceptar_Click(object sender, EventArgs e)
        {
            this.rol.Id = int.Parse(this.cbRoles.SelectedValue.ToString());
            this.rol.get();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
