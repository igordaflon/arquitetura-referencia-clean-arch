using Microsoft.Extensions.DependencyInjection;

namespace Spotifin.Aplicacao;

public static class DependencyInjection
{
    public static IServiceCollection AddAplicacao(this IServiceCollection servicos)
    {
        servicos.AddMediatR(options =>
        {
           options.RegisterServicesFromAssemblyContaining(typeof(DependencyInjection));
        });

        return servicos;
    }
}