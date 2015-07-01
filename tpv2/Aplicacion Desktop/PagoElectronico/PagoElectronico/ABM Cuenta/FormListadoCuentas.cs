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
            tipoCuenta.HeaderText = "Tipo cuenta";

            dgvCuentas.Columns.AddRange(new DataGridViewColumn[] { numero, pais, fechaApertura, tipoCuenta });
            dgvCuentas.AllowUserToAddRows = false;
            dgvCuentas.MultiSelect = false;

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
            FormCuenta frm = new FormCuenta(cuenta);
            frm.ShowDialog();
            
            if (frm.DialogResult == DialogResult.OK)
            {
                dgvCuentas.Rows.Add(new CuentaRow(cuenta));
            }
        }

        private void btSelect_Click(object sender, EventArgs e)
        {
            Cuenta cuenta = new Cuenta();
            if (dgvCuentas.SelectedRows.Count > 0)
            {
                foreach (CuentaRow row in this.dgvCuentas.SelectedRows)
                {
                    cuenta.Numero = row.Codigo;
                }
                //this.usuario = new Usuario();
                this.cliente.get();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }

    public class CuentaRow : DataGridViewRow
    {
        private int codigo;

        public int Codigo { get { return codigo; } }

        public CuentaRow(Cuenta cuenta)
        {
            this.codigo = cuenta.Numero;
            var numero = new DataGridViewTextBoxCell();
            numero.Value = cuenta.Numero;
            var pais = new DataGridViewTextBoxCell();
            foreach (Pais p in DataSession.Paices)
            {
                if (p.Id == cuenta.PaisCod)
                    pais.Value = p.Nombre;
            }
            var fechaApertura = new DataGridViewTextBoxCell();
            fechaApertura.Value = cuenta.FechaApertura;
            var tipoCuenta = new DataGridViewTextBoxCell();
            
            Cells.AddRange(new DataGridViewCell[] { numero, pais, fechaApertura, null });
        }
    }
}
