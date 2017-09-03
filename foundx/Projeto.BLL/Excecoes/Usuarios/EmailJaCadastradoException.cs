using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.BLL.Excecoes
{
    

    public class EmailJaCadastradoException : Exception
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
                return $"O email {email} já se encontra cadastrado no sistema!";
            } 
        }
    }
}
