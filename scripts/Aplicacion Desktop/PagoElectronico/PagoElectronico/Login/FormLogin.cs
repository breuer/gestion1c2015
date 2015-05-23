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
    public partial class FormLogin : Form
    {
        private Usuario usuario;
        public FormLogin(Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
            this.tbPassword.PasswordChar = '*';
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            if (this.tbUsername.Text != "" & this.tbPassword.Text != "")
            {
                this.usuario.Username = tbUsername.Text;
                this.usuario.Password = tbPassword.Text;
                if (this.usuario.login() > 0)
                {
                    usuario.get();
                    this.DialogResult = DialogResult.OK;
                }
                else
                    this.DialogResult = DialogResult.No;
                this.Close();
            }
            else
            {
                MessageBox.Show("Error: campos vacios");
            }
        }
    }
}
