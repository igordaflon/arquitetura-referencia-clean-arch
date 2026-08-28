using FluentValidation;

namespace Spotifin.Aplicacao.Playlists.Comandos.CriarPlaylist
{
    public class CriarPlaylistCommandValidator : AbstractValidator<CriarPlaylistComando>
    {
            public CriarPlaylistCommandValidator()
            {
                RuleFor(x => x.Nome)
                    .MinimumLength(3).WithMessage("O campo {PropertyName} deve ter no mínimo {MinLength} caracteres.")
                    .MaximumLength(100).WithMessage("O campo {PropertyName} não pode exceder {MaxLength} caracteres.");
            }
    }
}
