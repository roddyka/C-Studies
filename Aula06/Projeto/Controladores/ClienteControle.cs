using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto.Entidades;
using Projeto.Repositorios;

namespace Projeto.Controladores
{
    public class ClienteControle
    {
        public void CadastrarCliente()
        {

            try
            {
                Console.WriteLine("\n - CADASTRO DE CLIENTE - \n");

                Cliente c = new Cliente();

                Console.WriteLine("Nome do Cliente...: ");
                c.Nome = Console.ReadLine();

                Console.WriteLine("Email do Cliente...: ");
                c.Email = Console.ReadLine();

                ClienteRepositorio rep = new ClienteRepositorio();
                if (!rep.EmailJaCadastrado(c.Email))
                {
                    rep.Inserir(c);
                    Console.WriteLine("\nCliente cadastrado com sucesso!");
                }
                else
                {
                    Console.WriteLine("\nEste email ja foi cadastrado!");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro: "+ e.Message);
            }

        }
        
    }
}
