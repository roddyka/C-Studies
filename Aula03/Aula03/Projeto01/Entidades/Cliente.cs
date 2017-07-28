using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto01.Entidades.Tipos; //Enums

namespace Projeto01.Entidades
{
    public class Cliente
    {

        private int idCliente;
        private string nome;

        public Cliente()
        {

        }

        public Cliente(int idCliente, string nome, Sexo sexo, EstadoCivil estadoCivil)
        {
            IdCliente = idCliente;
            Nome = nome;
            Sexo = sexo;
            EstadoCivil = estadoCivil;
        }

        public int IdCliente  { get; set; }
        public string Nome { get; set; }
        public Sexo Sexo { get; set; }
        public EstadoCivil EstadoCivil { get; set; }

    }
}
