using ErrorOr;
using MediatR;
using TechFin.Spotifin.Dominio.Assinaturas;

namespace TechFin.Spotifin.Aplicacao.Assinaturas.Comandos.CriarAssinatura;

public record CriarAssinaturaComando(TipoAssinatura TipoAssinatura, Guid UsuarioId) : IRequest<ErrorOr<Assinatura>>;

