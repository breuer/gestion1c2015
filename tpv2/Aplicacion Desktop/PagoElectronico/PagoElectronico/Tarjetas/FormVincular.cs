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
    public partial class FormVincular : Form
    {
        DataTable emisores_tarjetas;
        Usuario usuario;

        public FormVincular(Usuario user)
        {
            InitializeComponent();
            this.usuario = user;
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

                if ((fec_emision!="")&&(fec_vencimiento!="")&&(this.txt_cod_seg.Text!="")&&(this.txt_num.Text!=""))
                {
                    //Revisar si ya hay una tarjeta ya vinculada.
                    if (tarj.existe_tarjeta_emisor_usuario(this.txt_num.Text, emisID, this.usuario.Id) == 1)
                    {
                        tarj.vincular_tarjeta(this.txt_num.Text, emisID, fec_emision, fec_vencimiento, this.txt_cod_seg.Text, this.usuario.Id);
                        MessageBox.Show("La tarjeta ha sido vinculada");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Ya se encuentra vinculada esa tarjeta");
                    }
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

        private void FormVincular_Load(object sender, EventArgs e)
        {
            cargar_combo_emisores();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
