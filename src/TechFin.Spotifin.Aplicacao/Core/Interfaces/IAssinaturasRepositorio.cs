using TechFin.Spotifin.Dominio.Assinaturas;

namespace TechFin.Spotifin.Aplicacao.Core.Interfaces;

public interface IAssinaturasRepositorio
{
    Task<Assinatura?> ObterPorIdAsync(Guid id);
    Task AdicionarAsync(Assinatura assinatura);
}
