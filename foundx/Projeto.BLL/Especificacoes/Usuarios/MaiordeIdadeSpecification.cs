using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto.Entidades;
using Projeto.BLL.Excecoes.Usuarios;

namespace Projeto.BLL.Especificacoes.Usuarios
{
    public class MaiordeIdadeSpecification
    {
        public void IsValid(Usuario u)
        {
            int anoNasc = u.DataNascimento.Year;

            int anoAtual = DateTime.Now.Year;

            int idade = anoAtual - anoNasc;
            if (u.DataNascimento > DateTime.Now.AddYears(-idade)) idade--;

            if(idade < 18)
            {
                throw new MenorDeIdadeException();
            }
            return true;
        }
    }
}
