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
    public partial class ClienteF : Form
    {
        public ClienteF()
        {
            InitializeComponent();
        }
        Cliente c = new Cliente();
        ClienteDAO cDAO = new ClienteDAO();
        int id = 0;
        private void ClienteF_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pizzaBdDataSet5.Cliente' table. You can move, or remove it, as needed.
            this.clienteTableAdapter.Fill(this.pizzaBdDataSet5.Cliente);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string searchValue = txtBuscarTel.Text;

            dgvClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            try
            {
                foreach (DataGridViewRow row in dgvClientes.Rows)
                {
                    string val = row.Cells[2].Value.ToString();
                    if (val == searchValue)
                    {
                        row.Selected = true;
                        id = Convert.ToInt32(row.Cells[0].Value.ToString());
                        txtNome.Text = row.Cells[1].Value.ToString();
                        txtTelefone.Text = row.Cells[2].Value.ToString();
                        txtEndereco.Text = row.Cells[3].Value.ToString();
                        txtCidade.Text = row.Cells[7].Value.ToString();
                        cbbUF.Text = row.Cells[8].Value.ToString();
                        txtComplemento.Text = row.Cells[6].Value.ToString();
                        txtBairro.Text = row.Cells[5].Value.ToString();
                        txtNumero.Text = row.Cells[4].Value.ToString();
                        txtBuscarTel.Text = "";
                        break;

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            c.Nome = txtNome.Text;
            c.Telefone =txtTelefone.Text;
            c.Rua = txtEndereco.Text;
            c.Cidade = txtCidade.Text;
            c.Uf = cbbUF.Text;
            c.Complemento = txtComplemento.Text;
            c.Bairro = txtBairro.Text;
            c.Numero = Convert.ToInt32(txtNumero.Text);
            cDAO.Inserir(c);
            this.clienteTableAdapter.Fill(this.pizzaBdDataSet5.Cliente);

            txtNome.Text = "";
            txtTelefone.Text = "";
            txtEndereco.Text = "";
            txtCidade.Text = "";
            cbbUF.Text = "";
            txtComplemento.Text = "";
            txtBairro.Text = "";
            txtNumero.Text = "";
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            c.Nome = txtNome.Text;
            c.Telefone = txtTelefone.Text;
            c.Rua = txtEndereco.Text;
            c.Cidade = txtCidade.Text;
            c.Uf = cbbUF.Text;
            c.Complemento = txtComplemento.Text;
            c.Bairro = txtBairro.Text;
            c.Numero = Convert.ToInt32(txtNumero.Text);
            c.Id = id;
            cDAO.Alterar(c);
            this.clienteTableAdapter.Fill(this.pizzaBdDataSet5.Cliente);

            txtNome.Text = "";
            txtTelefone.Text = "";
            txtEndereco.Text = "";
            txtCidade.Text = "";
            cbbUF.Text = "";
            txtComplemento.Text = "";
            txtBairro.Text = "";
            txtNumero.Text = "";
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            c.Nome = txtNome.Text;
            c.Telefone = txtTelefone.Text;
            c.Rua = txtEndereco.Text;
            c.Cidade = txtCidade.Text;
            c.Uf = cbbUF.Text;
            c.Complemento = txtComplemento.Text;
            c.Bairro = txtBairro.Text;
            c.Numero = Convert.ToInt32(txtNumero.Text);
            c.Id = id;
            cDAO.Excluir(c);
            this.clienteTableAdapter.Fill(this.pizzaBdDataSet5.Cliente);

            txtNome.Text = "";
            txtTelefone.Text = "";
            txtEndereco.Text = "";
            txtCidade.Text = "";
            cbbUF.Text = "";
            txtComplemento.Text = "";
            txtBairro.Text = "";
            txtNumero.Text = "";
        }

        private void dgvClientes_Click(object sender, EventArgs e)
        {

            id = Convert.ToInt32(dgvClientes.SelectedRows[0].Cells[0].Value.ToString());
            txtNome.Text = dgvClientes.SelectedRows[0].Cells[1].Value.ToString();
            txtTelefone.Text = dgvClientes.SelectedRows[0].Cells[2].Value.ToString();
            txtEndereco.Text = dgvClientes.SelectedRows[0].Cells[3].Value.ToString();
            txtCidade.Text = dgvClientes.SelectedRows[0].Cells[7].Value.ToString();
            cbbUF.Text = dgvClientes.SelectedRows[0].Cells[8].Value.ToString();
            txtComplemento.Text = dgvClientes.SelectedRows[0].Cells[6].Value.ToString();
            txtBairro.Text = dgvClientes.SelectedRows[0].Cells[5].Value.ToString();
            txtNumero.Text = dgvClientes.SelectedRows[0].Cells[4].Value.ToString();
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
