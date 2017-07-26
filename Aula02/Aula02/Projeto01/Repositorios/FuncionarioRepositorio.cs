using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto01.Entidades;
using System.IO;

namespace Projeto01.Repositorios
{
    public class FuncionarioRepositorio
    {
        //exportar dados csv
        public void ExportarDados(Funcionario f)
        {
            //abrindo um arquivo em modo escrita - /true para escrever em baixo do que ja existe
            using (StreamWriter sw = new StreamWriter("G:/rodrigo arquivos/WebDeveloperCSharp/Aula02/repositorio/aula2.csv", true))
            {
                string dados = string.Format("{0};{1};{2};{3};{4};{5};{6};{7};{8};{9}",
                    f.IdFuncionario, //posicao 0
                    f.Nome, //posicao 1 ... e assim por diante
                    f.Salario,
                    f.DataNascimento,
                    f.Endereco.IdEndereco,
                    f.Endereco.Logradouro,
                    f.Endereco.Bairro,
                    f.Endereco.Cidade,
                    f.Endereco.Estado,
                    f.Endereco.Cep);

                //escrevendo no arquivo
                sw.WriteLine(dados);

            }//dispose()
        }
    }
}
