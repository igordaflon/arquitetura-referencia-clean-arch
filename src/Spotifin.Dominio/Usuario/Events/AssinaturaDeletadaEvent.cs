using Spotifin.Dominio.Common;

namespace Spotifin.Dominio.Usuario.Events
{
    public record AssinaturaDeletadaEvent(Guid AssinaturaId) : IDomainEvent;
}