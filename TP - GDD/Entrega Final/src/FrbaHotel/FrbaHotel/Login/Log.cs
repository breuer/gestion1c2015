using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;
using FrbaHotel.ClasesTabla;

namespace FrbaHotel.Login
{
    public partial class Log : Form
    {
        public Log()
        {
            InitializeComponent();
        }

        static public decimal user = 0;
        static public decimal hotel = 0;
        static public string hotelNombre = null;
        SUsuario sUsuario = new SUsuario();

        private void Log_Load(object sender, EventArgs e)
        {
            user = 0;
            hotel = 0;
            hotelNombre = null;
        }

        public string SHA256Encripta(string input)
        {
            SHA256CryptoServiceProvider provider = new SHA256CryptoServiceProvider();

            byte[] inputBytes = Encoding.UTF8.GetBytes(input);
            byte[] hashedBytes = provider.ComputeHash(inputBytes);

            StringBuilder output = new StringBuilder();

            for (int i = 0; i < hashedBytes.Length; i++)
                output.Append(hashedBytes[i].ToString("x2").ToLower());

            return output.ToString();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            //cambiar variable de inicio loggeado a true y guardar hotel
            //si tiene un solo hotel lo asigna
            if (validar())
            {
                if (user == 0)
                {
                    Usuario usuario = sUsuario.GetByUser(txtUsuario.Text);
                    string encriptadaContra = SHA256Encripta(txtContra.Text);
                    if (usuario != null && encriptadaContra == usuario.user_password)
                    {
                        usuario.logueado = 1;
                        sUsuario.Update(usuario);
                        user = usuario.codigo;
                        FormIni.loggeado = true;
                        SHotel sHotel = new SHotel();
                        List<Hotel> hoteles = sHotel.GetBySQL("hotel.SP_GETHOTELESDEUSUARIO " + user);
                        cboHotel.Visible = true;
                        lblHotel.Visible = true;
                        cboHotel.DisplayMember = "direccionCompleta";
                        cboHotel.ValueMember = "codigo";
                        cboHotel.DataSource = hoteles;

                        if (hoteles.Count == 1)
                        {
                            cboHotel.Visible = true;
                            lblHotel.Visible = true;
                            cboHotel.DisplayMember = "direccionCompleta";
                            cboHotel.ValueMember = "codigo";
                            cboHotel.DataSource = hoteles;
                            Hotel hotelUnico = hoteles.Single();
                            hotel = hotelUnico.codigo;
                            hotelNombre = hotelUnico.direccionCompleta.ToString();
                            MessageBox.Show("Operación exitosa!");
                            this.Close();
                            FormIni.ventanaPrincip.cargarCBOFunc();
                        }
                        else
                        {
                            MessageBox.Show("Elija un hotel para poder ingresar.");
                        }
                    }
                    else if (usuario != null)
                    {
                        MessageBox.Show("Contraseña incorrecta.");
                        if (usuario.intentos_fallidos != 2)
                        {
                            usuario.intentos_fallidos = usuario.intentos_fallidos + 1;
                            sUsuario.Update(usuario);
                        }
                        else
                        {
                            usuario.intentos_fallidos = 0;
                            usuario.logueado = 0;
                            sUsuario.Update(usuario);
                            sUsuario.Delete(usuario.codigo);
                            MessageBox.Show("Comuniquese con el administrador, su usuario fue dado de baja.");
                        }
                    }
                    else MessageBox.Show("Usuario y Contraseña incorrectos.");
                }
                else
                {
                    hotel = decimal.Parse(cboHotel.SelectedValue.ToString());
                    hotelNombre = cboHotel.Text;
                    MessageBox.Show("Operación exitosa!");
                    this.Close();
                    FormIni.ventanaPrincip.cargarCBOFunc();
                }
            }
        }

        private bool validar()
        {
            if (user == 0)
            {
                if (txtUsuario.Text == "" || txtContra.Text == "")
                {
                    MessageBox.Show("Debe ingresar los datos obligatorios.");
                    return false;
                }
                else return true;
            }
            else
                if (((Hotel)cboHotel.SelectedItem).direccionCompleta == "")
                {
                    MessageBox.Show("Debe elegir el hotel.");
                    return false;
                }
                else return true;
        }

    }
}
