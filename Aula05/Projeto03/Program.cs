using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto03
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> fila = new Queue<string>();

            fila.Enqueue("Joao");
            fila.Enqueue("Ana");
            fila.Enqueue("Jose");
            fila.Enqueue("Maria");

            //sem remover
            Console.WriteLine("primeiro da fila: " + fila.Peek());

            //removendo
            Console.WriteLine("primeiro da fila: " + fila.Dequeue());

            foreach (string item in fila)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\n PILHA \n");
            //pilha
            Stack<string> pilha = new Stack<string>();
            pilha.Push("Antonio");
            pilha.Push("Seila");
            pilha.Push("Teste");
            pilha.Push("Zueira");

            foreach(string item in pilha)
            {
                Console.WriteLine(item);
            }

            //Console.WriteLine("primeiro da pilha: " + pilha.Peek());

            Console.WriteLine("primeiro da pilha: " + pilha.Pop());

            Console.ReadKey();
        }
    }
}
