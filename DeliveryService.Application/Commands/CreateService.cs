using DeliveryService.Application.Core;
using MediatR;

namespace DeliveryService.Application.Commands
{
    public class CreateService : IRequest<Response>
    {
		public string Name { get; private set; }
		public int Time { get; private set; }
		public int Cost { get; private set; }

		public CreateService(string name, int time, int cost)
        {
            Name = name;
            Time = time;
            Cost = cost;
        }
  
    }
}