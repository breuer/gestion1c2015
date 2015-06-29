using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaHotel.ClasesTabla;

namespace FrbaHotel.ABM_de_Usuario
{
    public partial class BusquedaUser : Form
    {
        public BusquedaUser()
        {
            InitializeComponent();
        }

        static public decimal usuarioSelected = 0;
        static public BusquedaUser ventanaBusqueda;
        static public decimal codHotel = 0;
        SRol SRol = new SRol();
        SUsuario susuario = new SUsuario();
        SPersona sCliente = new SPersona();

        private void BusquedaUser_Load(object sender, EventArgs e)
        {
            ventanaBusqueda = this;
            codHotel = Login.Log.hotel;

            List<Rol> roles = SRol.GetRolAsig();
            Rol rol = new Rol();
            rol.descripcion = "Todos";
            rol.codigo = 0;
            roles.Add(rol);
            cboRol.DisplayMember = "descripcion";
            cboRol.ValueMember = "codigo";
            cboRol.DataSource = roles;
            cargate();
            cboRol.SelectedItem = rol;
        }

        public void cargate() {
            gripUser.DataSource = susuario.GetBySQLGRID("select u.codigo, u.user_nombre,u.logueado,u.intentos_fallidos,u.estado from hotel.Usuario u, hotel.Usuario_hotel h where h.cod_usuario = u.codigo and u.codigo <> 2 and h.cod_hotel = " + codHotel);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtUser.Text = "";
            cboRol.SelectedIndex = cboRol.Items.Count - 1;
            usuarioSelected = 0;
            cargate();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            ABM_de_Usuario.ABMUser usuarionuevo = new ABMUser();
            usuarionuevo.Show();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtUser.Text.Trim() != "" || cboRol.Text.Trim() != "Todos")
            {
                StringBuilder Valores = new StringBuilder();

                if (txtUser.Text != "") Valores.Append(" u.user_nombre like '%" + txtUser.Text + "%'");

                if (txtUser.Text != "" && cboRol.Text != "Todos") Valores.Append(" and ");

                if (cboRol.Text != "Todos") Valores.Append(" rol.cod_rol =" + ((Rol)cboRol.SelectedItem).codigo);

                gripUser.DataSource = susuario.GetBySQLGRID("select u.codigo, u.user_nombre,u.logueado,u.intentos_fallidos,u.estado from hotel.Usuario u, hotel.Usuario_hotel h where h.cod_usuario = u.codigo and u.codigo <> 2 and h.cod_hotel = " + codHotel + " and " + Valores.ToString() + " group by u.codigo, u.user_nombre,u.logueado,u.intentos_fallidos,u.estado");

            }
            else cargate();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                if (e.ColumnIndex == 0)
                {
                    //Seleccionar
                    ABM_de_Usuario.ABMUser seleccionar = new ABMUser();
                    usuarioSelected = decimal.Parse(gripUser.Rows[e.RowIndex].Cells[2].Value.ToString());
                    seleccionar.Show();
                }
                
                if(e.ColumnIndex == 1)
                {
                    // Eliminar
                    usuarioSelected = decimal.Parse(gripUser.Rows[e.RowIndex].Cells[2].Value.ToString());
                    try{
                    susuario.Delete(usuarioSelected);
                    MessageBox.Show("Operación exitosa!");
                    cargate();
                    }
                    catch(Exception) { }
                    usuarioSelected = 0;
                }
            }

        }

        private void BusquedaUser_FormClosing(object sender, FormClosingEventArgs e)
        {
            usuarioSelected = 0;
            ventanaBusqueda = null;
        }

    }
}
