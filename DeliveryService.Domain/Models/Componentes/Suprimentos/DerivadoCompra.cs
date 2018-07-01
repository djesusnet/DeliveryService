using PlataformaIHARA.Domain.Core.Models;
using System;

namespace Domain.Models.Componentes.Suprimentos
{
    public class DerivadoCompra : Entity<Guid>
    {
        public DerivadoCompra(Guid id) => Id = id;

        public DerivadoCompra() { }

        public string Descricao { get; set; }
        public int Codigo { get; set; }
    }
}
