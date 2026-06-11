public record CriarAssinaturaRequest(
    TipoAssinaturaEnum TipoAssinatura,
    Guid UsuarioId
);