using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Projeto.Entidades;
using Projeto.Entidades.Tipos;

namespace Projeto.DAL
{
    public class UsuarioRepositorio : Conexao
    {
        public void Insert(Usuario u)
        {

            try
            {
                OpenConnection();
                string query = "INSERT INTO Usuarios (nome,sobrenome,email,dtnasc,sexo,estadocivil,profissao,area,descricao,pretencaosalarial,linkedin,senha) VALUES (@Nome,@Sobrenome,@Email,@DataNascimento,@Sexo,@EstadoCivil,@Profissao,@Area,@Descricao,@PretencaoSalarial,@Linkedin,@Senha)";

                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Nome", u.Nome);
                cmd.Parameters.AddWithValue("@Sobrenome", u.Sobrenome);
                cmd.Parameters.AddWithValue("@Email", u.Email);
                cmd.Parameters.AddWithValue("@DataNascimento", u.DataNascimento);
                cmd.Parameters.AddWithValue("@Sexo", u.Sexo);
                cmd.Parameters.AddWithValue("@EstadoCivil", u.EstadoCivil);
                cmd.Parameters.AddWithValue("@Profissao", u.Profissao);
                cmd.Parameters.AddWithValue("@Area", u.Area);
                cmd.Parameters.AddWithValue("@Descricao", u.Descricao);
                cmd.Parameters.AddWithValue("@PretencaoSalarial", u.PretencaoSalarial);
                cmd.Parameters.AddWithValue("@Linkedin", u.Linkedin);
                cmd.Parameters.AddWithValue("@Senha", u.Senha);

                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception("Erro ao adicionar usuario: " + e.Message);
            }
            finally
            {
                CloseConnection();
            }
        }

        public void Update(Usuario u)
        {
            try
            {
                OpenConnection();

                string query = "UPDATE Usuarios SET nome = @Nome,sobrenome = @Sobrenome,email = @Email,dtnasc = @DataNascimento,sexo = @Sexo,estadocivil = @EstadoCivil,profissao = @Profissao,area = @Area,descricao = @Descricao,pretencaosalarial = @PretencaoSalarial,linkedin = @Linkedin ,senha = @Senha WHERE IdUsuario = @IdUsuario ";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@IdUsuario", u.IdUsuario);
                cmd.Parameters.AddWithValue("@Nome", u.Nome);
                cmd.Parameters.AddWithValue("@Sobrenome", u.Sobrenome);
                cmd.Parameters.AddWithValue("@Email", u.Email);
                cmd.Parameters.AddWithValue("@DataNascimento", u.DataNascimento);
                cmd.Parameters.AddWithValue("@Sexo", u.Sexo);
                cmd.Parameters.AddWithValue("@EstadoCivil", u.EstadoCivil);
                cmd.Parameters.AddWithValue("@Profissao", u.Profissao);
                cmd.Parameters.AddWithValue("@Area", u.Area);
                cmd.Parameters.AddWithValue("@Descricao", u.Descricao);
                cmd.Parameters.AddWithValue("@PretencaoSalarial", u.PretencaoSalarial);
                cmd.Parameters.AddWithValue("@Linkedin", u.Linkedin);
                cmd.Parameters.AddWithValue("@Senha", u.Senha);

                cmd.ExecuteNonQuery();

            }
            catch (Exception e)
            {
                throw new Exception("Erro ao atualizar usuario: " + e.Message);
            }
            finally
            {
                CloseConnection();
            }
        }

        public void Delete(int idUsuario)
        {
            try
            {
                OpenConnection();
                string query = "DELETE FROM Usuarios WHERE IdUsuario = @IdUsuario";

                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@IdUsuario", idUsuario);
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception("Erro ao deletar usuario: " + e.Message);
            }
            finally
            {
                CloseConnection();
            }
        }

        public List<Usuario> findAll()
        {
            OpenConnection();
            string query = "SELECT * FROM Usuarios";
            cmd = new SqlCommand(query,con);
            dr = cmd.ExecuteReader();

            List<Usuario> lista = new List<Usuario>();
            while (dr.Read())
            { 
                Usuario u = new Usuario();
                u.IdUsuario = Convert.ToInt32(dr["IdUsuario"]);
                u.Nome = Convert.ToString(dr["nome"]);
                u.Email = Convert.ToString(dr["email"]);
                u.DataNascimento = Convert.ToDateTime(dr["dtnasc"]);
                u.Profissao = Convert.ToString(dr["profissao"]);
                u.Descricao = Convert.ToString(dr["descricao"]);
                u.PretencaoSalarial = Convert.ToInt32(dr["pretencaosalarial"]);
                u.Linkedin = Convert.ToString(dr["Linkedin"]);

                string sexo = Convert.ToString(dr["sexo"]);
                string estadoCivil = Convert.ToString(dr["estadocivil"]);
                string area = Convert.ToString(dr["area"]);

                u.Sexo = (Sexo)Enum.Parse(typeof(Sexo), sexo);
                u.EstadoCivil = (EstadoCivil)Enum.Parse(typeof(EstadoCivil), estadoCivil);
                u.Area = (Area)Enum.Parse(typeof(Area), area);
                
            }
        }

        public Usuario findById(int idUsuario)
        {
            try
            {
                OpenConnection();
                string query = "SELECT * FROM Usuarios WHERE IdUsuario = @IdUsuario";

                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@IdUsuario", idUsuario);
                dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    Usuario u = new Usuario();
                    u.IdUsuario = Convert.ToInt32(dr["IdUsuario"]);
                    u.Nome = Convert.ToString(dr["nome"]);
                    u.Email = Convert.ToString(dr["email"]);
                    u.DataNascimento = Convert.ToDateTime(dr["dtnasc"]);
                    u.Profissao = Convert.ToString(dr["profissao"]);
                    u.Descricao = Convert.ToString(dr["descricao"]);
                    u.PretencaoSalarial = Convert.ToInt32(dr["pretencaosalarial"]);
                    u.Linkedin = Convert.ToString(dr["Linkedin"]);

                    string sexo = Convert.ToString(dr["sexo"]);
                    string estadoCivil = Convert.ToString(dr["estadocivil"]);
                    string area = Convert.ToString(dr["area"]);

                    u.Sexo = (Sexo)Enum.Parse(typeof(Sexo), sexo);
                    u.EstadoCivil = (EstadoCivil)Enum.Parse(typeof(EstadoCivil), estadoCivil);
                    u.Area = (Area)Enum.Parse(typeof(Area), area);

                    return u;

                }
                return null;
            }catch(Exception e)
            {
                throw new Exception("Erro ao consultar usuario: " + e.Message);
            }
            finally
            {
                CloseConnection();
            }
        }

        public bool HasEmail(string email)
        {
            try
            {
                OpenConnection();
                string query = "select count(email) from Usuarios where email = @Email";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Email", email);
                int count = Convert.ToInt32(cmd.ExecuteScalar());

                return count > 0;
            }
            catch (Exception e)
            {
                throw new Exception("Email já existente: " + e.Message);
            }
            finally
            {
                CloseConnection();
            }
        }
    }
}
