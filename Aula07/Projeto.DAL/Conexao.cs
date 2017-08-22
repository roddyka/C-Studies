using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient; //acesso ao sqlserver
using System.Configuration; //obter a connectionstring

namespace Projeto.DAL
{
    public class Conexao
    {
        //atributos..
        protected SqlConnection con;    //conexão com o banco de dados..
        protected SqlCommand cmd;       //executar comandos SQL..
        protected SqlDataReader dr;     //Ler registros de consultas..
        protected SqlTransaction tr;    //Transações (commit, rollback)

        //métodos..
        protected void OpenConnection()
        {
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["aula"].ConnectionString);
            con.Open(); //conectado..
        }

        protected void CloseConnection()
        {
            con.Close(); //desconectado..
        }
    }
}