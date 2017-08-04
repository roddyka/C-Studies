using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto02.Entidades;
using Projeto02.Contratos;
using Projeto02.Entidades.Tipos;

namespace Projeto02.Repositorios
{
    public class FuncionarioRepositorioLAMBDA : IFuncionarioRepositorio
    {
        private List<Funcionario> funcionarios;

        public FuncionarioRepositorioLAMBDA()
        {
            funcionarios = new List<Funcionario>();
        }

        public void Inserir(Funcionario f)
        {
            funcionarios.Add(f);
        }

        public Funcionario ObterPorID(int id)
        {
            //LAMBDA
            return funcionarios.FirstOrDefault(f => f.IdFuncionario == id);
        }

        public List<Funcionario> ObterPorNome(string nome)
        {
            //LAMBDA
            return funcionarios.Where(f => f.Nome.StartsWith(f.Nome)).OrderBy(f => f.Nome).ToList();
        }

        public List<Funcionario> ObterPorSalario(decimal salarioIni, decimal salarioFim)
        {
            //LAMBDA
            return funcionarios.Where(f => f.Salario >= salarioIni && f.Salario <= salarioFim).OrderBy(f => f.Nome).ToList();
        }

        public List<Funcionario> obterPorTipo(TipoContratacao tipo)
        {
            //LAMBDA
            return funcionarios.Where(x => x.Tipo == tipo).OrderBy(f => f.Nome).ToList();
    }

        public List<Funcionario> obterTodos()
        {
            //LAMBDA
            return funcionarios.OrderBy(f => f.Nome).ToList();
        }
    }
}
