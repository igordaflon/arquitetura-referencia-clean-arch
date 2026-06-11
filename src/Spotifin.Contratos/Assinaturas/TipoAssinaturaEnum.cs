using System.Text.Json.Serialization;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum TipoAssinaturaEnum
{
    Gratuita,
    Basica,
    Pro
}