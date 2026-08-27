using ErrorOr;
using MediatR;
using Spotifin.Dominio.Playlists;

namespace Spotifin.Aplicacao.Playlists.Comandos.CriarPlaylist
{
    public record CriarPlaylistComando(string Nome, Guid AssinaturaId) : IRequest<ErrorOr<Playlist>>;
}
