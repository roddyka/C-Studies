using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;


namespace Projeto.DAL
{
    public class Conexao
    {
        protected SqlConnection con;
        protected SqlCommand cmd;
        protected SqlDataReader dr;
        protected SqlTransaction tr;

        public void OpenConnection()
        {
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["banco"].ConnectionString);
            con.Open();
        }

        protected void CloseConnection()
        {
            con.Close();
        }
    }
}
