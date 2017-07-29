using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto01.Entities
{
    public class Programador : Funcionario
    {
        private int tipo;
        private Departamento departamento;

        public Programador()
        {
                
        }

        public Programador(int idFuncionario, string nome, Decimal salario, int tipo ) : base(idFuncionario,nome,salario)
        {
            this.tipo = tipo;
        }

        public int Tipo { get => tipo; set => tipo = value; }
        public Departamento Departamento { get => departamento; set => departamento = value; }
    }
}
