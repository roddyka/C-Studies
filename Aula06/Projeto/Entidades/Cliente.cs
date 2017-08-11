using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Entidades
{
    public class Cliente
    {

        //propriedades...
        public int IdCliente { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public DateTime DataCadastro { get; set; }

        public Cliente()
        {
            //default
        }

        public Cliente(int idCliente, string nome, string email, DateTime dataCadastro)
        {
            IdCliente = idCliente;
            Nome = nome;
            Email = email;
            DataCadastro = dataCadastro;
        }

        //sobrescrita de método
        public override string ToString()
        {
            return $"Id: {IdCliente}, Nome: {Nome}, Email: {Email}, Data de Cadastro: {DataCadastro}";
        }
    }

    
}
