using MediatR;

namespace Spotifin.Aplicacao.Assinaturas.Comandos;

public record CriarAssinaturaComando(string TipoAssinatura,
                                     Guid UsuarioId) : IRequest<Guid>;
