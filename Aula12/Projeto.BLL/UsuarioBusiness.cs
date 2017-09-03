using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto.Entities;
using Projeto.DAL;
using Projeto.Util;
using Projeto.BLL.Exceptions.Usuarios;
using Projeto.BLL.Specifications.Usuarios;

namespace Projeto.BLL
{
    public class UsuarioBusiness
    {
        public void CriarConta(Usuario u)
        {
            LoginUnicoSpecification spec = new LoginUnicoSpecification();
            if(spec.IsSatisfiedBy(u)) //executando a especificação..
            {
                //criptografando a senha do usuario
                u.Senha = Criptografia.GetMD5Hash(u.Senha);

                UsuarioRepositorio rep = new UsuarioRepositorio();
                rep.Insert(u); //gravando o usuário..
            }
        }

        public Usuario RealizarAutenticacao(string login, string senha)
        {
            UsuarioRepositorio rep = new UsuarioRepositorio();
            Usuario u = rep.Find(login, Criptografia.GetMD5Hash(senha));

            if(u != null) //se usuario foi encontrado..
            {
                return u; //retornando o usuario..
            }
            else
            {
                throw new AcessoNegadoException();
            }
        }
    }
}
