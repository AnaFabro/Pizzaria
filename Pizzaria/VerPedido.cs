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
    public partial class VerPedido : Form
    {
        public VerPedido()
        {
            InitializeComponent();
        }
        Pedido p = new Pedido();
        PedidoDAO pDAO = new PedidoDAO();
        PedidoLer peLer = new PedidoLer();
        Cliente cli = new Cliente();

        private void VerPedido_Load(object sender, EventArgs e)
        {
            lblData.Text = DateTime.Now.ToString("M/d/yyyy");
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }
        public void preencherInfo(Cliente c, PedidoLer pLer)
        {
            rtxtCliente.Text = c.Nome + "\t" + c.Telefone;
            rTxtBoxPedidos.Text = pLer.Descricao + "\n Total: " + pLer.Total;
            cbstatus.Text = pLer.Status;
            peLer = pLer;
            cli = c;

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            string status = cbstatus.Text;
            pDAO.AlterarStatus(peLer, status);
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuPrincipal mp = new MenuPrincipal();
            mp.ShowDialog();
            this.Hide();
            this.Close();
        }
    }
}
