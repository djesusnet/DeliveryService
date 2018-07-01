using PlataformaIHARA.Domain.Core.Models;
using System;

namespace Domain.Models.Componentes.Suprimentos
{
    public class SuprimentoIhara : Entity<Guid>
    {
        public Componente Componente { get; set; }
        public Moeda Moeda { get; set; }
        public DerivadoCompra DerivadoCompra { get; set; }
        public GrupoCompra GrupoCompra { get; set; }
    }
}
