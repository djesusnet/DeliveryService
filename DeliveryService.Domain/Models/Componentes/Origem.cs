using System.ComponentModel;

namespace Domain.Models.Componentes
{
    public enum Origem
    {
        [Description("Nacional")]
        Nacional = 1,
        [Description("Importado")]
        Importado = 2
    }
}
