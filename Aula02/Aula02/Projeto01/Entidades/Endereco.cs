using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto01.Entidades
{
    public class Endereco : Funcionario
    {
        private int idEndereco;
        private string logradouro;
        private string bairro;
        private string cidade;
        private string estado;
        private string cep;

        public Endereco()
        {
            //vazio
        }

        public Endereco(int idEndereco, string logradouro, string bairro, string cidade, string estado, string cep)

        {
            this.idEndereco = idEndereco;
            this.logradouro = logradouro;
            this.bairro = bairro;
            this.cidade = cidade;
            this.estado = estado;
            this.cep = cep;
        }

        public int IdEndereco { get => idEndereco; set => idEndereco = value; }
        public string Logradouro { get => logradouro; set => logradouro = value; }
        public string Bairro { get => bairro; set => bairro = value; }
        public string Cidade { get => cidade; set => cidade = value; }
        public string Estado { get => estado; set => estado = value; }
        public string Cep { get => cep; set => cep = value; }
    }
}
