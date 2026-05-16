namespace TechFin.Spotifin.Aplicacao.Servicos;

public class AssinaturasServico : IAssinaturasServico
{
    public Guid CriarAssinatura(string tipoAssinatura, Guid usuarioId)
    {
        return Guid.NewGuid();
    }
}
