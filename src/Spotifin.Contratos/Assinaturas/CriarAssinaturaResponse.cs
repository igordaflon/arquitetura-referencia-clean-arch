namespace Spotifin.Contratos.Assinaturas;

public record AssinaturaResponse(
    Guid Id,
    TipoAssinaturaEnum TipoAssinatura
);