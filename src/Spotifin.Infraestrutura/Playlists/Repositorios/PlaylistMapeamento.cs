using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Spotifin.Dominio.Playlists;

namespace Spotifin.Infraestrutura.Playlists.Repositorios
{
    public class PlaylistMapeamento : IEntityTypeConfiguration<Playlist>
    {
        public void Configure(EntityTypeBuilder<Playlist> builder)
        {
            builder.HasKey(g => g.Id);

        builder.Property(g => g.Id)
            .ValueGeneratedNever();

        builder.Property(g => g.Nome);

        builder.Property(g => g.AssinaturaId);
        }
    }
}
