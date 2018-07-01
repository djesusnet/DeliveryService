using System.Threading.Tasks;
using Domain.Interfaces;
using MediatR;
using PlataformaIHARA.Domain.Core.Commands;
using PlataformaIHARA.Domain.Core.Mediator;
using PlataformaIHARA.Domain.Core.Notifications;

namespace Domain.Commands
{
    // TODO: Testar
    public class CommandHandler
    {
        protected readonly IUnitOfWork _uow;
        protected readonly IMediatorHandler _mediator;
        protected readonly DomainNotificationHandler _notifications;

        public CommandHandler(IUnitOfWork uow, IMediatorHandler mediator, INotificationHandler<DomainNotification> notifications)
        {
            _uow = uow;
            _notifications = notifications as DomainNotificationHandler;
            _mediator = mediator;
        }

        protected Task ReturnValidationErrors(Command command)
        {
            NotifyValidationErrors(command);
            return Task.CompletedTask;
        }

        protected void NotifyValidationErrors(Command message)
        {
            foreach (var error in message.ValidationResult.Errors)
            {
                _mediator.RaiseEvent(new DomainNotification(message.MessageType, error.ErrorMessage));
            }
        }

        public bool Commit()
        {
            if (_notifications.HasNotifications())
                return false;
            var commandResponse = _uow.Commit();
            if (commandResponse.Success)
                return true;

            _mediator.RaiseEvent(new DomainNotification("Commit", "Não foi possivel realizar a operação."));
            return false;
        }
    }
}
