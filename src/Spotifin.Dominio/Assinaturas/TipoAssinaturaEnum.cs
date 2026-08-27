using Ardalis.SmartEnum;

namespace Spotifin.Dominio.Assinaturas;

public class TipoAssinaturaEnum : SmartEnum<TipoAssinaturaEnum>
{
    public static readonly TipoAssinaturaEnum Gratuita = new(nameof(Gratuita), 0, limitePlaylist: 2);
    public static readonly TipoAssinaturaEnum Basica = new(nameof(Basica), 1, limitePlaylist: 5);
    public static readonly TipoAssinaturaEnum Pro = new(nameof(Pro), 2, limitePlaylist: 10);

    public int LimitePlaylist { get; }

    public TipoAssinaturaEnum(string name, int value, int limitePlaylist) : base(name, value)
    {
        LimitePlaylist = limitePlaylist;
    }
}

