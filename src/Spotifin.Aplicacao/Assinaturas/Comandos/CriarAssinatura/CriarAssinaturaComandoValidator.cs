namespace Spotifin.Aplicacao.Assinaturas.Comandos.CriarAssinatura
{
    using FluentValidation;

    public class CriarAssinaturaComandoValidator : AbstractValidator<CriarAssinaturaComando>
    {
        public CriarAssinaturaComandoValidator()
        {
            RuleFor(x => x.TipoAssinatura)
                .NotEmpty()
                .WithMessage("Tipo de assinatura é obrigatório.");

            RuleFor(x => x.UsuarioId)
                .NotEmpty()
                .WithMessage("Id do usuário é obrigatório.");
        }
    }
}