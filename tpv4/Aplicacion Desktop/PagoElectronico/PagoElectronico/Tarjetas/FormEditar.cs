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

namespace PagoElectronico.Tarjetas
{
    public partial class FormEditar : Form
    {
        DataTable emisores_tarjetas;
        Usuario   usuario;
        DataTable tarjeta;

        private int buscar_ix_tarj_id(int id)
        {
            int i = 0;

            foreach (DataRow row in this.emisores_tarjetas.Rows)
            {
                if (int.Parse(row["tarjemis_id"].ToString()) == id)
                    return i;
                else
                    i++;
            }

            return i;
        }

        public FormEditar(Usuario user,int tarjID)
        {
            InitializeComponent();
            this.usuario = user;
            
            Tarjeta tarj = new Tarjeta();
            this.tarjeta = tarj.traer_tarjeta_id(tarjID);

            cargar_combo_emisores();

            string num = this.tarjeta.Rows[0]["tarj_numero"].ToString();
            int  emisor = int.Parse(this.tarjeta.Rows[0]["tarj_emisor"].ToString());
            string fec_emis = this.tarjeta.Rows[0]["tarj_fecemision"].ToString();
            string fec_venc = this.tarjeta.Rows[0]["tarj_fecvencimiento"].ToString();
            string cod_seg = this.tarjeta.Rows[0]["tarj_codseguridad"].ToString();
            
            this.txt_cod_seg.Text = cod_seg;
            this.txt_num.Text = num;
            this.txt_fec_emis.Text = fec_emis;
            this.txt_fec_venc.Text = fec_venc;
            this.combo_emisores.SelectedIndex = this.buscar_ix_tarj_id(emisor);
        }

        private void cargar_combo_emisores()
        {
            Tarjeta tarj = new Tarjeta();
            DataTable resu = tarj.traer_emisores_tarjetas();
            
            //Si hay cuentas activas.
            if (resu.Rows.Count > 0)
            {
                this.emisores_tarjetas = resu;

                foreach (DataRow row in resu.Rows)
                {
                    combo_emisores.Items.Add(row["tarjemis_nombre"]);
                }
            }
            else
            {
                MessageBox.Show("No hay ningún emisor de tarjetas cargado, no se podra vincular niguna tarjeta.");
                this.Close();
            }     
        }

        private void FormEditar_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string fec_emision     = this.txt_fec_emis.Value.Date.ToString("yyyyMMdd");
            string fec_vencimiento = this.txt_fec_venc.Value.Date.ToString("yyyyMMdd");

            Tarjeta tarj = new Tarjeta();
            int ix_combo = combo_emisores.SelectedIndex;

            //Si hay algo seleccionado.
            if (ix_combo >= 0)
            {
                int emisID = int.Parse(this.emisores_tarjetas.Rows[ix_combo]["tarjemis_id"].ToString());

                if ((fec_emision != "") && (fec_vencimiento != "") && (this.txt_cod_seg.Text != "") && (this.txt_num.Text != ""))
                {
                    int tarj_id = int.Parse(this.tarjeta.Rows[0]["tarj_id"].ToString());
                    tarj.editar_tarjeta(tarj_id,this.txt_num.Text, emisID, fec_emision, fec_vencimiento, this.txt_cod_seg.Text);
                    MessageBox.Show("Tarjeta actualizada");
                    this.Close();                    
                }
                else
                {
                    MessageBox.Show("Hacen falta completar todos los campos.");
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un emisor.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
