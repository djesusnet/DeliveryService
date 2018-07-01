using DeliveryService.Application.Core;
using MediatR;

namespace DeliveryService.Application.Commands
{
    public class CreateService : IRequest<Response>
    {
		public string Name { get; }
        public int Time { get; }
        public int Cost { get; }

		public CreateService(string name, int time, int cost)
        {
            Name = name;
            Time = time;
            Cost = cost;
        }
  
    }
}