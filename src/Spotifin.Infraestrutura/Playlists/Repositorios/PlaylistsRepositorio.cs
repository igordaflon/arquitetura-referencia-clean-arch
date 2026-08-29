using Spotifin.Aplicacao.Common.Interfaces;
using Spotifin.Dominio.Playlists;
using Spotifin.Infraestrutura.Common.Contexts;
using Microsoft.EntityFrameworkCore;

namespace Spotifin.Infraestrutura.Playlists.Repositorios
{
    public class PlaylistsRepositorio : IPlaylistsRepositorio
    {
        private readonly SpotifinDbContext _context;
        
        public PlaylistsRepositorio(SpotifinDbContext context)
        {
            _context = context;
        }

        public async Task InserirAsync(Playlist playlist)
        {
            await _context.Playlists.AddAsync(playlist);
        }

        public async Task<List<Playlist>> ObterPorAssinaturaIdAsync(Guid assinaturaId)
        {
            return await _context.Playlists
                .Where(p => p.AssinaturaId == assinaturaId)
                .ToListAsync();
        }

        public async Task DeletarAsync(List<Playlist> playlists)
        {
            _context.Playlists.RemoveRange(playlists);
            await Task.CompletedTask;
        }
    }
}
