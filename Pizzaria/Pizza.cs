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
    public partial class Pizza : Form
    {
        public Pizza()
        {
            InitializeComponent();
        }
        PizzaC p = new PizzaC();
        PizzaDAO pDAO = new PizzaDAO();
        int id = 0;
        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuPrincipal mp = new MenuPrincipal();
            mp.ShowDialog();
        }

        private void Pizza_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pizzaBdDataSet1.Pizza' table. You can move, or remove it, as needed.
            this.pizzaTableAdapter.Fill(this.pizzaBdDataSet1.Pizza);

        }

        private void homeToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            MenuPrincipal mp = new MenuPrincipal();
            mp.ShowDialog();
            this.Hide();
            this.Close();
        }

        private void txtDescricao_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            p.Id = id;
            pDAO.Excluir(p);
            this.pizzaTableAdapter.Fill(this.pizzaBdDataSet1.Pizza);

            txtNome.Text = "";
            txtDescricao.Text = "";
            txtPreco.Text = "";
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            p.Nome = txtNome.Text;
            p.Preco = float.Parse(txtPreco.Text);
            p.Descricao = txtDescricao.Text;
            pDAO.Incluir(p);
            this.pizzaTableAdapter.Fill(this.pizzaBdDataSet1.Pizza);

            txtNome.Text = "";
            txtDescricao.Text = "";
            txtPreco.Text = "";
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            p.Id = id;
            p.Nome = txtNome.Text;
            p.Descricao = txtDescricao.Text;
            p.Preco = float.Parse(txtPreco.Text);
            pDAO.Alterar(p);
            this.pizzaTableAdapter.Fill(this.pizzaBdDataSet1.Pizza);

            txtNome.Text = "";
            txtDescricao.Text = "";
            txtPreco.Text = "";
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            

        }

        private void dgvPizza_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dgvPizza_Click(object sender, EventArgs e)
        {
            txtNome.Text = dgvPizza.SelectedRows[0].Cells[1].Value.ToString();
            txtDescricao.Text = dgvPizza.SelectedRows[0].Cells[2].Value.ToString();
            txtPreco.Text = dgvPizza.SelectedRows[0].Cells[3].Value.ToString();
            id = Convert.ToInt32(dgvPizza.SelectedRows[0].Cells[0].Value.ToString());
        }
    }
}
