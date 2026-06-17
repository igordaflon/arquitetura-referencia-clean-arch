using Spotifin.Aplicacao.Common.Interfaces;
using Spotifin.Dominio.Assinaturas;

namespace Spotifin.Infraestrutura.Assinaturas.Repositorios;

public class AssinaturasRepositorio : IAssinaturasRepositorio
{
    private readonly static List<Assinatura> _assinaturas = [];

    public Task InserirAsync(Assinatura assinatura)
    {
        _assinaturas.Add(assinatura);
        
        return Task.CompletedTask;
    }
}
