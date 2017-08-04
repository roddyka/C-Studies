using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto01.Entidades;

namespace Projeto01
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Produto> lista = new List<Produto>();

            Produto p1 = new Produto(1, "Notebook", 2500m, 10);
            Produto p2 = new Produto(2, "Pendriver64G", 55m, 5);
            Produto p3 = new Produto(3, "HD500GB", 100m, 3);
            Produto p4 = new Produto(4, "Celular", 2100m, 9);

            lista.Add(p1);
            lista.Add(p2);
            lista.Add(p3);
            lista.Add(p4);

            for (int i = 0; i < lista.Count; i++)
            {
                Produto p = lista.ElementAt(i);
                Console.WriteLine(p);
            }

            foreach (Produto p in lista)
            {
                Console.WriteLine(p);
            }

            Console.WriteLine("...");
            Console.ReadKey();
        }
    }
}
