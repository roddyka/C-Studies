using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto.Entidades;
using Projeto.DAL;
using Projeto.BLL.Especificacoes.Usuarios;

namespace Projeto.BLL
{
    public class UsuarioBusiness
    {
        public void Cadastrar(Usuario u)
        {
            EmailUnicoSpecification spEmailUnico = new EmailUnicoSpecification();
            MaiordeIdadeSpecification spMaiorIdade = new MaiordeIdadeSpecification();

            if(spMaiorIdade.IsValid(u) && spEmailUnico.IsValid(c))
            {
                UsuarioRepositorio rep = new UsuarioRepositorio();
                rep.Insert(u);
            }
        }

        public void Atualizar(Usuario u)
        {
            MaiordeIdadeSpecification spMaiorIdade = new MaiordeIdadeSpecification();

            if (spMaiorIdade.IsValid(u))
            {
                UsuarioRepositorio rep = new UsuarioRepositorio();
                Usuario registro = rep.findById(u.IdUsuario);

                if(registro != null){
                    registro.Nome = u.Nome;
                    registro.DataNascimento = u.DataNascimento;
                    registro.Sexo = u.Sexo;
                    registro.EstadoCivil = u.EstadoCivil;
                    registro.Profissao = u.Profissao;
                    registro.Area = u.Area;
                    registro.Descricao = u.Descricao;
                    registro.PretencaoSalarial = u.PretencaoSalarial;
                    registro.Linkedin = u.Linkedin;
                    registro.Senha = u.Senha;

                    rep.Update(registro);
                }
                else
                {
                    throw new Exception("Usuario não encontrado!");
                }
            }
        }

        public void Excluir(int idUsuario)
        {
            UsuarioRepositorio rep = new UsuarioRepositorio();
            if (rep.findById(idUsuario) != null)
            {
                rep.Delete(idUsuario);
            }
            else
            {
                throw new Exception("Usuario não encontrado");
            }
        }

        public List<Usuario> Consultar()
        {
            UsuarioRepositorio rep = new UsuarioRepositorio();
            return rep.findAll();
        }

        public Usuario ObterPorId(int idUsuario)
        {
            UsuarioRepositorio rep = new UsuarioRepositorio();
            Usuario registro = rep.findById(idUsuario);

            if(registro != null)
            {
                return registro;
            }
            else
            {
                throw new Exception("Usuario não encontrado!");
            }
        }
    }
}
