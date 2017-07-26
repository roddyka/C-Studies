using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto02.Entities; //tem que chamar o using para ele usar a classe desejada
using System.IO;//input, output

namespace Projeto02.Repositories
{
    public class ProdutoRepository
    {
        /// <summary>
        /// Mérodo para gravação dos dados de Produto em arquivo
        /// </summary>
        /// <param name="p">é um objeto da entidade Produto</param>
        public void ExportarDados(Produto p)
        {
            //abrindo um arquivo txt e gravando da ultima linha
            StreamWriter sw = new StreamWriter("G:/temp/produtos.txt",true);
            sw.WriteLine("Id...:" + p.IdProduto);
            sw.WriteLine("Nome...:" + p.Nome);
            sw.WriteLine("Preco...:" + p.Preco);
            sw.WriteLine("Quantidade...:" + p.Quantidade);
            sw.WriteLine("..");

            //fechando o arquivo
            sw.Close();
        }
    }
}
