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
using PagoElectronico.ABM_Rol;
using PagoElectronico.ABM_de_Usuario;
using PagoElectronico.ABM_Cliente;
using PagoElectronico.Listados;

namespace PagoElectronico
{
    public partial class FormMain : Form
    {
        private void habilitarPaneles()
        {
            if (DataSession.Usuario == null)
            {
                //En caso de que no halla un usuario cargado en la sesion, solo mostrar el login.
                this.btLogin.Visible            = true;
                this.btLogout.Visible           = false;
                this.btChangePassword.Visible   = false;

                //this.pnlSession.Visible     = false;
                this.pnlRol.Visible         = false;
                this.pnlUsuario.Visible     = false;
                this.pnlCliente.Visible     = false;
                this.pnlListados.Visible    = false;
            }
            else
            {
                //Habilitar el login.
                this.btLogin.Visible          = false;
                this.btLogout.Visible         = true;
                this.btChangePassword.Visible = true;

                //this.pnlSession.Visible = true;

                //Cuando hay un usuario, recorrer las funcionalidades y habilitar los paneles.
                foreach (Funcionalidad funcionalidad in DataSession.Usuario.RolSeleccionado.Funcionalidades)
                {
                    MessageBox.Show(funcionalidad.Nombre);

                    //Segun la funcionalidad.
                    switch (funcionalidad.Nombre)
                    {
                        case "Roles"        : this.pnlRol.Visible = true;
                                              break;
                        case "Usuarios"     : this.pnlUsuario.Visible = true;
                                              break;
                        case "Clientes"     : this.pnlCliente.Visible = true;
                                              break;
                        case "Estadisticas" : this.pnlListados.Visible = true;
                                              break;
                    }
                }
            }
        }

        public FormMain()
        {
            InitializeComponent();
            habilitarPaneles();
        }

        /****************** LOGIN *******************************************************/
        private void btLogin_Click_1(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            FormLogin frm = new FormLogin(usuario);
            frm.ShowDialog();

            if (frm.DialogResult == DialogResult.OK)
            {
                DataSession.Usuario = usuario;
                label_usuario.Text = "Usuario:"+usuario.Username;
                habilitarPaneles();
            }
        }
        /******************************* SESSION *************************************/

        private void btLogout_Click(object sender, EventArgs e)
        {
            DataSession.Usuario = null;
            label_usuario.Text = "No hay una sesión activa";
            habilitarPaneles();
        }

        private void btChangePassword_Click_1(object sender, EventArgs e)
        {
            FormChangePassword frm = new FormChangePassword(DataSession.Usuario);
            frm.ShowDialog();
        }

        /******************************* ROL *************************************/
        private void btAddRol_Click(object sender, EventArgs e)
        {
            Rol rol = new Rol();
            FormRol frm = new FormRol(rol);
            frm.ShowDialog();
        }

        private void btUpdateRol_Click(object sender, EventArgs e)
        {
            Rol rol = new Rol();
            FormSearchRol frmSearchRol = new FormSearchRol(rol);
            frmSearchRol.ShowDialog();

            if (frmSearchRol.DialogResult == DialogResult.OK)
            {
                FormRol frmRol = new FormRol(rol);
                frmRol.ShowDialog();
            }
        }

        /******************************* USUARIO **********************************/
        private void btAddUsuario_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            FormUsuario frm = new FormUsuario(usuario);
            frm.ShowDialog();
        }

        /******************************* CLIENTE **********************************/
        private void btAddCliente_Click(object sender, EventArgs e)
        {
            
        }

        /******************************* LISTADOS*********************************/

        private void btListadosEstadisticos_Click(object sender, EventArgs e)
        {
            FormListadoEstadistico frm = new FormListadoEstadistico();
            frm.ShowDialog();
        }


        /******************************* EXIT   **********************************/

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }
    }
}
