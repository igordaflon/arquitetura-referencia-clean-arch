using ErrorOr;
using MediatR;
using Spotifin.Aplicacao.Common.Interfaces;
using Spotifin.Dominio.Assinaturas;

namespace Spotifin.Aplicacao.Assinaturas.Comandos.CriarAssinatura;

public class CriarAssinaturaComandoHandler : IRequestHandler<CriarAssinaturaComando, ErrorOr<Assinatura>>
{
    private readonly IAssinaturasRepositorio _assinaturasRepositorio;
    private readonly IUnitOfWork _unitOfWork;

    public CriarAssinaturaComandoHandler(IAssinaturasRepositorio assinaturasRepositorio,
                                         IUnitOfWork unitOfWork)
    {
        _assinaturasRepositorio = assinaturasRepositorio;
        _unitOfWork = unitOfWork;
    }

    public async Task<ErrorOr<Assinatura>> Handle(CriarAssinaturaComando request, CancellationToken cancellationToken)
    {
        // Criar a assinatura usando os dados do comando
        var assinatura = new Assinatura
        {
            Id = Guid.NewGuid()
        };

        // Persistir a assinatura no repositório
        await _assinaturasRepositorio.InserirAsync(assinatura);
        await _unitOfWork.CommitAsync();   

        //Retornar assinatura 
        return assinatura;
    }
}
