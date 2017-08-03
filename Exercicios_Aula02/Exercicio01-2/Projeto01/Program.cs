using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto01.Controllers;
using Projeto01.Repositories;

namespace Projeto01
{
    class Program
    {
        static void Main(string[] args)
        {
            FuncionarioController f = new FuncionarioController(new FuncionarioExportarXML());
            f.CadastrarFuncionario();

            Console.ReadKey();

        }
    }
}
