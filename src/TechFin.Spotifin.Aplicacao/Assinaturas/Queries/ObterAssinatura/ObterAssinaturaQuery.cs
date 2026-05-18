using ErrorOr;
using MediatR;
using TechFin.Spotifin.Dominio.Assinaturas;

namespace TechFin.Spotifin.Aplicacao.Assinaturas.Queries.ObterAssinatura
{
    public record ObterAssinaturaQuery(Guid AssinaturaId) : IRequest<ErrorOr<Assinatura>>;
}
