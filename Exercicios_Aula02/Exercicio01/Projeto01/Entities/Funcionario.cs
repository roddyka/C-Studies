using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto01.Entities
{
    public class Funcionario
    {
        public Funcionario()
        {
                
        }

        public Funcionario(int idFuncionario, string nome, Decimal salario)
        {
            this.idFuncionario = idFuncionario;
            this.nome = nome;
            this.salario = salario;
        }

        private int idFuncionario;
        private string nome;
        private Decimal salario;

        public int IdFuncionario { get => idFuncionario; set => idFuncionario = value; }
        public string Nome { get => nome; set => nome = value; }
        public Decimal Salario { get => salario; set => salario = value; }
    }
}
