using System;
using System.Threading.Tasks;
using DeliveryService.Application.Handlers;
using Moq;
using Xunit;
using DeliveryService.Application.Commands;
using System.Threading;
using DeliveryService.Application.Core;
using DeliveryService.Application.Domain.Interfaces;

namespace DeliveryService.Tests.Handlers
{
	public class ServiceHandlerTests
    {
		private ServiceHandler _handler;

		private Mock<IServiceRepository> _repositoryMock = new Mock<IServiceRepository>();
        
        public ServiceHandlerTests()
        {
			_handler = new ServiceHandler(_repositoryMock.Object);
		}

		[Fact]
		public async Task CreateServiceRoute()
        {
			// Arrange
			var comand = new CreateService("Service test 01",1,1);
            
            // Act
			var result = await _handler.Handle(comand,GetCancelationToken(TimeSpan.FromSeconds(1)).Token);

            // Assert
            Assert.NotNull(result);

			var objectResult = result as Response;
            Assert.NotNull(objectResult);
   
			// Assert
			Assert.Equal("Serviço criado com sucesso", objectResult.Result);
        }

		[Fact]
        public async Task UpdateServiceRoute()
        {         
			
        }

		[Fact]
        public async Task DeleteServiceRoute()
        {

        }
        
		private CancellationTokenSource GetCancelationToken(TimeSpan time){

			CancellationTokenSource source = new CancellationTokenSource();
            
			source.CancelAfter(time);

			return source;
		}
    }
}
