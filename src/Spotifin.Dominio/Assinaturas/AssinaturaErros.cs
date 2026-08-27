using ErrorOr;

namespace Spotifin.Dominio.Assinaturas
{
    public static class AssinaturaErros
    {
        public static readonly Error NaoPodeAdicionarMaisPlaylistsQueAAssinaturaPermite = Error.Validation(
            code: "Assinatura.NaoPodeAdicionarMaisPlaylistsQueAAssinaturaPermite",
            description: "O limite de playlists para o tipo de assinatura foi atingido.");
    }
}
