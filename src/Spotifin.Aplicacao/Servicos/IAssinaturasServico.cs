public interface IAssinaturasServico
{
    Guid CriarAssinatura(string tipoAssinatura, Guid usuarioId);
}