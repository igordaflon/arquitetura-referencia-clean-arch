namespace TechFin.Spotifin.Aplicacao.Servicos;

public interface IAssinaturasServico
{
    Guid CriarAssinatura(string tipoAssinatura, Guid usuarioId);
}
