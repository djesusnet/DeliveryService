using PlataformaIHARA.Domain.Core.Models;
using System;

namespace Domain.Models.Componentes.Suprimentos
{
    public class Suprimento : Entity<Guid>
    {
        public decimal Densidade { get; set; }
        public decimal PesoBruto { get; set; }
        public decimal PesoLiquido { get; set; }
        public int PrazoAtendimento { get; set; }
        public DateTime? DataLimite { get; set; }
        public Componente Componente { get; set; }
        public FamiliaCompra FamiliaCompra { get; set; }
        public SegmentoCompra SegmentoCompra { get; set; }
        public SubTipo SubTipo { get; set; }
        public UnidadeMedida UnidadeMedida { get; set; }

        public virtual void AtualizarDataLimite(DateTime data) => DataLimite = data;
    }
}
