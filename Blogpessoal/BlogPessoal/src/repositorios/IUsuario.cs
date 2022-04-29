using Blogpessoal.src.modelos;
using BlogPessoal.src.dtos;

namespace BlogPessoal.src.repositorios
{
    /// <summary>
    /// <para>Resumo: Responsavel por representar ações de Crud de usuario</para>
    /// <para>Criado por: Matheus Rodrigues</para>
    /// <para>Versão: 1.0</para>
    /// <para>Data: 29/04/2022</para>
    /// </summary>
    public interface IUsuario
    {
        void NovoUsuario(NovoUsuarioDTO usuario);
        void AtualizarUsuario(AtualizarUsuarioDTO usuario);
        void DeletarUsuario(int id);
        UsuarioModelo PegarusuarioPeloID(int id);
        UsuarioModelo PegarUsuarioPeloEmail(string email);
        UsuarioModelo PegarUsuarioPeloNome(string nome);
    }
}
