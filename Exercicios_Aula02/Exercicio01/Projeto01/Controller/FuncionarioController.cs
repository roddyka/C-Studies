using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto01.Entities;
using Projeto01.Repository;

namespace Projeto01.Controller
{
    class FuncionarioController
    {
        public void CadastrarFuncionario()
        {
            try
            {
                Console.WriteLine("\nCadastro de Funcionário Programador\n");

                Programador p = new Programador();
                p.Departamento = new Departamento();

                Console.WriteLine("\nId Funcionario..:");
                p.IdFuncionario = int.Parse(Console.ReadLine());

                Console.WriteLine("\nNome..:");
                p.Nome = Console.ReadLine();

                Console.WriteLine("\nSalario..:");
                p.Salario = Decimal.Parse(Console.ReadLine());

                Console.WriteLine("\nTipo Programador..:");
                p.Tipo = int.Parse(Console.ReadLine());

                Console.WriteLine("\nId Departamento..:");
                p.Departamento.IdDepto = int.Parse(Console.ReadLine());

                Console.WriteLine("\nNome Departamento..:");
                p.Departamento.Nome = Console.ReadLine();

                FuncionarioRepository fr = new FuncionarioRepository();
                fr.ExportarDados(p);

                Console.WriteLine("\nExportados com sucesso!!!!");
            }
            catch (Exception e)
            {
                Console.WriteLine("ERRO: "+ e.Message);
            }
        }
    }
}
