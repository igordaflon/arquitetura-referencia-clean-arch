using ErrorOr;
using Spotifin.Dominio.Common;
using Spotifin.Dominio.Usuario.Events;

namespace Spotifin.Dominio.Usuario
{
    public class Usuario : Entity
    {
        public string Nome { get; private set; } = null!;
        public Guid? AssinaturaId { get; private set; } = null;


        public ErrorOr<Success> InserirAssinatura(Guid assinaturaId)
        {
            if(AssinaturaId is not null)
                return Error.Validation(description: "Usuário já possui uma assinatura ativa.");

            AssinaturaId = assinaturaId;
            return Result.Success;
        }

        public void DeletarAssinatura(Guid assinaturaId)
        {
            if (AssinaturaId is null)
                throw new InvalidOperationException("Não é possível remover uma assinatura nula.");

            AssinaturaId = null;

            // Domain event: Implementar evento de domínio para notificar que a assinatura foi removida
            _domainEvents.Add(new AssinaturaDeletadaEvent(assinaturaId));
        }
    }
}