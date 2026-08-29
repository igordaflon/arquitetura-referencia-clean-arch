using Spotifin.Dominio.Usuario;

namespace Spotifin.Aplicacao.Common.Interfaces
{
    public interface IUsuariosRepositorio
    {
        Task<Usuario?> ObterPorIdAsync(Guid usuarioId);
        Task AtualizarAsync(Usuario usuario);
    }
}