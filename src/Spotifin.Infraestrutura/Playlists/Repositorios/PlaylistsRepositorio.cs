using Spotifin.Aplicacao.Common.Interfaces;
using Spotifin.Dominio.Playlists;
using Spotifin.Infraestrutura.Common.Contexts;

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
    }
}
