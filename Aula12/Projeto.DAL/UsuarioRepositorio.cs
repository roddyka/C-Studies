using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient; //SqlServer
using Projeto.Entities; //classes de entidade
    
namespace Projeto.DAL
{
    public class UsuarioRepositorio : Conexao
    {
        //método para inserir um registro na tabela de usuario..
        public void Insert(Usuario u)
        {
            try
            {
                OpenConnection();

                string query = "insert into Usuario(Nome, Login, Senha, Foto) "
                             + "values(@Nome, @Login, @Senha, @Foto) "
                             + "select SCOPE_IDENTITY()";

                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Nome", u.Nome);
                cmd.Parameters.AddWithValue("@Login", u.Login);
                cmd.Parameters.AddWithValue("@Senha", u.Senha);
                cmd.Parameters.AddWithValue("@Foto", u.Foto);
                u.IdUsuario = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch(Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                CloseConnection();
            }
        }

        //método para verificar se um login ja esta cadastrado no banco de dados..
        public bool HasLogin(string login)
        {
            try
            {
                OpenConnection();

                string query = "select count(Login) from Usuario where Login = @Login";

                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Login", login);

                return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
            }
            catch(Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                CloseConnection();
            }
        }

        //método para buscar 1 usuario pelo login e senha..
        public Usuario Find(string login, string senha)
        {
            try
            {
                OpenConnection();

                string query = "select IdUsuario, Nome, Login, Foto from Usuario "
                             + "where Login = @Login and Senha = @Senha";

                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Login", login);
                cmd.Parameters.AddWithValue("@Senha", senha);
                dr = cmd.ExecuteReader(); //executando e lendo os registros..

                Usuario u = null; //sem espaço de memória..

                if(dr.Read()) //se algum registro foi encontrado..
                {
                    u = new Usuario(); //instanciando (criando espaço de memória)

                    u.IdUsuario = Convert.ToInt32(dr["IdUsuario"]);
                    u.Nome = Convert.ToString(dr["Nome"]);
                    u.Login = Convert.ToString(dr["Login"]);
                    u.Foto = Convert.ToString(dr["Foto"]);
                }

                return u; //retornando o usuario..
            }
            catch(Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                CloseConnection();
            }
        }


    }
}
