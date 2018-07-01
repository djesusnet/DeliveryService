using Domain.Commands;
using Domain.Extensions;
using Domain.Models.Componentes;

namespace Domain.Services.Componentes.FinalizacaoEtapa
{
    public class ValidadorFinalizacaoEtapaPcp : ValidadorFinalizacaoEtapa
    {
        protected override void ValidarInformacoesEspecificas(Componente componente, FinalizarEtapaCommand command)
        {
            var valido = true;

            if (componente.SolicitacaoComponente.ProprietarioId == (int)Proprietario.Terceiro)
                valido = componente.ClientesTerceiroComponente.Count == 1 && componente.EstoqueMinimo != null;
            else if(componente.SolicitacaoComponente.ProprietarioId == (int)Proprietario.Ihara)
                valido = componente.EstoqueMinimo != null;

            if (!valido)
                command.AdicionarErro(nameof(command.EtapaSolicitacao), "Não é possível finalizar etapa pois não existem dados de PCP cadastrados");
        }
    }
}
