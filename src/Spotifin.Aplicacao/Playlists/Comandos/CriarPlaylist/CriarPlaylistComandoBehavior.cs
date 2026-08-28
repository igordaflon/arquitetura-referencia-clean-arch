using ErrorOr;
using MediatR;
using Spotifin.Dominio.Playlists;

namespace Spotifin.Aplicacao.Playlists.Comandos.CriarPlaylist
{
    public class CriarPlaylistComandoBehavior : IPipelineBehavior<CriarPlaylistComando, ErrorOr<Playlist>>
    {
        public async Task<ErrorOr<Playlist>> Handle(CriarPlaylistComando request, RequestHandlerDelegate<ErrorOr<Playlist>> next, CancellationToken cancellationToken)
        {
            var validator = new CriarPlaylistCommandValidator();

            var validationResult = await validator.ValidateAsync(request);

            if (!validationResult.IsValid)
            {
                return validationResult.Errors
                    .Select(error => Error.Validation(code: error.PropertyName, description: error.ErrorMessage)).ToList();
            }

            return await next();
        }
    }
}