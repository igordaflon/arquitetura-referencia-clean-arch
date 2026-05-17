using TechFin.Spotifin.Dominio.Assinaturas;

namespace TechFin.Spotifin.Aplicacao.Core.Interfaces;

public interface IAssinaturasRepositorio
{
    Task AdicionarAsync(Assinatura assinatura);
}
