namespace TechFin.Spotifin.Dominio.Assinaturas;

public class Assinatura
{  
    public Guid Id { get; private set; }
    public TipoAssinatura TipoAssinatura { get; private set; }
    public Guid UsuarioId { get; private set; }

    private Assinatura() { }

    public Assinatura(TipoAssinatura tipoAssinatura, Guid usuarioId, Guid? id = null)
    {
        Id = id ?? Guid.NewGuid();
        TipoAssinatura = tipoAssinatura;
        UsuarioId = usuarioId;
    }
}
    