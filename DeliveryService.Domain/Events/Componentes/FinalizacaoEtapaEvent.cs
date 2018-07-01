using PlataformaIHARA.Domain.Core.Events;
using System;

namespace Domain.Events.Componentes
{
    public class FinalizacaoEtapaEvent : Event
    {
        public Guid ComponenteId { get; private set; }
        public int SolicitacaoComponenteEtapaId { get; private set; }
        public DateTime DataFinalizacao { get; private set; }

        public FinalizacaoEtapaEvent(Guid componenteId, int solicitacaoComponenteEtapaId, DateTime dataFinalizacao)
        {
            ComponenteId = componenteId;
            SolicitacaoComponenteEtapaId = solicitacaoComponenteEtapaId;
            DataFinalizacao = dataFinalizacao;
        }
    }
}
