using Domain.Models.Componentes;
using Domain.Validations;
using PlataformaIHARA.Domain.Core.Commands;
using System;

namespace Domain.Commands
{
    public class FinalizarEtapaCommand : Command
    {
        public Guid ComponenteId { get; set; }

        public EtapaSolicitacao EtapaSolicitacao { get; set; }

        public override bool IsValid()
        {
            ValidationResult = new FinalizarEtapaCommandValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
