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
using PagoElectronico.Transferencias;
using PagoElectronico.Retiros;
using PagoElectronico.Depositos;
using PagoElectronico.Saldos;

namespace PagoElectronico
{
    public partial class FormMain : Form
    {
        private void desabilitarPaneles()
        {
            //Paneles.
            this.admin_tab.Visible = false;
            this.cliente_tab.Visible = false;

            //Admin
            this.btn_add_user.Visible = false;
            this.btn_del_user.Visible = false;
            this.btn_upd_user.Visible = false;
            this.btn_add_rol.Visible = false;
            this.btn_del_rol.Visible = false;
            this.btn_upd_rol.Visible = false;
            this.btn_add_cliente.Visible = false;
            this.btn_del_cliente.Visible = false;
            this.btn_upd_cliente.Visible = false;
            this.btn_abm_cuentas.Visible = false;
            this.btn_facturacion.Visible = false;
            this.btn_estadisticas.Visible = false;

            //Cliente
            this.btn_tarj_vincular.Visible = false;
            this.btn_retiros.Visible = false;
            this.btn_tarj_desvincular.Visible = false;
            this.btn_cli_abm_cuentas.Visible = false;
            this.btn_transferencias.Visible = false;
            this.btn_depositos.Visible = false;
            this.btn_saldo.Visible = false;
            this.btn_cli_facturacion.Visible = false;        
        }

        private void habilitarPaneles()
        {
            if (DataSession.Usuario == null)
            {
                //En caso de que no halla un usuario cargado en la sesion, solo mostrar el login.
                this.label_hacer_login.Visible  = true; 
                this.btLogin.Visible            = true;
                this.btLogout.Visible           = false;
                this.btChangePassword.Visible   = false;

                //Oculto todo.
                this.desabilitarPaneles();
            }
            else
            {
                //Habilitar el login.
                this.label_hacer_login.Visible = false; 
                this.btLogin.Visible           = false;
                this.btLogout.Visible          = true;
                this.btChangePassword.Visible  = true;

                //Oculto todo.
                this.desabilitarPaneles();
                
                //Detecta si es usuario o cliente.
                if (DataSession.Usuario.RolSeleccionado.Id == 2)
                {
                    //Activo pagina de clientes y desactivo admin.
                    this.cliente_tab.Visible = true;
                    this.cliente_tab.Location = new Point(this.cliente_tab.Location.X, 45);
                    this.admin_tab.Visible   = false;

                    //CLIENTE
                    foreach (Funcionalidad funcionalidad in DataSession.Usuario.RolSeleccionado.Funcionalidades)
                    {
                        switch (funcionalidad.Nombre)
                        {
                            case "Cuentas"          : this.btn_cli_abm_cuentas.Visible = true;
                                                      break;
                            case "Transferencias"   : this.btn_transferencias.Visible = true;
                                                      break;
                            case "Depositos"        : this.btn_depositos.Visible = true;
                                                      break;
                            case "Retiros"          : this.btn_retiros.Visible=true;
                                                      break;                       
                            case "Tarjetas"         : this.btn_tarj_vincular.Visible=true;
                                                      this.btn_tarj_desvincular.Visible=true;
                                                      break;  
                            case "Facturacion"      : this.btn_cli_facturacion.Visible=true;
                                                      break;  
                            case "Saldo"            : this.btn_saldo.Visible=true;
                                                      break;  
                        }
                    }
                }
                else
                { 
                    //Activo pagina de clientes y desactivo admin.
                    this.cliente_tab.Visible = false;
                    this.admin_tab.Visible = true;

                    //ADMINISTRADOR
                    foreach (Funcionalidad funcionalidad in DataSession.Usuario.RolSeleccionado.Funcionalidades)
                    {
                        switch (funcionalidad.Nombre)
                        {
                            case "Clientes"          : this.btn_add_cliente.Visible=true;
                                                       this.btn_del_cliente.Visible=true;
                                                       this.btn_upd_cliente.Visible=true;
                                                       break;
                            case "Usuarios"          : this.btn_add_user.Visible=true;
                                                       this.btn_del_user.Visible=true;
                                                       this.btn_upd_user.Visible=true;
                                                       break;
                            case "Cuentas"           : this.btn_abm_cuentas.Visible=true;
                                                       break;
                            case "Roles"             : this.btn_add_rol.Visible=true;
                                                       this.btn_del_rol.Visible=true;
                                                       this.btn_upd_rol.Visible=true;
                                                       break;
                            case "Facturacion"       : this.btn_facturacion.Visible=true;
                                                       break;  
                            case "Estadisticas"      : this.btn_estadisticas.Visible=true;
                                                       break;  
                        }
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
            this.Size = new Size(this.Size.Width, 431);
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_transferencias_Click(object sender, EventArgs e)
        {
            FormTransfer frmTransf = new FormTransfer(DataSession.Usuario);
            frmTransf.Show();
        }

        private void btn_retiros_Click(object sender, EventArgs e)
        {
            FormRetiros frmRetiros = new FormRetiros(DataSession.Usuario);
            frmRetiros.Show();
        }

        private void btn_depositos_Click(object sender, EventArgs e)
        {
            FormDepositos frmDepositos = new FormDepositos(DataSession.Usuario);
            frmDepositos.Show();
        }

        private void btn_saldo_Click(object sender, EventArgs e)
        {
            FormSaldo_cliente frmsaldo = new FormSaldo_cliente(DataSession.Usuario);
            frmsaldo.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormSaldo_admin frmsaldoAdm = new FormSaldo_admin(DataSession.Usuario);
            frmsaldoAdm.Show();
        }
    }
}
