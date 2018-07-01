using PlataformaIHARA.Domain.Core.Events;
using System;

namespace Domain.Events.Componentes.Ativacao
{
    public class AlteracaoStatusComponenteEvent : Event
    {
        public AlteracaoStatusComponenteEvent(Guid componenteId, int chapaUsuario, string nomeUsuario,
            string justificativa, bool ativo)
        {
            ComponenteId = componenteId;
            ChapaUsuario = chapaUsuario;
            NomeUsuario = nomeUsuario;
            Justificativa = justificativa;
            Ativo = ativo;
        }

        public Guid ComponenteId { get; private set; }

        public int ChapaUsuario { get; private set; }

        public string NomeUsuario { get; private set; }

        public string Justificativa { get; private set; }

        public bool Ativo { get; private set; }
    }
}
