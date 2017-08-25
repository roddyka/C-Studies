using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto.Entidades;
using Projeto.DAL;
using Projeto.BLL.Especificacoes.Clientes;

namespace Projeto.BLL
{
    public class ClienteBusiness
    {
        public void Cadastrar(Cliente c)
        {
            EmailUnicoSpecification spEmailUnico = new EmailUnicoSpecification();
            MaiorDeIdadeSpecification spMaiorIdade = new MaiorDeIdadeSpecification();

            if (spMaiorIdade.IsValid(c) && spEmailUnico.IsValid(c))
            {
                ClienteRepositorio rep = new ClienteRepositorio();
                rep.Insert(c);
            }
        }

        public void Atualizar(Cliente c)
        {
            MaiorDeIdadeSpecification spMaiorIdade = new MaiorDeIdadeSpecification();

            if (spMaiorIdade.IsValid(c))
            {
                ClienteRepositorio rep = new ClienteRepositorio();
                Cliente registro = rep.findById(c.IdCliente);

                if (registro != null)
                { 
                    registro.Nome = c.Nome;
                    registro.DataNascimento = c.DataNascimento;
                    registro.Sexo = c.Sexo;
                    registro.EstadoCivil = c.EstadoCivil;

                    rep.Update(registro);
                }
                else
                {
                    throw new Exception("Cliente não encontrado.");
                }
            }
        }

        public void Excluir(int idCliente)
        {
            ClienteRepositorio rep = new ClienteRepositorio();
            if(rep.findById(idCliente) != null)
            {
                rep.Delete(idCliente);
            }
            else
            {
                throw new Exception("Cliente não encontrado.");
            }
        }

        public List<Cliente> Consultar()
        {
            ClienteRepositorio rep = new ClienteRepositorio();
            return rep.findAll();
        }

        public Cliente ObterPorId(int idCliente)
        {
            ClienteRepositorio rep = new ClienteRepositorio();
            Cliente registro = rep.findById(idCliente);

            if(registro != null)
            {
                return registro;
            }
            else
            {
                throw new Exception("Cliente não encontrado.");
            }
        }

    }
}
