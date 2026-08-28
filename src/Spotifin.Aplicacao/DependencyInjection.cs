using ErrorOr;
using FluentValidation;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using Spotifin.Aplicacao.Common.Behaviors;
using Spotifin.Aplicacao.Playlists.Comandos.CriarPlaylist;
using Spotifin.Dominio.Playlists;

namespace Spotifin.Aplicacao;

public static class DependencyInjection
{
    public static IServiceCollection AddAplicacao(this IServiceCollection servicos)
    {
        servicos.AddMediatR(options =>
        {
           options.RegisterServicesFromAssemblyContaining(typeof(DependencyInjection));
           options.AddOpenBehavior(typeof(ValidationBehavior<,>));
        });

        servicos.AddValidatorsFromAssemblyContaining(typeof(DependencyInjection));

        return servicos;
    }
}