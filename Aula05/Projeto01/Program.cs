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
            MensagemControle mensagem = new MensagemControle();
            mensagem.EnviarMensagem();

            Console.ReadKey();
        }
    }
}
