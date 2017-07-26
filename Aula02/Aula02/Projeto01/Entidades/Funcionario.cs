using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto01.Entidades
{
    public class Funcionario : Pessoa
    {
        private int idFuncionario;
        private decimal salario;
        private Endereco endereco; //associação, relacionamento (TER-1)

        public Funcionario()
        {

        }

        public Funcionario(int idFuncionario, string nome, DateTime dataNascimento, decimal salario)
            :base(nome,dataNascimento)
        {
            this.idFuncionario = idFuncionario;
            this.salario = salario;
        }

        public int IdFuncionario
        {
            set { idFuncionario = value; }
            get { return idFuncionario; }
        }

        public decimal Salario
        {
            set { salario = value; }
            get { return salario; }
        }


        public Endereco Endereco
        {
            set { endereco = value; }
            get { return endereco; }
        }
    }
}
