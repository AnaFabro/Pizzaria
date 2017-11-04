using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Pizzaria.Classes;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Pizzaria.DAO
{
    class UsuarioDAO
    {
        private string strConexao = ConfigurationManager.ConnectionStrings["PizzaBd"].ConnectionString;

        public Usuario verificaUsuario(Usuario u)
        {
            try
            {
                using(SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = strConexao;
                    conn.Open();
                    
                    using(SqlCommand comm = new SqlCommand())
                    {
                        string query = "Select tipo from dbo.Usuario where username=@username and pwd=@pwd";
                        comm.CommandText = query;
                        comm.Connection = conn;
                        comm.Parameters.AddWithValue("@username", u.Username);
                        comm.Parameters.AddWithValue("@pwd", u.Password);
                        SqlDataReader read = comm.ExecuteReader();
                        while (read.Read())
                        {
                            u.Credencial = read["tipo"].ToString();
                        }
                        
                    }
                }
                return u;
            }
            catch(Exception e)
            {

                MessageBox.Show("Usuario não cadastrado!");
                throw e;
            }
        }

        public void Cadastrar(Usuario u)
        {
            try
            {
                using(SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = strConexao;
                    conn.Open();
                    using(SqlCommand com = new SqlCommand())
                    {
                        string query = "Insert into dbo.Usuario(username, pwd, tipo) values(@username, @pwd, @tipo)";
                        com.CommandText = query;
                        com.Connection = conn;
                        com.Parameters.AddWithValue("@username", u.Username);
                        com.Parameters.AddWithValue("@pwd", u.Password);
                        com.Parameters.AddWithValue("@tipo", u.Credencial);
                        com.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Usuário criado com sucesso");

            }
            catch(Exception e)
            {
                throw e;
            }
        }

        public void Alterar(Usuario u)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = strConexao;
                    conn.Open();
                    using (SqlCommand com = new SqlCommand())
                    {
                        string query = "Update dbo.Usuario set username=@username,pwd=@pwd,tipo=@tipo where id=@id";
                        com.CommandText = query;
                        com.Connection = conn;
                        com.Parameters.AddWithValue("@username", u.Username);
                        com.Parameters.AddWithValue("@pwd", u.Password);
                        com.Parameters.AddWithValue("@tipo", u.Credencial);
                        com.Parameters.AddWithValue("@id", u.Id);
                        com.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Usuário alterado com sucesso");

            }
            catch (Exception e)
            {
                throw e;
            }

        }
        public void Excluir(Usuario u)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = strConexao;
                    conn.Open();
                    using (SqlCommand com = new SqlCommand())
                    {
                        string query = "DELETE dbo.Usuario where id=@id";
                        com.CommandText = query;
                        com.Connection = conn;
                        com.Parameters.AddWithValue("@id", u.Id);
                        com.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Usuário deletado com sucesso");

            }
            catch (Exception e)
            {
                throw e;
            }

        }
    }
}
