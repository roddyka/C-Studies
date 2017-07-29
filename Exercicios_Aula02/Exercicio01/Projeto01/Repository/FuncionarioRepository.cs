using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto01.Entities;
using System.IO;

namespace Projeto01.Repository
{
    public class FuncionarioRepository
    {
        public void ExportarDados(Programador f)
        {
            using(StreamWriter sw = new StreamWriter("c:\\temp\\funcionario.csv", true))
            {
                string dados = string.Format(
                    "{0};{1};{2};{3};{4};{5}",f.IdFuncionario,f.Nome,f.Salario,f.Tipo,f.Departamento.IdDepto, f.Departamento.Nome);

                sw.WriteLine(dados);
            }
        }
    }
}
