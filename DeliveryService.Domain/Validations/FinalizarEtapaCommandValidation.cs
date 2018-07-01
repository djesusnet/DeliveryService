using Domain.Commands;
using Domain.Models.Componentes;
using FluentValidation;
using System;

namespace Domain.Validations
{
    public class FinalizarEtapaCommandValidation : AbstractValidator<FinalizarEtapaCommand>
    {
        private const string MensagemEtapaInvalida = "A etapa informada é inválida";

        public FinalizarEtapaCommandValidation()
        {
            RuleFor(x => x.ComponenteId)
                .NotEqual(Guid.Empty).WithMessage("O Id do componente deve estar preenchido");

            RuleFor(x => x.EtapaSolicitacao)
                .NotEqual(EtapaSolicitacao.NaoEncontrado).WithMessage(MensagemEtapaInvalida)
                .NotEqual(EtapaSolicitacao.Solicitacao).WithMessage(MensagemEtapaInvalida)
                .NotEqual(EtapaSolicitacao.DadosBasicos).WithMessage(MensagemEtapaInvalida)
                .NotEqual(EtapaSolicitacao.ParametrosAnalise).WithMessage(MensagemEtapaInvalida)
                .NotEqual(EtapaSolicitacao.Custo).WithMessage(MensagemEtapaInvalida)
                .NotEqual(EtapaSolicitacao.Marketing).WithMessage(MensagemEtapaInvalida)
                .NotEqual(EtapaSolicitacao.Tributario).WithMessage(MensagemEtapaInvalida)
                .NotEqual(EtapaSolicitacao.Registro).WithMessage(MensagemEtapaInvalida)
                .NotEqual(EtapaSolicitacao.Ativacao).WithMessage(MensagemEtapaInvalida);
        }
    }
}
