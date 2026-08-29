using Spotifin.Dominio.Playlists;

namespace Spotifin.Aplicacao.Common.Interfaces;

public interface IPlaylistsRepositorio
{
    Task<List<Playlist>> ObterPorAssinaturaIdAsync(Guid assinaturaId);
    Task InserirAsync(Playlist playlist);
    Task DeletarAsync(List<Playlist> playlists);
}
