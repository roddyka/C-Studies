using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Projeto.Entities;
using Projeto.BLL;
using Projeto.BLL.Exceptions.Usuarios;

namespace Projeto.BLL.Test
{
    [TestClass]
    public class UsuarioBusinessTest
    {
        [TestMethod]
        public void TestCriarConta()
        {
            try
            {
                Usuario u = new Usuario();
                u.Nome  = "Sergio Mendes";
                u.Login = $"smendes{new Random().Next(10000).ToString()}";
                u.Senha = "adminadmin";
                u.Foto  = $"foto{new Random().Next(10000).ToString()}.jpg";

                UsuarioBusiness business = new UsuarioBusiness();
                business.CriarConta(u);

                Assert.IsTrue(u.IdUsuario > 0);
            }
            catch(Exception ex)
            {
                //gerar um status de falha no teste..
                Assert.Fail(ex.Message);
            }
        }

        [TestMethod]
        [ExpectedException(typeof(AcessoNegadoException))]
        public void TestAcessoNegado()
        {
            UsuarioBusiness business = new UsuarioBusiness();
            business.RealizarAutenticacao("teste", "teste");
        }

    }
}
