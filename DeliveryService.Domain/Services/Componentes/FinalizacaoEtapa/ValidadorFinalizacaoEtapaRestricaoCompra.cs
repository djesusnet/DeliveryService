using Domain.Commands;
using Domain.Extensions;
using Domain.Models.Componentes;

namespace Domain.Services.Componentes.FinalizacaoEtapa
{
    public class ValidadorFinalizacaoEtapaRestricaoCompra : ValidadorFinalizacaoEtapa
    {
        protected override void ValidarInformacoesEspecificas(Componente componente, FinalizarEtapaCommand command)
        {
            if(componente.RestricaoCompra == null)
                command.AdicionarErro(nameof(command.EtapaSolicitacao), "Não é possível finalizar etapa pois não existem dados de Restrição de Compra cadastrados.");
        }
    }
}
