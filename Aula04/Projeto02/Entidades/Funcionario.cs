using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto02.Entidades.Tipos;

namespace Projeto02.Entidades
{
    public class Funcionario
    {
        public int IdFuncionario { get; set; }
        public string Nome { get; set; }
        public decimal Salario { get; set; }
        public TipoContratacao Tipo { get; set; }

        public Funcionario()
        {

        }

        public Funcionario(int idFuncionario, string nome, decimal salario, TipoContratacao tipo)
        {
            IdFuncionario = idFuncionario;
            Nome = nome;
            Salario = salario;
            Tipo = tipo;
        }

        public override string ToString()
        {
            return $"Id: {IdFuncionario}, Nome: {Nome}, Salario: {Salario}, Tipo: {Tipo}";
        }
    }

    




}
