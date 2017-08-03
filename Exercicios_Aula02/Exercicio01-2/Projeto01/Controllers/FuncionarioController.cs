using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto01.Entities;
using Projeto01.Entities.types;
using Projeto01.Contract;

namespace Projeto01.Controllers
{
    class FuncionarioController
    {
        private IFuncionarioRepositorio repositorio;

        public FuncionarioController(IFuncionarioRepositorio repositorio)
        {
            this.repositorio = repositorio;
        }

        public void CadastrarFuncionario()
        {
            try
            {
                
                List<Programador> lista = new List<Programador>();
                lista.Add(new Programador(1,"Rodrigo",Sexo.Masculino,EstadoCivil.Solteiro,1000,1,Departamento.CSharp));

                repositorio.Exportar(lista);

                Console.WriteLine("Dados Gravados...");

            }catch(Exception e)
            {
                Console.WriteLine("Erro..:" + e.Message);
            }
        }
    }
}
