using Domain.Commands;
using Domain.Extensions;
using Domain.Models.Componentes;
using System.Linq;

namespace Domain.Services.Componentes.FinalizacaoEtapa
{
    public class ValidadorFinalizacaoEtapaFornecedoresAprovados : ValidadorFinalizacaoEtapa
    {
        protected override void ValidarInformacoesEspecificas(Componente componente, FinalizarEtapaCommand command)
        {
            if (!componente.Fornecedores.Any())
                command.AdicionarErro(nameof(command.EtapaSolicitacao), "Não é possível finalizar etapa pois não existem Fornecedores vinculados ao Componente");

            if (!componente.Fornecedores.All(x => x.Especificacoes.Any()))
                command.AdicionarErro(nameof(command.EtapaSolicitacao), "Não é possível finalizar etapa pois algum Fornecedor não possui dados de Especificação cadastrados");
        }
    }
}
