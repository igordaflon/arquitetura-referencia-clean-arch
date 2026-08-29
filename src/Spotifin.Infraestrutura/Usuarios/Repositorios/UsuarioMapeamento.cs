using Microsoft.EntityFrameworkCore;
using Spotifin.Dominio.Usuario;

namespace Spotifin.Infraestrutura.Usuarios.Repositorios
{
    public class UsuarioMapeamento : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Usuario> builder)
        {
            builder.HasKey(e => e.Id);

            builder.Property(g => g.Id)
                        .ValueGeneratedNever();

            builder.Property(e => e.Nome)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(e => e.AssinaturaId)
                .IsRequired(false);
        }
    }
}