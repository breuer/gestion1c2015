using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using FrbaHotel.ClasesTabla;

namespace FrbaHotel.ABM_de_Rol
{
    public partial class BusquedaRoles : Form
    {
        SRol sRoles = new SRol();
        static public BusquedaRoles ventana;
        static public decimal codSelected = 0;

        public BusquedaRoles()
        {
            InitializeComponent();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            cboFunc.SelectedIndex = cboFunc.Items.Count -1;
            gridRoles.DataSource = sRoles.GetAll();
        }

        public void cargate() {
            gridRoles.DataSource = sRoles.GetAll();
        }
        
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text != "" || cboFunc.Text != "Todas"){
                
                StringBuilder Valores = new StringBuilder();
                 if(txtNombre.Text != "")
                     Valores.Append("r.descripcion like '%" + txtNombre.Text + "%'");
                 if(txtNombre.Text != "" && cboFunc.Text != "Todas")Valores.Append(" and ");
                 
                 if(cboFunc.Text != "Todas")
                     Valores.Append("fun.cod_funcion = " + ((Funcion)cboFunc.SelectedItem).codigo + "");

                 gridRoles.DataSource = sRoles.GetBySQL("select r.codigo, r.descripcion, r.estado from hotel.Rol r, hotel.Rol_Funcion fun where fun.cod_rol = r.codigo and " + Valores + "group by r.codigo, r.descripcion, r.estado");
                
            }
            else cargate();
        }

        private void BusquedaRoles_Load(object sender, EventArgs e)
        {
            ventana = this;
            cargate();
            SFuncion sFuncion = new SFuncion();
            List<Funcion> funciones = sFuncion.GetAll();
            Funcion funcion = new Funcion();
            funcion.descripcion = "Todas";
            funcion.codigo = 0;
            funciones.Add(funcion);
            cboFunc.DataSource = funciones;
            cboFunc.DisplayMember = "descripcion";
            cboFunc.ValueMember = "codigo";

            cboFunc.SelectedItem = funcion;

        }

        private void gridRoles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                if (e.ColumnIndex == 0)
                {
                    //Seleccionar
                    ABM_de_Rol.ABMRol seleccionar = new ABMRol();
                    codSelected = decimal.Parse(gridRoles.Rows[e.RowIndex].Cells[2].Value.ToString());
                    seleccionar.Show();
                }
                
                if(e.ColumnIndex == 1)
                {
                    // Eliminar
                    codSelected = decimal.Parse(gridRoles.Rows[e.RowIndex].Cells[2].Value.ToString());
                    try{
                    sRoles.Delete(codSelected);
                    MessageBox.Show("Operación exitosa!");
                    cargate();
                    }
                    catch(Exception) { }
                    codSelected = 0;
                }
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            ABM_de_Rol.ABMRol seleccionar = new ABMRol();
            seleccionar.Show();
        }

        private void BusquedaRoles_FormClosing(object sender, FormClosingEventArgs e)
        {
            ABM_de_Rol.BusquedaRoles.codSelected = 0;
            ventana = null;
        }
    }
}
