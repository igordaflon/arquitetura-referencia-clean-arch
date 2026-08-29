using Spotifin.Dominio.Assinaturas;

namespace Spotifin.Aplicacao.Common.Interfaces;

public interface IAssinaturasRepositorio
{
    Task InserirAsync(Assinatura assinatura);
    Task<Assinatura?> ObterPorIdAsync(Guid id);
    Task AtualizarAsync(Assinatura assinatura);
    Task DeletarAsync(Assinatura assinatura);
}
