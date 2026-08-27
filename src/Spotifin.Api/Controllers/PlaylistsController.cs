using MediatR;
using Microsoft.AspNetCore.Mvc;
using Spotifin.Aplicacao.Playlists.Comandos.CriarPlaylist;
using Spotifin.Contratos.Playlists;

namespace Spotifin.Api.Controllers
{
    [Route("assinaturas/{assinaturaId}/playlists")]
    public class PlaylistsController : ApiController
    {
        private readonly ISender _mediator;

        public PlaylistsController(ISender mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> CriarPlaylist(CriarPlaylistRequest request, Guid assinaturaId)
        {
            var command = new CriarPlaylistComando(request.Nome, assinaturaId);

            var criarPlaylistResultado = await _mediator.Send(command);

            return criarPlaylistResultado.Match(
                playlist => CreatedAtAction(
                    nameof(ObterPlaylist),
                    new { assinaturaId, PlaylistId = playlist.Id },
                    new PlaylistResponse(playlist.Id, playlist.Nome)),
                Problem);
        }

        [HttpGet("{playlistId:guid}")]
        public async Task<IActionResult> ObterPlaylist(Guid assinaturaId, Guid playlistId)
        {
            throw new NotImplementedException();
        }
    }
}
