using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto01.Entities
{
    public class Departamento
    {
        private int idDepto;
        private string nome;


        public Departamento()
        {
                
        }
        public Departamento(int idDepto, string nome)
        {
            this.idDepto = idDepto;
            this.nome = nome;
        }

        public int IdDepto { get => idDepto; set => idDepto = value; }
        public string Nome { get => nome; set => nome = value; }
    }
}
