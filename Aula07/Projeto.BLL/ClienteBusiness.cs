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

    }
}
