using Microsoft.Extensions.DependencyInjection;

namespace TechFin.Spotifin.Aplicacao;

public static class InjecaoDependencia
{
    public static IServiceCollection AddAplicacao(this IServiceCollection services)
    {
        services.AddScoped<Servicos.IAssinaturasServico, Servicos.AssinaturasServico>();

        return services;
    }
}
