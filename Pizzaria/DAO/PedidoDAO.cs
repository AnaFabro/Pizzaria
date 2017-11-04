using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using Pizzaria.Classes;

namespace Pizzaria.DAO
{
    class PedidoDAO
    {
        private string strConexao = ConfigurationManager.ConnectionStrings["PizzaBd"].ConnectionString;
       
        public Cliente BuscarContato(Cliente c)
        {
           try
            {
               
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = strConexao;
                    conn.Open();
                    using(SqlCommand command = new SqlCommand())
                    {
                        string query = "Select nome,telefone,rua,numero,cidade,estado,bairro,complemento from dbo.Cliente where telefone=@telefone";
                        command.CommandText = query;
                        command.Connection = conn;
                        command.Parameters.AddWithValue("@telefone", c.Telefone);
                        SqlDataReader read = command.ExecuteReader();
                        
                        while (read.Read())
                        {
                            c.Nome = read["nome"].ToString();
                            c.Telefone = read["Telefone"].ToString();
                            c.Rua = read["rua"].ToString();
                            c.Cidade = read["cidade"].ToString();
                            c.Uf = read["estado"].ToString();
                            c.Complemento = read["complemento"].ToString();
                            c.Bairro = read["bairro"].ToString();
                            c.Numero = Convert.ToInt32(read["numero"]);
                        }
                    }
                }
                return c;
            }
            catch(Exception ex)
            {

                throw ex;
            }
        }
        public void Inserir(List<Pedido> lstPed, float total, Cliente c)
        {
            try
            {
                using (SqlConnection conexao = new SqlConnection())
                {
                    conexao.ConnectionString = strConexao;
                    conexao.Open();

                    using (SqlCommand comando = new SqlCommand())
                    {
                        string description = "";
                        int id = 0;
                        string status = "Cozinha";
                        foreach (Pedido p in lstPed){
                            id = p.Id;
                         description += p.Nome + "\t"  + p.Qtd + "\n";
                        }
                        string strSql = "Insert into dbo.Pedido (id, descricao, total, data, cli_nome, cli_tel, status) values(@id,@descricao, @total, @data, @cli_nome, @cli_tel, @status)";
                        comando.CommandText = strSql;
                        comando.Connection = conexao;
                        comando.Parameters.AddWithValue("@id", id);
                        comando.Parameters.AddWithValue("@descricao", description);
                        comando.Parameters.AddWithValue("@total", total);
                        comando.Parameters.AddWithValue("@data", DateTime.Now.ToString("M/d/yyyy"));
                        comando.Parameters.AddWithValue("@cli_nome", c.Nome);
                        comando.Parameters.AddWithValue("@cli_tel", c.Telefone);
                        comando.Parameters.AddWithValue("@status", status);
                        comando.ExecuteNonQuery();

                    }
                    MessageBox.Show("Pedido Finalizado e encaminhado pra cozinha");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public PedidoLer ConsultarPedido(Cliente c, string data) {

            try
            {
                List<PedidoLer> lstPler = new List<PedidoLer>();
                PedidoLer pLer = new PedidoLer();
                

                using(SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = strConexao;
                    conn.Open();

                    using(SqlCommand comando = new SqlCommand())
                    {
                        string query = "Select id,status, descricao, data, cli_nome, cli_tel, total from dbo.Pedido where data=@data and cli_tel=@cli_tel";
                        comando.CommandText = query;
                        comando.Connection = conn;
                        comando.Parameters.AddWithValue("@data", data);
                        comando.Parameters.AddWithValue("@cli_tel", c.Telefone);
                        SqlDataReader read = comando.ExecuteReader();
                        while (read.Read())
                        {
                            pLer.Id = Convert.ToInt32(read["id"]);
                            pLer.Descricao = read["descricao"].ToString();
                            pLer.Total = float.Parse(read["total"].ToString());
                            pLer.Status = read["status"].ToString();
                        }
                    }
                }
                return pLer;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public void AlterarStatus(PedidoLer p, string status)
        {
            try
            {
                using (SqlConnection conexao = new SqlConnection())
                {
                    conexao.ConnectionString = strConexao;
                    conexao.Open();

                    using (SqlCommand comando = new SqlCommand())
                    {
                            string strSql = "update dbo.Pedido set status=@status where id=@id";
                            comando.CommandText = strSql;
                            comando.Connection = conexao;
                            comando.Parameters.AddWithValue("@status", status);
                            comando.Parameters.AddWithValue("@id", p.Id);
                            comando.ExecuteNonQuery();
                       
                    }
                }
                MessageBox.Show("Status Alterado com Sucesso");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
