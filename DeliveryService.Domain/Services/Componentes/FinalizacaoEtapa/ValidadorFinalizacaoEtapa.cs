using Domain.Commands;
using Domain.Extensions;
using Domain.Models.Componentes;

namespace Domain.Services.Componentes.FinalizacaoEtapa
{
    public abstract class ValidadorFinalizacaoEtapa
    {
        public virtual void Validar(Componente componente, FinalizarEtapaCommand command)
        {
            if (componente.EtapaJaEstaFinalizada(command.EtapaSolicitacao))
                command.AdicionarErro(nameof(command.EtapaSolicitacao), "Etapa já encontra-se finalizada");

            if (!command.PossuiErros())
                ValidarInformacoesEspecificas(componente, command);
        }

        protected abstract void ValidarInformacoesEspecificas(Componente componente, FinalizarEtapaCommand command);
    }
}
