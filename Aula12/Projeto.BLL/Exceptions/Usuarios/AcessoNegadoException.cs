using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.BLL.Exceptions.Usuarios
{
    public class AcessoNegadoException : Exception
    {
        //sobrescrita do método Message..
        public override string Message
        {
            get { return "Acesso Negado. Usuário inválido."; }
        }
    }
}
