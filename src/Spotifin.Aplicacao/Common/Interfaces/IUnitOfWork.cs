namespace Spotifin.Aplicacao.Common.Interfaces;

public interface IUnitOfWork
{
    Task CommitAsync();
}
