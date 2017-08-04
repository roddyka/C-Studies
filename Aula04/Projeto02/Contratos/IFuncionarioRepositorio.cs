using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto02.Entidades;
using Projeto02.Entidades.Tipos;

namespace Projeto02.Contratos
{
    public interface IFuncionarioRepositorio
    {
        void Inserir(Funcionario f);

        List<Funcionario> obterTodos();

        List<Funcionario> ObterPorNome(string nome);

        List<Funcionario> obterPorTipo(TipoContratacao tipo);

        List<Funcionario> ObterPorSalario(decimal salarioIni, decimal salarioFim);

        Funcionario ObterPorID(int id);
    }
}
