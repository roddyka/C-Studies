using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto01.Entities
{
    public class Programador : Funcionario
    {
        public Programador()
        {
                
        }

       

        public Programador(int idFuncionario, string nome ,types.Sexo Sexo,types.EstadoCivil EstadoCivil, decimal salario, int tipo, types.Departamento Departamento
            ) : base(idFuncionario,nome,salario, Sexo, EstadoCivil, Departamento)
        {
            this.tipo = tipo;
        }

        public int tipo { get; set; }
        
    }
}
