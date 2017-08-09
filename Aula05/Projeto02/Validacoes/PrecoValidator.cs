using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto02.Validacoes
{
    public class PrecoValidator
    {
        public static bool IsValid(decimal preco)
        {
            if(preco <= 0 || preco > decimal.MaxValue)
            {
                throw new Exception("Valor de Preço Invalido!");
            }
            return true;
        }
    }
}
