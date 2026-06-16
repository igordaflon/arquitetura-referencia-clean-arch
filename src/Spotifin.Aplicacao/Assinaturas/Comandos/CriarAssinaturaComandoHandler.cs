using ErrorOr;
using MediatR;

namespace Spotifin.Aplicacao.Assinaturas.Comandos;

public class CriarAssinaturaComandoHandler : IRequestHandler<CriarAssinaturaComando, ErrorOr<Guid>>
{
    public async Task<ErrorOr<Guid>> Handle(CriarAssinaturaComando request, CancellationToken cancellationToken)
    {
        return Guid.NewGuid();
    }
}
