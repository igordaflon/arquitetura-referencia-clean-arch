using ErrorOr;
using MediatR;
using TechFin.Spotifin.Dominio.Assinaturas;

namespace TechFin.Spotifin.Aplicacao.Assinaturas.Comandos.CriarAssinatura;

public record CriarAssinaturaComando(string TipoAssinatura, Guid UsuarioId) : IRequest<ErrorOr<Assinatura>>;

