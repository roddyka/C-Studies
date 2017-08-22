using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.BLL.Excecoes.Clientes
{
    public class EmailJaCadastradoException: Exception
    {
        private string email;

        public EmailJaCadastradoException(string email)
        {
            this.email = email;
        }

        public override string Message
        {
            get
            {
                return $"O email {email} já encontra-se cadastrado no sistema!";
            }
        }
    }
}
