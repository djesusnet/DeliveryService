using Domain.Commands;
using Domain.Extensions;
using Domain.Models.Componentes;
using System.Linq;

namespace Domain.Services.Componentes.FinalizacaoEtapa
{
    public class ValidadorFinalizacaoEtapaParametrosCompra : ValidadorFinalizacaoEtapa
    {
        protected override void ValidarInformacoesEspecificas(Componente componente, FinalizarEtapaCommand command)
        {
            if (!componente.Fornecedores.Any())
                command.AdicionarErro(nameof(command.EtapaSolicitacao),
                    "Não é possível finalizar etapa pois não existem Fornecedores vinculados ao Componente");

            if (componente.Fornecedores.Count(x => x.Padrao) != 1)
                command.AdicionarErro(nameof(command.EtapaSolicitacao),
                    "Não é possível finalizar etapa pois não existe um Fornecedor padrão cadastrado");

            if (componente.Suprimento?.DataLimite == null)
                command.AdicionarErro(nameof(command.EtapaSolicitacao),
                    "Não é possível finalizar etapa pois a Data Limite para três Fornecedores não está cadastrada");

            if (!componente.Fornecedores.All(x => x.Armazenagens.Any(y => y.Padrao)))
                command.AdicionarErro(nameof(command.EtapaSolicitacao),
                    "Não é possível finalizar etapa pois existem Fornecedores sem Embalagem Padrão cadastradas");

            if (componente.SolicitacaoComponente.OrigemId == (int)Origem.Importado && componente.Fornecedores.Any(x => x.Importacao == null))
                command.AdicionarErro(nameof(command.EtapaSolicitacao),
                    "Não é possível finalizar etapa pois existem Fornecedores sem Dados de Importação cadastrados");
        }
    }
}
