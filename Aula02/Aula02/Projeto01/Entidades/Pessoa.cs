using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto01.Entidades
{
    public class Pessoa
    {
        //atributos
        private string nome;
        private DateTime dataNascimento;

        public Pessoa()
        {

        }

        public Pessoa(string nome, DateTime dataNascimento)
        {
            this.nome = nome;
            this.dataNascimento = dataNascimento;
        }
        //metodo de encapsulamento(set/get)
        //propriedades
        public string Nome
        {
            set { nome = value; }
            get { return nome; }
        }

        public DateTime DataNascimento
        {
            set { dataNascimento = value; }
            get { return dataNascimento; }
        }

    }
}
