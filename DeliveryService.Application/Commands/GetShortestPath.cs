using DeliveryService.Application.Core;
using MediatR;

namespace DeliveryService.Application.Commands
{
	public class GetShortestPath : IRequest<Response>
    {
		public int StartRouteId { get; private set;}

		public int DestinationId { get; private set;}
        

		public GetShortestPath(int startRouteId, int destinationId)
        {
			StartRouteId = startRouteId;

			DestinationId = destinationId;
   
        }
  
    }
}