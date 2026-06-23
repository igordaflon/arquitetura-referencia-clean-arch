using ErrorOr;
using MediatR;
using Spotifin.Dominio.Assinaturas;

namespace Spotifin.Aplicacao.Assinaturas.Comandos.CriarAssinatura;

public record CriarAssinaturaComando(TipoAssinaturaEnum TipoAssinatura,
                                     Guid UsuarioId) : IRequest<ErrorOr<Assinatura>>;
