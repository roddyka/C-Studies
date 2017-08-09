using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto02.Controladores;

namespace Projeto02
{
    class Program
    {
        static void Main(string[] args)
        {
            ProdutoControle pc = new ProdutoControle();
            pc.CadastrarProduto();

            Console.ReadKey();
        }
    }
}
