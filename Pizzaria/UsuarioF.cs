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
    public partial class UsuarioF : Form
    {
        public UsuarioF()
        {
            InitializeComponent();
        }

        private void UsuarioF_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pizzaBdDataSet7.Usuario' table. You can move, or remove it, as needed.
            this.usuarioTableAdapter1.Fill(this.pizzaBdDataSet7.Usuario);

        }
        Usuario u = new Usuario();
        UsuarioDAO uDAO = new UsuarioDAO();
        int id;
        string pwd;
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string searchValue = txtBusername.Text;

            dgvUser.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            try
            {
                foreach (DataGridViewRow row in dgvUser.Rows)
                {
                    string val = row.Cells[0].Value.ToString();
                    if (val == searchValue)
                    {
                        row.Selected = true;
                        pwd = dgvUser.SelectedRows[0].Cells[1].Value.ToString();
                        txtPwd.Text = pwd;
                        id = Convert.ToInt32(row.Cells[3].Value.ToString());
                        txtUsername.Text = row.Cells[0].Value.ToString();
                        cbPwd.Text = row.Cells[1].Value.ToString();
                        txtBusername.Text = "";
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
            u.Username = txtUsername.Text;
            u.Credencial = cbPwd.Text;
            u.Password = txtPwd.Text;
            uDAO.Cadastrar(u);
            this.usuarioTableAdapter1.Fill(this.pizzaBdDataSet7.Usuario);
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            u.Id = id;
            u.Username = txtUsername.Text;
            u.Credencial = cbPwd.Text;
            u.Password = txtPwd.Text;
            uDAO.Alterar(u);
            this.usuarioTableAdapter1.Fill(this.pizzaBdDataSet7.Usuario);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            u.Username = txtUsername.Text;
            u.Id = id;
            uDAO.Excluir(u);
            this.usuarioTableAdapter1.Fill(this.pizzaBdDataSet7.Usuario);
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuPrincipal m = new MenuPrincipal();
            m.ShowDialog();
            this.Hide();
        }

        private void cbPwd_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvUser_Click(object sender, EventArgs e)
        {
            id = Convert.ToInt32(dgvUser.SelectedRows[0].Cells[3].Value.ToString());
            txtUsername.Text = dgvUser.SelectedRows[0].Cells[0].Value.ToString();
            cbPwd.Text = dgvUser.SelectedRows[0].Cells[2].Value.ToString();
            pwd =dgvUser.SelectedRows[0].Cells[1].Value.ToString();
            txtPwd.Text = pwd;
        }
    }
}
