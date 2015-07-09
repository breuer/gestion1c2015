using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PagoElectronico.Model;

namespace PagoElectronico.ABM_Cliente
{
    public partial class FormSearchCliente : Form
    {
        private Cliente cliente;

        private void initCBB()
        {
            this.cbTipoIdentificacion.DataSource = (new TipoIdentificacion()).getAll();
            this.cbTipoIdentificacion.ValueMember = "id";
            this.cbTipoIdentificacion.DisplayMember = "nombre";
            this.cbTipoIdentificacion.SelectedIndex = -1;

        }

        private void inicializarDGV()
        {
            var nombre = new DataGridViewTextBoxColumn();
            nombre.HeaderText = "Nombre";
            nombre.Name = "nombre";
            var apellido = new DataGridViewTextBoxColumn();
            apellido.HeaderText = "Apellido";
            apellido.Name = "apellido";
            var mail = new DataGridViewTextBoxColumn();
            mail.HeaderText = "Mail";
            mail.Name = "mail";
            var identificacion = new DataGridViewTextBoxColumn();
            identificacion.HeaderText = "Identificacion";
            identificacion.Name = "identificacion";
            var tipoIdentificacion = new DataGridViewTextBoxColumn();
            tipoIdentificacion.HeaderText = "Tipo Identificacion";
            tipoIdentificacion.Name = "tipoIdentificacion";
            var habilitado = new DataGridViewTextBoxColumn();
            habilitado.HeaderText = "Habilitado";
            habilitado.Name = "habilitado";

            dgvClientes.Columns.AddRange(new DataGridViewColumn[] { nombre, apellido, mail, identificacion, tipoIdentificacion, habilitado });
            dgvClientes.AllowUserToAddRows = false;
            dgvClientes.MultiSelect = false;
        }

        public FormSearchCliente(Cliente cliente)
        {
            InitializeComponent();
            this.cliente = cliente;
            this.initCBB();
            this.inicializarDGV();
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            dgvClientes.Rows.Clear();
            cliente.Apellido = String.IsNullOrEmpty(tbApellido.Text) ? null : tbApellido.Text;
            cliente.Nombre = String.IsNullOrEmpty(tbNombre.Text) ? null : tbNombre.Text;
            cliente.Mail = String.IsNullOrEmpty(tbMail.Text) ? null : tbMail.Text;
            cliente.Identificacion = String.IsNullOrEmpty(tbIdentificacion.Text) ? null : (int?) int.Parse(tbIdentificacion.Text);
            //cliente.TipoDeIdentificacion.Id = cbTipoIdentificacion.SelectedIndex == -1 ? null : cbTipoIdentificacion.SelectedValue.ToString();
            foreach (var item in cliente.getAll())
            {
                dgvClientes.Rows.Add(new ClienteRow(item));
            }
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btSelect_Click(object sender, EventArgs e)
        {

            if (dgvClientes.SelectedRows.Count > 0)
            {
                foreach (ClienteRow row in this.dgvClientes.SelectedRows)
                {
                    this.cliente.Id = row.Codigo;
                }
                //this.usuario = new Usuario();
                this.cliente.get();
                Usuario usuario = new Usuario();
                usuario.Id = cliente.IdUsuario;
                usuario.get();
                this.cliente.Usuario = usuario;
                this.DialogResult = DialogResult.OK;
                //this.Close();
            }
        }
    }

    public class ClienteRow : DataGridViewRow
    {
        private long? codigo;

        public long? Codigo { get { return codigo; } }

        public ClienteRow(Cliente cliente)
        {
            this.codigo = cliente.Id;
            var nombre = new DataGridViewTextBoxCell();
            nombre.Value = cliente.Nombre;
            var apellido = new DataGridViewTextBoxCell();
            apellido.Value = cliente.Apellido;
            var mail = new DataGridViewTextBoxCell();
            mail.Value = cliente.Mail;
            var identificacion = new DataGridViewTextBoxCell();
            identificacion.Value = cliente.Identificacion;
            var tipoIdentificacion = new DataGridViewTextBoxCell();
            foreach(TipoIdentificacion i in DataSession.TipoIdentificaciones)
            {
                if (i.Id == cliente.TipoDeIdentificacionCod)
                    tipoIdentificacion.Value = i.Nombre;
            }
            var habilitado = new DataGridViewTextBoxCell();
            habilitado.Value = cliente.Activo ? "SI" : "NO";
            Cells.AddRange(new DataGridViewCell[] { nombre, apellido, mail, identificacion, tipoIdentificacion, habilitado });
        }
    }
}
