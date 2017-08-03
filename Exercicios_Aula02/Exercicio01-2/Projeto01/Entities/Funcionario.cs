using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto01.Entities.types;

namespace Projeto01.Entities
{
    public class Funcionario
    {
        public Funcionario()
        {
                
        }

        public Funcionario(int idFunctionario, string nome, decimal salario, Sexo sexo, EstadoCivil estadoCivil, Departamento departamento)
        {
            IdFunctionario = idFunctionario;
            Nome = nome;
            Salario = salario;
            Sexo = sexo;
            EstadoCivil = estadoCivil;
            departamento = departamento;
        }

        public int IdFunctionario { get; set; }
        public string Nome { get; set; }
        public Decimal Salario { get; set; }

        public Sexo Sexo { get; set; }
        public EstadoCivil EstadoCivil { get; set; }
        public Departamento departamento { get; set; }
    }
}
