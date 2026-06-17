using Spotifin.Dominio.Assinaturas;

namespace Spotifin.Aplicacao.Common.Interfaces;

public interface IAssinaturasRepositorio
{
    Task InserirAsync(Assinatura assinatura);
}
