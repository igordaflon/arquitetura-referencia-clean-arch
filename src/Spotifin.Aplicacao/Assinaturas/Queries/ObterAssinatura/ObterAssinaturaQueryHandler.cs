using ErrorOr;
using MediatR;
using Spotifin.Aplicacao.Assinaturas.Queries.ObterAssinatura;
using Spotifin.Aplicacao.Common.Interfaces;
using Spotifin.Dominio.Assinaturas;

public class ObterAssinaturaQueryHandler : IRequestHandler<ObterAssinaturaQuery, ErrorOr<Assinatura>>
{
    private readonly IAssinaturasRepositorio _assinaturasRepositorio;

    public ObterAssinaturaQueryHandler(IAssinaturasRepositorio assinaturasRepositorio)
    {
        _assinaturasRepositorio = assinaturasRepositorio;
    }

    public async Task<ErrorOr<Assinatura>> Handle(ObterAssinaturaQuery query, CancellationToken cancellationToken)
    {
        var assinatura = await _assinaturasRepositorio.ObterPorIdAsync(query.Id);

        return assinatura is null
            ? Error.NotFound(description: "Assinatura não encontrada")
            : assinatura;
    }
}
