namespace Spotifin.Dominio.Assinaturas;

public class Assinatura
{
    public Guid Id { get; }
    public TipoAssinaturaEnum TipoAssinatura { get; }

    private readonly Guid _usuarioId;

    public Assinatura(TipoAssinaturaEnum tipoAssinatura, Guid usuarioId)
    {
        Id = Guid.NewGuid();
        TipoAssinatura = tipoAssinatura;
        _usuarioId = usuarioId;
    }
}

