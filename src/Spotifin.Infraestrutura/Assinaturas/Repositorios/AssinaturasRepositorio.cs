using Spotifin.Aplicacao.Common.Interfaces;
using Spotifin.Dominio.Assinaturas;
using Spotifin.Infraestrutura.Common.Contexts;

namespace Spotifin.Infraestrutura.Assinaturas.Repositorios;

public class AssinaturasRepositorio : IAssinaturasRepositorio
{
    private readonly SpotifinDbContext _context;

    public AssinaturasRepositorio(SpotifinDbContext context)
    {
        _context = context;
    }

    public async Task InserirAsync(Assinatura assinatura)
    {
        await _context.Assinaturas.AddAsync(assinatura);
        
        await _context.SaveChangesAsync();
    }

    public async Task<Assinatura?> ObterPorIdAsync(Guid id)
    {
        return await _context.Assinaturas.FindAsync(id);
    }
}
