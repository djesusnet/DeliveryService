using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace DeliveryService.Application.Domain.Interfaces
{
	public interface IRepository<T> : IDisposable 
    {
    
		Task<T> GetAsync(int id);

        IQueryable<T> Query();

        Task InsertAsync(T entity);

        Task UpdateAsync(T entity);

        Task DeleteAsync(int id);
  
    }
}