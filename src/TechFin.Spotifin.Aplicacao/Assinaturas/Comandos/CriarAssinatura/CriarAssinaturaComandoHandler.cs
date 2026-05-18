using ErrorOr;
using MediatR;
using TechFin.Spotifin.Aplicacao.Core.Interfaces;
using TechFin.Spotifin.Dominio.Assinaturas;

namespace TechFin.Spotifin.Aplicacao.Assinaturas.Comandos.CriarAssinatura;

public class CriarAssinaturaComandoHandler : IRequestHandler<CriarAssinaturaComando, ErrorOr<Assinatura>>
{
    private readonly IAssinaturasRepositorio _assinaturasRepositorio;
    private readonly IUnitOfWork _unitOfWork;

    public CriarAssinaturaComandoHandler(IAssinaturasRepositorio assinaturasRepositorio, IUnitOfWork unitOfWork)
    {
        _assinaturasRepositorio = assinaturasRepositorio;
        _unitOfWork = unitOfWork;
    }

    public async Task<ErrorOr<Assinatura>> Handle(CriarAssinaturaComando request, CancellationToken cancellationToken)
    {
        var assinatura = new Assinatura(request.TipoAssinatura, request.UsuarioId);

        await _assinaturasRepositorio.AdicionarAsync(assinatura);
        await _unitOfWork.CommitAsync();

        return assinatura;
    }
}
