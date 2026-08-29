using ErrorOr;
using MediatR;

namespace Spotifin.Aplicacao.Assinaturas.Comandos.DeletarAssinatura
{
    public record DeletarAssinaturaComando(Guid AssinaturaId) : IRequest<ErrorOr<Deleted>>;
}