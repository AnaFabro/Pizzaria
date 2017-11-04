using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Pizzaria.Classes;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Pizzaria.DAO
{
    class ClienteDAO
    {
        private string strConexao = ConfigurationManager.ConnectionStrings["PizzaBd"].ConnectionString;

        public void Inserir(Cliente c)
        {
            try
            {
                using (SqlConnection conexao = new SqlConnection())
                {
                    conexao.ConnectionString = strConexao;
                    conexao.Open();

                    using (SqlCommand comando = new SqlCommand())
                    {

                        string strSql = "Insert into dbo.Cliente(nome, telefone, rua,cidade, estado,complemento,bairro,numero) values(@nome_clie,@telefone_clie,@rua_clie,@cidade_clie,@uf_clie,@complemento_clie,@bairro_clie,@numero_clie)";
                        comando.CommandText = strSql;
                        comando.Connection = conexao;
                        comando.Parameters.AddWithValue("@nome_clie", c.Nome);
                        comando.Parameters.AddWithValue("@telefone_clie", c.Telefone);
                        comando.Parameters.AddWithValue("@rua_clie", c.Rua);
                        comando.Parameters.AddWithValue("@cidade_clie", c.Cidade);
                        comando.Parameters.AddWithValue("@uf_clie", c.Uf);
                        comando.Parameters.AddWithValue("@complemento_clie", c.Complemento);
                        comando.Parameters.AddWithValue("@bairro_clie", c.Bairro);
                        comando.Parameters.AddWithValue("@numero_clie", c.Numero);
                        comando.ExecuteNonQuery();
                        MessageBox.Show("Cadastrado com sucesso!");
                    }

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void Alterar(Cliente c)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = strConexao;
                    conn.Open();

                    using (SqlCommand command = new SqlCommand())
                    {
                        string strSql = "update Cliente set nome=@nome_clie, telefone=@telefone_clie, rua=@rua_clie,cidade=@cidade_clie,estado=@uf_clie,complemento=@complemento_clie,bairro=@bairro_clie,numero=@numero_clie where id=@id";
                        command.CommandText = strSql;
                        command.Connection = conn;
                        command.Parameters.AddWithValue("@nome_clie", c.Nome);
                        command.Parameters.AddWithValue("@telefone_clie", c.Telefone);
                        command.Parameters.AddWithValue("@cidade_clie", c.Cidade);
                        command.Parameters.AddWithValue("@uf_clie", c.Uf);
                        command.Parameters.AddWithValue("@rua_clie", c.Rua);
                        command.Parameters.AddWithValue("@complemento_clie", c.Complemento);
                        command.Parameters.AddWithValue("@bairro_clie", c.Bairro);
                        command.Parameters.AddWithValue("@numero_clie", c.Numero);
                        command.Parameters.AddWithValue("@id", c.Id);

                        command.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Cliente " + c.Nome + " alterado com sucesso!");
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public void Excluir(Cliente c)
        {
            try
            {
                using (SqlConnection conexao = new SqlConnection())
                {
                    conexao.ConnectionString = strConexao;
                    conexao.Open();

                    using (SqlCommand comando = new SqlCommand())
                    {
                        string strSql = "Delete Cliente where id=@id";
                        comando.CommandText = strSql;
                        comando.Connection = conexao;
                        comando.Parameters.AddWithValue("@id", c.Id);
                        comando.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Cliente deletado com sucesso!");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
