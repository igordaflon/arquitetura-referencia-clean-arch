namespace Spotifin.Dominio.Playlists
{
    public class Playlist
    {
        public Guid Id { get; }
        public string Nome { get; init; } = null!;

        public Guid AssinaturaId { get; init; }

        public Playlist(string nome, Guid assinaturaId, Guid? id = null)
        {
            Id = id ?? Guid.NewGuid();
            Nome = nome;
            AssinaturaId = assinaturaId;
        }

        private Playlist() { }
    }
}
