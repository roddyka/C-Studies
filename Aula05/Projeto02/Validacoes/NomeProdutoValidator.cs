using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Projeto02.Validacoes
{
    public class NomeProdutoValidator
    {
        public static bool IsValid(string nome)
        {

            if (string.IsNullOrWhiteSpace(nome))
            {
                throw new Exception("Por favor informe um nome!");
            }
            else
            {
                //[Letras maiusculas e minusculas, numeros,acentos]{quantidade minima e maxima de caracteres}
                Regex r = new Regex("^[A-Za-zÀ-Üà-ü0-9\\s]{3,50}$");

                if (!r.IsMatch(nome))
                {
                    throw new Exception("Nome do produto inválido!");
                }
            }

            return true;
        }
    }
}
