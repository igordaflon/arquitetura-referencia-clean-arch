using System.Text.Json.Serialization;

namespace TechFin.Spotifin.Contratos.Assinaturas;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum TipoAssinaturaEnum
{
    Gratis,
    Basico,
    Pro
}
