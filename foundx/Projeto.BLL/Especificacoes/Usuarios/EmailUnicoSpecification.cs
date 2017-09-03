using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto.Entidades;
using Projeto.BLL.Excecoes.Usuarios;
using Projeto.DAL;

namespace Projeto.BLL.Especificacoes.Usuarios
{
    public class EmailUnicoSpecification
    {
        public bool IsValid(Usuario u)
        {
            UsuarioRepositorio rep = new UsuarioRepositorio();

            if (rep.HasEmail(u.Email))
            {
                throw new EmailJaCadastradoException(u.Email);
            }
            return true;
        }

    }
}
