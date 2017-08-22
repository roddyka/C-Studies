using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto.Entidades;
using Projeto.BLL.Excecoes.Clientes;
using Projeto.DAL;

namespace Projeto.BLL.Especificacoes.Clientes
{
    public class EmailUnicoSpecification
    {
        public bool IsValid(Cliente c)
        {
            ClienteRepositorio rep = new ClienteRepositorio();

            if (rep.HasEmail(c.Email))
            {
                throw new EmailJaCadastradoException(c.Email);
            }
            return true;
        }
    }
}
