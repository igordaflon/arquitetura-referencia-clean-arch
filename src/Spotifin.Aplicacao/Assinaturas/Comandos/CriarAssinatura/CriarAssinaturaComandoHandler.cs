using ErrorOr;
using MediatR;
using Spotifin.Aplicacao.Common.Interfaces;
using Spotifin.Dominio.Assinaturas;

namespace Spotifin.Aplicacao.Assinaturas.Comandos.CriarAssinatura;

public class CriarAssinaturaComandoHandler : IRequestHandler<CriarAssinaturaComando, ErrorOr<Assinatura>>
{
    private readonly IAssinaturasRepositorio _assinaturasRepositorio;
    private readonly IUsuariosRepositorio _usuarioRepositorio;
    private readonly IUnitOfWork _unitOfWork;

    public CriarAssinaturaComandoHandler(IAssinaturasRepositorio assinaturasRepositorio, IUsuariosRepositorio usuarioRepositorio, IUnitOfWork unitOfWork)
    {
        _assinaturasRepositorio = assinaturasRepositorio;
        _usuarioRepositorio = usuarioRepositorio;
        _unitOfWork = unitOfWork;
    }

    public async Task<ErrorOr<Assinatura>> Handle(CriarAssinaturaComando request, CancellationToken cancellationToken)
    {
        var usuario = await _usuarioRepositorio.ObterPorIdAsync(request.UsuarioId);
        if (usuario is null)        
            return Error.NotFound(description: "Usuário não encontrado");        

        // Criar a assinatura usando os dados do comando
        var assinatura = new Assinatura(request.TipoAssinatura,
                                         request.UsuarioId);

        var resultadoInserirAssinatura = usuario.InserirAssinatura(assinatura.Id);
        if (resultadoInserirAssinatura.IsError)
            return resultadoInserirAssinatura.Errors;

        // Persistir a assinatura no repositório
        await _assinaturasRepositorio.InserirAsync(assinatura);
        await _usuarioRepositorio.AtualizarAsync(usuario);
        await _unitOfWork.CommitAsync();   

        //Retornar assinatura 
        return assinatura;
    }
}
