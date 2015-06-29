using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PagoElectronico.Model;
using PagoElectronico.DAO;
using PagoElectronico.Saldos;

namespace PagoElectronico.Saldos
{
    public partial class FormSaldo_admin : Form
    {
        public Usuario   usuario;
        public DataTable cuentas_usuario;

        public FormSaldo_admin(Usuario usuario)
        {
            this.usuario = usuario;
            InitializeComponent();
        }

        //Agrega a la grilla las cuentas.
        private void cargar_grilla_columnas_cuentas()
        {
            grilla_cuentas.Columns.Clear();

            //Armo las columnas.
            var num = new DataGridViewTextBoxColumn();
            num.HeaderText = "Num";
            num.Name = "Num";

            var pais = new DataGridViewTextBoxColumn();
            pais.HeaderText = "Pais";
            pais.Name = "Pais";

            var apellido = new DataGridViewTextBoxColumn();
            apellido.HeaderText = "Apellido";
            apellido.Name = "Apellido";

            var nombre = new DataGridViewTextBoxColumn();
            nombre.HeaderText = "Nombre";
            nombre.Name = "Nombre";

            //Agrego las columnas.
            grilla_cuentas.Columns.AddRange(new DataGridViewColumn[] { num, pais, apellido, nombre });

            //Seteo propiedades.
            grilla_cuentas.AllowUserToAddRows = false;
            grilla_cuentas.MultiSelect = false;
        }

        //Agrego a la grilla las filas de cuentas.
        private void cargar_datos_grilla_cuentas(DataTable data)
        {
            grilla_cuentas.Rows.Clear();
          
            foreach (DataRow row in data.Rows)
            {
                grilla_cuentas.Rows.Add(row["cta_num"].ToString(), row["cta_pais_apertura"], row["cli_apellido"], row["cli_nombre"]);
            }
        }

        private void ver_panel_saldo()
        {
            this.panel_movimientos.Visible=false;
            this.panel_saldo.Visible=true;
        }

        private void ver_panel_movimientos()
        {
            this.panel_movimientos.Visible=true;
            this.panel_saldo.Visible=false;        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_cuenta.Text!="")
            {
               Saldo     saldo    = new Saldo();
               DataTable cuentas = saldo.buscar_cuentas_num(txt_cuenta.Text);

               this.cuentas_usuario = cuentas;

               this.cargar_grilla_columnas_cuentas();
               this.cargar_datos_grilla_cuentas(cuentas);
            }
        }

        //Dibuja las columnas de movimientos.
        private void cargar_grilla_columnas_movs()
        {
            grilla_resu.Columns.Clear();

            //Armo las columnas.
            var tipo = new DataGridViewTextBoxColumn();
            tipo.HeaderText = "Tipo";
            tipo.Name = "Tipo";

            var importe = new DataGridViewTextBoxColumn();
            importe.HeaderText = "Importe";
            importe.Name = "Importe";

            var fecha = new DataGridViewTextBoxColumn();
            fecha.HeaderText = "Fecha";
            fecha.Name = "Fecha";

            //Agrego las columnas.
            grilla_resu.Columns.AddRange(new DataGridViewColumn[] { tipo, importe, fecha });

            //Seteo propiedades.
            grilla_resu.AllowUserToAddRows = false;
            grilla_resu.MultiSelect = false;
        }

        //Agrego a la grilla las filas.
        private void cargar_datos_grilla_movs(DataTable data)
        {
            grilla_resu.Rows.Clear();

            foreach (DataRow row in data.Rows)
            {
                grilla_resu.Rows.Add(row["tipo"].ToString(), row["importe"].ToString(), row["fecha"].ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int ix_grilla_cuenta = grilla_cuentas.CurrentCell.RowIndex;

            if (ix_grilla_cuenta >= 0)
            {
                ver_panel_movimientos();

                //Cuenta.
                String cuenta = this.cuentas_usuario.Rows[ix_grilla_cuenta]["cta_id"].ToString();

                //Obtengo el saldo actual.
                Saldo saldo = new Saldo();
                DataTable saldos = saldo.saldo_actual(cuenta);

                //Traigo el saldo.
                if (saldos.Rows.Count > 0)
                {
                    String importe     = saldos.Rows[0]["saldo"].ToString();
                    label_importe.Text = "U$$ "+importe;
                }

                //Dibujo en la grilla los movimientos en la grilla.
                DataTable datos = saldo.consulta_movimientos(cuenta);
                this.cargar_grilla_columnas_movs();
                this.cargar_datos_grilla_movs(datos);
            }
        }

        private void FormSaldo_admin_Load(object sender, EventArgs e)
        {
            this.panel_movimientos.Location = new Point(12,9);
            this.panel_movimientos.Visible = false;
            this.Size = new System.Drawing.Size(this.Size.Width, 447);
        }
    }
}
