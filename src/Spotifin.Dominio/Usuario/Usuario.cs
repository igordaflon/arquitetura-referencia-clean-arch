using ErrorOr;

namespace Spotifin.Dominio.Usuario
{
    public class Usuario
    {
        public Guid Id { get; private set; }
        public string Nome { get; private set; } = null!;
        public Guid? AssinaturaId { get; private set; } = null;


        public ErrorOr<Success> InserirAssinatura(Guid assinaturaId)
        {
            if(AssinaturaId is not null)
                return Error.Validation(description: "Usuário já possui uma assinatura ativa.");

            AssinaturaId = assinaturaId;
            return Result.Success;
        }

        public void DeletarAssinatura()
        {
            if (AssinaturaId is null)
                throw new InvalidOperationException("Não é possível remover uma assinatura nula.");

            AssinaturaId = null;
        }
    }
}