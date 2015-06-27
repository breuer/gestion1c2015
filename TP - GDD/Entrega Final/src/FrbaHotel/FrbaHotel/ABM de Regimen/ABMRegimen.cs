using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaHotel.ClasesTabla;

namespace FrbaHotel.ABM_de_Regimen
{
    public partial class ABMRegimen : Form
    {
        public ABMRegimen()
        {
            InitializeComponent();
        }

        static public decimal codReg = 0;
        static public decimal codhotel = 0;

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //variar precio de las que no estan usandose

            if (validar())
            {
                BuildRegimen();
                try
                {

                    if (codReg > 0)
                    {
                        if (reg.estado == false)
                        { //darle de baja
                            SHotel sHotel = new SHotel();

                            var ocupado = sHotel.hotelOcupadoRegimen(reg.cod_hotel, reg.cod_regimen, FormIni.FechaSistema);
                            if (ocupado == false)
                            {
                                sRegimen.UpdateDTO(reg);
                                MessageBox.Show("Operación exitosa!");
                            }
                            else if (reg.estado == false)
                                MessageBox.Show("No puede dar de baja, hay reservas con este tipo de regimen!");
                        }
                        else
                        {
                            sRegimen.UpdateDTO(reg);
                            MessageBox.Show("Operación exitosa!");
                        }
                    }
                    else
                    {
                        codReg = sRegimen.SaveDTO(reg);
                        MessageBox.Show("Operación exitosa!");
                    }
                }

                catch (Exception)
                {
                    MessageBox.Show("Error en la operación!");
                }
                finally
                {

                    if (codReg > 0)
                        this.Close();
                    else
                        limpiar();
                }
            }
        }

        SRegimen sRegimen = new SRegimen();
        RegimenDTO reg = new RegimenDTO();

        private void BuildRegimen()
        {
            if (codReg != 0)
            {
                reg = sRegimen.GetByCodDTO(codReg, codhotel);
                reg.cod_regimen = codReg;
            }

            reg.cod_hotel = codhotel;
            reg.descripcion = cboDescrip.Text;
            reg.estado = ckActivo.Checked;
            reg.precio_base = decimal.Parse(txtPrecio.Text);

        }

        private bool validar()
        {
            if (cboDescrip.Text.Trim() != "")
            {
                if (txtPrecio.Text.Trim() != "." || txtPrecio.Text.Trim() != "" || txtPrecio.Text.Trim() != ",")
                {
                    try
                    {
                        decimal precio = decimal.Parse(txtPrecio.Text.Replace('.', ','));
                        return true;
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("El formato ingresado como precio base es incorrecto!");
                        return false;
                    }
                }
                else return false;
            }
            else
            {
                MessageBox.Show("Todos los datos son obligatorios!");
                return false;
            }
        }

        private void cargarFormulario()
        {
            RegimenDTO reg = sRegimen.GetByCodDTO(codReg, codhotel);

            cboDescrip.Text = reg.descripcion;
            txtPrecio.Text = reg.precio_base.ToString();
            ckActivo.Checked = reg.estado;
            if (reg.precio_base != 0)
                txtPrecio.Enabled = false;
            if (ckActivo.Checked == true)
                ckActivo.Enabled = false;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void limpiar()
        {
            cboDescrip.Text = "";
            txtPrecio.Text = "";
            ckActivo.Checked = false;
            codReg = 0;
        }

        private void ABMRegimen_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (ABM_de_Regimen.BusquedaRegimen.ventanabusqreg != null)
                ABM_de_Regimen.BusquedaRegimen.ventanabusqreg.cargate();
            ABM_de_Regimen.BusquedaRegimen.selectedReg = 0;
            codReg = 0;
            codhotel = 0;
        }

        private void ABMRegimen_Load(object sender, EventArgs e)
        {
            codReg = ABM_de_Regimen.BusquedaRegimen.selectedReg;
            codhotel = ABM_de_Regimen.BusquedaRegimen.codHotel;

            if (codReg != 0)
                cargarFormulario();

        }
    }
}
