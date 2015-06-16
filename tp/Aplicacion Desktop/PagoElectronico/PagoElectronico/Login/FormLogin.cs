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

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void btLogin_Click_1(object sender, EventArgs e)
        {
            if (this.tbUsername.Text != "" || this.tbPassword.Text != "")
            {
                this.usuario.Username = tbUsername.Text;
                this.usuario.Password = tbPassword.Text;
                int result = usuario.login();
                switch (result)
                {
                    case 1:
                        if (usuario.Roles.Count > 1)
                        {
                            FormChooseRol frmRoles = new FormChooseRol(usuario);
                            frmRoles.ShowDialog();
                        }
                        else
                        {
                            usuario.rolPorDefecto();
                        }

                        this.DialogResult = DialogResult.OK;
                        break;
                    case -1:
                        MessageBox.Show("Login incorrecto");
                        break;
                    case -2:
                        MessageBox.Show("Usuario inhabilitado");
                        break;
                }
                this.Close();
            }
            else
            {
                MessageBox.Show("Error: campos vacios");
            }
        }

        private void btClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
