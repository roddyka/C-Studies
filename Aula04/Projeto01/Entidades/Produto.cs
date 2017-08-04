using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto01.Entidades
{
    public class Produto
    {
        public Produto()
        {
            //declarando construtor default
        }

        public Produto(int idProduto, string nome, decimal preco, int quantidade)
        { //sobrecarga de construtor(overloading)
            IdProduto = idProduto;
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public int IdProduto { get; set; }
        public string Nome{ get; set; }
        public decimal Preco { get; set; }
        public int Quantidade { get; set; }

        public override string ToString()
        {
            return $"IdProduto: {IdProduto}, Nome: {Nome}, Preço: {Preco}, Quantidade: {Quantidade}";
        }
    }
}
