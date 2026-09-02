using MediatR;
using Spotifin.Aplicacao.Common.Interfaces;
using Spotifin.Dominio.Usuario.Events;

namespace Spotifin.Aplicacao.Playlists.Events
{
    public class AssinaturaDeletadaEventHandler : INotificationHandler<AssinaturaDeletadaEvent>
    {
        private readonly IPlaylistsRepositorio _playlistsRepositorio;
        private readonly IUnitOfWork _unitOfWork;

        public AssinaturaDeletadaEventHandler(IPlaylistsRepositorio playlistsRepositorio, IUnitOfWork unitOfWork)
        {
            _playlistsRepositorio = playlistsRepositorio;
            _unitOfWork = unitOfWork;
        }

        public async Task Handle(AssinaturaDeletadaEvent notification, CancellationToken cancellationToken)
        {
            var playlistsDeletar = await _playlistsRepositorio.ObterPorAssinaturaIdAsync(notification.AssinaturaId);

            await _playlistsRepositorio.DeletarAsync(playlistsDeletar);
            await _unitOfWork.CommitAsync();
        }
    }
}