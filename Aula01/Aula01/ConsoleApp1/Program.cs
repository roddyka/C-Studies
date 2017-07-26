using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Entities; //importando o conteudo do namespace

namespace ConsoleApp1
{
    class Program
    {
        //metodo utilizado pelo contole aplication para executar o projeto
        static void Main(string[] args)
        {
            Console.WriteLine("Aula1 WebDeveloperC# - COTIINFORMATICA");

            //classe->objeto;
            //alt+f12 exibe a classe em que o mouse esta em cima;
            Pessoa pessoa = new Pessoa();

            //tratamento de erro em tempo de execução
            try
            {
                Console.WriteLine("\n- REGISTRO DE PESSOA -\n");
                Console.Write("Informe o id.......: ");
                pessoa.IdPessoa = int.Parse(Console.ReadLine());

                Console.Write("Informe o Nome.......: ");
                pessoa.Nome = Console.ReadLine();

                Console.Write("Informe o Sobrenome.......: ");
                pessoa.Sobrenome = Console.ReadLine();

                Console.Write("Informe o Cpf.......: ");
                pessoa.Cpf = Console.ReadLine();

                Console.WriteLine("\nDados de Pessoa:");
                Console.WriteLine("Id....:" + pessoa.IdPessoa);
                Console.WriteLine("Nome....:"+pessoa.Nome);
                Console.WriteLine("Sobrenome....:" + pessoa.Sobrenome);
                Console.WriteLine("Cpf....:" + pessoa.Cpf);
            }
            catch (Exception e)//exception representa qualquer tipo de exceção dentro do .net
            {
                //imrimir mensagem de error
                Console.WriteLine("\nError: "+e.Message);
            }

            //pausar a execução
            Console.ReadKey();
            
        }
    }
}
