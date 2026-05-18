using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using TechFin.Spotifin.Aplicacao.Core.Interfaces;
using TechFin.Spotifin.Dominio.Assinaturas;

namespace TechFin.Spotifin.Infra.Contexts
{
    public class SpotifinDbContext : DbContext, IUnitOfWork
    {
        public SpotifinDbContext(DbContextOptions options) : base(options) { }

        public DbSet<Assinatura> Assinaturas { get; set; } = null!;

        override protected void OnModelCreating(ModelBuilder modelBuilder)
        {            
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(modelBuilder);
        }

        public async Task CommitAsync()
        {
            await base.SaveChangesAsync();
        }
    }
}
