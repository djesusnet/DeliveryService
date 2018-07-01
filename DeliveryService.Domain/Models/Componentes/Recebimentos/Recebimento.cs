using PlataformaIHARA.Domain.Core.Models;
using System;

namespace Domain.Models.Componentes.Recebimentos
{
    public class Recebimento : Entity<Guid>
    {
        public Componente Componente { get; set; }

        public bool PermiteTolerancia { get; set; }

        public decimal PercentualTolerancia { get; set; }
    }
}
