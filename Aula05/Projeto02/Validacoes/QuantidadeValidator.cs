using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto02.Validacoes
{
    public class QuantidadeValidator
    {
        public static bool IsValid(int quantidade)
        {
            if(quantidade < 0 || quantidade >= int.MaxValue)
            {
                throw new Exception("Valor de Quantidade Invalida!");
            }
            return true;
        }
    }
}
