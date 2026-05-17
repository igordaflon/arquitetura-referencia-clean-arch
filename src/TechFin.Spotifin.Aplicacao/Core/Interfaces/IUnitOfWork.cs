namespace TechFin.Spotifin.Aplicacao.Core.Interfaces;

public interface IUnitOfWork
{
    Task CommitAsync();
}
