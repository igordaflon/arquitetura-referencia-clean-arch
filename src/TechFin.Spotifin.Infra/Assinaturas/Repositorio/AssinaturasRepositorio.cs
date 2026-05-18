using TechFin.Spotifin.Aplicacao.Core.Interfaces;
using TechFin.Spotifin.Dominio.Assinaturas;
using TechFin.Spotifin.Infra.Contexts;

namespace TechFin.Spotifin.Infra.Assinaturas.Repositorio;

public class AssinaturasRepositorio : IAssinaturasRepositorio
{
    private readonly SpotifinDbContext _contexto;

    public AssinaturasRepositorio(SpotifinDbContext contexto)
    {
        _contexto = contexto;
    }

    public async Task<Assinatura?> ObterPorIdAsync(Guid id)
    {
        var assinatura = await _contexto.Assinaturas.FindAsync(id);
        return assinatura;
    }

    public async Task AdicionarAsync(Assinatura assinatura)
    {
        await _contexto.Assinaturas.AddAsync(assinatura);        
    }
}
