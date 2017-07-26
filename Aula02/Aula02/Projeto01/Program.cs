using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto01.Controladores;

namespace Projeto01
{
    class Program
    {
        static void Main(string[] args)
        {
            FuncionarioCntrole fc = new FuncionarioCntrole();
            fc.CadastrarFuncionario();

            Console.ReadKey();
        }
    }
}
