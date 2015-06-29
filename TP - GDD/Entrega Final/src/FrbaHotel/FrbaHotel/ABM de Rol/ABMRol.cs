using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaHotel.ClasesTabla;

namespace FrbaHotel.ABM_de_Rol
{
    public partial class ABMRol : Form
    {
        SRol sRol = new SRol();
        SFuncion sFuncion = new SFuncion();
        public ABMRol()
        {
            InitializeComponent();
        }

        public static decimal valorL = 0;

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            BuildRol();
            try
            {
                if(validar()){
                    if (valorL > 0)
                    {
                        sRol.Update(rol);
                    }
                    else
                    {
                        rol.codigo = sRol.Save(rol);
                    }
                    altaFunciones(rol.codigo);
                    MessageBox.Show("Operación exitosa!");
                }
            }

            catch (Exception)
            {
                MessageBox.Show("Error en la operación!");
                if(valorL == 0 ) limpiar();
            }
            finally
            {
                if (valorL > 0)
                    this.Close();
                else
                    limpiar();
            }
        }

        private void altaFunciones(decimal codRol)
        {
            List<Funcion> funciones = sFuncion.GetAll();

            sFuncion.DeleteAllByCodRol(codRol);

            foreach (int indexChecked in ckLstFunciones.CheckedIndices)
            {
                string descrip = ((Funcion)ckLstFunciones.Items[indexChecked]).descripcion.ToString();

                foreach (Funcion func in funciones)
                {
                    if (descrip == func.descripcion)
                        sFuncion.SaveCodRol(codRol, func.codigo);
                }
            }

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void limpiar()
        {
            txtNombre.Text = "";
            for (int i = 0; i < ckLstFunciones.Items.Count; i++)
                ckLstFunciones.SetItemCheckState(i, CheckState.Unchecked);
            ckActiva.Checked = true;
            valorL = 0;
            rol = new Rol();
        }

        private void ABMRol_Load(object sender, EventArgs e)
        {
            valorL = ABM_de_Rol.BusquedaRoles.codSelected;
            List<Funcion> funciones = sFuncion.GetAll();
            ckLstFunciones.DataSource = funciones;
            ckLstFunciones.DisplayMember = "descripcion";
            ckLstFunciones.ValueMember = "codigo";

            if (valorL > 0)
            {
                LoadRol(valorL);
            }
        }
        Rol rol = new Rol();

        private void LoadRol(decimal codRol)
        {
            List<Rol> roles = sRol.GetBySQL("select * from hotel.Rol r where r.codigo = " + codRol);
            rol = roles.SingleOrDefault();
            txtNombre.Text = rol.descripcion;
            ckActiva.Checked = rol.estado;
            if (ckActiva.Checked == true) ckActiva.Enabled = false;
            cargarFunciones(codRol);
        }

        private void cargarFunciones(decimal codRol)
        {

            List<Funcion> funcionesDelRol = sFuncion.GetRolPorFuncion(int.Parse(codRol.ToString()));

            for (int i = 0; i <= (ckLstFunciones.Items.Count - 1); i++)
            {
                string descrip = ((Funcion)ckLstFunciones.Items[i]).descripcion.ToString();
                var checkear = false;

                foreach (Funcion func in funcionesDelRol)
                {
                    if (descrip == func.descripcion) checkear = true;
                }
                if (checkear)
                    ckLstFunciones.SetItemCheckState(i, CheckState.Checked);
                else
                    ckLstFunciones.SetItemCheckState(i, CheckState.Unchecked);
            }
        }

        private void BuildRol()
        {
            if (valorL > 0)
                rol.codigo = valorL;
            rol.descripcion = txtNombre.Text;
            rol.estado = ckActiva.Checked;
        }

        private void ABMRol_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (ABM_de_Rol.BusquedaRoles.ventana != null)
                ABM_de_Rol.BusquedaRoles.ventana.cargate();
            ABM_de_Rol.BusquedaRoles.codSelected = 0;
            valorL = 0;
        }

         private bool validar()
          {
              if (txtNombre.Text.Trim() != "") return true;
              else
                  return false;
          }
    }
}
