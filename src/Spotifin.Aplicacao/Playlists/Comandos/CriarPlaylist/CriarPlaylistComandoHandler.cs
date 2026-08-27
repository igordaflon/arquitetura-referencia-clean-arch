using ErrorOr;
using MediatR;
using Spotifin.Aplicacao.Common.Interfaces;
using Spotifin.Dominio.Playlists;

namespace Spotifin.Aplicacao.Playlists.Comandos.CriarPlaylist;

public class CriarPlaylistComandoHandler : IRequestHandler<CriarPlaylistComando, ErrorOr<Playlist>>
{
    private readonly IAssinaturasRepositorio _assinaturasRepositorio;
    private readonly IPlaylistsRepositorio _playlistsRepositorio;
    private readonly IUnitOfWork _unitOfWork;

    public CriarPlaylistComandoHandler(IAssinaturasRepositorio assinaturasRepositorio, IPlaylistsRepositorio playlistsRepositorio, IUnitOfWork unitOfWork)
    {
        _assinaturasRepositorio = assinaturasRepositorio;
        _playlistsRepositorio = playlistsRepositorio;
        _unitOfWork = unitOfWork;
    }

    public async Task<ErrorOr<Playlist>> Handle(CriarPlaylistComando request, CancellationToken cancellationToken)
    {
        var assinatura = await _assinaturasRepositorio.ObterPorIdAsync(request.AssinaturaId);

        if (assinatura is null)        
            return Error.NotFound(description: "Assinatura não encontrada.");

        var playlist = new Playlist(request.Nome, request.AssinaturaId);

        var addPlaylistResultado = assinatura.AdicionarPlaylist(playlist);

        if (addPlaylistResultado.IsError)        
            return addPlaylistResultado.Errors;        

        await _assinaturasRepositorio.AtualizarAsync(assinatura);
        await _playlistsRepositorio.InserirAsync(playlist);
        await _unitOfWork.CommitAsync();

        return playlist;
    }
}
