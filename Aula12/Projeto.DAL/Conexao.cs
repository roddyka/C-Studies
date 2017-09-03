using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient; //SqlServer..
using System.Configuration; //importando..

namespace Projeto.DAL
{
    public class Conexao
    {
        //atributos..
        protected SqlConnection con;    //Conexão com o banco de dados
        protected SqlCommand cmd;       //Executar comandos SQL
        protected SqlDataReader dr;     //Ler dados de consultas
        protected SqlTransaction tr;    //Transações (commit, rollback)

        //método para abrir conexão com o banco de dados..
        protected void OpenConnection()
        {
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["aula"].ConnectionString);
            con.Open(); //conexão aberta..
        }

        protected void CloseConnection()
        {
            con.Close();
        }
    }
}
