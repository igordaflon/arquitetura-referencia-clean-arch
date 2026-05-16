namespace TechFin.Spotifin.Contratos.Assinaturas;

public record CriarAssinaturaRequest(TipoAssinaturaEnum TipoAssinatura, Guid UsuarioId);
