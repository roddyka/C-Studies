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
    public class FuncionarioRepositorioLINQ : IFuncionarioRepositorio
    {

        //atributo 
        private List<Funcionario> funcionarios;

        public FuncionarioRepositorioLINQ()
        {
            funcionarios = new List<Funcionario>();
        }

        public void Inserir(Funcionario f)
        {
            funcionarios.Add(f);
        }

        public Funcionario ObterPorID(int id)
        {
            //LINQ - language integrated query
            return (from f in funcionarios where f.IdFuncionario == id select f).FirstOrDefault();
        }

        public List<Funcionario> ObterPorNome(string nome)
        {
            //LINQ - language integrated query
            return (from f in funcionarios where f.Nome.StartsWith(nome) orderby f.Nome ascending select f).ToList();
        }

        public List<Funcionario> ObterPorSalario(decimal salarioIni, decimal salarioFim)
        {
            //LINQ - language integrated query
            return (from f in funcionarios where f.Salario >= salarioIni && f.Salario <=salarioFim
                    orderby f.Nome ascending select f).ToList();
        }

        public List<Funcionario> obterPorTipo(TipoContratacao tipo)
        {
            //LINQ - language integrated query
            return (from f in funcionarios where f.Tipo == tipo orderby f.Nome ascending select f).ToList();
        }

        public List<Funcionario> obterTodos()
        {
            //LINQ - language integrated query
            return (from f in funcionarios
                    orderby f.Nome ascending
                    select f).ToList();
        }
    }
}
