namespace Spotifin.Contratos.Assinaturas;

public record CriarAssinaturaResponse(
    Guid Id,
    TipoAssinaturaEnum TipoAssinatura
);