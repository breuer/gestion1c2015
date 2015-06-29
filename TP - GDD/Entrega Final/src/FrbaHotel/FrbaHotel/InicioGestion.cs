using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaHotel.ClasesTabla;

namespace FrbaHotel
{
    public partial class FormIni : Form
    {
        public FormIni()
        {
            InitializeComponent();
            var customSetting = System.Configuration.ConfigurationSettings.AppSettings;
            FechaSistema = DateTime.Parse(customSetting.Get("dia").ToString()+'/'+ customSetting.Get("mes")+'/'+customSetting.Get("anio"));
        }


        static public DateTime FechaSistema;
        static public FormIni ventanaPrincip;
        static public string rol;
        static public bool loggeado = false;
        //static private bool requiereLoggeo = false;

        private void btnAcept_Click(object sender, EventArgs e)
        {
            rol = cboRoles.Text;
            /*
            SFuncion SFuncion = new SFuncion();
            List<Funcion> funciones = SFuncion.GetRolPorFuncion(int.Parse(cboRoles.SelectedValue.ToString()));

            Funcion funcion = (from f in funciones where f.descripcion == "Login" select f).SingleOrDefault();
            if (funcion != null) { requiereLoggeo = true; }
            */
            if (!loggeado) { if (rol != "Guest") cboFunciones.Items.Add("Login"); }
            else cargarCBOFunc();

            if (rol == "Guest")
            {
                loggeado = true;
                Login.Log.user = 1;
                cargarCBOFunc();
            }
            btnSalir.Visible = true;
            btnSalir.Enabled = true;
            cboRoles.Enabled = false;
            btnIngresar.Enabled = false;

            cboFunciones.Visible = true;
            lblFunciones.Visible = true;
            btnAceptar.Visible = true;
        }

        public void cargarCBOFunc()
        {
            cboFunciones.DataSource = null;
            cboFunciones.Items.Clear();
            SFuncion SFuncion = new SFuncion();
            List<Funcion> funciones = SFuncion.GetRolPorFuncion(int.Parse(cboRoles.SelectedValue.ToString()));
            /*
            Funcion funcion = (from f in funciones where f.descripcion == "Login" select f).SingleOrDefault();
            if (funcion != null) { funciones.Remove(funcion); requiereLoggeo = true; }
            */
            cboFunciones.DataSource = funciones;
            cboFunciones.DisplayMember = "descripcion";
            cboFunciones.ValueMember = "codigo";
            
        }

        private void btnFunc_Click(object sender, EventArgs e)
        {
            if (cboFunciones.Text != "")
            {
                if (cboFunciones.Text != "Login")
                {
                    int funcionSelected = int.Parse(cboFunciones.SelectedValue.ToString());

                    /* case de redireccionamiento */

                    switch (funcionSelected)
                    {
                        case 1:
                            ABM_de_Usuario.BusquedaUser BusquedaUser = new FrbaHotel.ABM_de_Usuario.BusquedaUser();
                            BusquedaUser.Show();
                            break;
                        case 2:
                            ABM_de_Cliente.BusquedaCliente BusquedaCliente = new FrbaHotel.ABM_de_Cliente.BusquedaCliente();
                            BusquedaCliente.Show();
                            break;
                        case 3:
                            ABM_Hotel.BusquedaHotel BusquedaHotel = new FrbaHotel.ABM_Hotel.BusquedaHotel();
                            BusquedaHotel.Show();
                            break;
                        case 4:
                            ABM_de_Habitacion.BusquedaHabitacion BusquedaHab = new FrbaHotel.ABM_de_Habitacion.BusquedaHabitacion();
                            BusquedaHab.Show();
                            break;
                        case 5:
                            ABM_de_Regimen.BusquedaRegimen BusquedaReg = new FrbaHotel.ABM_de_Regimen.BusquedaRegimen();
                            BusquedaReg.Show();
                            break;
                        case 6:
                            Generar_Modificar_Reserva.AMReserva AMReserva = new FrbaHotel.Generar_Modificar_Reserva.AMReserva();
                            AMReserva.Show();
                            break;
                        case 7:
                            Cancelar_Reserva.CancelarReserva CancelarReserva = new FrbaHotel.Cancelar_Reserva.CancelarReserva();
                            CancelarReserva.Show();
                            break;
                        case 8:
                            Registrar_Estadia.Estadia Estadia = new FrbaHotel.Registrar_Estadia.Estadia();
                            Estadia.Show();
                            break;
                        case 9:
                            Registrar_Consumible.RegistrarConsumible RegistrarConsum = new FrbaHotel.Registrar_Consumible.RegistrarConsumible();
                            RegistrarConsum.Show();
                            break;
                        case 10:
                            Registrar_Consumible.Facturar Facturar = new FrbaHotel.Registrar_Consumible.Facturar();
                            Facturar.Show();
                            break;
                        case 11:
                            Listado_Estadistico.ListadoEstadistico Estadistica = new FrbaHotel.Listado_Estadistico.ListadoEstadistico();
                            Estadistica.Show();

                            break;
                        case 12:
                            ABM_de_Rol.BusquedaRoles roles = new FrbaHotel.ABM_de_Rol.BusquedaRoles();
                            roles.Show();
                            break;
                    }
                }
                else
                {
                    Login.Log loggearse = new FrbaHotel.Login.Log();
                    loggearse.Show();
                }
            }
        }

        private void FormIni_Load(object sender, EventArgs e)
        {
            ventanaPrincip = this;
            if (Login.Log.user == 0)
            {
                SRol SRol = new SRol();
                List<Rol> roles = SRol.GetAllActivos();
                cboRoles.DisplayMember = "descripcion";
                cboRoles.ValueMember = "codigo";
                cboRoles.DataSource = roles;
            }
            else
                cargarCBOFunc();

            ActualizarReservasNOTSHOW();
        }

        private void ActualizarReservasNOTSHOW()
        {
            EntidadBase entidad = new EntidadBase();
            entidad.EjecutarSQL("update hotel.reserva set cod_estado = 5 where fecha_desde < '" + FechaSistema.ToShortDateString() + "' and (cod_estado = 1 or cod_estado = 2)");
   
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Login.Log.user = 0;
            Login.Log.hotelNombre = null;
            Login.Log.hotel = 0;
            loggeado = false;
            rol = null;
            //requiereLoggeo = false;
            cboRoles.Enabled = true;
            cboFunciones.Visible = false;
            lblFunciones.Visible = false;
            btnAceptar.Visible = false;
            btnSalir.Visible = false;
            btnSalir.Enabled = false;
            btnIngresar.Enabled = true;
            cboFunciones.DataSource = null;
            cboFunciones.Items.Clear();
        }

    }
}
