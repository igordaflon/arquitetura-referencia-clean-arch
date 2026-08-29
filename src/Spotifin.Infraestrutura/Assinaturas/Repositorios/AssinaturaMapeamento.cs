using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Spotifin.Dominio.Assinaturas;
using Spotifin.Infraestrutura.Common;

namespace Spotifin.Infraestrutura.Assinaturas.Repositorios;

public class AssinaturaMapeamento : IEntityTypeConfiguration<Assinatura>
{
    public void Configure(EntityTypeBuilder<Assinatura> builder)
    {
        builder.HasKey(a => a.Id);

        builder.Property(a => a.Id)
            .ValueGeneratedNever();

        builder.Property(a => a.TipoAssinatura)
            .HasConversion(
                tipoAssinatura => tipoAssinatura.Value,
                value => TipoAssinaturaEnum.FromValue(value));

        builder.Property(a => a.UsuarioId)
            .IsRequired();

        builder.Property<List<Guid>>("_playlistIds")
            .HasColumnName("PlaylistIds")
            .HasListOfIdsConverter();
    }
}

