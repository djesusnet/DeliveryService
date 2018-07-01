using Domain.Commands;
using Domain.Extensions;
using Domain.Models.Componentes;

namespace Domain.Services.Componentes.FinalizacaoEtapa
{
    public class ValidadorFinalizacaoEtapaSuprimentos : ValidadorFinalizacaoEtapa
    {
        protected override void ValidarInformacoesEspecificas(Componente componente, FinalizarEtapaCommand command)
        {
            var valido = true;

            if (componente.SolicitacaoComponente.ProprietarioId == (int)Proprietario.Ihara)
            {
                valido = componente.Suprimento != null && componente.SuprimentoIhara != null;
            }
            else if (componente.SolicitacaoComponente.ProprietarioId == (int)Proprietario.Terceiro)
            {
                valido = componente.Suprimento != null;
            }

            if (!valido)
                command.AdicionarErro(nameof(command.EtapaSolicitacao), "Não é possível finalizar etapa pois não existem dados de Suprimento cadastrados");
        }
    }
}
