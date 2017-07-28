using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto01.Entidades;
using Projeto01.Entidades.Tipos;
using Projeto01.Contratos;

namespace Projeto01.Controladores
{
    public class ClienteControler
    {
        private IClienteRepositorio repositorio;

        public ClienteControler(IClienteRepositorio repositorio)
        {
            this.repositorio = repositorio;
        }



        //metodo para cadastrar clientes...
        public void cadastrarCliente()
        {
            try
            {
                List<Cliente> lista = new List<Cliente>();

                lista.Add(new Cliente(1,"Rodrigo",Sexo.Masculino,EstadoCivil.Solteiro));
                lista.Add(new Cliente(2, "Bruno", Sexo.Masculino, EstadoCivil.Solteiro));
                lista.Add(new Cliente(3, "Felipe", Sexo.Masculino, EstadoCivil.Solteiro));

                //exportar

                repositorio.Exportar(lista);

                Console.WriteLine("\n Dados Gravados com Sucesso...");
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro: " + e.Message);
            }
        }
    }
}
