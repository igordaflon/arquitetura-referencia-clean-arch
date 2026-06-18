using ErrorOr;
using MediatR;
using Spotifin.Dominio.Assinaturas;

namespace Spotifin.Aplicacao.Assinaturas.Queries.ObterAssinatura;

public record ObterAssinaturaQuery(Guid Id) : IRequest<ErrorOr<Assinatura>>;
