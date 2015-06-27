using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PagoElectronico.Model;

namespace PagoElectronico.Listados
{
    public partial class FormListadoEstadistico : Form
    {
        List<Trimestre> trimestres = new List<Trimestre>();
        List<TipoListado> tipoListados = new List<TipoListado>();

        private void initializeComboYear()
        {
            List<int> lista = new List<int>();
            DateTime now = Properties.Settings.Default.SYSTEM_DATE; ;
            for (int i = 2000; i <= now.Year; i++)
            {
                lista.Add(i);
            }
            cbYear.DataSource = lista;
        }

        private void initializeComboTrimestre()
        {
            int nroTrimestre = 1;
            for (int i = 1; i < 12; i = i + 3)
            {
                Trimestre trimestre = new Trimestre();
                trimestre.MesInicio = i;
                trimestre.MesFin = i + 2;
                trimestre.Codigo = nroTrimestre;
                trimestre.Descripcion = "Trimestre " + nroTrimestre.ToString();
                nroTrimestre++;
                trimestres.Add(trimestre);
            }
            this.cbTrimestre.DataSource = this.trimestres;
            this.cbTrimestre.ValueMember = "codigo";
            this.cbTrimestre.DisplayMember = "descripcion";
        }

        private void initializeComboListado()
        {
            tipoListados.Add(new TipoListado(1, "Clientes con alguna cuenta ihabilitada por no pagar costos de transacción"));
            tipoListados.Add(new TipoListado(2, "Cliente con mayor cantidad de comisiones facturadas en todas sus cuentas"));
            tipoListados.Add(new TipoListado(3, "Clientes con mayor cantidad de transacciones realizadas entre cuentas propias"));
            tipoListados.Add(new TipoListado(4, "Países con mayour cantidad de movimientos tanto ingresos como egresos"));
            tipoListados.Add(new TipoListado(5, "Total facturados para los distintos tipos de cuentas"));

            this.cbTipoListado.DataSource = this.tipoListados;
            this.cbTipoListado.ValueMember = "codigo";
            this.cbTipoListado.DisplayMember = "descripcion";
        }

        public FormListadoEstadistico()
        {
            InitializeComponent();
            initializeComboYear();
            initializeComboTrimestre();
            initializeComboListado();
            this.dgvListado.AllowUserToAddRows = false;
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btAceptar_Click(object sender, EventArgs e)
        {
            Listado listado = new Listado();
            listado.Year = int.Parse(this.cbYear.SelectedValue.ToString());
            listado.TipoListado = int.Parse(this.cbTipoListado.SelectedValue.ToString());
            foreach (Trimestre trimestre in trimestres)
            {
                if (trimestre.Codigo == int.Parse(this.cbTrimestre.SelectedValue.ToString()))
                {
                    listado.MesInicio = trimestre.MesInicio;
                    listado.MesFin = trimestre.MesFin;
                }
            }
            this.dgvListado.DataSource = listado.listar();
        }
    }

    public class Trimestre
    {
        private int codigo;
        private string descripcion;
        private int mesInicio;
        private int mesFin;

        public int Codigo { get { return codigo; } set { codigo = value; } }
        public string Descripcion { get { return descripcion; } set { descripcion = value; } }
        public int MesInicio { get { return mesInicio; } set { mesInicio = value; } }
        public int MesFin { get { return mesFin; } set { mesFin = value; } }
    }

    public class TipoListado
    {
        private int codigo;
        private string descripcion;

        public int Codigo { get { return codigo; } set { codigo = value; } }
        public string Descripcion { get { return descripcion; } set { descripcion = value; } }

        public TipoListado(int codigo, string descripcion)
        {
            this.codigo = codigo;
            this.descripcion = descripcion;
        }
    }
}
