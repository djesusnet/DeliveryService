using DeliveryService.Application.Core;
using MediatR;

namespace DeliveryService.Application.Commands
{
	public class UpdateService : IRequest<Response>
    {
		public int Id { get; }
		public string Name { get; }
        public int Time { get; }
        public int Cost { get; }
		      
		public UpdateService(int id, string name, int time, int cost)
        {
			Id = id;
            Name = name;
            Time = time;
            Cost = cost;
        }
  
    }
}