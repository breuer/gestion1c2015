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
    public partial class FormSearchUsuario : Form
    {
        private Usuario usuario;

        private void inicializarDGV()
        {
            var username = new DataGridViewTextBoxColumn();
            var estado = new DataGridViewTextBoxColumn();
            var cliente = new DataGridViewTextBoxColumn();
            username.HeaderText = "Username";
            estado.HeaderText = "Estado";
            cliente.HeaderText = "Cliente Asignado";
            this.dgvUsuarios.Columns.AddRange(new DataGridViewColumn[] { username, estado, cliente });
            this.dgvUsuarios.AllowUserToAddRows = false;
            this.dgvUsuarios.MultiSelect = false;
        }


        public FormSearchUsuario(Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
            inicializarDGV();

        }



        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btSelect_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.SelectedRows.Count > 0)
            {
                foreach (UsuarioRow row in this.dgvUsuarios.SelectedRows)
                {
                    this.usuario.Id = row.Codigo;
                }
                this.usuario.get();
                if (!usuario.Activo)
                {
                    MessageBox.Show("El usuario no se encuentra activo");
                }
                else if (usuario.IdCliente != null)
                {
                    MessageBox.Show("El usuario ya tiene un cliente asociado");
                }
                else
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            else
            {
                if (dgvUsuarios.Rows.Count>0)
                    MessageBox.Show("No hay un cliente seleccionado, haga click en la 1ra columna.");                    
                else
                    MessageBox.Show("No se han encontrado clientes, no se podra seleccionar ninguno.");
            }
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            //this.usuario.Username = tbUsername.Text;
            dgvUsuarios.Rows.Clear();

            this.usuario.Username = String.IsNullOrEmpty(tbUsername.Text) ? null : tbUsername.Text;
            foreach (var item in usuario.getAll())
            {
                dgvUsuarios.Rows.Add(new UsuarioRow(item));
            }
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            dgvUsuarios.Rows.Clear();
        }
    }

    public class UsuarioRow : DataGridViewRow
    {
        private int? codigo;

        public int? Codigo { get { return codigo; } }

        public UsuarioRow(Usuario usuario)
        {
            this.codigo = usuario.Id;
            var username = new DataGridViewTextBoxCell();
            username.Value = usuario.Username;
            var estado = new DataGridViewTextBoxCell();
            estado.Value = usuario.Activo ? "ACTIVO" : "INACTIVO";
            var cliente = new DataGridViewTextBoxCell();
            cliente.Value = usuario.IdCliente != null ? "SI" : "NO";
            Cells.AddRange(new DataGridViewCell[] { username, estado, cliente });
        }
    }
}
