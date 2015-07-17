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
using PagoElectronico.Transferencias;

namespace PagoElectronico.Transferencias
{
    public partial class FormTransfer : Form
    {
        public Usuario   usuario;
        public DataTable cuentas_Origen;
        public DataTable cuentas_Destino;

        public FormTransfer(Usuario usuario)
        {
            this.usuario = usuario;
            InitializeComponent();
        }

        //Mostrar panel de origen destino.
        private void mostrar_panel_origen_destino()
        {
            this.panel_transf.Visible = true;
            this.panel_importe.Visible = false;
        }

        //Muestra el panel de importe
        private void mostrar_panel_importe()
        {
            this.panel_transf.Visible = false;
            this.panel_importe.Visible = true;
        }

        //Cargar combo box
        private void cargar_combo_cuentas()
        {
            Transferencia transf = new Transferencia();
            DataTable resu = transf.buscar_cuentas_usuario(this.usuario);

            //Si hay cuentas activas.
            if (resu.Rows.Count > 0)
            {
                this.cuentas_Origen = resu;

                foreach (DataRow row in resu.Rows)
                {
                    combo_ctas_activas.Items.Add(row["cta_num"].ToString() + " - " + row["pais_descrip"].ToString());
                }
            }
            else
            {
                MessageBox.Show("No tenes cuentas activas con saldo disponible, para que puedas realizar una transferencia.");
                this.Close();
            }
        }

        //Agrega a la grilla las cuentas.
        private void cargar_grilla_columnas()
        {
            grilla_cuentas.Columns.Clear();

            //Armo las columnas.
            var numero = new DataGridViewTextBoxColumn();
            numero.HeaderText = "Numero";
            numero.Name       = "numero";

            var pais = new DataGridViewTextBoxColumn();
            pais.HeaderText = "Pais";
            pais.Name       = "pais";

            var apellido = new DataGridViewTextBoxColumn();
            apellido.HeaderText = "Apellido";
            apellido.Name       = "apellido";

            var nombre = new DataGridViewTextBoxColumn();
            nombre.HeaderText = "Nombre";
            nombre.Name       = "nombre";

            //Agrego las columnas.
            grilla_cuentas.Columns.AddRange(new DataGridViewColumn[] { numero, pais, apellido, nombre});

            //Seteo propiedades.
            grilla_cuentas.AllowUserToAddRows = false;
            grilla_cuentas.MultiSelect = false;
        }

        //Agrego a la grilla las filas.
        private void cargar_datos_grilla(DataTable data)
        {
            grilla_cuentas.Rows.Clear();

            foreach (DataRow row in data.Rows)
            {
                grilla_cuentas.Rows.Add(row["cta_num"].ToString(), row["pais_descrip"].ToString(), row["cli_apellido"].ToString(), row["cli_nombre"].ToString());                   
            }            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Transferencia transf = new Transferencia();
            DataTable resu = transf.buscar_cuentas(txt_cuenta.Text);

            if (resu.Rows.Count > 0)
            {                
                //Cargo los datos en la grilla.
                cargar_grilla_columnas();
                cargar_datos_grilla(resu);

                //Asigno las cuentas obtenidas a un objeto en memoria.
                this.cuentas_Destino = resu;
            }
            else
            {
                MessageBox.Show("No se encuentro una cuenta con ese número.");
            }  
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Si hay cuentas destino cargadas.
            if (grilla_cuentas.Rows.Count>0)
            {
                //Si hay items cargados en el combo.
                if (combo_ctas_activas.Items.Count > 0)
                {
                    //Indice elegido.
                    int ix_grilla = grilla_cuentas.CurrentCell.RowIndex;
                    int ix_combo = combo_ctas_activas.SelectedIndex;                     
                
                    //Fijo los textos de los labeles.    
                    label_cta_nomb.Text = "Cliente: "+this.cuentas_Destino.Rows[ix_grilla]["cli_apellido"] + " " + this.cuentas_Destino.Rows[ix_grilla]["cli_nombre"];
                    label_cta_num.Text  = "Cuenta N: °"+this.cuentas_Destino.Rows[ix_grilla]["cta_num"].ToString();
                    label_cta_pais.Text = "Pais: "+this.cuentas_Destino.Rows[ix_grilla]["pais_descrip"].ToString();

                    //Muestro el panel.
                    mostrar_panel_importe();
                }
            }
            else
            {
                MessageBox.Show("No hay cuentas cargadas..");
            }
        }

        private void FormTransfer_Load(object sender, EventArgs e)
        {
            this.cargar_combo_cuentas();
            this.panel_importe.Location = new Point(panel_importe.Location.X,12);
            this.Size = new System.Drawing.Size(this.Size.Width,505);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Indice elegido.
            int ix_grilla = grilla_cuentas.CurrentCell.RowIndex;
            int ix_combo = combo_ctas_activas.SelectedIndex;  

            //Obtengo las cuentas.
            String cta_origen = this.cuentas_Origen.Rows[ix_combo]["cta_id"].ToString();
            String cta_destino = this.cuentas_Destino.Rows[ix_grilla]["cta_id"].ToString();

            //Importe.
            float importe = float.Parse(txt_importe.Text);

            //Hacer transferencia.
            Transferencia transf = new Transferencia();
            int resu = transf.hacer_transferencia(cta_origen, cta_destino, importe);

            switch (resu)
            { 
                case 1:
                        MessageBox.Show("Transferencia realizada correctamente!");
                        this.Close();
                        break;
                case -1:
                        MessageBox.Show("Cuenta invalida");
                        break;
                case -2:
                        MessageBox.Show("El importe debe ser mayor a cero");
                        break;
                case -3:
                        MessageBox.Show("No hay saldo suficiente para realizar la transferncia.");
                        break;
            }            
        }

        private void combo_ctas_activas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_cuenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
