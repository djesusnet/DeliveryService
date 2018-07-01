using Domain.Models.Componentes;
using System;

namespace Domain.Services.Componentes.FinalizacaoEtapa
{
    public class ValidadorFinalizacaoEtapaFactory : IValidadorFinalizacaoEtapaFactory
    {
        public ValidadorFinalizacaoEtapa ObterValidador(EtapaSolicitacao etapa)
        {
            switch (etapa)
            {
                case EtapaSolicitacao.FornecedoresAprovados:
                    return new ValidadorFinalizacaoEtapaFornecedoresAprovados();
                case EtapaSolicitacao.Suprimentos:
                    return new ValidadorFinalizacaoEtapaSuprimentos();
                case EtapaSolicitacao.Recebimento:
                    return new ValidadorFinalizacaoEtapaRecebimento();
                case EtapaSolicitacao.RestricaoCompra:
                    return new ValidadorFinalizacaoEtapaRestricaoCompra();
                case EtapaSolicitacao.ParametrosCompra:
                    return new ValidadorFinalizacaoEtapaParametrosCompra();
                case EtapaSolicitacao.Logistica:
                    return new ValidadorFinalizacaoEtapaLogistica();
                case EtapaSolicitacao.Pcp:
                    return new ValidadorFinalizacaoEtapaPcp();
                case EtapaSolicitacao.Mrp:
                    return new ValidadorFinalizacaoEtapaMrp();
                case EtapaSolicitacao.SlowMoving:
                    return new ValidadorFinalizacaoEtapaSlowMoving();
                default:
                    throw new InvalidOperationException("Não existe validador para a etapa informada.");
            }
        }
    }
}
