using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PagoElectronico.Model;

namespace PagoElectronico.ABM_de_Usuario
{
    public partial class FormUsuario : Form
    {
        private Usuario usuario;
        private List<Rol> roles;

        private void initCBRol()
        {
            this.cbRoles.DataSource = roles;
            this.cbRoles.ValueMember = "id";
            this.cbRoles.DisplayMember = "nombre";
        }

        private void initDGVRol()
        {
            var descripcion = new DataGridViewTextBoxColumn();
            descripcion.HeaderText = "descripcion";
            descripcion.Name = "descripcion";
            dgvRoles.Columns.AddRange(new DataGridViewColumn[] { descripcion });
            dgvRoles.AllowUserToAddRows = false;
            foreach (Rol rol in this.usuario.Roles)
            {
                dgvRoles.Rows.Add(new RolRow(rol));
            }
        }

        public FormUsuario(Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
            this.roles = (new Rol()).getAll();
            this.initCBRol();
            this.initDGVRol();
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private Rol searchRol(int codigo)
        {
            foreach (Rol rol in roles)
            {
                if (rol.Id == codigo)
                {
                    return rol;
                }
            }
            return null;
        }

        private void btAddRol_Click(object sender, EventArgs e)
        {
            Rol rol = searchRol(int.Parse(this.cbRoles.SelectedValue.ToString()));
            bool encontro = false;
            foreach (RolRow row in dgvRoles.Rows)
            {
                if (row.Codigo.Equals(rol.Id))
                {
                    encontro = true;
                }
            }
            if (!encontro)
            {
                dgvRoles.Rows.Add(new RolRow(rol));
            }
        }

        private void btQuitarRol_Click(object sender, EventArgs e)
        {
            foreach (RolRow rolRow in this.dgvRoles.SelectedRows)
            {
                this.dgvRoles.Rows.Remove(rolRow);
            }     
        }

        private void btAceptar_Click(object sender, EventArgs e)
        {
            this.usuario.Username = this.tbUsername.Text;
            this.usuario.Password = this.tbPassword.Text;
            foreach (RolRow rolRow in dgvRoles.Rows)
            {
                this.usuario.Roles.Add(rolRow.Rol);
            }
                this.usuario.add();
                this.Close();
        }
    }

    public class RolRow : DataGridViewRow
    {
        private Rol rol;

        public int Codigo { get { return rol.Id; } }
        public Rol Rol { get { return rol; } }

        public RolRow(Rol rol)
        {
            this.rol = rol;
            var descripcion = new DataGridViewTextBoxCell();
            descripcion.Value = rol.Nombre;
            Cells.AddRange(new DataGridViewCell[] { descripcion });
        }
    }
}
