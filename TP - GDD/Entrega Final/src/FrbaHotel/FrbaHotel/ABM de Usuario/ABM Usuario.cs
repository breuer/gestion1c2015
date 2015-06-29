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

namespace FrbaHotel.ABM_de_Usuario
{
    public partial class ABMUser : Form
    {
        public ABMUser()
        {
            InitializeComponent();
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

        static public decimal valorL = 0;

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Limpiar()
        {
            txtApellido.Text = "";
            txtCalle.Text = "";
            /* for (int i = 0; i < ckLstHoteles.Items.Count; i++)
                 ckLstHoteles.SetItemCheckState(i, CheckState.Unchecked);*/
            txtMail.Text = "";
            txtNacimiento.Text = "";
            txtNombre.Text = "";
            txtNumCalle.Text = "";
            txtNumDNI.Text = "";
            txtPassword.Text = "";
            txtTelefono.Text = "";
            txtUser.Text = "";
            for (int i = 0; i < ckListRoles.Items.Count; i++)
                ckListRoles.SetItemCheckState(i, CheckState.Unchecked);
            cboTipoDNI.SelectedValue = 1;
            calendNacimiento.Visible = false;
            valorL = 0;
        }

        SUsuario sUsuario = new SUsuario();
        SPersona sCliente = new SPersona();
        EntidadBase entidadBase = new EntidadBase();

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                if (valorL == 0)
                {
                    bool puedeNew = ValidarNuevo();
                    if (puedeNew)
                        BuildUsuario();

                }
                else
                {
                    bool puede = ValidarModificacion();
                    if (puede)
                        BuildUsuario();
                }
            }
        }

        private bool ValidarNuevo()
        {
            bool resultado = true;
            Usuario usuario = sUsuario.GetByUser(txtUser.Text);
            if (usuario != null)
            {
                MessageBox.Show("El usuario ya está asignado, elija otro nombre.");
                resultado = false;
            }
            else
            {
                List<Persona> clientesMail = sCliente.GetByMail(txtMail.Text);
                if (clientesMail.Count != 0)
                {
                    MessageBox.Show("El mail debe ser único! Ya está registrado.");
                    resultado = false;
                }
                else
                    resultado = true;
            }
            return resultado;
        }

        private bool ValidarModificacion()
        {
            Usuario usuario = new Usuario();
            bool resultado = true;
            Usuario user = sUsuario.GetByCod(valorL);
            usuario = user;

            Persona per = new Persona();

            usuario.codigo = valorL;
            per = sCliente.GetByCod(decimal.Parse(user.cod_persona.ToString()));

            if (per.num_doc != decimal.Parse(txtNumDNI.Text))
            {
                List<Persona> persona = sCliente.GetByDoc(decimal.Parse(txtNumDNI.Text));
                if (persona.Count > 0)
                {
                    MessageBox.Show("Ya existe otra persona con ese documento!");
                    resultado = false;
                }
                else
                    resultado = true;
            }
            if (resultado == true)
            {
                if (per.mail != txtMail.Text)
                {
                    List<Persona> persona = sCliente.GetByMail(txtMail.Text);
                    if (persona.Count > 0)
                    {
                        resultado = false;
                        MessageBox.Show("Ya existe otra persona con ese mail!");
                    }
                    else
                        resultado = true;
                }

                if (resultado == true)
                {
                    if (user.user_nombre != txtUser.Text)
                    {
                        Usuario usuarioExiste = sUsuario.GetByUser(txtUser.Text);
                        if (usuarioExiste != null)
                        {
                            resultado = false;
                            MessageBox.Show("Ya existe otra persona con ese usuario!");
                        }
                        else
                            resultado = true;
                    }
                }
            }
            return resultado;
        }

