using PlataformaIHARA.Domain.Core.Models;
using System;

namespace Domain.Models.Componentes.Mrps
{
    public class Mrp : Entity<Guid>
    {
        protected Mrp() { }

        public Mrp(Componente componente, decimal loteCompra, decimal multiploCompra, decimal capacidadeEmbalagem)
        {
            LoteCompra = loteCompra;
            MultiploCompra = multiploCompra;
            CapacidadeEmbalagem = capacidadeEmbalagem;
            Componente = componente;
        }

        public Componente Componente { get; private set; }
        public decimal LoteCompra { get; private set; }
        public decimal MultiploCompra { get; private set; }
        public decimal CapacidadeEmbalagem { get; private set; }

        public void AtualizarInformacoes(decimal loteCompra, decimal multiploCompra, decimal capacidadeEmbalagem)
        {
            LoteCompra = loteCompra;
            MultiploCompra = multiploCompra;
            CapacidadeEmbalagem = capacidadeEmbalagem;
        }
    }
}
