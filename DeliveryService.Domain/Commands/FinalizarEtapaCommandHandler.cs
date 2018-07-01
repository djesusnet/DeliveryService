using Domain.Events.Componentes;
using Domain.Extensions;
using Domain.Interfaces;
using Domain.Interfaces.Componentes;
using Domain.Models.Componentes;
using Domain.Services.Componentes.FinalizacaoEtapa;
using MediatR;
using PlataformaIHARA.Domain.Core.Mediator;
using PlataformaIHARA.Domain.Core.Notifications;
using System.Threading;
using System.Threading.Tasks;

namespace Domain.Commands
{
    public class FinalizarEtapaCommandHandler : CommandHandler, INotificationHandler<FinalizarEtapaCommand>
    {
        private readonly IComponenteRepository _componenteRepository;
        private readonly IValidadorFinalizacaoEtapaFactory _validadorFinalizacaoEtapaFactory;

        public FinalizarEtapaCommandHandler(IUnitOfWork uow, IMediatorHandler mediator,
            INotificationHandler<DomainNotification> notifications, IComponenteRepository componenteRepository,
            IValidadorFinalizacaoEtapaFactory validadorFinalizacaoEtapaFactory)
            : base(uow, mediator, notifications)
        {
            _componenteRepository = componenteRepository;
            _validadorFinalizacaoEtapaFactory = validadorFinalizacaoEtapaFactory;
        }

        public Task Handle(FinalizarEtapaCommand command, CancellationToken cancellationToken)
        {
            if (!command.IsValid())
                return ReturnValidationErrors(command);

            var componente = _componenteRepository.GetById(command.ComponenteId);

            ValidarInformacoesAdicionais(command, componente);

            if (command.PossuiErros())
                return ReturnValidationErrors(command);

            var validadorEtapa = _validadorFinalizacaoEtapaFactory.ObterValidador(command.EtapaSolicitacao);
            validadorEtapa.Validar(componente, command);

            if (command.PossuiErros())
                return ReturnValidationErrors(command);

            var etapaFinalizada = componente.FinalizarEtapa(command.EtapaSolicitacao);

            _componenteRepository.Update(componente);

            if (Commit())
                _mediator.RaiseEvent(
                    new FinalizacaoEtapaEvent(command.ComponenteId, etapaFinalizada.Id,
                        etapaFinalizada.DataFinalizacao.GetValueOrDefault()), true);

            return Task.CompletedTask;
        }

        private void ValidarInformacoesAdicionais(FinalizarEtapaCommand command, Componente componente)
        {
            if (componente == null)
                command.AdicionarErro(nameof(command.ComponenteId), "Componente não encontrado");
        }
    }
}
