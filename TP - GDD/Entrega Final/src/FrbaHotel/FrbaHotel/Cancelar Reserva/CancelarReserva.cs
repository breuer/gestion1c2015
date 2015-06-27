using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaHotel.ClasesTabla;

namespace FrbaHotel.Cancelar_Reserva
{
    public partial class CancelarReserva : Form
    {
        SReserva sReserva = new SReserva();

        public CancelarReserva()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if ((txtareaMotivo.Text != "") && (txtNumeroReserva.Text != ""))
            {
                Reserva reserva = sReserva.getReserva(txtNumeroReserva.Text);
                if (reserva != null)
                {
                    if (reserva.cod_estado == 1 || reserva.cod_estado == 2)
                    {
                        if(Login.Log.user != 1){
                            if(reserva.cod_hotel == Login.Log.hotel){
                                sReserva.cancelarReserva(reserva);
                                sReserva.auditarReserva(reserva, FormIni.FechaSistema.ToShortDateString(), "Baja - " + txtareaMotivo.Text);
                                MessageBox.Show("La reserva ha sido cancelada correctamente");
                                resetear();
                            }
                            else
                                MessageBox.Show("No puede cancelar reservas de otros hoteles");
                        }else{
                            sReserva.cancelarReserva(reserva);
                            sReserva.auditarReserva(reserva, FormIni.FechaSistema.ToShortDateString(), "Baja - "+txtareaMotivo.Text);
                            MessageBox.Show("La reserva ha sido cancelada correctamente");
                            resetear();
                        }
                    }
                    else
                    {
                        if (reserva.cod_estado == 6)
                            MessageBox.Show("La reserva ha sido utilizada anteriormente");
                        else
                            MessageBox.Show("La reserva ha sido cancelada anteriormente");
                    }
                }
                else
                {
                    MessageBox.Show("Número de reserva no válido");
                }
            }
            else
            {
                MessageBox.Show("Complete los datos");
            }
        }

        private void CancelarReserva_Load(object sender, EventArgs e)
        {
            txtFechaCancela.Text = FormIni.FechaSistema.ToShortDateString();
            txtareaMotivo.Text = "";
            txtNumeroReserva.Text = "";
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            resetear();
        }

        private void resetear()
        {
            txtareaMotivo.Text = "";
            txtNumeroReserva.Text = "";
        }
    }
}