        private void BuildUsuario()
        {
            Usuario usuario = new Usuario();

            Usuario user = sUsuario.GetByCod(valorL);
            if (user != null)
                usuario = user;

            Persona per = new Persona();

            if (valorL != 0)
            {
                usuario.codigo = valorL;
                per = sCliente.GetByCod(decimal.Parse(user.cod_persona.ToString()));
            }

            per.num_doc = decimal.Parse(txtNumDNI.Text);
            per.nombre = txtNombre.Text;
            per.apellido = txtApellido.Text;
            per.codigo_tipo_doc = int.Parse(cboTipoDNI.SelectedValue.ToString());
            per.mail = txtMail.Text;

            string tel = txtTelefono.Text.Replace('-', ' ').Replace(" ", "").Trim().ToString();
            per.telefono = decimal.Parse(tel);
            per.nom_calle = txtCalle.Text;
            per.num_calle = decimal.Parse(txtNumCalle.Text);
            per.fecha_nacimiento = DateTime.Parse(txtNacimiento.Text);
            per.estado = true;

            decimal codPer;
            if (valorL == 0)
                codPer = sCliente.Save(per);
            else
                codPer = sCliente.Update(per);

            string encriptadaContra = SHA256Encripta(txtPassword.Text);
            usuario.user_nombre = txtUser.Text;
            if (valorL == 0)
                usuario.user_password = encriptadaContra;
            else if (user.user_password != txtPassword.Text)
                usuario.user_password = encriptadaContra;
            usuario.logueado = 0;
            usuario.intentos_fallidos = 0;
            usuario.cod_persona = codPer;
            usuario.estado = true;
            usuario.estado = ckActivo.Checked;

            decimal codUsuario;
            if (valorL == 0)
            {
                codUsuario = sUsuario.Save(usuario);
            }
            else
            {
                codUsuario = sUsuario.Update(usuario);
            }
            altaRoles(codUsuario);

            if (valorL == 0)
                altaHotelesRol(codUsuario); //solo da alta a la relacion si es que es un usuario nuevo
            
            MessageBox.Show("Operación exitosa!");
            if (valorL != 0)
                this.Close();
            else
                Limpiar();
        }

        private void cargarRoles(decimal codUsuario)
        {
            SRol sRol = new SRol();
            List<Rol> roles = sRol.GetRolesUser(codUsuario);

            for (int i = 0; i <= (ckListRoles.Items.Count - 1); i++)
            {
                string descr = ((Rol)ckListRoles.Items[i]).descripcion.ToString();
                var checkear = false;

                foreach (Rol r in roles)
                {
                    if (descr == r.descripcion) checkear = true;
                }
                if (checkear)
                    ckListRoles.SetItemCheckState(i, CheckState.Checked);
                else
                    ckListRoles.SetItemCheckState(i, CheckState.Unchecked);
            }
        }

        /*   private void cargarHoteles(decimal codUsuario)
           {
               SHotel sHotel = new SHotel();
               List<Hotel> hoteles = sHotel.GetBySQL("hotel.SP_GETHOTELESDEUSUARIO " + valorL);

               for (int i = 0; i <= (ckLstHoteles.Items.Count - 1); i++)
               {
                   string direccion = ((Hotel)ckLstHoteles.Items[i]).direccionCompleta.ToString();
                   var checkear = false;

                   foreach (Hotel h in hoteles)
                   {
                       if (direccion == h.direccionCompleta) checkear = true;
                   }
                   if (checkear)
                       ckLstHoteles.SetItemCheckState(i, CheckState.Checked);
                   else
                       ckLstHoteles.SetItemCheckState(i, CheckState.Unchecked);
               }
           }*/

        private void altaHotelesRol(decimal codUsuario)
        {
            decimal codHotel = Login.Log.hotel;

            entidadBase.EjecutarSQL("insert hotel.Usuario_hotel (cod_usuario,cod_hotel) values (" + codUsuario.ToString() + "," + codHotel + ")");

            /* SHotel sHotel = new SHotel();
             List<Hotel> hoteles = sHotel.GetAllActivos();
             List<Hotel> hotelesAlta = new List<Hotel>();

             sUsuario.DeleteAllByCodUser(codUsuario);

             foreach (int indexChecked in ckLstHoteles.CheckedIndices)
             {
                 string direccion = ((Hotel)ckLstHoteles.Items[indexChecked]).direccionCompleta.ToString();

                 foreach (Hotel h in hoteles)
                 {
                     if (direccion == h.direccionCompleta)
                         entidadBase.EjecutarSQL("insert hotel.Usuario_hotel (cod_usuario,cod_hotel) values (" + codUsuario.ToString() + "," + h.codigo.ToString() + ")");
                 }
             }*/

        }

        private void altaRoles(decimal codUsuario)
        {
            SRol sRol = new SRol();
            List<Rol> roles = sRol.GetAllActivos();

            entidadBase.EjecutarSQL("delete hotel.Rol_Usuario where cod_usuario =" + codUsuario);

            foreach (int indexChecked in ckListRoles.CheckedIndices)
            {
                string descr = ((Rol)ckListRoles.Items[indexChecked]).descripcion.ToString();

                foreach (Rol r in roles)
                {
                    if (descr == r.descripcion)
                        entidadBase.EjecutarSQL("insert hotel.Rol_Usuario (cod_usuario,cod_rol) values (" + codUsuario.ToString() + "," + r.codigo.ToString() + ")");
                }
            }
        }

        private void btnCalendario_Click(object sender, EventArgs e)
        {
            calendNacimiento.Visible = true;
        }

