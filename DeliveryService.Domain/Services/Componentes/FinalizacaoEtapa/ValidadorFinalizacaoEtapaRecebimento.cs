using Domain.Commands;
using Domain.Extensions;
using Domain.Models.Componentes;

namespace Domain.Services.Componentes.FinalizacaoEtapa
{
    public class ValidadorFinalizacaoEtapaRecebimento : ValidadorFinalizacaoEtapa
    {
        protected override void ValidarInformacoesEspecificas(Componente componente, FinalizarEtapaCommand command)
        {
            if (componente.Recebimento == null)
                command.AdicionarErro(nameof(command.EtapaSolicitacao), "Não é possível finalizar etapa pois não existem dados de Recebimento cadastrados");
        }
    }
}
