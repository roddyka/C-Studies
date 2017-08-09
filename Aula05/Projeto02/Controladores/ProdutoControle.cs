using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto02.Entidades;
using Projeto02.Validacoes;

namespace Projeto02.Controladores
{
    public class ProdutoControle
    {
        public void CadastrarProduto()
        {
            try
            {
                Console.WriteLine("\n - Cadastro de Produto - \n");
                Produto p = new Produto();

                Console.WriteLine("Id do produto: ");
                p.IdProduto = int.Parse(Console.ReadLine());

                Console.WriteLine("Nome do Produto: ");
                p.Nome = Console.ReadLine();

                Console.WriteLine("Preço: ");
                p.Preco = decimal.Parse(Console.ReadLine());

                Console.WriteLine("Quantidade: ");
                p.Quantidade = int.Parse(Console.ReadLine());

                if(IdValidator.IsValid(p.IdProduto) && NomeProdutoValidator.IsValid(p.Nome) && PrecoValidator.IsValid(p.Preco) && QuantidadeValidator.IsValid(p.Quantidade))
                {
                    Console.WriteLine("\nProduto Cadastrado com Sucesso");
                    Console.WriteLine("Produto: "+p.ToString());
                }
                
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
