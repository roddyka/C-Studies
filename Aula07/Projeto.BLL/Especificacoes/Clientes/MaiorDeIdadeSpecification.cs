using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto.Entidades;
using Projeto.BLL.Excecoes.Clientes;

namespace Projeto.BLL.Especificacoes.Clientes
{
    public class MaiorDeIdadeSpecification
    {
        public bool IsValid(Cliente c)
        {
            //ano de nascimento do cliente
            int anoNasc = c.DataNascimento.Year;

            //ano atual
            int anoAtual = DateTime.Now.Year;

            int idade = anoAtual - anoNasc;

            if (c.DataNascimento > DateTime.Now.AddYears(-idade)) idade--;

            if (idade < 18){
                throw new MenorDeIdadeException();
            }
            return true;
        }

    }
}
