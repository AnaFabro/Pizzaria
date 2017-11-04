using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using Pizzaria.Classes;

namespace Pizzaria.DAO
{
    class PedidoDAO
    {
        private string strConexao = ConfigurationManager.ConnectionStrings["PizzaBd"].ConnectionString;

        public void BuscarContato(Cliente c)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = strConexao;
                    conn.Open();

                    using (SqlCommand comando = new SqlCommand())
                    {
                        string query = "Select * from dbo.Cliente where telefone=@telefone";
                        comando.CommandText = query;
                        comando.Connection = conn;
                        comando.Parameters.AddWithValue("@telefone", c.Telefone);
                        SqlDataReader read = comando.ExecuteReader();

                        while (read.Read())
                        {
                            c.Id = Convert.ToInt32(read["id"]);
                            c.Nome = read["nome"].ToString();
                            c.Telefone = read["telefone"].ToString();
                            c.Rua = read["rua"].ToString();
                            c.Cidade = read["cidade"].ToString();
                            c.Uf = read["uf"].ToString();
                            c.Complemento = read["complemento"].ToString();
                            c.Bairro = read["bairro"].ToString();
                        }
                    }
                }
                return c;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void Inserir(Pedido p)
        {
            try
            {
                using (SqlConnection conexao = new SqlConnection())
                {
                    conexao.ConnectionString = strConexao;
                    conexao.Open();

                    using (SqlCommand comando = new SqlCommand())
                    {
                        string strSql = "Insert into Pedido (pizza_id, cliente_id, bebida_id) values(@pizza_id,@cliente_id,@bebida_id)";
                        comando.CommandText = strSql;
                        comando.Connection = conexao;
                        comando.Parameters.AddWithValue("@pizza_id", p.Pizza_id);
                        comando.Parameters.AddWithValue("@cliente_id", p.Cliente_id);
                        comando.Parameters.AddWithValue("@bebida_id", p.Bebida_id);

                        comando.ExecuteNonQuery();
                    }

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
