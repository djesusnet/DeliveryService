using Domain.Commands;
using Domain.Extensions;
using Domain.Models.Componentes;

namespace Domain.Services.Componentes.FinalizacaoEtapa
{
    public class ValidadorFinalizacaoEtapaSlowMoving : ValidadorFinalizacaoEtapa
    {
        protected override void ValidarInformacoesEspecificas(Componente componente, FinalizarEtapaCommand command)
        {
            if (componente.SlowMoving == null)
                command.AdicionarErro(nameof(command.EtapaSolicitacao), "Não é possível finalizar etapa pois não existem dados de Slow Moving cadastrado");
        }
    }
}
