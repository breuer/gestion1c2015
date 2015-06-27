using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaHotel.ClasesTabla;

namespace FrbaHotel.ABM_Hotel
{
    public partial class ABMHotel : Form
    {
        public ABMHotel()
        {
            InitializeComponent();
        }

        

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (validar())
            {

                Hotel hotel = BuildHotel();

                try
                {

                    if (codHotel > 0)
                    {
                        codHotel = sHotel.Update(hotel);
                    }
                    else
                    {
                        codHotel = sHotel.Save(hotel,Login.Log.user);
                    }
                    altaRegimen(codHotel);
                    MessageBox.Show("Operación exitosa!");
                }

                catch (Exception)
                {
                    MessageBox.Show("Error en la operación!");
                }
                finally
                {

                    if (codHotel > 0)
                        this.Close();
                    else
                        limpiar();
                }
            }
        }

        private Hotel BuildHotel()
        {
            Hotel hotel = new Hotel();

            if (codHotel != 0)
            {
                hotel = sHotel.GetByCod(codHotel);
                hotel.codigo = codHotel;
            }

            hotel.nombre = txtNombre.Text;
            hotel.telefono = decimal.Parse(txtTelefono.Text.Replace('-', ' ').Replace(" ", "").Trim().ToString());
            hotel.recarga_estrella = numUpDnCantEstrellas.Value;
            hotel.mail = txtMail.Text;
            hotel.fecha_creacion = Convert.ToDateTime(txtFecha.Text);
            hotel.ciudad = txtCiudad.Text;
            hotel.nom_calle = txtCalle.Text;
            hotel.num_calle = decimal.Parse(txtNumCalle.Text);
            hotel.pais = txtPais.Text;
            if (Login.Log.user != 2)
                hotel.administrador = Login.Log.user;
            hotel.cant_estrellas = numUpDnCantEstrellas.Value;
            hotel.recarga_estrella = numUpDownRecEstrella.Value;
            return hotel;
        }

        private void altaRegimen(decimal codHotel)
        {
            //da de alta los checkeados nuevos
            List<RegimenDTO> regimenesDelHotel = sRegimen.GetAllHotel(codHotel);
            List<Regimen> regimenes = sRegimen.GetAll();
            foreach (RegimenDTO reg in regimenesDelHotel)
            {
                Regimen regimen = (from r in regimenes where r.descripcion == reg.descripcion select r).SingleOrDefault();
                regimenes.Remove(regimen);
            }

            foreach (int indexChecked in ckLstRegimenes.CheckedIndices)
            {
                string descrip = ((Regimen)ckLstRegimenes.Items[indexChecked]).descripcion.ToString();

                foreach (Regimen regimen in regimenes)
                {
                    if (descrip == regimen.descripcion)
                        sRegimen.SaveDTO(regimen, codHotel);
                }
            }
        }

        private bool validar()
        {
            if (
            txtCiudad.Text.Trim() != "" &&
            txtCalle.Text.Trim() != "" &&
            txtMail.Text.Trim() != "" &&
            txtFecha.Text.Trim() != "" &&
            txtPais.Text.Trim() != "" &&
            ckLstRegimenes.SelectedValue != null &&
            numUpDnCantEstrellas.Value != 0 &&
            txtNombre.Text.Trim() != "" &&
            txtNumCalle.Text.Trim() != "" &&
            txtTelefono.Text.Trim() != "")
            {

                if (codHotel > 0)
                {
                    Hotel hotelCalle = sHotel.GetByDireccion(txtCalle.Text + " " + txtNumCalle.Text);
                    Hotel hotel = sHotel.GetByCod(codHotel);
                    var direccion = txtCalle.Text + " " + txtNumCalle.Text;
                    if (direccion != hotel.direccionCompleta)
                    {
                        if (hotelCalle != null) { MessageBox.Show("Ya existe un hotel en esa dirección!"); return false; }
                        else
                            return true;
                    }
                    else
                        return true;
                }
                else
                {
                    Hotel hotelCalle = sHotel.GetByDireccion(txtCalle.Text + " " + txtNumCalle.Text);
                    if (hotelCalle != null) { MessageBox.Show("Ya existe un hotel en esa dirección!"); return false; }
                    else
                        return true;
                }


            }
            else
            {
                MessageBox.Show("Todos los datos son obligatorios!");
                return false;
            }
        }

