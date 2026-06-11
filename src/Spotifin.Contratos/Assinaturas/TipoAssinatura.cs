using System.Text.Json.Serialization;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum TipoAssinatura
{
    Gratuita,
    Basica,
    Pro
}