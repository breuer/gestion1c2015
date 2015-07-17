using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PagoElectronico.Model;


namespace PagoElectronico.ABM_Rol
{
    public partial class FormRol : Form
    {
        private List<Funcionalidad> funcionalidades;
        private Rol rol;

        private Funcionalidad getFuncionalidad(int codigo)
        {
            foreach (Funcionalidad funcionalidad in funcionalidades)
            {
                if (funcionalidad.Id == codigo)
                {
                    return funcionalidad;
                }
            }
            return null;
        }

        private void inicializarDGV()
        {
            var descripcion = new DataGridViewTextBoxColumn();
            descripcion.HeaderText = "descripcion";
            descripcion.Name = "descripcion";
            dgvFuncionalidades.Columns.AddRange(new DataGridViewColumn[] { descripcion });
            dgvFuncionalidades.AllowUserToAddRows = false;
        }

        private void inicializarCB()
        {
            this.cbFuncionalidades.DataSource = funcionalidades;
            this.cbFuncionalidades.ValueMember = "id";
            this.cbFuncionalidades.DisplayMember = "nombre";
        }

        public FormRol(Rol rol)
        {
            InitializeComponent();
            this.rol = rol;
            this.funcionalidades = (new Funcionalidad()).getAll();
            inicializarCB();
            inicializarDGV();
            if (rol.Id != 0)
            {
                this.tbNombre.Text = rol.Nombre;
                foreach (Funcionalidad funcionalidad in rol.Funcionalidades)
                {
                    dgvFuncionalidades.Rows.Add(new FuncionalidadRow(funcionalidad));
                }
            }
        }

        private void btQuitarFunionalidad_Click(object sender, EventArgs e)
        {
            foreach (FuncionalidadRow row in dgvFuncionalidades.SelectedRows)
            {
                dgvFuncionalidades.Rows.Remove(row);
            }
        }

        private void btAddFuncionalidad_Click(object sender, EventArgs e)
        {
            Funcionalidad funcionalidad = getFuncionalidad(int.Parse(this.cbFuncionalidades.SelectedValue.ToString()));
            bool encontro = false;
            foreach (FuncionalidadRow row in dgvFuncionalidades.Rows)
            {
                if (row.Codigo.Equals(funcionalidad.Id))
                {
                    encontro = true;
                }
            }
            if (!encontro)
            {
                dgvFuncionalidades.Rows.Add(new FuncionalidadRow(funcionalidad));
            }
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btAceptar_Click(object sender, EventArgs e)
        {
            this.rol.Nombre = this.tbNombre.Text;
            this.rol.Funcionalidades.Clear();
            foreach (FuncionalidadRow row in dgvFuncionalidades.Rows)
            {
                rol.Funcionalidades.Add(row.Funcionalidad);
            }
            if (rol.Id == 0)
            {
                this.rol.add();
            }
            else
            {
                this.rol.update();
            }
            this.Close();
        }


    }

    public class FuncionalidadRow : DataGridViewRow
    {
        private Funcionalidad funcionalidad;

        public int Codigo { get { return funcionalidad.Id; } }
        public Funcionalidad Funcionalidad { get { return this.funcionalidad; } }

        public FuncionalidadRow(Funcionalidad funcionalidad)
        {
            this.funcionalidad = funcionalidad;
            var descripcion = new DataGridViewTextBoxCell();
            descripcion.Value = funcionalidad.Nombre;
            Cells.AddRange(new DataGridViewCell[] { descripcion });
        }
    }
}
