using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PagoElectronico.Model;

namespace PagoElectronico.ABM_Cuenta
{
    public partial class FormListadoCuentas : Form
    {
        private Cliente cliente;
       
        private void inicializarDGV()
        {
            var numero = new DataGridViewTextBoxColumn();
            numero.HeaderText = "Numero";
            var pais = new DataGridViewTextBoxColumn();
            pais.HeaderText = "Pais";
            var fechaApertura = new DataGridViewTextBoxColumn();
            fechaApertura.HeaderText = "Fecha apertura";
            var tipoCuenta = new DataGridViewTextBoxColumn();
            tipoCuenta.HeaderText = "Categoría";
            var estadoCuenta = new DataGridViewTextBoxColumn();
            estadoCuenta.HeaderText = "Estado";

            dgvCuentas.Columns.AddRange(new DataGridViewColumn[] { numero, pais, fechaApertura, tipoCuenta, estadoCuenta});
            dgvCuentas.AllowUserToAddRows = false;
            dgvCuentas.MultiSelect = false;
            dgvCuentas.Rows.Clear();
            
            if (cliente.Cuentas!=null)
            foreach (var item in cliente.Cuentas)
            {
                dgvCuentas.Rows.Add(new CuentaRow(item));
            }
        }
        public FormListadoCuentas(Cliente cliente)
        {
            InitializeComponent();
            this.cliente = cliente;
            inicializarDGV();
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btAddCuenta_Click(object sender, EventArgs e)
        {
            Cuenta cuenta = new Cuenta();
            cuenta.ClienteId = this.cliente.Id;
            //MessageBox.Show("ClienteId: " + cuenta.ClienteId.ToString());
            FormCuenta frm = new FormCuenta(cuenta, DataSession.ALTA);
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {
                dgvCuentas.Rows.Clear();
                cliente.Cuentas = null;
                foreach (var item in cliente.Cuentas)
                {
                    dgvCuentas.Rows.Add(new CuentaRow(item));
                }
            }
        }

        private void btSelect_Click(object sender, EventArgs e)
        {
            Cuenta cuenta = new Cuenta();
            if (dgvCuentas.Rows.Count > 0)
            {
                if (dgvCuentas.CurrentCell.RowIndex >= 0)
                {
                    foreach (CuentaRow row in this.dgvCuentas.SelectedRows)
                    {
                        cuenta.Id = row.Codigo;
                    }

                    cuenta.get();
                    FormCuenta frm = new FormCuenta(cuenta, DataSession.MODIFICACION);
                    frm.ShowDialog();

                    dgvCuentas.Rows.Clear();
                    foreach (var item in cliente.Cuentas)
                    {
                        dgvCuentas.Rows.Add(new CuentaRow(item));
                    }                
                }
                else
                {
                    MessageBox.Show("No hay una cuenta seleccionada, haga click en la primera columna.");                
                }
            }
            else
            {
                MessageBox.Show("No hay ninguna cuenta asociada, debe agregar una primero para poder seleccionarla.");
            }
        }
    }

    public class CuentaRow : DataGridViewRow
    {
        private long codigo;

        public long Codigo { get { return codigo; } }

        public CuentaRow(Cuenta cuenta)
        {
            this.codigo = cuenta.Id;
            var numero = new DataGridViewTextBoxCell();
            numero.Value = cuenta.Numero;
            var pais = new DataGridViewTextBoxCell();
            foreach (Pais p in DataSession.Paises)
            {
                if (p.Id == cuenta.PaisCod)
                    pais.Value = p.Nombre;
            }
            var fechaApertura = new DataGridViewTextBoxCell();
            fechaApertura.Value = cuenta.FechaApertura;
            var tipoCuenta = new DataGridViewTextBoxCell();
            foreach (TipoCuenta t in DataSession.TipoCuentas)
            {
                if (t.Id == cuenta.TipoCuentaCod)
                    tipoCuenta.Value = t.Nombre;
            }

            var estadoCuenta = new DataGridViewTextBoxCell();
            foreach (EstadoCuenta e in DataSession.EstadosCuenta)
            {
                if (e.Id == cuenta.EstadoCuentaCod)
                    estadoCuenta.Value = e.Nombre;
            } 

            Cells.AddRange(new DataGridViewCell[] { numero, pais, fechaApertura, tipoCuenta, estadoCuenta });
        }
    }
}
