using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto01.Controller;

namespace Projeto01
{
    class Program
    {
        static void Main(string[] args)
        {
            FuncionarioController f = new FuncionarioController();
            f.CadastrarFuncionario();

            Console.ReadKey();
        }
    }
}
