using Microsoft.EntityFrameworkCore;

namespace DeliveryService.Data.SQL.Repositories
{

	public class ServiceRepository : 
	Repository<Application.Domain.Models.ServiceRoute>, 
	Application.Domain.Interfaces.IServiceRepository
	{
		public ServiceRepository(DbContext context) : base(context) => this.Db = context;
	}
}
