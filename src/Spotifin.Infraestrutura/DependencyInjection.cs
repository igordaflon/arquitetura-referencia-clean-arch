using Microsoft.Extensions.DependencyInjection;
using Spotifin.Aplicacao.Common.Interfaces;
using Spotifin.Infraestrutura.Assinaturas.Repositorios;

namespace Spotifin.Infraestrutura;

public static class DependencyInjection
{
    public static IServiceCollection AddInfraestrutura(this IServiceCollection servicos)
    {
        servicos.AddScoped<IAssinaturasRepositorio, AssinaturasRepositorio>();

        return servicos;
    }
}