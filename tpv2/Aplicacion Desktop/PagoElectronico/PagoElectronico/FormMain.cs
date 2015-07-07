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
using PagoElectronico.ABM_Cuenta;
using PagoElectronico.Transferencias;
using PagoElectronico.Retiros;
using PagoElectronico.Depositos;
using PagoElectronico.Saldos;
using PagoElectronico.Tarjetas;
using PagoElectronico.Facturacion;

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
                this.pnlCuenta.Visible = false;
                this.pnlCuentasClientes.Visible = false;
                this.pnlListados.Visible = false;
                this.btn_retiros.Visible = false;
                this.btn_transf.Visible = false;
                this.btn_depositos.Visible = false;
                this.btn_saldo_cli.Visible = false;
                this.btn_saldo_admin.Visible = false;
                this.btn_tarjetas.Visible = false;
                this.btn_fact_cli.Visible = false;
            }
            else
            {
                //MessageBox.Show("Usuario <> null");
                this.pnlLogin.Visible = false;
                this.pnlSession.Visible = true;
                foreach (Funcionalidad funcionalidad in DataSession.Usuario.RolSeleccionado.Funcionalidades)
                {
                    if (funcionalidad.Nombre.Equals("Roles"))
                    {
                        this.pnlRol.Visible = true;
                    }
                    if (funcionalidad.Nombre.Equals("Usuarios"))
                    {
                        this.pnlUsuario.Visible = true;
                    }
                    if (funcionalidad.Nombre.Equals("Clientes"))
                    {
                        this.pnlCliente.Visible = true;
                    }
                    if (funcionalidad.Nombre.Equals("Cuentas"))
                    {
                        this.pnlCuenta.Visible = true;
                    }
                    if (funcionalidad.Nombre.Equals("Cuentas clientes"))
                    {
                        this.pnlCuentasClientes.Visible = true;
                    }
                    if (funcionalidad.Nombre.Equals("Estadisticas"))
                    {
                        this.pnlListados.Visible = true;
                    }
                    if (funcionalidad.Nombre.Equals("Retiros"))
                    {
                        this.btn_retiros.Visible = true;
                    }
                    if (funcionalidad.Nombre.Equals("Transferencias"))
                    {
                        this.btn_transf.Visible = true;
                    }
                    if (funcionalidad.Nombre.Equals("Depositos"))
                    {
                        this.btn_depositos.Visible = true;
                    }
                    if (funcionalidad.Nombre.Equals("Saldo"))
                    {
                        this.btn_saldo_cli.Visible = true;
                    }
                    if (funcionalidad.Nombre.Equals("Saldo admin"))
                    {
                        this.btn_saldo_admin.Visible = true;
                    }
                    if (funcionalidad.Nombre.Equals("Tarjetas"))
                    {
                        this.btn_tarjetas.Visible = true;
                    }
                    if (funcionalidad.Nombre.Equals("Facturacion"))
                    {
                        this.btn_fact_cli.Visible = true;
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

        
        /******************************* CUENTA   **********************************/


        private void btCuentaClientes_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            FormSearchCliente frmS = new FormSearchCliente(cliente);
            frmS.ShowDialog();

            if (frmS.DialogResult == DialogResult.OK)
            {
                cliente.get();
                FormListadoCuentas frm = new FormListadoCuentas(cliente);
                frm.ShowDialog();
            }

        }

        private void btCuenta_Click(object sender, EventArgs e)
        {
            //FormListadoCuentas frm = new FormListadoCuentas(cliente);
            //frm.ShowDialog();

        }

        private void btn_saldo_admin_Click(object sender, EventArgs e)
        {
            FormSaldo_admin frmsaldoAdm = new FormSaldo_admin(DataSession.Usuario);
            frmsaldoAdm.Show();
        }

        private void btn_depositos_Click(object sender, EventArgs e)
        {
            FormDepositos frmDepositos = new FormDepositos(DataSession.Usuario);
            frmDepositos.Show();
        }

        private void btn_transf_Click(object sender, EventArgs e)
        {
            FormTransfer frmTransf = new FormTransfer(DataSession.Usuario);
            frmTransf.Show();
        }

        private void btn_retiros_Click(object sender, EventArgs e)
        {
            FormRetiros frmRetiros = new FormRetiros(DataSession.Usuario);
            frmRetiros.Show();
        }

        private void btn_saldo_cli_Click(object sender, EventArgs e)
        {
            FormSaldo_cliente frmsaldo = new FormSaldo_cliente(DataSession.Usuario);
            frmsaldo.Show();
        }

        private void btn_tarjetas_Click(object sender, EventArgs e)
        {
            FormTarjetas frmtarj = new FormTarjetas(DataSession.Usuario);
            frmtarj.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormFacturacion fact = new FormFacturacion(DataSession.Usuario);
            fact.Show();
        }


    }
}
