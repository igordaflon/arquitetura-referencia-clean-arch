using System.Text.Json.Serialization;

namespace Spotifin.Contratos.Assinaturas;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum TipoAssinaturaEnum
{
    Gratuita,
    Basica,
    Pro
}