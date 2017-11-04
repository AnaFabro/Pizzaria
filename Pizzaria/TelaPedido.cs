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
    public partial class TelaPedido : Form
    {
        public TelaPedido()
        {
            InitializeComponent();
        }
        Cliente cli = new Cliente();
        Pedido p = new Pedido();
        PedidoDAO pDAO = new PedidoDAO();
        int id = 0;
        int index = -1;
        float total = 0;
        private void TelaPedido_Load(object sender, EventArgs e)
        {
            id = id + 1;
            // TODO: This line of code loads data into the 'pizzaBdDataSet2.Bebida' table. You can move, or remove it, as needed.
            this.bebidaTableAdapter.Fill(this.pizzaBdDataSet2.Bebida);
            // TODO: This line of code loads data into the 'pizzaBdDataSet1.Pizza' table. You can move, or remove it, as needed.
            this.pizzaTableAdapter.Fill(this.pizzaBdDataSet1.Pizza);
            // TODO: This line of code loads data into the 'pizzaBdDataSet.Pedido' table. You can move, or remove it, as needed.
            this.pedidoTableAdapter.Fill(this.pizzaBdDataSet.Pedido);

        }
        public void Cliente(Cliente c)
        {
            rTxtCliInfo.Text = c.Nome + "\n" + c.Rua +"\t"  + c.Numero.ToString() + "\t" + c.Bairro + "\n" + c.Cidade + "\t" + c.Uf
            + "\n"    + c.Telefone;

            cli = c;
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvPedido_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        List<Pedido> lstPed = new List<Pedido>();
        private void btnAddPizza_Click(object sender, EventArgs e)
        {
            Pedido pPizza = new Pedido();
            if (rbtnInteira.Checked)
            {
                var selectedRow = dgvPizzas.SelectedRows[0];
                if (selectedRow != null)
                {
                    pPizza.Id = id;
                    pPizza.Nome = dgvPizzas.SelectedRows[0].Cells[0].Value.ToString();
                    pPizza.Qtd = rbtnInteira.Text;
                    pPizza.Preco = float.Parse(dgvPizzas.SelectedRows[0].Cells[2].Value.ToString());
                    total = total + pPizza.Preco;
                    index = index + 1;
                    lstPed.Insert(index,pPizza);
                    this.preencherPedido(lstPed);
                }
                
            }
            else if (rBtnMeia.Checked)
            {
                float preco = 0;
                float p1 = float.Parse(dgvPizzas.SelectedRows[0].Cells[2].Value.ToString());
                float p2 = float.Parse(dgvPizzas.SelectedRows[1].Cells[2].Value.ToString());

                if (p1 > p2)
                {
                    preco = p1;
                    total = total + p1;
                }
                else
                {
                    preco = p2;
                    total = total + p2;
                }

                pPizza.Id = id;
                pPizza.Nome = dgvPizzas.SelectedRows[0].Cells[0].Value.ToString();

                pPizza.Qtd = rBtnMeia.Text;
                pPizza.Preco = preco;              
                index = index + 1;
                lstPed.Insert(index, pPizza);

                Pedido p = new Pedido();
                p.Id = id;
                p.Nome = dgvPizzas.SelectedRows[1].Cells[0].Value.ToString();

                p.Qtd = rBtnMeia.Text;
                p.Preco = 0;
                index = index + 1;
                lstPed.Insert(index, p);


                this.preencherPedido(lstPed);
                total = total + pPizza.Preco;

            }
        }

        public void preencherPedido(List<Pedido> lstPed)
        {
            var bindingList = new BindingList<Pedido>(lstPed);
            var source = new BindingSource(bindingList, null);
            dgvPedido.DataSource = source;
            txtTotal.Text = total.ToString();
        }

        private void btnAddBebida_Click(object sender, EventArgs e)
        {
            Pedido pBeb = new Pedido();
            pBeb.Nome = dgvBebidas.SelectedRows[0].Cells[0].Value.ToString();
            pBeb.Id = id;
            pBeb.Qtd = txtQtd.Text;
            int x = Convert.ToInt32(pBeb.Qtd);
            int valor = Convert.ToInt32(dgvBebidas.SelectedRows[0].Cells[2].Value.ToString());
            float preco = x * valor;
            pBeb.Preco = preco;
            total = total + pBeb.Preco;
            index = index + 1;
            lstPed.Insert(index, pBeb);
            this.preencherPedido(lstPed);
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            float total = float.Parse(txtTotal.Text);
            pDAO.Inserir(lstPed, total, cli);
            this.Close();
            MenuPrincipal mp = new MenuPrincipal();
            mp.ShowDialog();
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
