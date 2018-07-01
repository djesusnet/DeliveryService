using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DeliveryService.Data.SQL.Repositories;
using Microsoft.EntityFrameworkCore;
using Moq;
using Xunit;

namespace DeliveryService.Tests.Repositories
{
	public class ServiceRepositoryTests
    {
		private Mock<ServiceRepository> _repository;
  
		public ServiceRepositoryTests()
        {
			_repository = new Mock<ServiceRepository>();

			Initialise();
        }
  
		private void Initialise()
        {
			

        }

    }
}
