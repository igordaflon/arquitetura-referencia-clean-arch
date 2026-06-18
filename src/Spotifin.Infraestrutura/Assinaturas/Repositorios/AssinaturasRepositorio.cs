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

    public Task<Assinatura?> ObterPorIdAsync(Guid id)
    {
        var assinatura = _assinaturas.FirstOrDefault(a => a.Id == id);

        return Task.FromResult(assinatura);
    }
}
