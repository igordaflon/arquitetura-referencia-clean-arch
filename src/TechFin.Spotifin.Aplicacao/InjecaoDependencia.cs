using Microsoft.Extensions.DependencyInjection;

namespace TechFin.Spotifin.Aplicacao;

public static class InjecaoDependencia
{
    public static IServiceCollection AddAplicacao(this IServiceCollection services)
    {
        services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblyContaining(typeof(InjecaoDependencia)));
        return services;
    }
}
