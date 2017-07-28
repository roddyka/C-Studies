using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto01.Controladores;
using Projeto01.Repositorios;

namespace Projeto01
{
    class Program
    {
        static void Main(string[] args)
        {
            ClienteControler c = new ClienteControler(new ClienteRepositorioCSV());
            c.cadastrarCliente();

            Console.ReadKey();
        }
    }
}
