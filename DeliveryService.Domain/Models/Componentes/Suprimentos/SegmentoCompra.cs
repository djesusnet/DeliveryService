using PlataformaIHARA.Domain.Core.Models;
using System;

namespace Domain.Models.Componentes.Suprimentos
{
    public class SegmentoCompra : Entity<Guid>
    {
        public SegmentoCompra(Guid id) => Id = id;

        public SegmentoCompra() { }

        public string Descricao { get; set; }
        public int Codigo { get; set; }
    }
}
