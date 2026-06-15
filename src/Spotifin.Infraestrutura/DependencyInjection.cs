using Microsoft.Extensions.DependencyInjection;

namespace Spotifin.Infraestrutura;

public static class DependencyInjection
{
    public static IServiceCollection AddInfraestrutura(this IServiceCollection servicos)
    {
        return servicos;
    }
}