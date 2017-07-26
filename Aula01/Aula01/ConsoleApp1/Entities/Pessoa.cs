using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//localização da classe ( esta em consoleapp1/entities
namespace ConsoleApp1.Entities
{
    //definição da classe
    //acessado total
    public class Pessoa
    {
        //atributos(dados)
        //privado -> somente acessado dentro da propria classe
        private int idPessoa;
        private string nome;
        private string sobrenome;
        private string cpf;

        

        //propriedade set/get - IdPessoa(nome maiusculo para não dar confusão com o private que tem o mesmo nome;
        public int IdPessoa // property
        {
            set { idPessoa = value; }//entrada
            get { return idPessoa; }//saida
        }

        public string Nome //property
        {
            set { nome = value; }
            get { return nome; }
        }

        public string Sobrenome //property
        {
            set { sobrenome = value; }
            get { return sobrenome; }
        }

        public string Cpf //property
        {
            set { cpf = value; }
            get { return cpf; }
        }
    }
}
