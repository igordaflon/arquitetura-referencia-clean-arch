using FluentValidation;

namespace Spotifin.Aplicacao.Assinaturas.Comandos.DeletarAssinatura
{
    public class DeletarAssinaturaComandoValidator : AbstractValidator<DeletarAssinaturaComando>
    {
        public DeletarAssinaturaComandoValidator()
        {
            RuleFor(x => x.AssinaturaId)
                .NotEmpty()
                .WithMessage("Id da assinatura é obrigatório.");
        }
    }
}