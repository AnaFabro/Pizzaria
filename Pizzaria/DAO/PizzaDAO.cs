using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pizzaria.Classes;
using Pizzaria.DAO;
using System.Configuration;
using System.Windows.Forms;

namespace Pizzaria.DAO
{
    class PizzaDAO
    {
        private string strConexao = ConfigurationManager.ConnectionStrings["PizzaBd"].ConnectionString;

        public void Incluir(PizzaC piz)
        {
            try
            {
                using(SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = strConexao;
                    conn.Open();

                    using(SqlCommand command = new SqlCommand())
                    {
                        string query = "Insert into dbo.Pizza(nome,descricao,preco) values(@nome, @descricao, @preco)";
                        command.CommandText = query;
                        command.Connection = conn;
                        command.Parameters.AddWithValue("@nome",piz.Nome);
                        command.Parameters.AddWithValue("@descricao", piz.Descricao);
                        command.Parameters.AddWithValue("@preco", piz.Preco);
                        command.ExecuteNonQuery();                       
                    }
                }
                MessageBox.Show("Pizza cadastrada com sucesso!");
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public void Alterar(PizzaC p)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = strConexao;
                    conn.Open();

                    using (SqlCommand command = new SqlCommand())
                    {
                        string query = "Update dbo.Pizza set nome=@nome,descricao=@descricao,preco=@preco where id=@id";
                        command.CommandText = query;
                        command.Connection = conn;
                        command.Parameters.AddWithValue("@nome", p.Nome);
                        command.Parameters.AddWithValue("@descricao", p.Descricao);
                        command.Parameters.AddWithValue("@preco", p.Preco);
                        command.Parameters.AddWithValue("@id", p.Id);
                        command.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Pizza "+p.Nome+ " alterada com sucesso!");
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public void Excluir(PizzaC p)
        {
            try
            {
                using (SqlConnection conexao = new SqlConnection())
                {
                    conexao.ConnectionString = strConexao;
                    conexao.Open();

                    using (SqlCommand comando = new SqlCommand())
                    {
                        string strSql = "Delete Pizza where id=@id";
                        comando.CommandText = strSql;
                        comando.Connection = conexao;
                        comando.Parameters.AddWithValue("@id", p.Id);
                        comando.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Pizza deletada com sucesso!");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
