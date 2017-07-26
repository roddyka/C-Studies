using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto02.Entities;
using Projeto02.Repositories;

namespace Projeto02
{
    class Program
    {
        static void Main(string[] args)
        {
            //construtor default da classe
            Produto p1 = new Produto();
            //set e get é metodo ou propriedade
            p1.IdProduto = 1;
            p1.Nome = "Pendrive 128GB";
            p1.Preco = 10m;
            p1.Quantidade = 5;

            //construtor com entrada de argumentos
            Produto p2 = new Produto(2,"Biscoito 500GB",500,10m);

            //pode se usar de qualquer uma das duas formas, 
            //serve para dar opção caso mude alguma coisa


            try
            {
                ProdutoRepository rep = new ProdutoRepository();

                rep.ExportarDados(p1);
                rep.ExportarDados(p2);
                //tudo foi para a pasta temp do pendriver
                Console.WriteLine("Dados Gravados");
                
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro:" + e.Message);
            }

            Console.ReadKey();
        }
    }
}
