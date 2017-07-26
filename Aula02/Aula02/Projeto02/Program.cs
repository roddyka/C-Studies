using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto02.Entidades;

namespace Projeto02
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno a1 = new Aluno(1,"Edinaldo Cleber");
            Aluno a2 = new Aluno(2, "Sandro Vasconcelos");
            Aluno a3 = new Aluno(3, "Felipe Videira");
            Aluno a4 = new Aluno(4, "Renan Loureiro");

            List<Aluno> lista = new List<Aluno>();

            lista.Add(a1);
            lista.Add(a2);
            lista.Add(a3);
            lista.Add(a4);
            //Console.WriteLine("\nPercorrendo a lista com FOR...: ");
            //Console.WriteLine("\nQuantidade de Alunos...: "+lista.Count);

            //percorrer a lista
            /*for (int i = 0; i < lista.Count; i++)
            {
                Aluno a = lista.ElementAt(i);
                Console.WriteLine("\nId do Aluno...: " + a.IdAluno);
                Console.WriteLine("Aluno...: " + a.Nome);
                Console.WriteLine("...");
            }*/

            Console.WriteLine("\nPercorrendo a lista com FOREACH...: ");
            foreach (Aluno a in lista
                .Where(aluno => aluno.Nome.StartsWith("R")))
            {
                Console.WriteLine("\nId do Aluno...: " + a.IdAluno);
                Console.WriteLine("Aluno...: " + a.Nome);
                Console.WriteLine("...");
            }

            Console.ReadKey(); //pausa
        }
    }
}