        private void calendNacimiento_DateSelected(object sender, DateRangeEventArgs e)
        {
            txtNacimiento.Text = e.Start.ToShortDateString();
        }

        private void ABMUser_Load(object sender, EventArgs e)
        {
            /*  SHotel sHotel = new SHotel();
              List<Hotel> hoteles = sHotel.GetAllActivos();
              ckLstHoteles.DataSource = hoteles;
              ckLstHoteles.DisplayMember = "direccionCompleta";
              ckLstHoteles.ValueMember = "codigo";

              */
            calendNacimiento.MaxDate = FormIni.FechaSistema;
            calendNacimiento.TodayDate = FormIni.FechaSistema;

            if (Login.Log.hotel != 0)
            {
                SHotel sHotel = new SHotel();
                Hotel hotel = sHotel.GetByCod(Login.Log.hotel);
                if ((hotel.administrador != 0 || hotel.administrador != null) && Login.Log.user != 2)
                {

                    SRol SRol = new SRol();
                    List<Rol> roles = SRol.GetRolAsig();
                    Rol rolAdmin = (from r in roles where r.descripcion == "Administrador" select r).SingleOrDefault();
                    roles.Remove(rolAdmin);
                    ckListRoles.DataSource = roles;
                    ckListRoles.DisplayMember = "descripcion";
                    ckListRoles.ValueMember = "codigo";
                }
                else {
                    SRol SRol = new SRol();
                    List<Rol> roles = SRol.GetRolAsig();
                    ckListRoles.DataSource = roles;
                    ckListRoles.DisplayMember = "descripcion";
                    ckListRoles.ValueMember = "codigo";
                }
            }
            else
            {
                SRol SRol = new SRol();
                List<Rol> roles = SRol.GetRolAsig();
                ckListRoles.DataSource = roles;
                ckListRoles.DisplayMember = "descripcion";
                ckListRoles.ValueMember = "codigo";

            }

            STipoDoc stip = new STipoDoc();
            List<TipoDoc> tipos = stip.GetAll();
            cboTipoDNI.DataSource = tipos;
            cboTipoDNI.DisplayMember = "descripcion";
            cboTipoDNI.ValueMember = "codigo";


            if (ABM_de_Usuario.BusquedaUser.usuarioSelected != 0)
                cargarFormulario(ABM_de_Usuario.BusquedaUser.usuarioSelected);

            ckActivo.Checked = true;
        }

        private void cargarFormulario(decimal codUsuario)
        {
            Usuario usuario = sUsuario.GetByCod(codUsuario);
            valorL = usuario.codigo;
            List<Persona> per = sCliente.GetBySQL("hotel.SP_GETPERSONAUsuario " + valorL);
            Persona persona = per.SingleOrDefault();

            //cargarHoteles(codUsuario);

            cargarRoles(codUsuario);
            if (persona != null)
            {
                txtApellido.Text = persona.apellido;
                txtCalle.Text = persona.nom_calle;
                txtMail.Text = persona.mail;
                txtNacimiento.Text = persona.fecha_nacimiento.ToString();
                txtNombre.Text = persona.nombre;
                txtNumCalle.Text = persona.num_calle.ToString();
                txtNumDNI.Text = persona.num_doc.ToString();
                txtPassword.Text = usuario.user_password;
                txtTelefono.Text = persona.telefono.ToString();
                txtUser.Text = usuario.user_nombre;
                cboTipoDNI.SelectedValue = persona.codigo_tipo_doc;
                ckActivo.Checked = usuario.estado;

                if (ckActivo.Checked == true) ckActivo.Enabled = false;
            }
        }

        private bool validar()
        {
            if (
            txtApellido.Text.Trim() != "" &&
            txtCalle.Text.Trim() != "" &&
            txtMail.Text.Trim() != "" &&
            txtNacimiento.Text.Trim() != "" &&
            txtNombre.Text.Trim() != "" &&
            txtNumCalle.Text.Trim() != "" &&
            txtNumDNI.Text.Trim() != "" &&
            txtPassword.Text.Trim() != "" &&
            txtTelefono.Text.Trim() != "" &&
            txtUser.Text.Trim() != "" &&
            ckListRoles.SelectedItems.Count != 0 &&
            cboTipoDNI.Text.Trim() != "")

                return true;
            else
            {
                MessageBox.Show("Todos los datos son obligatorios!");
                return false;
            }
        }

        private void ABMUser_FormClosing(object sender, FormClosingEventArgs e)
        {
            valorL = 0;
            ABM_de_Usuario.BusquedaUser.usuarioSelected = 0;
            if (ABM_de_Usuario.BusquedaUser.ventanaBusqueda != null)
                ABM_de_Usuario.BusquedaUser.ventanaBusqueda.cargate();
        }

    }
}
