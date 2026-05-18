using Ardalis.SmartEnum;

namespace TechFin.Spotifin.Dominio.Assinaturas
{
    public class TipoAssinatura : SmartEnum<TipoAssinatura>
    {
        public static readonly TipoAssinatura Gratis = new(nameof(Gratis), 0);
        public static readonly TipoAssinatura Basico = new(nameof(Basico), 1);
        public static readonly TipoAssinatura Pro = new(nameof(Pro), 2);

        public TipoAssinatura(string name, int value) : base(name, value)
        {
        }
    }
}
