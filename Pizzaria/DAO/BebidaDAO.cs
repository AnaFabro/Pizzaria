using Pizzaria.Classes;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizzaria.DAO
{
    class BebidaDAO
    {
        private string strConexao = ConfigurationManager.ConnectionStrings["PizzaBd"].ConnectionString;

        public void Incluir(Bebidac b)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = strConexao;
                    conn.Open();

                    using (SqlCommand command = new SqlCommand())
                    {
                        string query = "Insert into dbo.Bebida(nome,tamanho,preco) values(@nome, @tamanho, @preco)";
                        command.CommandText = query;
                        command.Connection = conn;
                        command.Parameters.AddWithValue("@nome", b.Nome);
                        command.Parameters.AddWithValue("@tamanho", b.Litros);
                        command.Parameters.AddWithValue("@preco", b.Preco);
                        command.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Bebida cadastrada com sucesso!");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Alterar(Bebidac b)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = strConexao;
                    conn.Open();

                    using (SqlCommand command = new SqlCommand())
                    {
                        string query = "Update dbo.Bebida set nome=@nome,tamanho=@tamanho,preco=@preco where id=@id";
                        command.CommandText = query;
                        command.Connection = conn;
                        command.Parameters.AddWithValue("@nome", b.Nome);
                        command.Parameters.AddWithValue("@tamanho", b.Litros);
                        command.Parameters.AddWithValue("@preco",b.Preco);
                        command.Parameters.AddWithValue("@id",b.Id);
                        command.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Bebida " + b.Nome + " alterada com sucesso!");
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public void Excluir(Bebidac b)
        {
            try
            {
                using (SqlConnection conexao = new SqlConnection())
                {
                    conexao.ConnectionString = strConexao;
                    conexao.Open();

                    using (SqlCommand comando = new SqlCommand())
                    {
                        string strSql = "Delete Bebida where id=@id";
                        comando.CommandText = strSql;
                        comando.Connection = conexao;
                        comando.Parameters.AddWithValue("@id", b.Id);
                        comando.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Bebida deletada com sucesso!");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
