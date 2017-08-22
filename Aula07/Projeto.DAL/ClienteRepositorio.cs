using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Projeto.Entidades;

namespace Projeto.DAL
{
    public class ClienteRepositorio:Conexao
    {
        public void Insert(Cliente c)
        {
            try
            {
                OpenConnection();

                string query = "Insert into Cliente(Nome, Email, DataNascimento, Sexo, EstadoCivil) VALUES(@Nome,@Email,@DataNascimento,@Sexo,@EstadoCivil)";

                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Nome", c.Nome);
                cmd.Parameters.AddWithValue("@Email", c.Email);
                cmd.Parameters.AddWithValue("@DataNascimento", c.DataNascimento);
                cmd.Parameters.AddWithValue("@Sexo", c.Sexo.ToString());
                cmd.Parameters.AddWithValue("@EstadoCivil", c.EstadoCivil.ToString());
                cmd.ExecuteNonQuery();

            } catch(Exception e)
            {
                throw new Exception("Erro ao inserir cliente: " + e.Message);
            }
            finally
            {
                CloseConnection();
            }
        }

        public void Update(Cliente c)
        {
            try
            {
                OpenConnection();

                string query = "UPDATE Cliente set Nome = @Nome, Email = @Email, DataNascimento = @DataNascimento, Sexo = @Sexo, EstadoCivil = @EstadoCivil WHERE IdCliente = @IdCliente";

                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@IdCliente", c.IdCliente);
                cmd.Parameters.AddWithValue("@Nome", c.Nome);
                cmd.Parameters.AddWithValue("@Email", c.Email);
                cmd.Parameters.AddWithValue("@DataNascimento", c.DataNascimento);
                cmd.Parameters.AddWithValue("@Sexo", c.Sexo.ToString());
                cmd.Parameters.AddWithValue("@EstadoCivil", c.EstadoCivil.ToString());
                cmd.ExecuteNonQuery();

            }
            catch (Exception e)
            {
                throw new Exception("Erro ao atualizar cliente: " + e.Message);
            }
            finally
            {
                CloseConnection();
            }
        }

        public void Delete(int idCliente)
        {
            try
            {
                OpenConnection();

                string query = "DELETE FROM Cliente WHERE IdCliente = @IdCliente";

                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@IdCliente", idCliente);
                cmd.ExecuteNonQuery();

            }
            catch (Exception e)
            {
                throw new Exception("Erro ao atualizar cliente: " + e.Message);
            }
            finally
            {
                CloseConnection();
            }
        }
        //metodo para verificar se algum email ja esta cadastrado
        public bool HasEmail(string email)
        {
            try
            {
                OpenConnection();

                string query = " select count(Email) from Cliente where Email = @Email ";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Email", email);
                int count = Convert.ToInt32(cmd.ExecuteScalar());

                return count > 0;


            }catch(Exception e)
            {
                throw new Exception("Error ao verificar e-mail: " + e.Message);
            }
            finally{
                CloseConnection();
            }
        }
    }
}
