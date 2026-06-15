using MediatR;

namespace Spotifin.Aplicacao.Assinaturas.Comandos;

public class CriarAssinaturaComandoHandler : IRequestHandler<CriarAssinaturaComando, Guid>
{
    public Task<Guid> Handle(CriarAssinaturaComando request, CancellationToken cancellationToken)
    {
        return Task.FromResult(Guid.NewGuid());
    }
}
