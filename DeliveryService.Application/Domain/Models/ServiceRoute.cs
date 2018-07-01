using System;

namespace DeliveryService.Application.Domain.Models
{
    public class ServiceRoute
    {
		public int Id{ get; private set; }
		public string Name { get; private set;}
		public int Time { get; private set;}
		public int Cost { get; private set;}

        public ServiceRoute(string name, int time, int cost)
        {
            Name = name;
			Time = time;
			Cost = cost;
        }

		public ServiceRoute(int id, string name, int time, int cost)
        {
			Id = id;
            Name = name;
            Time = time;
            Cost = cost;
        }
    }
}