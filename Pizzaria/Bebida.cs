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
    public partial class Bebida : Form
    {
        Bebidac b = new Bebidac();
        BebidaDAO bDAO = new BebidaDAO();
        int id = 0;
        public Bebida()
        {
            InitializeComponent();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuPrincipal mp = new MenuPrincipal();
            mp.ShowDialog();
            this.Hide();
            this.Close();
        }

        private void Bebida_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pizzaBdDataSet4.Bebida' table. You can move, or remove it, as needed.
            this.bebidaTableAdapter2.Fill(this.pizzaBdDataSet4.Bebida);


        }

        private void dgvBebidas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {

            b.Nome = txtTipo.Text;
            b.Litros = txtLitros.Text;
            b.Preco = float.Parse(txtPreco.Text);
            bDAO.Incluir(b);
            this.bebidaTableAdapter2.Fill(this.pizzaBdDataSet4.Bebida);

            txtTipo.Text = "";
            txtPreco.Text = "";
            txtLitros.Text = "";
        }

        private void dgvBebidas_Click(object sender, EventArgs e)
        {
            txtTipo.Text = dgvBebidas.SelectedRows[0].Cells[1].Value.ToString();
            txtLitros.Text = dgvBebidas.SelectedRows[0].Cells[2].Value.ToString();
            txtPreco.Text = dgvBebidas.SelectedRows[0].Cells[3].Value.ToString();
            id = Convert.ToInt32(dgvBebidas.SelectedRows[0].Cells[0].Value.ToString());
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            b.Id = id;
            b.Nome = txtTipo.Text;
            b.Litros = txtLitros.Text;
            b.Preco = float.Parse(txtPreco.Text);
            bDAO.Alterar(b);
            this.bebidaTableAdapter2.Fill(this.pizzaBdDataSet4.Bebida);

            txtTipo.Text = "";
            txtPreco.Text = "";
            txtLitros.Text = "";
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            b.Id = id;
            b.Nome = txtTipo.Text;
            b.Litros = txtLitros.Text;
            b.Preco = float.Parse(txtPreco.Text);
            bDAO.Excluir(b);
            this.bebidaTableAdapter2.Fill(this.pizzaBdDataSet4.Bebida);

            txtTipo.Text = "";
            txtPreco.Text = "";
            txtLitros.Text = "";
        }

        private void Formulario_Enter(object sender, EventArgs e)
        {

        }
    }
}