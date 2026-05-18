using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using TechFin.Spotifin.Aplicacao.Core.Interfaces;
using TechFin.Spotifin.Infra.Assinaturas.Repositorio;
using TechFin.Spotifin.Infra.Contexts;

namespace TechFin.Spotifin.Infra;

public static class InjecaoDependencia
{
    public static IServiceCollection AddInfra(this IServiceCollection services)
    {
        services.AddDbContext<SpotifinDbContext>(options =>
        {
            options.UseSqlite("Data Source = spotifin.db");
        });

        services.AddScoped<IAssinaturasRepositorio, AssinaturasRepositorio>();
        services.AddScoped<IUnitOfWork>(serviceProvider => serviceProvider.GetRequiredService<SpotifinDbContext>());

        return services;
    }
}
