using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto02.Entidades
{
    public class Aluno
    {
        //atributos
        private int idAluno;
        private string nome;

        //construtor
        public Aluno()
        {

        }

        public Aluno(int idAluno, string nome)
        {
            this.idAluno = idAluno;
            this.nome = nome;
        }

        public int IdAluno { get => idAluno; set => idAluno = value; }
        public string Nome { get => nome; set => nome = value; }
    }
}
