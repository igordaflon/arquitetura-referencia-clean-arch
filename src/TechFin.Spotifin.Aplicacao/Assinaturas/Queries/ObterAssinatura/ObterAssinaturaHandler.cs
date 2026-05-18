using ErrorOr;
using MediatR;
using TechFin.Spotifin.Aplicacao.Assinaturas.Comandos.CriarAssinatura;
using TechFin.Spotifin.Aplicacao.Core.Interfaces;
using TechFin.Spotifin.Dominio.Assinaturas;

namespace TechFin.Spotifin.Aplicacao.Assinaturas.Queries.ObterAssinatura;

public class ObterAssinaturaHandler : IRequestHandler<ObterAssinaturaQuery, ErrorOr<Assinatura>>
{
    private readonly IAssinaturasRepositorio _assinaturasRepositorio;

    public ObterAssinaturaHandler(IAssinaturasRepositorio assinaturasRepositorio)
    {
        _assinaturasRepositorio = assinaturasRepositorio;
    }

    public async Task<ErrorOr<Assinatura>> Handle(ObterAssinaturaQuery request, CancellationToken cancellationToken)
    {
        var assinatura = await _assinaturasRepositorio.ObterPorIdAsync(request.AssinaturaId);

        return assinatura is null
            ? Error.NotFound(description: "Assinatura não encontrada")
            : assinatura;
    }
}

