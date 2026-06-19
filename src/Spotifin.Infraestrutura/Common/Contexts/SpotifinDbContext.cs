using Microsoft.EntityFrameworkCore;
using Spotifin.Dominio.Assinaturas;

namespace Spotifin.Infraestrutura.Common.Contexts;

public class SpotifinDbContext : DbContext
{
    public SpotifinDbContext(DbContextOptions<SpotifinDbContext> options)
        : base(options)
    {
    }

    public DbSet<Assinatura> Assinaturas { get; set; } = null!;
}