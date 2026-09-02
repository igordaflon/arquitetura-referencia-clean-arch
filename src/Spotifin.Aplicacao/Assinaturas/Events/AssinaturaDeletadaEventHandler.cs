using MediatR;
using Spotifin.Aplicacao.Common.Interfaces;
using Spotifin.Dominio.Usuario.Events;

namespace Spotifin.Aplicacao.Assinaturas.Events
{
    public class AssinaturaDeletadaEventHandler : INotificationHandler<AssinaturaDeletadaEvent>
    {
        private readonly IAssinaturasRepositorio _assinaturasRepositorio;
        private readonly IUnitOfWork _unitOfWork;

        public AssinaturaDeletadaEventHandler(IAssinaturasRepositorio assinaturasRepositorio, IUnitOfWork unitOfWork)
        {
            _assinaturasRepositorio = assinaturasRepositorio;
            _unitOfWork = unitOfWork;
        }

        public async Task Handle(AssinaturaDeletadaEvent notification, CancellationToken cancellationToken)
        {
            var assinaturasDeletar = await _assinaturasRepositorio.ObterPorIdAsync(notification.AssinaturaId)
                ?? throw new InvalidOperationException("Assinatura não encontrada para deletar.");

            await _assinaturasRepositorio.DeletarAsync(assinaturasDeletar);
            await _unitOfWork.CommitAsync();
        }
    }
}