using PlataformaIHARA.Domain.Core.Models;
using System;

namespace Domain.Models.Componentes.SlowMovings
{
    public class SlowMoving : Entity<Guid>
    {

        public SlowMoving(Componente componente, int quantidadeDias, DateTime dataVigencia)
        {
            Componente = componente;
            QuantidadeDias = quantidadeDias;
            DataVigencia = dataVigencia;
        }
        
        public SlowMoving(Componente componente, int quantidadeDias)
            : this(componente, quantidadeDias, DateTime.Now.Date)
        {
        }

        protected SlowMoving() { }

        public Componente Componente { get; private set; }
        public int QuantidadeDias { get; private set; }
        public DateTime DataVigencia { get; private set; }

        public void AtualizarInformacoes(int quantidadeDias)
        {
            if (QuantidadeDias == quantidadeDias)
                return;

            QuantidadeDias = quantidadeDias;
            DataVigencia = DateTime.Now.Date;
        }
    }
}
