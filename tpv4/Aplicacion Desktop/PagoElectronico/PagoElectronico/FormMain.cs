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
        /*************************************************************/
        /* actualiza las cuentas de migración que vienen sin fecha de vto */
        private void actualizarCuentas() 
        {
            Cuenta cuenta = new Cuenta();
            cuenta.FechaSistema = DataSession.FechaSistema;
            cuenta.TipoCuentaCod = DataSession.TIPO_CUENTA_GRATUITA;
            cuenta.actualizarCuentas();
        }

        /*********************** FECHA SISTEMA **********************/
        private void cargarFechaSistema() 
        { 
            DataSession.FechaSistema = Properties.Settings.Default.SYSTEM_DATE;
            this.dtpFechaSistema.Value = DataSession.FechaSistema;
            Cuenta cuenta = new Cuenta();
            cuenta.FechaSistema = DataSession.FechaSistema;
            cuenta.actualizarEstados();
        }

        private void dtpFechaSistema_ValueChanged(object sender, EventArgs e)
        {
            DataSession.FechaSistema = this.dtpFechaSistema.Value;
            Cuenta cuenta = new Cuenta();
            cuenta.FechaSistema = this.dtpFechaSistema.Value; 
            cuenta.actualizarEstados();

        }


        /*************************************************************/

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
                this.btListadosEstadisticos.Visible = false;
                this.btCuenta.Visible = false;
                this.btCuentaClientes.Visible = false;
                this.btn_retiros.Visible = false;
                this.btn_transf.Visible = false;
                this.btn_depositos.Visible = false;
                this.btn_saldo_cli.Visible = false;
                this.btn_saldo_admin.Visible = false;
                this.btn_tarjetas.Visible = false;
                this.btn_fact_cli.Visible = false;
                this.btn_fact_admin.Visible = false;
                this.admin_tab.Visible = false;
                this.cliente_tab.Visible = false;
                this.welcome_label.Text = "";
                this.status_label.Text = "Haga click en Login para iniciar sesión.";
                this.status_label.Location = new Point(281, this.status_label.Location.Y);
                this.status_label.Visible = true;
            }
            else
            {
                this.welcome_label.Text = "Bienvenido, " + DataSession.Usuario.Username;
                this.pnlLogin.Visible = false;
                this.pnlSession.Visible = true;

                this.status_label.Visible = false;

                //Muestro los paneles de administrador o cliente.
                if (DataSession.Usuario.RolSeleccionado.Id == 1)
                    this.admin_tab.Visible = true;

                if (DataSession.Usuario.RolSeleccionado.Id == 2)
                    this.cliente_tab.Visible = true;

                foreach (Funcionalidad funcionalidad in DataSession.Usuario.RolSeleccionado.Funcionalidades)
                {
                    if (funcionalidad.Nombre.Equals(DataSession.FUNCIONALIDAD_ROLES))
                    {
                        this.pnlRol.Visible = true;
                    }
                    if (funcionalidad.Nombre.Equals(DataSession.FUNCIONALIDAD_CLIENTES))
                    {
                        this.pnlCliente.Visible = true;
                    }
                    if (funcionalidad.Nombre.Equals(DataSession.FUNCIONALIDAD_CUENTAS))
                    {
                        this.btCuenta.Visible = true;
                    }
                    if (funcionalidad.Nombre.Equals(DataSession.FUNCIONALIDAD_CUENTAS_CLIENTES))
                    {
                        this.btCuentaClientes.Visible = true;
                    }
                    if (funcionalidad.Nombre.Equals(DataSession.FUNCIONALIDAD_ESTADISTICAS))
                    {
                        this.btListadosEstadisticos.Visible = true;
                    }
                    if (funcionalidad.Nombre.Equals(DataSession.FUNCIONALIDAD_RETIROS))
                    {
                        this.btn_retiros.Visible = true;
                    }
                    if (funcionalidad.Nombre.Equals(DataSession.FUNCIONALIDAD_TRANSFERENCIAS))
                    {
                        this.btn_transf.Visible = true;
                    }
                    if (funcionalidad.Nombre.Equals(DataSession.FUNCIONALIDAD_DEPOSITOS))
                    {
                        this.btn_depositos.Visible = true;
                    }
                    if (funcionalidad.Nombre.Equals(DataSession.FUNCIONALIDAD_SALDO))
                    {
                        this.btn_saldo_cli.Visible = true;
                    }
                    if (funcionalidad.Nombre.Equals(DataSession.FUNCIONALIDAD_SALDO_ADMIN))
                    {
                        this.btn_saldo_admin.Visible = true;
                    }
                    if (funcionalidad.Nombre.Equals(DataSession.FUNCIONALIDAD_TARJETAS))
                    {
                        this.btn_tarjetas.Visible = true;
                    }
                    if (funcionalidad.Nombre.Equals(DataSession.FUNCIONALIDAD_FACTURACION))
                    {
                        this.btn_fact_cli.Visible = true;
                    }
                    if (funcionalidad.Nombre.Equals(DataSession.FUNCIONALIDAD_FACTURACION_ADMIN))
                    {
                        this.btn_fact_admin.Visible = true;
                    }
                }
            }
        }

        public FormMain()
        {
            InitializeComponent();
            cargarFechaSistema();
           
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
                DataSession.inicializar();
                habilitarPaneles();
                /************ actualiza cuentas de migracion ****************/
                actualizarCuentas();
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
                cliente.IdUsuario = usuario.Id;
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
            Cliente cliente = DataSession.Usuario.Cliente;
            FormListadoCuentas frm = new FormListadoCuentas(cliente);
            frm.ShowDialog();

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

        private void FormMain_Load(object sender, EventArgs e)
        {
            this.Size = new Size(this.Size.Width, 361);
            this.cliente_tab.Location = new Point(this.cliente_tab.Location.X, 7);
        }

        private void btExit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_fact_cli_Click(object sender, EventArgs e)
        {
            FormFacturacion fact = new FormFacturacion(DataSession.Usuario);
            fact.Show();
        }

        private void btn_fact_admin_Click(object sender, EventArgs e)
        {
            FormFacturacionAdmin frm = new FormFacturacionAdmin(DataSession.Usuario);
            frm.Show();
        }

        private void txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }/*
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }*/
            else
            {
                e.Handled = true;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
