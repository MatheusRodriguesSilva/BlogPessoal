using Blogpessoal.src.modelos;
using BlogPessoal.src.data;
using Microsoft.EntityFrameworkCore;

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace BlogPessoalTest.Testes.data
{
    [TestClass]
    public class BlogPessoalContextoTeste
    {
        private BlogPessoalContexto _contexto;

        [TestInitialize]
        public void inicio()
        {
            var opt = new DbContextOptionsBuilder<BlogPessoalContexto>()
                .UseInMemoryDatabase(databaseName: "db_blogpessoal")
                .Options;

            _contexto = new BlogPessoalContexto(opt);
        }


        [TestMethod]
        public void IserirNovoUsuarioNoBancoRetornarUsuario()
        {
            UsuarioModelo usuario = new UsuarioModelo();
            usuario.Nome = "Matheus Boaz";
            usuario.Email = "matheus@email.com";
            usuario.Senha = "123456";
            usuario.Foto = "AKITAOLINKDAFOTO";

            _contexto.Usuarios.Add(usuario);

            _contexto.SaveChanges();

            Assert.IsNotNull(_contexto.Usuarios.FirstOrDefault(u => u.Email == "matheus@email.com"));
        }
    }
}