
using DeliveryService.Application.Commands;
using DeliveryService.Application.Core;
using DeliveryService.Application.Domain.Interfaces;
using DeliveryService.Application.Domain.Models;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace DeliveryService.Application.Handlers
{
	public class ServiceHandler : 
	IRequestHandler<CreateService,Response>, 
	IRequestHandler<UpdateService, Response>,
	IRequestHandler<DeleteService, Response>
    {
        private readonly IServiceRepository _repository;

		public ServiceHandler(IServiceRepository repository)
        {
            _repository = repository;
        }

        public async Task<Response> Handle(CreateService request, CancellationToken cancellationToken)
        {
			var Service = new ServiceRoute(request.Name, request.Time, request.Cost);

			await _repository.InsertAsync(Service);

            return new Response("Serviço criado com sucesso!");
        }

		public async Task<Response> Handle(UpdateService request, CancellationToken cancellationToken)
        {
			var Service = new ServiceRoute(request.Id, request.Name, request.Time, request.Cost);

			await _repository.UpdateAsync(Service);

			return new Response("Serviço atualizado com sucesso!");
        }

		public async Task<Response> Handle(DeleteService request, CancellationToken cancellationToken)
        {  
			await _repository.DeleteAsync(request.Id);

            return new Response("Serviço excluido com sucesso!");
        }
    }
}