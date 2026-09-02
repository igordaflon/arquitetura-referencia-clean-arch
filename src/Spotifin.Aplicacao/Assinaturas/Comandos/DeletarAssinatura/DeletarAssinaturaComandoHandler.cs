using ErrorOr;
using MediatR;
using Spotifin.Aplicacao.Common.Interfaces;

namespace Spotifin.Aplicacao.Assinaturas.Comandos.DeletarAssinatura
{
    public class DeletarAssinaturaComandoHandler : IRequestHandler<DeletarAssinaturaComando, ErrorOr<Deleted>>
    {
        private readonly IAssinaturasRepositorio _assinaturaRepositorio;
        private readonly IUsuariosRepositorio _usuariosRepositorio;
        private readonly IUnitOfWork _unitOfWork;

        public DeletarAssinaturaComandoHandler(IAssinaturasRepositorio assinaturaRepositorio,
                                               IUsuariosRepositorio usuariosRepositorio,
                                               IUnitOfWork unitOfWork)
        {
            _assinaturaRepositorio = assinaturaRepositorio;
            _usuariosRepositorio = usuariosRepositorio;
            _unitOfWork = unitOfWork;
        }

        public async Task<ErrorOr<Deleted>> Handle(DeletarAssinaturaComando request, CancellationToken cancellationToken)
        {
            var assinatura = await _assinaturaRepositorio.ObterPorIdAsync(request.AssinaturaId);
            if (assinatura is null)
            {
                return Error.NotFound(description: "Assinatura não encontrada");
            }

            var usuario = await _usuariosRepositorio.ObterPorIdAsync(assinatura.UsuarioId);
            if (usuario is null)
            {
                return Error.Unexpected(description: "Usuário não encontrado");
            }

            usuario.DeletarAssinatura(assinatura.Id);


            await _usuariosRepositorio.AtualizarAsync(usuario);
            await _unitOfWork.CommitAsync();

            return Result.Deleted;
        }
    }
}