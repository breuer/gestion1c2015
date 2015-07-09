using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PagoElectronico.Model;

namespace PagoElectronico.Login
{
    public partial class FormChangePassword : Form
    {
        Usuario usuario;

        public FormChangePassword(Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
        }

        private void btAceptar_Click(object sender, EventArgs e)
        {
            usuario.Password = this.tbPassword.Text;
            usuario.updatePassword();
            this.Close();
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
