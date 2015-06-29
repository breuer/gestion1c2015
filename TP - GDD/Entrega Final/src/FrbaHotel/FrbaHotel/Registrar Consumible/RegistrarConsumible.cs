using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaHotel.ClasesTabla;

namespace FrbaHotel.Registrar_Consumible
{
    public partial class RegistrarConsumible : Form
    {
        private SConsumible sConsumible = new SConsumible();
        private SReserva sReserva = new SReserva();

        public RegistrarConsumible()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            decimal precioTotal = 0;
            for (int x = 0; x < consumosgrid.Rows.Count - 1; x++)
            {
                decimal codigoProducto = (decimal)consumosgrid.Rows[x].Cells[0].Value;
                decimal cantidadProducto = (decimal)consumosgrid.Rows[x].Cells[2].Value;
                decimal precioProducto = (decimal)consumosgrid.Rows[x].Cells[3].Value;

                precioTotal = precioTotal + (cantidadProducto * precioProducto);

                sConsumible.RegistrarConsumible(codigoReservatxt.Text,
                    codigoProducto.ToString(), cantidadProducto.ToString(), precioProducto.ToString().Replace(',', '.'));
            }

            MessageBox.Show("Registro de consumibles exitoso");
            btnGuardar.Enabled = false;

            if (sReserva.isAllInclusive(codigoReservatxt.Text))
            {
                precioTotal = -precioTotal;
                sConsumible.registrarAllInclusive(codigoReservatxt.Text, precioTotal.ToString().Replace(',', '.'));
            }
        }

        private void RegistrarConsumible_Load(object sender, EventArgs e)
        {
            List<Consumible> consumibles = sConsumible.GetAll();
            consumiblecbx.DisplayMember = "descripcion";
            consumiblecbx.ValueMember = "codigo";
            consumiblecbx.DataSource = consumibles;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool valido = validarCampos();

            if (valido)
            {
                DataGridViewRow row = (DataGridViewRow)consumosgrid.Rows[0].Clone();
                row.Cells[0].Value = ((Consumible)consumiblecbx.SelectedItem).codigo;
                row.Cells[1].Value = ((Consumible)consumiblecbx.SelectedItem).descripcion;
                row.Cells[2].Value = decimal.Parse(cantidadtxt.Text);
                row.Cells[3].Value = ((Consumible)consumiblecbx.SelectedItem).precio;
                row.Cells[4].Value = "eliminar";

                consumosgrid.Rows.Add(row);

                codigoReservatxt.ReadOnly = true;
            }
        }

        private bool validarCampos()
        {
            if (codigoReservatxt.Text == "" || consumiblecbx.Text == "" || cantidadtxt.Text == "")
            {
                MessageBox.Show("Complete los datos requeridos con *");
                return false;
            }

            if (sReserva.GetReserva(codigoReservatxt.Text) == null)
            {
                MessageBox.Show("El codigo de reserva ingresado no existe");
                return false;
            }

            for (int x = 0; x < consumosgrid.Rows.Count - 1; x++)
            {
                if (((Consumible)consumiblecbx.SelectedItem).codigo.ToString() == consumosgrid.Rows[x].Cells[0].Value.ToString())
                {
                    MessageBox.Show("Ya hay un consumible cargado con ese codigo");
                    return false;
                }
            }

            return true;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            codigoReservatxt.Text = "";
            cantidadtxt.Text = "";
            codigoReservatxt.ReadOnly = false;

            for (int x = 0; x < consumosgrid.Rows.Count - 1; x++)
            {
                consumosgrid.Rows.RemoveAt(x);
            }
        }

        private void consumosgrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (consumosgrid.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                consumosgrid.Rows.RemoveAt(e.RowIndex);
            }
        }
    }
}