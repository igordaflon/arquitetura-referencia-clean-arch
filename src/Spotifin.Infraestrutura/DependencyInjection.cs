using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Spotifin.Aplicacao.Common.Interfaces;
using Spotifin.Infraestrutura.Assinaturas.Repositorios;
using Spotifin.Infraestrutura.Common.Contexts;

namespace Spotifin.Infraestrutura;

public static class DependencyInjection
{
    public static IServiceCollection AddInfraestrutura(this IServiceCollection servicos)
    {
        servicos.AddDbContext<SpotifinDbContext>(options => 
            options.UseSqlite("Data Source=SpotifinDb.db"));

        servicos.AddScoped<IAssinaturasRepositorio, AssinaturasRepositorio>();

        return servicos;
    }
}