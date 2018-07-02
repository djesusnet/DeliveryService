using System;

namespace DeliveryService.Application.Commands
{
    public class ServiceRouteResponse

    {
		public int Id { get; private set; }
        public string Name { get; private set; }
        public int Time { get; private set; }
        public int Cost { get; private set; }
        
		public ServiceRouteResponse(int id, string name, int time, int cost)
        {
            Id = id;
            Name = name;
            Time = time;
            Cost = cost;
        }
    }
}
