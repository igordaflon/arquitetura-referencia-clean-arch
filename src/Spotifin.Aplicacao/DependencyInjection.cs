using Microsoft.Extensions.DependencyInjection;
using Spotifin.Aplicacao.Servicos;

namespace Spotifin.Aplicacao;

public static class DependencyInjection
{
    public static IServiceCollection AddAplicacao(this IServiceCollection servicos)
    {
        servicos.AddScoped<IAssinaturasServico, AssinaturasServico>();

        return servicos;
    }
}