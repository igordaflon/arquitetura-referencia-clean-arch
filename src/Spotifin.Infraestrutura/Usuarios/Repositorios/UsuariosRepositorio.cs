using Microsoft.EntityFrameworkCore;
using Spotifin.Aplicacao.Common.Interfaces;
using Spotifin.Dominio.Usuario;
using Spotifin.Infraestrutura.Common.Contexts;

namespace Spotifin.Infraestrutura.Usuarios.Repositorios
{
    public class UsuarioRepositorio : IUsuariosRepositorio
    {
        private readonly SpotifinDbContext _context;

        public UsuarioRepositorio(SpotifinDbContext context)
        {
            _context = context;
        }

        public Task AtualizarAsync(Usuario usuario)
        {
            _context.Usuarios.Update(usuario);

            return Task.CompletedTask;
        }

        public async Task<Usuario?> ObterPorIdAsync(Guid usuarioId)
        {
            return await _context.Usuarios.FirstOrDefaultAsync(a => a.Id == usuarioId);
        }
    }
}