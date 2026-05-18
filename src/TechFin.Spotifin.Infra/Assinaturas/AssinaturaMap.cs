using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using TechFin.Spotifin.Dominio.Assinaturas;

namespace TechFin.Spotifin.Infra.Assinaturas
{
    public class AssinaturaMap : IEntityTypeConfiguration<Assinatura>
    {
        public void Configure(EntityTypeBuilder<Assinatura> builder)
        {
            builder.HasKey(s => s.Id);

            builder.Property(s => s.Id)
                .ValueGeneratedNever();

            builder.Property(s => s.UsuarioId);

            builder.Property(s => s.TipoAssinatura)
                .HasConversion(
                    subscriptionType => subscriptionType.Value,
                    value => TipoAssinatura.FromValue(value));
        }
    }
}
