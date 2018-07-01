using System;
using System.Collections.Generic;
using DeliveryService.Application.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace DeliveryService.Data.SQL.Tools
{
    
		public class Seed
        {
		private readonly DbContext context;
            
		public Seed(DbContext context)
            {
                this.context = context;
            }

			public void SeedServiceRoutes()
            {
                try
                {
					foreach (var item in GetServiceRoutes())
                    {
						context.Add<ServiceRoute>(item);
                    }

                    context.SaveChanges();
                }
                catch (Exception e)
                {
                    Console.Write(e);
                }
            }
            
			public IEnumerable<ServiceRoute> GetServiceRoutes()
            {

				var services = new List<ServiceRoute>();

				services.Add(new ServiceRoute("Service 01", 1, 2));            
                services.Add(new ServiceRoute("Service 02", 1, 2));
                services.Add(new ServiceRoute("Service 03", 1, 2));            
                services.Add(new ServiceRoute("Service 04", 1, 2));

				return services;
            }
            
        }
    
}
