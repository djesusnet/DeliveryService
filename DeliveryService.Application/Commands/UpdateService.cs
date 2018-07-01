using DeliveryService.Application.Core;
using MediatR;

namespace DeliveryService.Application.Commands
{
	public class DeleteService : IRequest<Response>
    {
		public int Id { get; }
		      
		public DeleteService(int id)
        {
			Id = id;
        }
  
    }
}