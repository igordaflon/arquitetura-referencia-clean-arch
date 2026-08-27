using Spotifin.Dominio.Playlists;
using ErrorOr;

namespace Spotifin.Dominio.Assinaturas;

public class Assinatura
{
    public Guid Id { get; private set; }
    public TipoAssinaturaEnum TipoAssinatura { get; private set; }

    private readonly Guid _usuarioId;

    private readonly List<Guid> _playlistIds = new List<Guid>();

    public Assinatura(TipoAssinaturaEnum tipoAssinatura, Guid usuarioId)
    {
        Id = Guid.NewGuid();
        TipoAssinatura = tipoAssinatura;
        _usuarioId = usuarioId;
    }

    private Assinatura() { }

    public ErrorOr<Success> AdicionarPlaylist(Playlist playlist)
    {
        if (playlist.AssinaturaId != Id)
            throw new InvalidOperationException("Não é possível adicionar uma playlist de outra assinatura.");

        if (_playlistIds.Count >= TipoAssinatura.LimitePlaylist)        
            return AssinaturaErros.NaoPodeAdicionarMaisPlaylistsQueAAssinaturaPermite;        

        _playlistIds.Add(playlist.Id);

        return Result.Success;
    }
}