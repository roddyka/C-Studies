using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto02.Entidades;
using Projeto02.Entidades.Tipos;
using Projeto02.Contratos;
using Projeto02.Repositorios;

namespace Projeto02
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario f1 = new Funcionario(1, "Rodrigo", 1000m, TipoContratacao.Estagiario);
            Funcionario f2 = new Funcionario(1, "Hayra", 2000m, TipoContratacao.CLT);
            Funcionario f3 = new Funcionario(1, "Antunes", 1400m, TipoContratacao.Terceirizado);

            IFuncionarioRepositorio rep = new FuncionarioRepositorioLAMBDA();

            rep.Inserir(f1);
            rep.Inserir(f2);
            rep.Inserir(f3);

            foreach(Funcionario f in rep.ObterPorSalario(1500m, 3500m))
            {
                Console.WriteLine(f.ToString());
            }

            Console.WriteLine("...");
            Console.ReadKey();
        }
    }
}
