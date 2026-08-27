using Microsoft.EntityFrameworkCore;
using Spotifin.Aplicacao.Common.Interfaces;
using Spotifin.Dominio.Assinaturas;
using Spotifin.Dominio.Playlists;

namespace Spotifin.Infraestrutura.Common.Contexts;

public class SpotifinDbContext : DbContext, IUnitOfWork
{
    public SpotifinDbContext(DbContextOptions<SpotifinDbContext> options)
        : base(options)
    {
    }

    public DbSet<Assinatura> Assinaturas { get; set; } = null!;
    public DbSet<Playlist> Playlists { get; set; } = null!;

    public async Task CommitAsync()
    {
        await base.SaveChangesAsync();
    }

    override protected void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(SpotifinDbContext).Assembly);
    }
}