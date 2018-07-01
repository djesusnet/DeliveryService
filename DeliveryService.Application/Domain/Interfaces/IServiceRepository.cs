using System.Threading.Tasks;
using DeliveryService.Application.Domain.Models;
using DeliveryService.Application.Domain.Interfaces;

namespace DeliveryService.Application.Domain.Interfaces
{
	public interface IServiceRepository : IRepository<ServiceRoute>
    {
		
    }
}