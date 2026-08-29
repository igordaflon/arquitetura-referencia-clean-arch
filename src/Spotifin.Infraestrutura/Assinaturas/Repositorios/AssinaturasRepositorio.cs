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
    }

    public async Task<Assinatura?> ObterPorIdAsync(Guid id)
    {
        return await _context.Assinaturas.FindAsync(id);
    }

    public async Task AtualizarAsync(Assinatura assinatura)
    {
        _context.Assinaturas.Update(assinatura);
        await Task.CompletedTask;
    }

    public async Task DeletarAsync(Assinatura assinatura)
    {
        _context.Assinaturas.Remove(assinatura);
        await Task.CompletedTask;
    }
}
