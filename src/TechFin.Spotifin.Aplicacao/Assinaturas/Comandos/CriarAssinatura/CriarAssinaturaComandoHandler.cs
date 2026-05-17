using ErrorOr;
using MediatR;
using TechFin.Spotifin.Aplicacao.Core.Interfaces;
using TechFin.Spotifin.Dominio.Assinaturas;

namespace TechFin.Spotifin.Aplicacao.Assinaturas.Comandos.CriarAssinatura;

public class CriarAssinaturaComandoHandler : IRequestHandler<CriarAssinaturaComando, ErrorOr<Assinatura>>
{
    private readonly IAssinaturasRepositorio _assinaturasRepositorio;

    public CriarAssinaturaComandoHandler(IAssinaturasRepositorio assinaturasRepositorio)
    {
        _assinaturasRepositorio = assinaturasRepositorio;
    }

    public async Task<ErrorOr<Assinatura>> Handle(CriarAssinaturaComando request, CancellationToken cancellationToken)
    {
        var assinatura = new Assinatura
        {
            Id = Guid.NewGuid()
        };

        _assinaturasRepositorio.Adicionar(assinatura);

        return assinatura;
    }
}
