using Spotifin.Dominio.Playlists;

namespace Spotifin.Aplicacao.Common.Interfaces;

public interface IPlaylistsRepositorio
{
    Task InserirAsync(Playlist playlist);
}
