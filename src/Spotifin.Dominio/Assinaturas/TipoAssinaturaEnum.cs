using Ardalis.SmartEnum;

namespace Spotifin.Dominio.Assinaturas;

public class TipoAssinaturaEnum : SmartEnum<TipoAssinaturaEnum>
{
    public static readonly TipoAssinaturaEnum Gratuita = new(nameof(Gratuita), 0);
    public static readonly TipoAssinaturaEnum Basica = new(nameof(Basica), 1);
    public static readonly TipoAssinaturaEnum Pro = new(nameof(Pro), 2);

    public TipoAssinaturaEnum(string name, int value) : base(name, value)
    {
    }
}

