using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pizzaria.Classes;
using Pizzaria.DAO;

namespace Pizzaria
{

    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }
        Pedido p = new Pedido();
        PedidoDAO pDAO = new PedidoDAO();
        PedidoLer pLer = new PedidoLer();
        Usuario u = new Usuario();
        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        Cliente c = new Cliente();
        ClienteDAO cDAO = new ClienteDAO();
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            c.Nome = null;
           
            c.Telefone = txtBuscTel.Text;
            Cliente newC = pDAO.BuscarContato(c);
            if (newC.Nome != null)
            {
                txtNome.Text = newC.Nome;
                txtEndereco.Text = newC.Rua;
                txtBairro.Text = newC.Bairro;
                txtCidade.Text = newC.Cidade;
                txtComplemento.Text = newC.Complemento;
                txtNumero.Text = newC.Numero.ToString();
                cbbUF.Text = newC.Uf;
                c = newC;
            }
            else
            {
                MessageBox.Show("Cliente não encontrado");
                txtNome.Text = "";
                txtEndereco.Text = "";
                txtBairro.Text = "";
                txtCidade.Text = "";
                txtComplemento.Text = "";
                txtNumero.Text = "";
                cbbUF.Text = "";
            }


        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Cliente c = new Cliente();
            c.Nome = txtNome.Text;
            c.Rua = txtEndereco.Text;
            c.Telefone = txtBuscTel.Text;
            c.Bairro = txtBairro.Text;
            c.Numero = Convert.ToInt32(txtNumero.Text);
            c.Cidade = txtCidade.Text;
            c.Uf = cbbUF.Text;

            TelaPedido telPed = new TelaPedido();
            telPed.Cliente(c);
            telPed.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string data = DateTime.Now.ToString("M/d/yyyy");
            PedidoLer pLer = pDAO.ConsultarPedido(c, data);
            VerPedido vP = new VerPedido();
            vP.preencherInfo(c, pLer);
            vP.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            c.Nome = txtNome.Text;
            c.Telefone = txtBuscTel.Text;
            c.Rua = txtEndereco.Text;
            c.Cidade = txtCidade.Text;
            c.Uf = cbbUF.Text;
            c.Complemento = txtComplemento.Text;
            c.Bairro = txtBairro.Text;
            c.Numero = Convert.ToInt32(txtNumero.Text);
            cDAO.Inserir(c);
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            lblTodayData.Text = System.DateTime.Now.ToLongDateString();
            lblHora.Text = System.DateTime.Now.ToLongTimeString();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuPrincipal mp = new MenuPrincipal();
            mp.ShowDialog();
            this.Hide();
            this.Close();
        }

        private void pizzasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pizza pMenu = new Pizza();
            pMenu.ShowDialog();
            this.Hide();
            this.Close();
        }

        private void bebidasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bebida bMenu = new Bebida();
            bMenu.ShowDialog();
            this.Close();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClienteF cf = new ClienteF();
            cf.ShowDialog();
            this.Close();
        }

        private void lblNumero_Click(object sender, EventArgs e)
        {

        }

        private void funcionáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UsuarioF u = new UsuarioF();
            u.ShowDialog();
            this.Close();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        public void validaUsuario(Usuario u)
        {
            if (u.Credencial == "basic")
            {
                menu.Visible = false;
                usuarios.Visible = false;

            }
            else
            {
                menu.Visible = true;
                usuarios.Visible = true;
            }

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            this.Close();
            this.Hide();
            l.ShowDialog();
        }
    }
}
