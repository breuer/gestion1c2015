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
                //MessageBox.Show("Usuario == null");
                this.pnlLogin.Visible = true;
                this.pnlSession.Visible = false;
                this.pnlRol.Visible = false;
                this.pnlUsuario.Visible = false;
                this.pnlCliente.Visible = false;
                this.pnlListados.Visible = false;
            }
            else
            {
                //MessageBox.Show("Usuario <> null");
                this.pnlLogin.Visible = false;
                this.pnlSession.Visible = true;
                foreach (Funcionalidad funcionalidad in DataSession.Usuario.RolSeleccionado.Funcionalidades)
                {
                    if (funcionalidad.Nombre.Equals("Rol"))
                    {
                        this.pnlRol.Visible = true;
                    }
                    if (funcionalidad.Nombre.Equals("Usuario"))
                    {
                        this.pnlUsuario.Visible = true;
                    }
                    if (funcionalidad.Nombre.Equals("Cliente"))
                    {
                        this.pnlCliente.Visible = true;
                    }
                    if (funcionalidad.Nombre.Equals("Listados"))
                    {
                        this.pnlListados.Visible = true;
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
        private void btLogin_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            FormLogin frm = new FormLogin(usuario);
            frm.ShowDialog();

            if (frm.DialogResult == DialogResult.OK)
            {                
                DataSession.Usuario = usuario;
                DataSession.inicializar();
                habilitarPaneles();
            }
        }
        /******************************* SESSION *************************************/

        private void btLogout_Click(object sender, EventArgs e)
        {
            DataSession.Usuario = null;
            habilitarPaneles();
        }

        private void btChangePassword_Click(object sender, EventArgs e)
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
            Usuario usuario = new Usuario();
            FormSearchUsuario frmS = new FormSearchUsuario(usuario);
            frmS.ShowDialog();

            if (frmS.DialogResult == DialogResult.OK)
            {
                Cliente cliente = new Cliente();
                cliente.Usuario = usuario;
                FormCliente frm = new FormCliente(cliente, DataSession.ALTA);
                frm.ShowDialog();
            }
        }

        private void btUpdateCliente_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            FormSearchCliente frmS = new FormSearchCliente(cliente);
            frmS.ShowDialog();

            if (frmS.DialogResult == DialogResult.OK)
            {
                cliente.get();
                FormCliente frm = new FormCliente(cliente, DataSession.MODIFICACION);
                frm.ShowDialog();
            }
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




    }
}
