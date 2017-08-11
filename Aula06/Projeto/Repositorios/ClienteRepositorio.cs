using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Projeto.Entidades;

namespace Projeto.Repositorios
{
    public class ClienteRepositorio : Conexao
    {
        public void Inserir(Cliente c)
        {
            try
            {
                AbrirConexao();

                string query = " INSERT INTO Cliente(Nome,Email,DataCadastro) "+" VALUES(@Nome,@Email, GetDate()) ";

                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Nome",c.Nome);
                cmd.Parameters.AddWithValue("@Email", c.Email);
                cmd.ExecuteNonQuery();

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                FecharConexao();
            }
        }

        public void Atualizar(Cliente c)
        {
            try
            {
                AbrirConexao();

                string query = " UPDATE Cliente set Nome = @Nome, Email = @Email WHERE IdCliente = @IdCliente ";

                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@IdCliente", c.IdCliente);
                cmd.Parameters.AddWithValue("@Nome", c.Nome);
                cmd.Parameters.AddWithValue("@Email", c.Email);
                cmd.ExecuteNonQuery();

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                FecharConexao();
            }
        }

        public void Excluir(int idCliente)
        {
            try
            {
                AbrirConexao();

                string query = " DELETE FROM Cliente WHERE IdCliente = @IdCliente ";

                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@IdCliente", idCliente);
                cmd.ExecuteNonQuery();

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                FecharConexao();
            }
        }

        public List<Cliente> ListarTodos()
        {
            try
            {
                AbrirConexao();
                string query = " SELECT * FROM Cliente ";
                cmd = new SqlCommand(query, con);
                dr = cmd.ExecuteReader();

                List<Cliente> lista = new List<Cliente>();
                while (dr.Read())
                {
                    Cliente c = new Cliente(); //instanciando um cliente
                    c.IdCliente = Convert.ToInt32(dr["IdCLiente"]);
                    c.Nome = Convert.ToString(dr["Nome"]);
                    c.Email = Convert.ToString(dr["Email"]);
                    c.DataCadastro = Convert.ToDateTime(dr["DataCadastro"]);

                    lista.Add(c);
                }

                return lista;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                FecharConexao();
            }
        }

        public Cliente ObterPorId(int idCLiente)
        {
            try
            {
                AbrirConexao();
                string query = " SELECT * FROM Cliente WHERE IdCLiente = @IdCLiente ";

                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@IdCliente", idCLiente);
                dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    Cliente c = new Cliente(); //instanciando um cliente
                    c.IdCliente = Convert.ToInt32(dr["IdCLiente"]);
                    c.Nome = Convert.ToString(dr["Nome"]);
                    c.Email = Convert.ToString(dr["Email"]);
                    c.DataCadastro = Convert.ToDateTime(dr["DataCadastro"]);

                    return c;

                }
                else
                {
                    throw new Exception("Cliente não encontrado...");
                }

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                FecharConexao();
            }
        }

        //verificar se o email ja esta cadastrado
        public bool EmailJaCadastrado(string email)
        {
            try
            {
                AbrirConexao();
                string query = " SELECT COUNT(Email) FROM Cliente " + " WHERE Email = @Email ";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Email", email);
                int count = Convert.ToInt32(cmd.ExecuteScalar());

                return count > 0;
            }
            catch (Exception e){
                throw new Exception(e.Message);
            }
            finally{
                FecharConexao();
            }
        }
    }
}
