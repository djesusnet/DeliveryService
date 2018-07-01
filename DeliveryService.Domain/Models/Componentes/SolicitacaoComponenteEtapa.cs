using PlataformaIHARA.Domain.Core.Models;
using System;

namespace Domain.Models.Componentes
{
    public class SolicitacaoComponenteEtapa : Entity<int>
    {
        public SolicitacaoComponenteEtapa(EtapaSolicitacao etapa, SolicitacaoComponente solicitacaoComponente, string descricao, DateTime? dataFinalizacao)
        {
            Id = (int)etapa;
            SolicitacaoComponenteId = solicitacaoComponente.Id;
            SolicitacaoComponente = solicitacaoComponente;
            Descricao = descricao;
            DataFinalizacao = dataFinalizacao;
        }

        protected SolicitacaoComponenteEtapa() { }

        public Guid SolicitacaoComponenteId { get; private set; }

        public SolicitacaoComponente SolicitacaoComponente { get; private set; }

        public string Descricao { get; private set; }

        public DateTime? DataFinalizacao { get; private set; }

        public virtual EtapaSolicitacao EtapaSolicitacao => (EtapaSolicitacao)Id;

        public virtual void Finalizar()
        {
            if (DataFinalizacao.HasValue)
                throw new InvalidOperationException("Etapa já encontra-se finalizada.");

            DataFinalizacao = DateTime.Now;
        }
    }
}
