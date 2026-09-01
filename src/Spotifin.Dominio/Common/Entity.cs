namespace Spotifin.Dominio.Common
{
    public abstract class Entity
    {
        public Guid Id { get; init; }
        protected readonly List<IDomainEvent> _domainEvents = new();

        protected Entity(Guid id)
        {
            Id = id;
        }

        //EF
        protected Entity(){}
    }
}