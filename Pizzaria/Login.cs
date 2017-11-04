using Pizzaria.Classes;
using Pizzaria.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizzaria
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        Usuario u = new Usuario();
        UsuarioDAO uDAO = new UsuarioDAO();

        private void btnEntrar_Click(object sender, EventArgs e)
        {
                u.Username = txtUser.Text;
                u.Password = txtSenha.Text;
              Usuario us = uDAO.verificaUsuario(u);
            if(us.Credencial != null) { 
                this.Hide();
                MenuPrincipal p = new MenuPrincipal();
                p.validaUsuario(u);
                p.ShowDialog();
                this.Close();
                
            }
            else
            {
                MessageBox.Show("Senha incorreta! Tente novamente", "Erro");
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
