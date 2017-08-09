using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto02.Validacoes
{
    public class IdValidator
    {
        public static bool IsValid(int id)
        {
            if(id <= 0)
            {
                throw new Exception("Id não pode ser menor ou igual a zero.");
            }
            return true; //true / false...
        }
    }
}