        static public decimal codHotel = 0;

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void limpiar()
        {
            txtCalle.Text = "";
            txtCiudad.Text = "";
            txtFecha.Text = "";
            txtMail.Text = "";
            txtNombre.Text = "";
            txtNumCalle.Text = "";
            txtPais.Text = "";
            txtTelefono.Text = "";
            for (int i = 0; i < ckLstRegimenes.Items.Count; i++)
                ckLstRegimenes.SetItemCheckState(i, CheckState.Unchecked);
            numUpDnCantEstrellas.Value = 0;
            codHotel = 0;
            //hotel = null;
        }

        private void ABMHotel_Load(object sender, EventArgs e)
        {
            codHotel = ABM_Hotel.BusquedaHotel.hotelSelected;
            numUpDownRecEstrella.Value = 10;//default
            SRegimen sRegimen = new SRegimen();
            List<Regimen> regimenes = sRegimen.GetAll();
            ckLstRegimenes.DataSource = regimenes;
            ckLstRegimenes.DisplayMember = "descripcion";
            ckLstRegimenes.ValueMember = "codigo";
            calendFecha.TodayDate = FormIni.FechaSistema;
            if (codHotel != 0)
                cargarFormulario();

        }

        SHotel sHotel = new SHotel();
        SRegimen sRegimen = new SRegimen();

        private void cargarFormulario()
        {
            Hotel hotel = sHotel.GetByCod(codHotel);

            cargarRegimenes();

            txtCalle.Text = hotel.nom_calle;
            txtMail.Text = hotel.mail;
            txtNombre.Text = hotel.nombre;
            txtNumCalle.Text = hotel.num_calle.ToString();
            txtTelefono.Text = hotel.telefono.ToString();
            txtCiudad.Text = hotel.ciudad;
            txtPais.Text = hotel.pais;
            txtFecha.Text = hotel.fecha_creacion.ToShortDateString();
            numUpDnCantEstrellas.Value = hotel.cant_estrellas;
            btnCalendario.Enabled = false;
        }

        private void cargarRegimenes()
        {
            Hotel hotel = sHotel.GetByCod(codHotel);

            List<RegimenDTO> regimenesHotel = sRegimen.GetAllHotel(hotel.codigo);

            for (int i = 0; i <= (ckLstRegimenes.Items.Count - 1); i++)
            {
                string descrip = ((Regimen)ckLstRegimenes.Items[i]).descripcion.ToString();
                var checkear = false;

                foreach (RegimenDTO regimen in regimenesHotel)
                {
                    if (descrip == regimen.descripcion) checkear = true;
                }
                if (checkear)
                    ckLstRegimenes.SetItemCheckState(i, CheckState.Checked);
                else
                    ckLstRegimenes.SetItemCheckState(i, CheckState.Unchecked);
            }
            //ckLstRegimenes.Enabled = false;
        }

        private void btnCalendario_Click(object sender, EventArgs e)
        {
            calendFecha.Visible = true;
        }

        private void calendFecha_DateSelected(object sender, DateRangeEventArgs e)
        {
            txtFecha.Text = e.Start.ToShortDateString();
        }

        private void ABMHotel_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (ABM_Hotel.BusquedaHotel.ventanaHotel != null)
                ABM_Hotel.BusquedaHotel.ventanaHotel.cargate();
            ABM_Hotel.BusquedaHotel.hotelSelected = 0;
            //hotel = null;
        }
    }
}
