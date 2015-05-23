using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PagoElectronico.Model;
using PagoElectronico.Login;

namespace PagoElectronico
{
    public partial class FormMain : Form
    {
        private void habilitarPaneles()
        {
            this.btLogin.Visible = true;
            this.btLogout.Visible = false;
            this.pnlRol.Visible = false;
            this.pnlUsuario.Visible = false;
            this.pnlCliente.Visible = false;

            /*this.btChangePassword.Visible = false;            
            this.pnlListados.Visible = false;*/

            foreach (Funcionalidad funcionalidad in DataSession.Usuario.RolSeleccionado.Funcionalidades)
            {
                if (funcionalidad.Nombre.Equals("abm rol"))
                    this.pnlRol.Visible = true;
                if (funcionalidad.Nombre.Equals("abm usuario"))
                    this.pnlRol.Visible = true;
                if (funcionalidad.Nombre.Equals("abm cliente"))
                    this.pnlCliente.Visible = true;
                if (funcionalidad.Nombre.Equals("abm cuenta"))
                    this.pnlCliente.Visible = true;
            }
        }
        public FormMain()
        {
            InitializeComponent();
            //habilitarPaneles();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            FormLogin frm = new FormLogin(usuario);
            frm.ShowDialog();

            if (frm.DialogResult == DialogResult.OK)
            {
                if (usuario.Roles.Count > 1)
                {
                    FormChooseRol frmRoles = new FormChooseRol(usuario);
                    frmRoles.ShowDialog();
                }
                else
                {
                    usuario.rolPorDefecto();
                }

                DataSession.Usuario = usuario;
                //habilitarPaneles();
                this.btLogin.Visible = false;
                this.btLogout.Visible = true;
                //this.btChangePassword.Visible = true;
            }
            else
            {
                MessageBox.Show("Login incorrecto");
            }

        }

        private void btAddCliente_Click(object sender, EventArgs e)
        {
            
        }
    }
}
