using DeliveryService.Application.Commands;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace DeliveryService.Api.Controllers
{
    [Route("api/[controller]")]
	public class ServiceController : Controller
    {
        private readonly IMediator _mediator;

		public ServiceController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> CreateService([FromBody] CreateService command)
        {
            var response = await _mediator.Send(command).ConfigureAwait(false);

            if (response.Errors.Any())
            {
                return BadRequest(response.Errors);
            }
            
            return Ok(response.Result);
        }

		[HttpPut]
		public async Task<IActionResult> UpdateService([FromBody] UpdateService command)
        {
            var response = await _mediator.Send(command).ConfigureAwait(false);

            if (response.Errors.Any())
            {
                return BadRequest(response.Errors);
            }

            return Ok(response.Result);
        }

		[HttpDelete("{id}")]
		public async Task<IActionResult> DeleteService(int id)
        {
			var response = await _mediator.Send(new DeleteService(id)).ConfigureAwait(false);

            if (response.Errors.Any())
            {
                 BadRequest(response.Errors);
            }

            return Ok(response.Result);
        }
    }
}
