using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto.Entities;
using Projeto.DAL;
using Projeto.BLL.Exceptions.Usuarios;

namespace Projeto.BLL.Specifications.Usuarios
{
    public class LoginUnicoSpecification
    {
        public bool IsSatisfiedBy(Usuario u)
        {
            UsuarioRepositorio rep = new UsuarioRepositorio();

            if(rep.HasLogin(u.Login))
            {
                throw new LoginJaExistenteException(u.Login);
            }
            
            return true;
        }
    }
}
