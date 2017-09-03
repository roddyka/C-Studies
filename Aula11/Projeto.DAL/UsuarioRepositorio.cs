using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Projeto.Entities;

namespace Projeto.DAL
{
    public class UsuarioRepositorio : Conexao
    {

        public void Insert(Usuario u)
        {
            try
            {
                OpenConnection();
                string query = "insert into Usuario(Nome,Login,Senha,Foto) values (@Nome,@Login,@Senha,@Foto) select SCOPE_IDENTITY()";

                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Nome", u.Nome);
                cmd.Parameters.AddWithValue("@Login", u.Login);
                cmd.Parameters.AddWithValue("@Senha", u.Senha);
                cmd.Parameters.AddWithValue("@Foto", u.Foto);

                u.IdUsuario = Convert.ToInt32(cmd.ExecuteScalar());

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                CloseConnection();
            }
        }

        //verificar se login esta cadastrado no banco de dados

        public bool HasLogin(string login)
        {
            try
            {
                OpenConnection();
                string query = "SELECT count(Login) from usuario where Login = @Login";

                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Login", login);
                return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                CloseConnection();
            }
        }

        public Usuario Find(string login, string senha)
        {
            try
            {
                OpenConnection();
                string query = "select IdUsuario,Nome,Login,Foto from Usuario where Login = @Login and Senha = @Senha";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Login", login);
                cmd.Parameters.AddWithValue("@Senha", senha);
                dr = cmd.ExecuteReader();

                Usuario u = null;
                if (dr.Read())
                {
                    u = new Usuario();

                    u.IdUsuario = Convert.ToInt32(dr["IdUsuario"]);
                    u.Nome = Convert.ToString(dr["Nome"]);
                    u.Login = Convert.ToString(dr["Login"]);
                    u.Foto = Convert.ToString(dr["Foto"]);
                }

                return u;

            }
            catch (Exception e)
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
