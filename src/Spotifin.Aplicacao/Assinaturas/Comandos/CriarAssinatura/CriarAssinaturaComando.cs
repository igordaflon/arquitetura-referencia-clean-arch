using ErrorOr;
using MediatR;
using Spotifin.Dominio.Assinaturas;

namespace Spotifin.Aplicacao.Assinaturas.Comandos.CriarAssinatura;

public record CriarAssinaturaComando(string TipoAssinatura,
                                     Guid UsuarioId) : IRequest<ErrorOr<Assinatura>>;
