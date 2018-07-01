using FluentValidation;

namespace DeliveryService.Application.Commands.Validators
{
    public class CreateServiceValidator : AbstractValidator<CreateService>
    {
        public CreateServiceValidator()
        {
            RuleFor(a => a.Name)
                .NotEmpty()
                .WithMessage("O Nome é obrigatório");

			RuleFor(a => a.Time)
                .NotEmpty()
                .WithMessage("O Tempo é obrigatório");
            
			RuleFor(a => a.Cost)
                .NotEmpty()
                .WithMessage("O Custo é obrigatória");
   
        }
    }
}