using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto01.Entidades;

namespace Projeto01.Controladores
{
    public class FuncionarioCntrole
    {
        //metodo para cadastrar funcionario no sistema.
        public void CadastrarFuncionario()
        {
            try
            {
                Console.WriteLine("\n - CADASTRO DE FUNCIONARIO - \n");
                Funcionario f = new Funcionario();
                f.Endereco = new Endereco();

                Console.WriteLine("Id do funcionário......:");
                f.IdFuncionario = int.Parse(Console.ReadLine());

                Console.WriteLine("Nome do funciónário....:");
                f.Nome = Console.ReadLine();

                Console.WriteLine("Data de Nascimento.....:");
                f.DataNascimento = DateTime.Parse(Console.ReadLine());

                Console.WriteLine("Salário................:");
                f.Salario = decimal.Parse(Console.ReadLine());

                Console.WriteLine("Id do Endereço.........:");
                f.Endereco.IdEndereco = int.Parse(Console.ReadLine());

                Console.WriteLine("Logradouro.............:");
                f.Endereco.Logradouro = Console.ReadLine();

                Console.WriteLine("Bairro.................:");
                f.Endereco.Bairro = Console.ReadLine();

                Console.WriteLine("Cidade.................:");
                f.Endereco.Cidade = Console.ReadLine();

                Console.WriteLine("Estado.................:");
                f.Endereco.Estado = Console.ReadLine();

                Console.WriteLine("Cep....................:");
                f.Endereco.Cep = Console.ReadLine();

                

            }
            catch (Exception e)
            {
                //imprimir mensagem de erro
                Console.WriteLine("Erro: " + e.Message);
            }
        }
    }
}
