using Domain.Extensions;
using PlataformaIHARA.Domain.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Domain.Models.Componentes
{
    public class SolicitacaoComponente : Entity<Guid>
    {
        public SolicitacaoComponente() =>
            Etapas = new List<SolicitacaoComponenteEtapa>();

        public int CodigoComponente { get; set; }
        public string ComponenteSugerido { get; set; }
        public DateTime DataSolicitacao { get; set; }
        public string Observacao { get; set; }
        public int SituacaoId { get; set; }
        public Guid UsuarioId { get; set; }
        public int ProprietarioId { get; set; }
        public string Proprietario => ((Proprietario)ProprietarioId).GetDescription();
        public int TipoId { get; set; }
        public string Tipo => ((Tipo)TipoId).GetDescription();
        public int OrigemId { get; set; }
        public string Origem => ((Origem)OrigemId).GetDescription();
        public IList<SolicitacaoComponenteEtapa> Etapas { get; private set; }

        public virtual SolicitacaoComponenteEtapa FinalizarEtapa(EtapaSolicitacao etapaSolicitacao)
        {
            var solicitacaoComponenteEtapa = Etapas.FirstOrDefault(x => x.EtapaSolicitacao == etapaSolicitacao);

            if (solicitacaoComponenteEtapa == null)
                throw new InvalidOperationException("Etapa informada não encontrada.");

            solicitacaoComponenteEtapa.Finalizar();

            return solicitacaoComponenteEtapa;
        }
    }
}
