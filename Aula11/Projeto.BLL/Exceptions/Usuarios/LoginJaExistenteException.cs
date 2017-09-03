using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.BLL.Exceptions.Usuarios
{
    public class LoginJaExistenteException:Exception;
    {
        private string login;

        public LoginJaExistenteException(string login)
        {
            this.login = login;
        }

        public override string Message
        {
            get
            {
                return $"O login {login} já encontra-se em uso. Tente outro.";
            }
        }
    }
}
